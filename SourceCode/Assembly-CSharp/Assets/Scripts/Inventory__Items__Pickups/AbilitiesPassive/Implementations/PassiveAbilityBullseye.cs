// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityBullseye
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x20003F3")]
  public class PassiveAbilityBullseye : PassiveAbility
  {
    [Token(Token = "0x4001A3C")]
    [FieldOffset(Offset = "0x18")]
    private float critDamagePerLevel;
    [Token(Token = "0x4001A3D")]
    public const int MAX_MARKERS = 20;
    [Token(Token = "0x4001A3E")]
    [FieldOffset(Offset = "0x1C")]
    private float markDuration;
    [Token(Token = "0x4001A3F")]
    [FieldOffset(Offset = "0x20")]
    private float markCooldown;
    [Token(Token = "0x4001A40")]
    [FieldOffset(Offset = "0x24")]
    private float markReadyAtTime;
    [Token(Token = "0x4001A41")]
    [FieldOffset(Offset = "0x28")]
    private float explosionRadius;
    [Token(Token = "0x4001A42")]
    [FieldOffset(Offset = "0x2C")]
    private float explosionDamage;
    [Token(Token = "0x4001A43")]
    private static Dictionary<Enemy, float> markedEnemies;
    [Token(Token = "0x4001A44")]
    [FieldOffset(Offset = "0x30")]
    private string damageSource;
    [Token(Token = "0x4001A45")]
    [FieldOffset(Offset = "0x38")]
    private DamageContainer reuseDc;
    [Token(Token = "0x4001A46")]
    [FieldOffset(Offset = "0x40")]
    private bool isExplosionDamage;

    [Token(Token = "0x6001C75")]
    [Address(RVA = "0x42A870", Offset = "0x429470", Length = "0x54A")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001C76")]
    [Address(RVA = "0x42A170", Offset = "0x428D70", Length = "0x540")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001C77")]
    [Address(RVA = "0x42B7C0", Offset = "0x42A3C0", Length = "0x8F")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001C78")]
    [Address(RVA = "0x42B850", Offset = "0x42A450", Length = "0x7")]
    private void OnStageStarted()
    {
    }

    [Token(Token = "0x6001C79")]
    [Address(RVA = "0x42B530", Offset = "0x42A130", Length = "0x285")]
    private void OnEnemySpawned(Enemy enemy)
    {
    }

    [Token(Token = "0x6001C7A")]
    [Address(RVA = "0x42AEF0", Offset = "0x429AF0", Length = "0x591")]
    private void OnEnemyDamaged(Enemy enemy, DamageContainer dc)
    {
    }

    [Token(Token = "0x6001C7B")]
    [Address(RVA = "0x42B490", Offset = "0x42A090", Length = "0x9C")]
    private void OnEnemyReleasedFromPool(Enemy enemy)
    {
    }

    [Token(Token = "0x6001C7C")]
    [Address(RVA = "0x42B860", Offset = "0x42A460", Length = "0xD2")]
    private void Reset()
    {
    }

    [Token(Token = "0x6001C7D")]
    [Address(RVA = "0x42ADC0", Offset = "0x4299C0", Length = "0x12F")]
    public static bool IsMarkedEnemy(Enemy enemy) => false;

    [Token(Token = "0x6001C7E")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001C7F")]
    [Address(RVA = "0x395320", Offset = "0x393F20", Length = "0x3")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001C80")]
    [Address(RVA = "0x42A6C0", Offset = "0x4292C0", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001C81")]
    [Address(RVA = "0x42B940", Offset = "0x42A540", Length = "0x10C")]
    public PassiveAbilityBullseye()
    {
    }
  }
}
