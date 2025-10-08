// Decompiled with JetBrains decompiler
// Type: IceAura
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Combat.ConstantAttacks;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000053")]
public class IceAura : ConstantAttack
{
  [Token(Token = "0x40002C9")]
  [FieldOffset(Offset = "0x28")]
  private float defaultRadius;
  [Token(Token = "0x40002CA")]
  [FieldOffset(Offset = "0x30")]
  public AttackMuzzle attackMuzzle;
  [Token(Token = "0x40002CB")]
  [FieldOffset(Offset = "0x38")]
  private float radius;
  [Token(Token = "0x40002CC")]
  [FieldOffset(Offset = "0x3C")]
  private float cooldown;
  [Token(Token = "0x40002CD")]
  [FieldOffset(Offset = "0x40")]
  private float oldRadius;
  [Token(Token = "0x40002CE")]
  [FieldOffset(Offset = "0x44")]
  private float scaleTimer;
  [Token(Token = "0x40002CF")]
  [FieldOffset(Offset = "0x48")]
  private float scaleOverTime;
  [Token(Token = "0x40002D0")]
  [FieldOffset(Offset = "0x4C")]
  private float minCooldown;
  [Token(Token = "0x40002D1")]
  [FieldOffset(Offset = "0x50")]
  public ParticleSystem psRing;
  [Token(Token = "0x40002D2")]
  [FieldOffset(Offset = "0x58")]
  public ParticleSystem psSmoke;
  [Token(Token = "0x40002D3")]
  [FieldOffset(Offset = "0x60")]
  public ParticleSystem psSnow;
  [Token(Token = "0x40002D4")]
  [FieldOffset(Offset = "0x68")]
  private ParticleSystem.EmissionModule emissionSmoke;
  [Token(Token = "0x40002D5")]
  [FieldOffset(Offset = "0x70")]
  private ParticleSystem.EmissionModule emissionSnow;
  [Token(Token = "0x40002D6")]
  [FieldOffset(Offset = "0x78")]
  private Color ringStartColor;
  [Token(Token = "0x40002D7")]
  [FieldOffset(Offset = "0x88")]
  private bool inited;
  [Token(Token = "0x40002D8")]
  [FieldOffset(Offset = "0x8C")]
  private float nextCheckDamageTime;

  [Token(Token = "0x6000243")]
  [Address(RVA = "0x35D7E0", Offset = "0x35C3E0", Length = "0x48")]
  protected override void Init()
  {
  }

  [Token(Token = "0x6000244")]
  [Address(RVA = "0x3579E0", Offset = "0x3565E0", Length = "0x3B")]
  protected override void OnWeaponStatUpdate(EStat stat, EWeapon weapon)
  {
  }

  [Token(Token = "0x6000245")]
  [Address(RVA = "0x35D830", Offset = "0x35C430", Length = "0x19")]
  protected override void OnStatUpdate(EStat stat)
  {
  }

  [Token(Token = "0x6000246")]
  [Address(RVA = "0x358360", Offset = "0x356F60", Length = "0x9")]
  public override float GetAuraRotationSpeed() => 0.0f;

  [Token(Token = "0x6000247")]
  [Address(RVA = "0x35DC00", Offset = "0x35C800", Length = "0xBD")]
  private void UpdateSize()
  {
  }

  [Token(Token = "0x6000248")]
  [Address(RVA = "0x35DCC0", Offset = "0x35C8C0", Length = "0x12D")]
  private void Update()
  {
  }

  [Token(Token = "0x6000249")]
  [Address(RVA = "0x35DB60", Offset = "0x35C760", Length = "0x94")]
  private void UpdateCooldown()
  {
  }

  [Token(Token = "0x600024A")]
  [Address(RVA = "0x35D850", Offset = "0x35C450", Length = "0x30A")]
  private void RefreshParticles()
  {
  }

  [Token(Token = "0x600024B")]
  [Address(RVA = "0x35D760", Offset = "0x35C360", Length = "0x7D")]
  private void InitParticles()
  {
  }

  [Token(Token = "0x600024C")]
  [Address(RVA = "0x35D730", Offset = "0x35C330", Length = "0x22")]
  private float GetFreezeTime() => 0.0f;

  [Token(Token = "0x600024D")]
  [Address(RVA = "0x35D1E0", Offset = "0x35BDE0", Length = "0x547")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x600024E")]
  [Address(RVA = "0x35DDF0", Offset = "0x35C9F0", Length = "0x15")]
  public IceAura()
  {
  }
}
