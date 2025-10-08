// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Stats.StatComponents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Stats
{
  [Token(Token = "0x2000382")]
  public class StatComponents
  {
    [Token(Token = "0x40017C8")]
    [FieldOffset(Offset = "0x10")]
    public bool hasModifications;

    [field: Token(Token = "0x40017C9")]
    [field: FieldOffset(Offset = "0x14")]
    [Token(Token = "0x17000387")]
    public float baseValue { [Token(Token = "0x600190B"), Address(RVA = "0x3933A0", Offset = "0x391FA0", Length = "0x6")] get; [Token(Token = "0x600190C"), Address(RVA = "0x393400", Offset = "0x392000", Length = "0x6")] private set; }

    [field: Token(Token = "0x40017CA")]
    [field: FieldOffset(Offset = "0x18")]
    [Token(Token = "0x17000388")]
    public float additiveValue { [Token(Token = "0x600190D"), Address(RVA = "0x393390", Offset = "0x391F90", Length = "0x6")] get; [Token(Token = "0x600190E"), Address(RVA = "0x3933F0", Offset = "0x391FF0", Length = "0x6")] private set; }

    [field: Token(Token = "0x40017CB")]
    [field: FieldOffset(Offset = "0x1C")]
    [Token(Token = "0x17000389")]
    public float multiplicativeValue { [Token(Token = "0x600190F"), Address(RVA = "0x393330", Offset = "0x391F30", Length = "0x6")] get; [Token(Token = "0x6001910"), Address(RVA = "0x3933B0", Offset = "0x391FB0", Length = "0x6")] private set; }

    [Token(Token = "0x6001911")]
    [Address(RVA = "0x3F65B0", Offset = "0x3F51B0", Length = "0x11")]
    public void Recycle()
    {
    }

    [Token(Token = "0x6001912")]
    [Address(RVA = "0x3F65D0", Offset = "0x3F51D0", Length = "0x10")]
    public void SetValues(float baseValues, float additiveValues, float multiplicativeValues)
    {
    }

    [Token(Token = "0x6001913")]
    [Address(RVA = "0x3F6570", Offset = "0x3F5170", Length = "0x39")]
    public float GetFinalValue(StatComponents other) => 0.0f;

    [Token(Token = "0x6001914")]
    [Address(RVA = "0x3F6560", Offset = "0x3F5160", Length = "0xF")]
    public void AddMultiplier(float value)
    {
    }

    [Token(Token = "0x6001915")]
    [Address(RVA = "0x3F6540", Offset = "0x3F5140", Length = "0xF")]
    public void AddAdditive(float value)
    {
    }

    [Token(Token = "0x6001916")]
    [Address(RVA = "0x3F6550", Offset = "0x3F5150", Length = "0xF")]
    public void AddFlat(float value)
    {
    }

    [Token(Token = "0x6001917")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public StatComponents()
    {
    }
  }
}
