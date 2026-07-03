#nullable enable
namespace DirectN;

public partial struct _PACKAGE_INFO_REFERENCE : IEquatable<_PACKAGE_INFO_REFERENCE>, IValueGet<nint>
{
    public static readonly _PACKAGE_INFO_REFERENCE Null = new();
    
    public nint reserved;
    
    public _PACKAGE_INFO_REFERENCE(nint value) => this.reserved = value;
    public override readonly string ToString() => $"0x{reserved:x}";
    
    public override readonly bool Equals(object? obj) => obj is _PACKAGE_INFO_REFERENCE value && Equals(value);
    public readonly bool Equals(_PACKAGE_INFO_REFERENCE other) => other.reserved == reserved;
    public override readonly int GetHashCode() => reserved.GetHashCode();
    public static bool operator ==(_PACKAGE_INFO_REFERENCE left, _PACKAGE_INFO_REFERENCE right) => left.Equals(right);
    public static bool operator !=(_PACKAGE_INFO_REFERENCE left, _PACKAGE_INFO_REFERENCE right) => !left.Equals(right);
    public static implicit operator nint(_PACKAGE_INFO_REFERENCE value) => value.reserved;
    public static implicit operator _PACKAGE_INFO_REFERENCE(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => reserved;
    readonly object? IValueGet.GetValue() => reserved;
}
