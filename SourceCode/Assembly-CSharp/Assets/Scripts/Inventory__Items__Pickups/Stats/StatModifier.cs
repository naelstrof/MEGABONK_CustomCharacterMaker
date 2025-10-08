// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Stats.StatModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System;

namespace Assets.Scripts.Inventory__Items__Pickups.Stats
{
  [Token(Token = "0x2000384")]
  [Serializable]
  public class StatModifier
  {
    [Token(Token = "0x40017D1")]
    [FieldOffset(Offset = "0x10")]
    public EStat stat;
    [Token(Token = "0x40017D2")]
    [FieldOffset(Offset = "0x14")]
    public EStatModifyType modifyType;
    [Token(Token = "0x40017D3")]
    [FieldOffset(Offset = "0x18")]
    public float modification;

    [Token(Token = "0x600191D")]
    [Address(RVA = "0x393390", Offset = "0x391F90", Length = "0x6")]
    public float GetModificationAtAmount(int amount) => 0.0f;

    [Token(Token = "0x600191E")]
    [Address(RVA = "0x419340", Offset = "0x417F40", Length = "0x76")]
    public float GetModificationTotal(int amount) => 0.0f;

    [Token(Token = "0x600191F")]
    [Address(RVA = "0x4193C0", Offset = "0x417FC0", Length = "0xB7")]
    public override string ToString() => (string) null;

    [Token(Token = "0x6001920")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public StatModifier()
    {
    }
  }
}
