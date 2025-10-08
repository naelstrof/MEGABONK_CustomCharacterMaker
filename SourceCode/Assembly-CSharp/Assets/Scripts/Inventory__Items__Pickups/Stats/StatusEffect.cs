// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Stats.StatusEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Stats
{
  [Token(Token = "0x2000387")]
  public class StatusEffect
  {
    [Token(Token = "0x40017D6")]
    [FieldOffset(Offset = "0x10")]
    public EStatusEffect eStatusEffect;
    [Token(Token = "0x40017D7")]
    [FieldOffset(Offset = "0x18")]
    public StatModifier[] modifiers;
    [Token(Token = "0x40017D8")]
    [FieldOffset(Offset = "0x20")]
    public float expirationTime;
    [Token(Token = "0x40017D9")]
    [FieldOffset(Offset = "0x24")]
    public float addedTime;

    [Token(Token = "0x6001925")]
    [Address(RVA = "0x41A810", Offset = "0x419410", Length = "0x9E")]
    public StatusEffect(
      EStatusEffect eStatusEffect,
      float expirationTime,
      StatModifier[] modifiers)
    {
    }
  }
}
