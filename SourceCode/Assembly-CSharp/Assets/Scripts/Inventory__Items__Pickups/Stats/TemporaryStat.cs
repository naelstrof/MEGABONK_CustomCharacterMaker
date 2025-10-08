// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Stats.TemporaryStat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Stats
{
  [Token(Token = "0x2000389")]
  public class TemporaryStat
  {
    [Token(Token = "0x40017DA")]
    [FieldOffset(Offset = "0x10")]
    public StatModifier modifier;
    [Token(Token = "0x40017DB")]
    [FieldOffset(Offset = "0x18")]
    public float expirationTime;

    [Token(Token = "0x6001933")]
    [Address(RVA = "0x3A7D50", Offset = "0x3A6950", Length = "0x44")]
    public TemporaryStat(StatModifier modifier, float expirationTime)
    {
    }
  }
}
