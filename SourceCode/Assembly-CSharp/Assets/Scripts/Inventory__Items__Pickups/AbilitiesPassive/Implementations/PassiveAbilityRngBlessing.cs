// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityRngBlessing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x2000400")]
  public class PassiveAbilityRngBlessing : PassiveAbility
  {
    [Token(Token = "0x4001A63")]
    [FieldOffset(Offset = "0x18")]
    private float luckPerLevel;

    [Token(Token = "0x6001CD8")]
    [Address(RVA = "0x430D50", Offset = "0x42F950", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001CD9")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001CDA")]
    [Address(RVA = "0x430EA0", Offset = "0x42FAA0", Length = "0x8F")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001CDB")]
    [Address(RVA = "0x430A40", Offset = "0x42F640", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001CDC")]
    [Address(RVA = "0x430D40", Offset = "0x42F940", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001CDD")]
    [Address(RVA = "0x430B90", Offset = "0x42F790", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001CDE")]
    [Address(RVA = "0x42BF40", Offset = "0x42AB40", Length = "0xE")]
    public PassiveAbilityRngBlessing()
    {
    }
  }
}
