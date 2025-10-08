// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.InGame.Rewards.EffectStat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.UI.InGame.Rewards.Effects;
using Cpp2ILInjected;
using System;

namespace Assets.Scripts.UI.InGame.Rewards
{
  [Token(Token = "0x20002F9")]
  [Serializable]
  public class EffectStat
  {
    [Token(Token = "0x4001448")]
    [FieldOffset(Offset = "0x10")]
    public EEncounterEffect effectType;
    [Token(Token = "0x4001449")]
    [FieldOffset(Offset = "0x18")]
    public StatModifier statModifier;
    [Token(Token = "0x400144A")]
    [FieldOffset(Offset = "0x20")]
    public bool permanent;
    [Token(Token = "0x400144B")]
    [FieldOffset(Offset = "0x24")]
    public float duration;
    [Token(Token = "0x400144C")]
    [FieldOffset(Offset = "0x28")]
    public float value;
    [Token(Token = "0x400144D")]
    [FieldOffset(Offset = "0x2C")]
    public bool isPositiveEffect;

    [Token(Token = "0x600158A")]
    [Address(RVA = "0x3A8310", Offset = "0x3A6F10", Length = "0x741")]
    public string GetDescription() => (string) null;

    [Token(Token = "0x600158B")]
    [Address(RVA = "0x3A8D50", Offset = "0x3A7950", Length = "0x105")]
    private float GetValue() => 0.0f;

    [Token(Token = "0x600158C")]
    [Address(RVA = "0x3A8CA0", Offset = "0x3A78A0", Length = "0xAD")]
    private string GetStatDescription(string color) => (string) null;

    [Token(Token = "0x600158D")]
    [Address(RVA = "0x3A8B90", Offset = "0x3A7790", Length = "0x10F")]
    public string GetShortDescription() => (string) null;

    [Token(Token = "0x600158E")]
    [Address(RVA = "0x3A8AD0", Offset = "0x3A76D0", Length = "0xBC")]
    public string GetEffectNumber() => (string) null;

    [Token(Token = "0x600158F")]
    [Address(RVA = "0x3A8A60", Offset = "0x3A7660", Length = "0x67")]
    public string GetEffectName() => (string) null;

    [Token(Token = "0x6001590")]
    [Address(RVA = "0x3A7DA0", Offset = "0x3A69A0", Length = "0x2FE")]
    public void ApplyEffect()
    {
    }

    [Token(Token = "0x6001591")]
    [Address(RVA = "0x3A82C0", Offset = "0x3A6EC0", Length = "0x4D")]
    private string GetColor() => (string) null;

    [Token(Token = "0x6001592")]
    [Address(RVA = "0x3A8E60", Offset = "0x3A7A60", Length = "0x1E7")]
    private void HealthEffect()
    {
    }

    [Token(Token = "0x6001593")]
    [Address(RVA = "0x3A80A0", Offset = "0x3A6CA0", Length = "0x216")]
    public bool CanApplyEffect(out string reason)
    {
      reason = (string) null;
      return false;
    }

    [Token(Token = "0x6001594")]
    [Address(RVA = "0x3A9050", Offset = "0x3A7C50", Length = "0xF")]
    public EffectStat()
    {
    }
  }
}
