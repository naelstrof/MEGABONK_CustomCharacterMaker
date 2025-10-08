// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityCritHappens
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x20003F4")]
  public class PassiveAbilityCritHappens : PassiveAbility
  {
    [Token(Token = "0x4001A47")]
    [FieldOffset(Offset = "0x18")]
    private float critChancePerLevel;

    [Token(Token = "0x6001C82")]
    [Address(RVA = "0x42BD60", Offset = "0x42A960", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001C83")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001C84")]
    [Address(RVA = "0x42BEB0", Offset = "0x42AAB0", Length = "0x8F")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001C85")]
    [Address(RVA = "0x42BA50", Offset = "0x42A650", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001C86")]
    [Address(RVA = "0x42BD50", Offset = "0x42A950", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001C87")]
    [Address(RVA = "0x42BBA0", Offset = "0x42A7A0", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001C88")]
    [Address(RVA = "0x42BF40", Offset = "0x42AB40", Length = "0xE")]
    public PassiveAbilityCritHappens()
    {
    }
  }
}
