// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityReinforced
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x20003FF")]
  public class PassiveAbilityReinforced : PassiveAbility
  {
    [Token(Token = "0x4001A62")]
    [FieldOffset(Offset = "0x18")]
    private float armorPerLevel;

    [Token(Token = "0x6001CD1")]
    [Address(RVA = "0x430860", Offset = "0x42F460", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001CD2")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001CD3")]
    [Address(RVA = "0x4309B0", Offset = "0x42F5B0", Length = "0x8F")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001CD4")]
    [Address(RVA = "0x430560", Offset = "0x42F160", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001CD5")]
    [Address(RVA = "0x3E74B0", Offset = "0x3E60B0", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001CD6")]
    [Address(RVA = "0x4306B0", Offset = "0x42F2B0", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001CD7")]
    [Address(RVA = "0x42BF40", Offset = "0x42AB40", Length = "0xE")]
    public PassiveAbilityReinforced()
    {
    }
  }
}
