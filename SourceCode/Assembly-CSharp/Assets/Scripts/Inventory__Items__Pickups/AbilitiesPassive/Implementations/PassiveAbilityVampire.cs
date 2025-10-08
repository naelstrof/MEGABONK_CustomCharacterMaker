// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityVampire
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x2000404")]
  public class PassiveAbilityVampire : PassiveAbility
  {
    [Token(Token = "0x4001A76")]
    [FieldOffset(Offset = "0x18")]
    private float lifestealPerLevel;

    [Token(Token = "0x6001CF6")]
    [Address(RVA = "0x432D50", Offset = "0x431950", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001CF7")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001CF8")]
    [Address(RVA = "0x432EA0", Offset = "0x431AA0", Length = "0x8F")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001CF9")]
    [Address(RVA = "0x432A40", Offset = "0x431640", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001CFA")]
    [Address(RVA = "0x432D40", Offset = "0x431940", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001CFB")]
    [Address(RVA = "0x432B90", Offset = "0x431790", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001CFC")]
    [Address(RVA = "0x42BF40", Offset = "0x42AB40", Length = "0xE")]
    public PassiveAbilityVampire()
    {
    }
  }
}
