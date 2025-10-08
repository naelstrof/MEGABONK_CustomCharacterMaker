// Decompiled with JetBrains decompiler
// Type: BossOrbBleed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200004B")]
public class BossOrbBleed : MonoBehaviour
{
  [Token(Token = "0x400026B")]
  [FieldOffset(Offset = "0x20")]
  public Rigidbody rb;
  [Token(Token = "0x400026C")]
  [FieldOffset(Offset = "0x28")]
  public SphereCollider collider;
  [Token(Token = "0x400026D")]
  [FieldOffset(Offset = "0x30")]
  public GameObject explosion;
  [Token(Token = "0x400026E")]
  [FieldOffset(Offset = "0x38")]
  public GameObject trail;
  [Token(Token = "0x400026F")]
  [FieldOffset(Offset = "0x40")]
  public RandomSfx randomSfx;
  [Token(Token = "0x4000270")]
  [FieldOffset(Offset = "0x48")]
  private Enemy boss;
  [Token(Token = "0x4000271")]
  [FieldOffset(Offset = "0x50")]
  private float acceleration;
  [Token(Token = "0x4000272")]
  [FieldOffset(Offset = "0x54")]
  private bool isFired;
  [Token(Token = "0x4000273")]
  [FieldOffset(Offset = "0x58")]
  private float speed;
  [Token(Token = "0x4000274")]
  [FieldOffset(Offset = "0x5C")]
  private float moveAtTime;
  [Token(Token = "0x4000275")]
  [FieldOffset(Offset = "0x60")]
  private float destroyAtTime;
  [Token(Token = "0x4000276")]
  [FieldOffset(Offset = "0x64")]
  private Vector3 offset;
  [Token(Token = "0x4000277")]
  [FieldOffset(Offset = "0x70")]
  private Vector3 velocity;
  [Token(Token = "0x4000278")]
  [FieldOffset(Offset = "0x7C")]
  private float moveTimer;
  [Token(Token = "0x4000279")]
  [FieldOffset(Offset = "0x80")]
  private float moveOverSeconds;
  [Token(Token = "0x400027A")]
  [FieldOffset(Offset = "0x84")]
  public float spinSpeed;
  [Token(Token = "0x400027B")]
  [FieldOffset(Offset = "0x88")]
  private float currentAngle;

  [Token(Token = "0x60001FF")]
  [Address(RVA = "0x353810", Offset = "0x352410", Length = "0x2F")]
  protected void Start()
  {
  }

  [Token(Token = "0x6000200")]
  [Address(RVA = "0x3535B0", Offset = "0x3521B0", Length = "0x204")]
  public void Set(Enemy boss, int currentPhase, int numOrbs, int orbIndex)
  {
  }

  [Token(Token = "0x6000201")]
  [Address(RVA = "0x3529C0", Offset = "0x3515C0", Length = "0x29F")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000202")]
  [Address(RVA = "0x353840", Offset = "0x352440", Length = "0xC8")]
  private void Update()
  {
  }

  [Token(Token = "0x6000203")]
  [Address(RVA = "0x3537C0", Offset = "0x3523C0", Length = "0x4C")]
  private void ShootOrb()
  {
  }

  [Token(Token = "0x6000204")]
  [Address(RVA = "0x352F80", Offset = "0x351B80", Length = "0x1F1")]
  private void Movement()
  {
  }

  [Token(Token = "0x6000205")]
  [Address(RVA = "0x352C60", Offset = "0x351860", Length = "0x294")]
  private void FloatMovement()
  {
  }

  [Token(Token = "0x6000206")]
  [Address(RVA = "0x353180", Offset = "0x351D80", Length = "0x428")]
  private void OnCollisionEnter(Collision collision)
  {
  }

  [Token(Token = "0x6000207")]
  [Address(RVA = "0x352900", Offset = "0x351500", Length = "0xB8")]
  private void Explode()
  {
  }

  [Token(Token = "0x6000208")]
  [Address(RVA = "0x352F00", Offset = "0x351B00", Length = "0x79")]
  private float GetDamage() => 0.0f;

  [Token(Token = "0x6000209")]
  [Address(RVA = "0x353910", Offset = "0x352510", Length = "0x29")]
  public BossOrbBleed()
  {
  }
}
