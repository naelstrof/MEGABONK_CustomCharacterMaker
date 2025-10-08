// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityShadowstep
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x2000401")]
  public class PassiveAbilityShadowstep : PassiveAbility
  {
    [Token(Token = "0x4001A64")]
    [FieldOffset(Offset = "0x18")]
    private float evadePerLevel;
    [Token(Token = "0x4001A65")]
    private const string damageSource = "Shadowstep";
    [Token(Token = "0x4001A66")]
    [FieldOffset(Offset = "0x20")]
    private DamageContainer reuseDc;

    [Token(Token = "0x6001CDF")]
    [Address(RVA = "0x4313F0", Offset = "0x42FFF0", Length = "0x264")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001CE0")]
    [Address(RVA = "0x430F30", Offset = "0x42FB30", Length = "0x264")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001CE1")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001CE2")]
    [Address(RVA = "0x431730", Offset = "0x430330", Length = "0x8F")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001CE3")]
    [Address(RVA = "0x431660", Offset = "0x430260", Length = "0xC6")]
    private void OnEvade(Enemy enemy)
    {
    }

    [Token(Token = "0x6001CE4")]
    [Address(RVA = "0x4313E0", Offset = "0x42FFE0", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001CE5")]
    [Address(RVA = "0x4311A0", Offset = "0x42FDA0", Length = "0x238")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001CE6")]
    [Address(RVA = "0x4317C0", Offset = "0x4303C0", Length = "0x89")]
    public PassiveAbilityShadowstep()
    {
    }
  }
}
