// Decompiled with JetBrains decompiler
// Type: BossOrb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200004A")]
public class BossOrb : MonoBehaviour
{
  [Token(Token = "0x4000254")]
  [FieldOffset(Offset = "0x20")]
  public Rigidbody rb;
  [Token(Token = "0x4000255")]
  [FieldOffset(Offset = "0x28")]
  public SphereCollider collider;
  [Token(Token = "0x4000256")]
  [FieldOffset(Offset = "0x30")]
  public GameObject explosion;
  [Token(Token = "0x4000257")]
  [FieldOffset(Offset = "0x38")]
  public GameObject trail;
  [Token(Token = "0x4000258")]
  [FieldOffset(Offset = "0x40")]
  public RandomSfx randomSfx;
  [Token(Token = "0x4000259")]
  [FieldOffset(Offset = "0x48")]
  private Vector3 offset;
  [Token(Token = "0x400025A")]
  [FieldOffset(Offset = "0x58")]
  private Enemy boss;
  [Token(Token = "0x400025B")]
  [FieldOffset(Offset = "0x60")]
  private int iterationsBeforeExplode;
  [Token(Token = "0x400025C")]
  [FieldOffset(Offset = "0x64")]
  private float overshootDistance;
  [Token(Token = "0x400025D")]
  [FieldOffset(Offset = "0x68")]
  private float moveInterval;
  [Token(Token = "0x400025E")]
  [FieldOffset(Offset = "0x6C")]
  private float nextMoveTime;
  [Token(Token = "0x400025F")]
  [FieldOffset(Offset = "0x70")]
  private float moveTimer;
  [Token(Token = "0x4000260")]
  [FieldOffset(Offset = "0x74")]
  private float moveOverSeconds;
  [Token(Token = "0x4000261")]
  [FieldOffset(Offset = "0x78")]
  private float maxMoveDistance;
  [Token(Token = "0x4000262")]
  [FieldOffset(Offset = "0x7C")]
  private Vector3 fromPosition;
  [Token(Token = "0x4000263")]
  [FieldOffset(Offset = "0x88")]
  private Vector3 toPosition;
  [Token(Token = "0x4000264")]
  [FieldOffset(Offset = "0x94")]
  private bool isFired;
  [Token(Token = "0x4000265")]
  [FieldOffset(Offset = "0x98")]
  public float spinSpeed;
  [Token(Token = "0x4000266")]
  [FieldOffset(Offset = "0x9C")]
  private float currentAngle;
  [Token(Token = "0x4000267")]
  [FieldOffset(Offset = "0xA0")]
  private float moveDist;
  [Token(Token = "0x4000268")]
  [FieldOffset(Offset = "0xA4")]
  private Vector3 moveDirection;
  [Token(Token = "0x4000269")]
  [FieldOffset(Offset = "0xB0")]
  private float moveSpeed;
  [Token(Token = "0x400026A")]
  [FieldOffset(Offset = "0xB4")]
  private int numMoves;

  [Token(Token = "0x60001F4")]
  [Address(RVA = "0x353810", Offset = "0x352410", Length = "0x2F")]
  protected void Start()
  {
  }

  [Token(Token = "0x60001F5")]
  [Address(RVA = "0x354F90", Offset = "0x353B90", Length = "0x293")]
  public void Set(
    float startDelay,
    int currentPhase,
    Enemy ignoreCollisionEnemy,
    int numOrbs,
    int orbIndex)
  {
  }

  [Token(Token = "0x60001F6")]
  [Address(RVA = "0x3548C0", Offset = "0x3534C0", Length = "0xBA")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x60001F7")]
  [Address(RVA = "0x355920", Offset = "0x354520", Length = "0x75")]
  private void Update()
  {
  }

  [Token(Token = "0x60001F8")]
  [Address(RVA = "0x354980", Offset = "0x353580", Length = "0x291")]
  private void FloatMovement()
  {
  }

  [Token(Token = "0x60001F9")]
  [Address(RVA = "0x355530", Offset = "0x354130", Length = "0x3E3")]
  private void UpdateMoving()
  {
  }

  [Token(Token = "0x60001FA")]
  [Address(RVA = "0x355230", Offset = "0x353E30", Length = "0x2F5")]
  private void StartMoving()
  {
  }

  [Token(Token = "0x60001FB")]
  [Address(RVA = "0x354CA0", Offset = "0x3538A0", Length = "0x2E7")]
  private void OnCollisionEnter(Collision collision)
  {
  }

  [Token(Token = "0x60001FC")]
  [Address(RVA = "0x354800", Offset = "0x353400", Length = "0xB8")]
  private void Explode()
  {
  }

  [Token(Token = "0x60001FD")]
  [Address(RVA = "0x354C20", Offset = "0x353820", Length = "0x79")]
  private float GetDamage() => 0.0f;

  [Token(Token = "0x60001FE")]
  [Address(RVA = "0x3559A0", Offset = "0x3545A0", Length = "0x34")]
  public BossOrb()
  {
  }
}
