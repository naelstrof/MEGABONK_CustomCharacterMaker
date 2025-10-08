// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityEnduring
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x20003F6")]
  public class PassiveAbilityEnduring : PassiveAbility
  {
    [Token(Token = "0x4001A49")]
    [FieldOffset(Offset = "0x18")]
    private float druationPerLevel;

    [Token(Token = "0x6001C90")]
    [Address(RVA = "0x42C750", Offset = "0x42B350", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001C91")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001C92")]
    [Address(RVA = "0x42C8A0", Offset = "0x42B4A0", Length = "0x8F")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001C93")]
    [Address(RVA = "0x42C440", Offset = "0x42B040", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001C94")]
    [Address(RVA = "0x42C740", Offset = "0x42B340", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001C95")]
    [Address(RVA = "0x42C590", Offset = "0x42B190", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001C96")]
    [Address(RVA = "0x42BF40", Offset = "0x42AB40", Length = "0xE")]
    public PassiveAbilityEnduring()
    {
    }
  }
}
