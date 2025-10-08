// Decompiled with JetBrains decompiler
// Type: ProjectileDragonsBreath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Combat.ConstantAttacks;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000BF")]
public class ProjectileDragonsBreath : ConstantAttack
{
  [Token(Token = "0x400063D")]
  [FieldOffset(Offset = "0x28")]
  public ParticleSystem ps;
  [Token(Token = "0x400063E")]
  [FieldOffset(Offset = "0x30")]
  public AudioSource sfx;
  [Token(Token = "0x400063F")]
  [FieldOffset(Offset = "0x38")]
  public AudioClip sfxStart;
  [Token(Token = "0x4000640")]
  [FieldOffset(Offset = "0x40")]
  public AudioClip sfxLoop;
  [Token(Token = "0x4000641")]
  [FieldOffset(Offset = "0x48")]
  private float defaultVolume;
  [Token(Token = "0x4000642")]
  [FieldOffset(Offset = "0x50")]
  private ParticleSystem.VelocityOverLifetimeModule[] velocities;
  [Token(Token = "0x4000643")]
  [FieldOffset(Offset = "0x58")]
  private ParticleSystem[] particles;
  [Token(Token = "0x4000644")]
  [FieldOffset(Offset = "0x60")]
  private float startTime;
  [Token(Token = "0x4000645")]
  [FieldOffset(Offset = "0x64")]
  private float stopTime;
  [Token(Token = "0x4000646")]
  [FieldOffset(Offset = "0x68")]
  private float previousStopTime;
  [Token(Token = "0x4000647")]
  [FieldOffset(Offset = "0x6C")]
  private float stopHitboxTime;
  [Token(Token = "0x4000648")]
  [FieldOffset(Offset = "0x70")]
  private Dictionary<Collider, float> enemyHitCooldowns;
  [Token(Token = "0x4000649")]
  [FieldOffset(Offset = "0x78")]
  private float enemyHitCooldown;
  [Token(Token = "0x400064A")]
  [FieldOffset(Offset = "0x7C")]
  private float hitboxCooldown;
  [Token(Token = "0x400064B")]
  [FieldOffset(Offset = "0x80")]
  private float nextHitboxTime;
  [Token(Token = "0x400064C")]
  [FieldOffset(Offset = "0x84")]
  private bool isActive;
  [Token(Token = "0x400064D")]
  [FieldOffset(Offset = "0x88")]
  private float range;
  [Token(Token = "0x400064E")]
  [FieldOffset(Offset = "0x8C")]
  private float duration;
  [Token(Token = "0x400064F")]
  [FieldOffset(Offset = "0x90")]
  private float rotationSpeed;
  [Token(Token = "0x4000650")]
  [FieldOffset(Offset = "0x94")]
  private float cooldown;
  [Token(Token = "0x4000651")]
  [FieldOffset(Offset = "0x98")]
  private float minCooldown;
  [Token(Token = "0x4000652")]
  [FieldOffset(Offset = "0x9C")]
  private Vector3 attackDir;
  [Token(Token = "0x4000653")]
  [FieldOffset(Offset = "0xA8")]
  private float lingerTime;
  [Token(Token = "0x4000654")]
  [FieldOffset(Offset = "0xAC")]
  private float scaleTimer;
  [Token(Token = "0x4000655")]
  [FieldOffset(Offset = "0xB0")]
  private float scaleOverTime;
  [Token(Token = "0x4000656")]
  [FieldOffset(Offset = "0xB4")]
  private float oldRange;
  [Token(Token = "0x4000657")]
  [FieldOffset(Offset = "0xB8")]
  private float scale;
  [Token(Token = "0x4000658")]
  [FieldOffset(Offset = "0xBC")]
  private float oldScale;

  [Token(Token = "0x60004FF")]
  [Address(RVA = "0x48C1E0", Offset = "0x48ADE0", Length = "0x1F8")]
  protected override void Init()
  {
  }

  [Token(Token = "0x6000500")]
  [Address(RVA = "0x48CCC0", Offset = "0x48B8C0", Length = "0x23A")]
  private void Update()
  {
  }

  [Token(Token = "0x6000501")]
  [Address(RVA = "0x48B720", Offset = "0x48A320", Length = "0x662")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000502")]
  [Address(RVA = "0x48BD90", Offset = "0x48A990", Length = "0x446")]
  private bool HitEnemy(Collider collider) => false;

  [Token(Token = "0x6000503")]
  [Address(RVA = "0x48C720", Offset = "0x48B320", Length = "0x2A1")]
  private void StepActive()
  {
  }

  [Token(Token = "0x6000504")]
  [Address(RVA = "0x48C3E0", Offset = "0x48AFE0", Length = "0x8")]
  private bool IsAttacking() => false;

  [Token(Token = "0x6000505")]
  [Address(RVA = "0x48C5D0", Offset = "0x48B1D0", Length = "0x142")]
  private void SizeUpdate()
  {
  }

  [Token(Token = "0x6000506")]
  [Address(RVA = "0x3579E0", Offset = "0x3565E0", Length = "0x3B")]
  protected override void OnWeaponStatUpdate(EStat stat, EWeapon weapon)
  {
  }

  [Token(Token = "0x6000507")]
  [Address(RVA = "0x48C3F0", Offset = "0x48AFF0", Length = "0x44")]
  protected override void OnStatUpdate(EStat stat)
  {
  }

  [Token(Token = "0x6000508")]
  [Address(RVA = "0x48CC20", Offset = "0x48B820", Length = "0x94")]
  private void UpdateSize()
  {
  }

  [Token(Token = "0x6000509")]
  [Address(RVA = "0x48C9D0", Offset = "0x48B5D0", Length = "0x9B")]
  private void UpdateCooldown()
  {
  }

  [Token(Token = "0x600050A")]
  [Address(RVA = "0x375D80", Offset = "0x374980", Length = "0x3")]
  public override bool IsManualRotation() => false;

  [Token(Token = "0x600050B")]
  [Address(RVA = "0x3573F0", Offset = "0x355FF0", Length = "0x4")]
  public override float GetAuraRotationSpeed() => 0.0f;

  [Token(Token = "0x600050C")]
  [Address(RVA = "0x48CA70", Offset = "0x48B670", Length = "0x1A2")]
  private void UpdateSfx()
  {
  }

  [Token(Token = "0x600050D")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void OnDrawGizmos()
  {
  }

  [Token(Token = "0x600050E")]
  [Address(RVA = "0x48CF00", Offset = "0x48BB00", Length = "0xB7")]
  public ProjectileDragonsBreath()
  {
  }
}
