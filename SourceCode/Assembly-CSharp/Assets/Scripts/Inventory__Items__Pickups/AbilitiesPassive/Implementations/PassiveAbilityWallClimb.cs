// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityWallClimb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x2000405")]
  public class PassiveAbilityWallClimb : PassiveAbility
  {
    [Token(Token = "0x4001A77")]
    [FieldOffset(Offset = "0x18")]
    private float hpPerLevel;

    [Token(Token = "0x6001CFD")]
    [Address(RVA = "0x433240", Offset = "0x431E40", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001CFE")]
    [Address(RVA = "0x433390", Offset = "0x431F90", Length = "0x8F")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001CFF")]
    [Address(RVA = "0x432F30", Offset = "0x431B30", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001D00")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001D01")]
    [Address(RVA = "0x433230", Offset = "0x431E30", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001D02")]
    [Address(RVA = "0x433080", Offset = "0x431C80", Length = "0x1A2")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001D03")]
    [Address(RVA = "0x433420", Offset = "0x432020", Length = "0xE")]
    public PassiveAbilityWallClimb()
    {
    }
  }
}
