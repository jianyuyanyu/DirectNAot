namespace DirectN.Extensions.Utilities;

[TypeConverter(typeof(CursorConverter))]
public class Cursor : IEquatable<Cursor>, IDisposable
{
    private nint _handle;

    public Cursor(int id)
    {
        _handle = Functions.LoadCursorW(HINSTANCE.Null, new PWSTR { Value = id });
        Id = id;
    }

    public Cursor(HCURSOR handle)
    {
        _handle = handle;
    }


    public int Id { get; }
    public HCURSOR Handle => new() { Value = _handle };
    public virtual bool DestroyHandleOnDispose { get; set; }

    public SIZE Hotspot
    {
        get
        {
            if (_handle == 0)
                return new();

            Functions.GetIconInfo(_handle, out var ii);
            if (ii.hbmColor == 0)
                return new();

            return new(ii.xHotspot, ii.yHotspot);
        }
    }

    public static readonly Cursor AppStarting = new(32650);
    public static readonly Cursor Arrow = new(32512);
    public static readonly Cursor Cross = new(32515);
    public static readonly Cursor Hand = new(32649);
    public static readonly Cursor Help = new(32651);
    public static readonly Cursor IBeam = new(32513);
    public static readonly Cursor No = new(32648);
    public static readonly Cursor Size = new(32640);
    public static readonly Cursor SizeAll = new(32646);
    public static readonly Cursor SizeNESW = new(32643);
    public static readonly Cursor SizeNS = new(32645);
    public static readonly Cursor SizeNWSE = new(32642);
    public static readonly Cursor SizeWE = new(32644);
    public static readonly Cursor UpArrow = new(32516);
    public static readonly Cursor Wait = new(32514);

    public static void Set(Cursor? cursor)
    {
        if (cursor == null || cursor.Handle.Value == 0)
        {
            Functions.SetCursor(Arrow.Handle);
        }
        else
        {
            Functions.SetCursor(cursor.Handle);
        }
    }

    public static Cursor? FromHandle(nint handle, bool destroyHandleOnDispose = false)
    {
        if (handle == 0)
            return null;

        return new Cursor(handle) { DestroyHandleOnDispose = destroyHandleOnDispose };
    }

    public static Cursor? FromFilePath(string filePath, int cx = 0, int cy = 0, IMAGE_FLAGS flags = IMAGE_FLAGS.LR_LOADFROMFILE, bool destroyHandleOnDispose = false)
    {
        ArgumentNullException.ThrowIfNull(filePath);
        flags |= IMAGE_FLAGS.LR_LOADFROMFILE;
        var handle = Functions.LoadImageW(0, PWSTR.From(filePath), GDI_IMAGE_TYPE.IMAGE_CURSOR, cx, cy, flags);
        return FromHandle(handle, destroyHandleOnDispose);
    }

    public static Cursor? FromIconFilePath(string filePath, uint xHotspot = 0, uint yHotspot = 0, int cx = 0, int cy = 0, IMAGE_FLAGS flags = IMAGE_FLAGS.LR_LOADFROMFILE, bool destroyHandleOnDispose = false)
    {
        ArgumentNullException.ThrowIfNull(filePath);
        using var icon = Icon.FromFilePath(filePath, cx, cy, flags, destroyHandleOnDispose);
        if (icon == null)
            return null;

        return FromIcon(icon, xHotspot, yHotspot, destroyHandleOnDispose);
    }

    public static Cursor? FromIcon(Icon? icon, uint xHotspot, uint yHotspot, bool destroyHandleOnDispose = false) => FromIcon(icon?.Handle ?? HICON.Null, xHotspot, yHotspot, destroyHandleOnDispose);
    public static Cursor? FromIcon(HICON icon, uint xHotspot, uint yHotspot, bool destroyHandleOnDispose = false)
    {
        if (icon == 0)
            return null;

        var handle = Icon.ToCursorHandle(icon, xHotspot, yHotspot);
        if (handle == 0)
            return null;

        return new(handle) { DestroyHandleOnDispose = destroyHandleOnDispose };
    }

    public static bool Destroy(ref HCURSOR handle)
    {
        if (handle.Value == 0)
            return false;

        var ret = Functions.DestroyCursor(handle);
        if (ret)
        {
            handle = new();
        }
        return ret;
    }

    public static bool Destroy(nint handle)
    {
        if (handle == 0)
            return false;

        return Functions.DestroyCursor(new HCURSOR { Value = handle });
    }

    public override int GetHashCode() => Handle.GetHashCode();
    public override string ToString() => Id + " " + Handle;
    public override bool Equals(object? obj) => Equals(obj as Cursor);
    public bool Equals(Cursor? other) => other != null && (Handle == other.Handle || (Id != 0 && Id == other.Id));

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            var handle = Interlocked.Exchange(ref _handle, 0);
            if (handle != 0 && DestroyHandleOnDispose)
            {
                Functions.DestroyCursor(new(handle));
            }
        }
    }

    ~Cursor() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
}

public class CursorConverter : TypeConverter
{
    public override bool CanConvertTo(ITypeDescriptorContext? context, [NotNullWhen(true)] Type? destinationType)
        => base.CanConvertTo(context, destinationType) || destinationType == typeof(string) || destinationType == typeof(HCURSOR);

    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type type)
        => base.CanConvertFrom(context, type) || type == typeof(string) || type == typeof(HCURSOR);

    public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object? value)
    {
        if (value is string s && s != null && int.TryParse(s, out var i))
            return new Cursor(i);

        if (value is HCURSOR cursor)
            return new Cursor(cursor);

        return null;
    }

    public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
    {
        if (destinationType == typeof(string))
        {
            if (value is Cursor cursor)
                return cursor.Id.ToString();

            return null;
        }

        if (destinationType == typeof(HCURSOR))
        {
            if (value is Cursor cursor)
                return cursor.Handle;

            return null;
        }

        return base.ConvertTo(context, culture, value, destinationType);
    }
}
