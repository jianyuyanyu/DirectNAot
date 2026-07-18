#nullable enable
namespace DirectN;

public partial struct PHIDP_PREPARSED_DATA : IEquatable<PHIDP_PREPARSED_DATA>, IValueGet<nint>
{
    public static readonly PHIDP_PREPARSED_DATA Null = new();
    
    public nint Value;
    
    public PHIDP_PREPARSED_DATA(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is PHIDP_PREPARSED_DATA value && Equals(value);
    public readonly bool Equals(PHIDP_PREPARSED_DATA other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(PHIDP_PREPARSED_DATA left, PHIDP_PREPARSED_DATA right) => left.Equals(right);
    public static bool operator !=(PHIDP_PREPARSED_DATA left, PHIDP_PREPARSED_DATA right) => !left.Equals(right);
    public static implicit operator nint(PHIDP_PREPARSED_DATA value) => value.Value;
    public static implicit operator PHIDP_PREPARSED_DATA(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
