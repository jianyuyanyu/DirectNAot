#nullable enable
namespace DirectN;

public partial struct HRAWINPUT : IEquatable<HRAWINPUT>, IValueGet<nint>
{
    public static readonly HRAWINPUT Null = new();
    
    public nint Value;
    
    public HRAWINPUT(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HRAWINPUT value && Equals(value);
    public readonly bool Equals(HRAWINPUT other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HRAWINPUT left, HRAWINPUT right) => left.Equals(right);
    public static bool operator !=(HRAWINPUT left, HRAWINPUT right) => !left.Equals(right);
    public static implicit operator nint(HRAWINPUT value) => value.Value;
    public static implicit operator HRAWINPUT(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
