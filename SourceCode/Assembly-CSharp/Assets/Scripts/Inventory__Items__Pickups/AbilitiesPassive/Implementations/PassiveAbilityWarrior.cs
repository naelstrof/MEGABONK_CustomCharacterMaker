// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityWarrior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x2000406")]
  public class PassiveAbilityWarrior : PassiveAbility
  {
    [Token(Token = "0x4001A78")]
    [FieldOffset(Offset = "0x18")]
    private float damagePerLevel;

    [Token(Token = "0x6001D04")]
    [Address(RVA = "0x433730", Offset = "0x432330", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001D05")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001D06")]
    [Address(RVA = "0x433880", Offset = "0x432480", Length = "0x8F")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001D07")]
    [Address(RVA = "0x433430", Offset = "0x432030", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001D08")]
    [Address(RVA = "0x432D40", Offset = "0x431940", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001D09")]
    [Address(RVA = "0x433580", Offset = "0x432180", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001D0A")]
    [Address(RVA = "0x42BF40", Offset = "0x42AB40", Length = "0xE")]
    public PassiveAbilityWarrior()
    {
    }
  }
}
