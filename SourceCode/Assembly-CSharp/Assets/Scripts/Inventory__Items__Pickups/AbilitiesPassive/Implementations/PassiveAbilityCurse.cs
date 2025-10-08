// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityCurse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x20003F5")]
  public class PassiveAbilityCurse : PassiveAbility
  {
    [Token(Token = "0x4001A48")]
    [FieldOffset(Offset = "0x18")]
    private float difficultyChancePerLevel;

    [Token(Token = "0x6001C89")]
    [Address(RVA = "0x42C260", Offset = "0x42AE60", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001C8A")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001C8B")]
    [Address(RVA = "0x42C3B0", Offset = "0x42AFB0", Length = "0x8F")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001C8C")]
    [Address(RVA = "0x42BF50", Offset = "0x42AB50", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001C8D")]
    [Address(RVA = "0x42C250", Offset = "0x42AE50", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001C8E")]
    [Address(RVA = "0x42C0A0", Offset = "0x42ACA0", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001C8F")]
    [Address(RVA = "0x42BF40", Offset = "0x42AB40", Length = "0xE")]
    public PassiveAbilityCurse()
    {
    }
  }
}
