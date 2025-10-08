// Decompiled with JetBrains decompiler
// Type: LaserBeamAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Game.Combat.ConstantAttacks;
using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000B5")]
public class LaserBeamAttack : ConstantAttack
{
  [Token(Token = "0x40005C6")]
  [FieldOffset(Offset = "0x28")]
  public LineRenderer linerenderer;
  [Token(Token = "0x40005C7")]
  [FieldOffset(Offset = "0x30")]
  public GameObject laserStart;
  [Token(Token = "0x40005C8")]
  [FieldOffset(Offset = "0x38")]
  public GameObject laserEnd;
  [Token(Token = "0x40005C9")]
  [FieldOffset(Offset = "0x40")]
  private float radius;
  [Token(Token = "0x40005CA")]
  [FieldOffset(Offset = "0x44")]
  private Vector3 laserDir;
  [Token(Token = "0x40005CB")]
  [FieldOffset(Offset = "0x50")]
  private Enemy target;
  [Token(Token = "0x40005CC")]
  [FieldOffset(Offset = "0x58")]
  private float laserStopTime;
  [Token(Token = "0x40005CD")]
  [FieldOffset(Offset = "0x5C")]
  private float laserStartedAtTime;
  [Token(Token = "0x40005CE")]
  [FieldOffset(Offset = "0x60")]
  private float laserReadyTime;
  [Token(Token = "0x40005CF")]
  [FieldOffset(Offset = "0x64")]
  private bool isShooting;
  [Token(Token = "0x40005D0")]
  [FieldOffset(Offset = "0x68")]
  private Vector3 prevStart;
  [Token(Token = "0x40005D1")]
  [FieldOffset(Offset = "0x74")]
  private Vector3 prevEnd;
  [Token(Token = "0x40005D2")]
  [FieldOffset(Offset = "0x80")]
  private Vector3 center;
  [Token(Token = "0x40005D3")]
  [FieldOffset(Offset = "0x8C")]
  private Quaternion rotation;
  [Token(Token = "0x40005D4")]
  [FieldOffset(Offset = "0x9C")]
  private Vector3 halfExtents;
  [Token(Token = "0x40005D5")]
  [FieldOffset(Offset = "0xA8")]
  public AudioSource audioLoop;
  [Token(Token = "0x40005D6")]
  [FieldOffset(Offset = "0xB0")]
  public GameObject explosionFx;
  [Token(Token = "0x40005D7")]
  [FieldOffset(Offset = "0xB8")]
  private Dictionary<Collider, float> enemyHitCooldowns;
  [Token(Token = "0x40005D8")]
  [FieldOffset(Offset = "0xC0")]
  private float hitCooldown;
  [Header("Whip Effect")]
  [Token(Token = "0x40005D9")]
  [FieldOffset(Offset = "0xC4")]
  public int whipSegments;
  [Token(Token = "0x40005DA")]
  [FieldOffset(Offset = "0xC8")]
  public float whipAmplitude;
  [Token(Token = "0x40005DB")]
  [FieldOffset(Offset = "0xCC")]
  public float whipFrequency;
  [Token(Token = "0x40005DC")]
  [FieldOffset(Offset = "0xD0")]
  public float animateWhipTime;
  [Token(Token = "0x40005DD")]
  [FieldOffset(Offset = "0xD4")]
  private float whipAnimationTime;
  [Token(Token = "0x40005DE")]
  [FieldOffset(Offset = "0xD8")]
  private float laserRadius;

  [Token(Token = "0x6000488")]
  [Address(RVA = "0x47D520", Offset = "0x47C120", Length = "0x132")]
  private new void Awake()
  {
  }

  [Token(Token = "0x6000489")]
  [Address(RVA = "0x47E3A0", Offset = "0x47CFA0", Length = "0x132")]
  private new void OnDestroy()
  {
  }

  [Token(Token = "0x600048A")]
  [Address(RVA = "0x47E530", Offset = "0x47D130", Length = "0x7")]
  private void OnWeaponToggled(WeaponBase weaponBase)
  {
  }

  [Token(Token = "0x600048B")]
  [Address(RVA = "0x47E390", Offset = "0x47CF90", Length = "0x7")]
  protected override void Init()
  {
  }

  [Token(Token = "0x600048C")]
  [Address(RVA = "0x47F7C0", Offset = "0x47E3C0", Length = "0x75")]
  private void Update()
  {
  }

  [Token(Token = "0x600048D")]
  [Address(RVA = "0x47EFF0", Offset = "0x47DBF0", Length = "0x408")]
  private void StartLaser()
  {
  }

  [Token(Token = "0x600048E")]
  [Address(RVA = "0x47F400", Offset = "0x47E000", Length = "0x323")]
  private void StopLaser()
  {
  }

  [Token(Token = "0x600048F")]
  [Address(RVA = "0x47E5A0", Offset = "0x47D1A0", Length = "0xA4B")]
  private void RenderLaser()
  {
  }

  [Token(Token = "0x6000490")]
  [Address(RVA = "0x47DD60", Offset = "0x47C960", Length = "0x8F")]
  private Vector3 GetBeamStart() => new Vector3();

  [Token(Token = "0x6000491")]
  [Address(RVA = "0x47DC50", Offset = "0x47C850", Length = "0x107")]
  private Vector3 GetBeamEnd() => new Vector3();

  [Token(Token = "0x6000492")]
  [Address(RVA = "0x47D660", Offset = "0x47C260", Length = "0x11B")]
  private void FindTarget()
  {
  }

  [Token(Token = "0x6000493")]
  [Address(RVA = "0x47D780", Offset = "0x47C380", Length = "0x4CB")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000494")]
  [Address(RVA = "0x47E540", Offset = "0x47D140", Length = "0x5E")]
  private void ProcessHits(Collider[] colliders)
  {
  }

  [Token(Token = "0x6000495")]
  [Address(RVA = "0x47DEB0", Offset = "0x47CAB0", Length = "0x4D7")]
  private void HitEnemy(Collider collider)
  {
  }

  [Token(Token = "0x6000496")]
  [Address(RVA = "0x47F730", Offset = "0x47E330", Length = "0x8A")]
  private void UpdateSize()
  {
  }

  [Token(Token = "0x6000497")]
  [Address(RVA = "0x47DEA0", Offset = "0x47CAA0", Length = "0x9")]
  private float GetRadius() => 0.0f;

  [Token(Token = "0x6000498")]
  [Address(RVA = "0x3573F0", Offset = "0x355FF0", Length = "0x4")]
  public override float GetAuraRotationSpeed() => 0.0f;

  [Token(Token = "0x6000499")]
  [Address(RVA = "0x47DE50", Offset = "0x47CA50", Length = "0x4D")]
  private float GetDuration() => 0.0f;

  [Token(Token = "0x600049A")]
  [Address(RVA = "0x47DDF0", Offset = "0x47C9F0", Length = "0x56")]
  private float GetCooldown() => 0.0f;

  [Token(Token = "0x600049B")]
  [Address(RVA = "0x47E4F0", Offset = "0x47D0F0", Length = "0x3B")]
  protected override void OnWeaponStatUpdate(EStat stat, EWeapon weapon)
  {
  }

  [Token(Token = "0x600049C")]
  [Address(RVA = "0x47E4E0", Offset = "0x47D0E0", Length = "0xD")]
  protected override void OnStatUpdate(EStat stat)
  {
  }

  [Token(Token = "0x600049D")]
  [Address(RVA = "0x47F840", Offset = "0x47E440", Length = "0xC0")]
  public LaserBeamAttack()
  {
  }
}
