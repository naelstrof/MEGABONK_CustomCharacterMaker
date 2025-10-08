// Decompiled with JetBrains decompiler
// Type: EnemySpecialAttackSpinningLasers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000063")]
public class EnemySpecialAttackSpinningLasers : EnemySpecialAttackPrefab
{
  [Token(Token = "0x400031D")]
  [FieldOffset(Offset = "0x50")]
  public Rigidbody rb;
  [Token(Token = "0x400031E")]
  [FieldOffset(Offset = "0x58")]
  public Transform disk;
  [Token(Token = "0x400031F")]
  [FieldOffset(Offset = "0x60")]
  public Transform laserParent;
  [Token(Token = "0x4000320")]
  [FieldOffset(Offset = "0x68")]
  private Transform[] lasers;
  [Token(Token = "0x4000321")]
  [FieldOffset(Offset = "0x70")]
  private float overAtTime;
  [Token(Token = "0x4000322")]
  [FieldOffset(Offset = "0x74")]
  private float startedAtTime;
  [Token(Token = "0x4000323")]
  [FieldOffset(Offset = "0x78")]
  private float laserLength;
  [Token(Token = "0x4000324")]
  [FieldOffset(Offset = "0x7C")]
  private float maxLaserLength;
  [Token(Token = "0x4000325")]
  [FieldOffset(Offset = "0x80")]
  private Vector3 defaultScale;
  [Token(Token = "0x4000326")]
  [FieldOffset(Offset = "0x8C")]
  private float defaultVolume;
  [Token(Token = "0x4000327")]
  [FieldOffset(Offset = "0x90")]
  public AudioSource audio;
  [Token(Token = "0x4000328")]
  [FieldOffset(Offset = "0x98")]
  private float audioFadeTime;
  [Token(Token = "0x4000329")]
  [FieldOffset(Offset = "0x9C")]
  private float damageCooldown;
  [Token(Token = "0x400032A")]
  [FieldOffset(Offset = "0xA0")]
  private float nextDamageReadyTime;
  [Token(Token = "0x400032B")]
  [FieldOffset(Offset = "0xA4")]
  public float defaultSpinSpeed;
  [Token(Token = "0x400032C")]
  [FieldOffset(Offset = "0xA8")]
  public float diskRotationSpeed;
  [Token(Token = "0x400032D")]
  [FieldOffset(Offset = "0xAC")]
  private float spinSpeed;
  [Token(Token = "0x400032E")]
  [FieldOffset(Offset = "0xB0")]
  private float spinAngle;
  [Token(Token = "0x400032F")]
  [FieldOffset(Offset = "0xB4")]
  private float spinPhaseOffset;

  [Token(Token = "0x6000287")]
  [Address(RVA = "0x460DA0", Offset = "0x45F9A0", Length = "0x1ED")]
  protected override void Init()
  {
  }

  [Token(Token = "0x6000288")]
  [Address(RVA = "0x461160", Offset = "0x45FD60", Length = "0x1A8")]
  private void OnceInit()
  {
  }

  [Token(Token = "0x6000289")]
  [Address(RVA = "0x460740", Offset = "0x45F340", Length = "0x650")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x600028A")]
  [Address(RVA = "0x460F90", Offset = "0x45FB90", Length = "0x1CD")]
  private void OnTriggerStay(Collider other)
  {
  }

  [Token(Token = "0x600028B")]
  [Address(RVA = "0x461310", Offset = "0x45FF10", Length = "0x793")]
  private void RotationStuff()
  {
  }

  [Token(Token = "0x600028C")]
  [Address(RVA = "0x461AB0", Offset = "0x4606B0", Length = "0x29")]
  public EnemySpecialAttackSpinningLasers()
  {
  }
}
