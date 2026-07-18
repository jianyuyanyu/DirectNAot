#nullable enable
namespace DirectN;

public partial struct DICONSTANTFORCE : IEquatable<DICONSTANTFORCE>, IValueGet<int>
{
    public static readonly DICONSTANTFORCE Null = new();
    
    public int lMagnitude;
    
    public DICONSTANTFORCE(int value) => this.lMagnitude = value;
    public override readonly string ToString() => $"0x{lMagnitude:x}";
    
    public override readonly bool Equals(object? obj) => obj is DICONSTANTFORCE value && Equals(value);
    public readonly bool Equals(DICONSTANTFORCE other) => other.lMagnitude == lMagnitude;
    public override readonly int GetHashCode() => lMagnitude.GetHashCode();
    public static bool operator ==(DICONSTANTFORCE left, DICONSTANTFORCE right) => left.Equals(right);
    public static bool operator !=(DICONSTANTFORCE left, DICONSTANTFORCE right) => !left.Equals(right);
    public static implicit operator int(DICONSTANTFORCE value) => value.lMagnitude;
    public static implicit operator DICONSTANTFORCE(int value) => new(value);
    
    readonly int IValueGet<int>.GetValue() => lMagnitude;
    readonly object? IValueGet.GetValue() => lMagnitude;
}
