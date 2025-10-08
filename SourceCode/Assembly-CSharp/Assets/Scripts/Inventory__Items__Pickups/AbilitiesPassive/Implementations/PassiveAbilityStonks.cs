// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityStonks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x2000403")]
  public class PassiveAbilityStonks : PassiveAbility
  {
    [Token(Token = "0x4001A71")]
    [FieldOffset(Offset = "0x18")]
    private float goldIncreasePerLevel;
    [Token(Token = "0x4001A72")]
    [FieldOffset(Offset = "0x1C")]
    private float damageIncreasePer1000Gold;
    [Token(Token = "0x4001A73")]
    [FieldOffset(Offset = "0x20")]
    private float nextUpdateTime;
    [Token(Token = "0x4001A74")]
    [FieldOffset(Offset = "0x24")]
    private float updateCooldown;
    [Token(Token = "0x4001A75")]
    [FieldOffset(Offset = "0x28")]
    private float lastValue;

    [Token(Token = "0x6001CEF")]
    [Address(RVA = "0x432690", Offset = "0x431290", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001CF0")]
    [Address(RVA = "0x432870", Offset = "0x431470", Length = "0x194")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001CF1")]
    [Address(RVA = "0x4327E0", Offset = "0x4313E0", Length = "0x8F")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001CF2")]
    [Address(RVA = "0x4322F0", Offset = "0x430EF0", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001CF3")]
    [Address(RVA = "0x432680", Offset = "0x431280", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001CF4")]
    [Address(RVA = "0x432440", Offset = "0x431040", Length = "0x231")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001CF5")]
    [Address(RVA = "0x432A10", Offset = "0x431610", Length = "0x23")]
    public PassiveAbilityStonks()
    {
    }
  }
}
