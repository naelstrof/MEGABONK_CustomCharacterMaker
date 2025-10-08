// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityZooma
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x2000407")]
  public class PassiveAbilityZooma : PassiveAbility
  {
    [Token(Token = "0x4001A79")]
    [FieldOffset(Offset = "0x18")]
    private float chargePerMeter;
    [Token(Token = "0x4001A7A")]
    [FieldOffset(Offset = "0x1C")]
    private float checkInterval;
    [Token(Token = "0x4001A7B")]
    [FieldOffset(Offset = "0x20")]
    private float nextCheckTime;
    [Token(Token = "0x4001A7C")]
    [FieldOffset(Offset = "0x24")]
    private Vector3 lastPos;
    [Token(Token = "0x4001A7D")]
    [FieldOffset(Offset = "0x30")]
    private float accumulatedCharge;
    [Token(Token = "0x4001A7E")]
    [FieldOffset(Offset = "0x34")]
    private float attractionAddPerLevel;
    [Token(Token = "0x4001A7F")]
    [FieldOffset(Offset = "0x38")]
    private DamageContainer reuseDc;
    [Token(Token = "0x4001A80")]
    [FieldOffset(Offset = "0x40")]
    private string damageSource;

    [Token(Token = "0x6001D0B")]
    [Address(RVA = "0x433DA0", Offset = "0x4329A0", Length = "0x264")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001D0C")]
    [Address(RVA = "0x433910", Offset = "0x432510", Length = "0x264")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001D0D")]
    [Address(RVA = "0x434410", Offset = "0x433010", Length = "0x89")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001D0E")]
    [Address(RVA = "0x434010", Offset = "0x432C10", Length = "0x3F4")]
    private void OnEnemyDamage(Enemy enemy, DamageContainer dc)
    {
    }

    [Token(Token = "0x6001D0F")]
    [Address(RVA = "0x433B80", Offset = "0x432780", Length = "0x69")]
    private float GetDamage() => 0.0f;

    [Token(Token = "0x6001D10")]
    [Address(RVA = "0x4344A0", Offset = "0x4330A0", Length = "0x1E7")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001D11")]
    [Address(RVA = "0x3F37B0", Offset = "0x3F23B0", Length = "0x6")]
    public float GetProgress() => 0.0f;

    [Token(Token = "0x6001D12")]
    [Address(RVA = "0x403740", Offset = "0x402340", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001D13")]
    [Address(RVA = "0x433BF0", Offset = "0x4327F0", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001D14")]
    [Address(RVA = "0x434690", Offset = "0x433290", Length = "0xB2")]
    public PassiveAbilityZooma()
    {
    }
  }
}
