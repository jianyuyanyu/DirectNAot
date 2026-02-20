#nullable enable
namespace DirectN;

public partial struct HHOOK : IEquatable<HHOOK>, IValueGet<nint>
{
    public static readonly HHOOK Null = new();
    
    public nint Value;
    
    public HHOOK(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HHOOK value && Equals(value);
    public readonly bool Equals(HHOOK other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HHOOK left, HHOOK right) => left.Equals(right);
    public static bool operator !=(HHOOK left, HHOOK right) => !left.Equals(right);
    public static implicit operator nint(HHOOK value) => value.Value;
    public static implicit operator HHOOK(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
