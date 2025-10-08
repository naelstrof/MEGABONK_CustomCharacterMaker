// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.InGame.Rewards.EncounterOffer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups;
using Cpp2ILInjected;
using System;

namespace Assets.Scripts.UI.InGame.Rewards
{
  [Token(Token = "0x20002FB")]
  [Serializable]
  public class EncounterOffer
  {
    [Token(Token = "0x4001452")]
    [FieldOffset(Offset = "0x10")]
    public ERarity rarity;
    [Token(Token = "0x4001453")]
    [FieldOffset(Offset = "0x18")]
    public EffectStat[] effects;

    [Token(Token = "0x600159A")]
    [Address(RVA = "0x3A9850", Offset = "0x3A8450", Length = "0x14F")]
    public string GetEffectsDescription() => (string) null;

    [Token(Token = "0x600159B")]
    [Address(RVA = "0x3A9350", Offset = "0x3A7F50", Length = "0x20C")]
    public void ApplyEffects(bool showInScoreUi = true)
    {
    }

    [Token(Token = "0x600159C")]
    [Address(RVA = "0x3A9560", Offset = "0x3A8160", Length = "0x2E0")]
    public bool CanAccept(out string reason)
    {
      reason = (string) null;
      return false;
    }

    [Token(Token = "0x600159D")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public EncounterOffer()
    {
    }
  }
}
