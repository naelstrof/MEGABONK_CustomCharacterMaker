// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityGamba
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x20003FA")]
  public class PassiveAbilityGamba : PassiveAbility
  {
    [Token(Token = "0x4001A55")]
    [FieldOffset(Offset = "0x18")]
    private float upgradeMultiplier;
    [Token(Token = "0x4001A56")]
    [FieldOffset(Offset = "0x1C")]
    private float minMultiplier;
    [Token(Token = "0x4001A57")]
    [FieldOffset(Offset = "0x20")]
    private float maxMultiplier;

    [Token(Token = "0x6001CB0")]
    [Address(RVA = "0x42EA20", Offset = "0x42D620", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001CB1")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001CB2")]
    [Address(RVA = "0x42EB70", Offset = "0x42D770", Length = "0x1E6")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001CB3")]
    [Address(RVA = "0x42E8A0", Offset = "0x42D4A0", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001CB4")]
    [Address(RVA = "0x42EA10", Offset = "0x42D610", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001CB5")]
    [Address(RVA = "0x42E9F0", Offset = "0x42D5F0", Length = "0x1F")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001CB6")]
    [Address(RVA = "0x42ED60", Offset = "0x42D960", Length = "0x1C")]
    public PassiveAbilityGamba()
    {
    }
  }
}
