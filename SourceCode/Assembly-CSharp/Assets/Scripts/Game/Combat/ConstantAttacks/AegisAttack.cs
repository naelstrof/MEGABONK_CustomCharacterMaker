// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.ConstantAttacks.AegisAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System;
using UnityEngine;

namespace Assets.Scripts.Game.Combat.ConstantAttacks
{
  [Token(Token = "0x2000442")]
  public class AegisAttack : ConstantAttack
  {
    [Token(Token = "0x4001B8C")]
    [FieldOffset(Offset = "0x28")]
    public RandomSfx shieldUseSfx;
    [Token(Token = "0x4001B8D")]
    [FieldOffset(Offset = "0x30")]
    public RandomSfx shieldRegenSfx;
    [Token(Token = "0x4001B8E")]
    [FieldOffset(Offset = "0x38")]
    public Transform renderer;
    [Token(Token = "0x4001B8F")]
    [FieldOffset(Offset = "0x40")]
    public AegisRenderer aegisRenderer;
    [Token(Token = "0x4001B90")]
    [FieldOffset(Offset = "0x48")]
    public Transform[] particles;
    [Token(Token = "0x4001B91")]
    [FieldOffset(Offset = "0x50")]
    public ParticleSystem rootParticles;
    [Token(Token = "0x4001B92")]
    [FieldOffset(Offset = "0x58")]
    private bool isActive;
    [Token(Token = "0x4001B93")]
    [FieldOffset(Offset = "0x5C")]
    private int currentAmount;
    [Token(Token = "0x4001B94")]
    [FieldOffset(Offset = "0x60")]
    private float minAegisCooldown;
    [Token(Token = "0x4001B95")]
    [FieldOffset(Offset = "0x64")]
    private float shieldReadyAtTime;
    [Token(Token = "0x4001B96")]
    public static Action<int> A_Used;
    [Token(Token = "0x4001B97")]
    public static Action<int> A_Regen;
    [Token(Token = "0x4001B98")]
    [FieldOffset(Offset = "0x68")]
    private float nextAmountTime;

    [Token(Token = "0x6001E6D")]
    [Address(RVA = "0x43A610", Offset = "0x439210", Length = "0x66")]
    protected override void Init()
    {
    }

    [Token(Token = "0x6001E6E")]
    [Address(RVA = "0x43A500", Offset = "0x439100", Length = "0xA6")]
    private void FixedUpdate()
    {
    }

    [Token(Token = "0x6001E6F")]
    [Address(RVA = "0x43A610", Offset = "0x439210", Length = "0x66")]
    public void RegenShield()
    {
    }

    [Token(Token = "0x6001E70")]
    [Address(RVA = "0x43A400", Offset = "0x439000", Length = "0xFE")]
    private void AmplifyShield()
    {
    }

    [Token(Token = "0x6001E71")]
    [Address(RVA = "0x43A750", Offset = "0x439350", Length = "0xA9")]
    private void ResetNextAmountTime()
    {
    }

    [Token(Token = "0x6001E72")]
    [Address(RVA = "0x43A5C0", Offset = "0x4391C0", Length = "0x4D")]
    private int GetMaxShields() => 0;

    [Token(Token = "0x6001E73")]
    [Address(RVA = "0x43A800", Offset = "0x439400", Length = "0x898")]
    public void UseShield(Vector3 enemyFeetPosition)
    {
    }

    [Token(Token = "0x6001E74")]
    [Address(RVA = "0x39E880", Offset = "0x39D480", Length = "0x5")]
    public bool IsActive() => false;

    [Token(Token = "0x6001E75")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void OnWeaponStatUpdate(EStat stat, EWeapon weapon)
    {
    }

    [Token(Token = "0x6001E76")]
    [Address(RVA = "0x43A680", Offset = "0x439280", Length = "0xCD")]
    protected override void OnStatUpdate(EStat stat)
    {
    }

    [Token(Token = "0x6001E77")]
    [Address(RVA = "0x43A5B0", Offset = "0x4391B0", Length = "0x9")]
    public override float GetAuraRotationSpeed() => 0.0f;

    [Token(Token = "0x6001E78")]
    [Address(RVA = "0x43B0A0", Offset = "0x439CA0", Length = "0xE")]
    public AegisAttack()
    {
    }
  }
}
