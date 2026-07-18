#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ntddkbd/ns-ntddkbd-keyboard_unit_id_parameter
public partial struct KEYBOARD_UNIT_ID_PARAMETER : IEquatable<KEYBOARD_UNIT_ID_PARAMETER>, IValueGet<ushort>
{
    public static readonly KEYBOARD_UNIT_ID_PARAMETER Null = new();
    
    public ushort UnitId;
    
    public KEYBOARD_UNIT_ID_PARAMETER(ushort value) => this.UnitId = value;
    public override readonly string ToString() => $"0x{UnitId:x}";
    
    public override readonly bool Equals(object? obj) => obj is KEYBOARD_UNIT_ID_PARAMETER value && Equals(value);
    public readonly bool Equals(KEYBOARD_UNIT_ID_PARAMETER other) => other.UnitId == UnitId;
    public override readonly int GetHashCode() => UnitId.GetHashCode();
    public static bool operator ==(KEYBOARD_UNIT_ID_PARAMETER left, KEYBOARD_UNIT_ID_PARAMETER right) => left.Equals(right);
    public static bool operator !=(KEYBOARD_UNIT_ID_PARAMETER left, KEYBOARD_UNIT_ID_PARAMETER right) => !left.Equals(right);
    public static implicit operator ushort(KEYBOARD_UNIT_ID_PARAMETER value) => value.UnitId;
    public static implicit operator KEYBOARD_UNIT_ID_PARAMETER(ushort value) => new(value);
    
    readonly ushort IValueGet<ushort>.GetValue() => UnitId;
    readonly object? IValueGet.GetValue() => UnitId;
}
