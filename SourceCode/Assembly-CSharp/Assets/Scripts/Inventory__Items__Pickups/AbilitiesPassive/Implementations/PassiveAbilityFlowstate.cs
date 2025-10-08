// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityFlowstate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x20003F9")]
  public class PassiveAbilityFlowstate : PassiveAbility
  {
    [Token(Token = "0x4001A54")]
    [FieldOffset(Offset = "0x18")]
    private float attackSpeedPerLevel;

    [Token(Token = "0x6001CA9")]
    [Address(RVA = "0x42E6C0", Offset = "0x42D2C0", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001CAA")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001CAB")]
    [Address(RVA = "0x42E810", Offset = "0x42D410", Length = "0x8F")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001CAC")]
    [Address(RVA = "0x42E3C0", Offset = "0x42CFC0", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001CAD")]
    [Address(RVA = "0x3E74A0", Offset = "0x3E60A0", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001CAE")]
    [Address(RVA = "0x42E510", Offset = "0x42D110", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001CAF")]
    [Address(RVA = "0x42BF40", Offset = "0x42AB40", Length = "0xE")]
    public PassiveAbilityFlowstate()
    {
    }
  }
}
