// Decompiled with JetBrains decompiler
// Type: BossOrbShooty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200004C")]
public class BossOrbShooty : MonoBehaviour
{
  [Token(Token = "0x400027C")]
  [FieldOffset(Offset = "0x20")]
  public Rigidbody rb;
  [Token(Token = "0x400027D")]
  [FieldOffset(Offset = "0x28")]
  public SphereCollider collider;
  [Token(Token = "0x400027E")]
  [FieldOffset(Offset = "0x30")]
  public GameObject explosion;
  [Token(Token = "0x400027F")]
  [FieldOffset(Offset = "0x38")]
  public GameObject trail;
  [Token(Token = "0x4000280")]
  [FieldOffset(Offset = "0x40")]
  public RandomSfx randomSfx;
  [Token(Token = "0x4000281")]
  [FieldOffset(Offset = "0x48")]
  private Enemy boss;
  [Token(Token = "0x4000282")]
  [FieldOffset(Offset = "0x50")]
  private bool isFired;
  [Token(Token = "0x4000283")]
  [FieldOffset(Offset = "0x54")]
  private float speed;
  [Token(Token = "0x4000284")]
  [FieldOffset(Offset = "0x58")]
  private float moveAtTime;
  [Token(Token = "0x4000285")]
  [FieldOffset(Offset = "0x5C")]
  private float destroyAtTime;
  [Token(Token = "0x4000286")]
  [FieldOffset(Offset = "0x60")]
  private Vector3 offset;
  [Token(Token = "0x4000287")]
  [FieldOffset(Offset = "0x6C")]
  private float moveTimer;
  [Token(Token = "0x4000288")]
  [FieldOffset(Offset = "0x70")]
  private float moveOverSeconds;
  [Token(Token = "0x4000289")]
  [FieldOffset(Offset = "0x74")]
  public float spinSpeed;
  [Token(Token = "0x400028A")]
  [FieldOffset(Offset = "0x78")]
  private float currentAngle;

  [Token(Token = "0x600020A")]
  [Address(RVA = "0x353810", Offset = "0x352410", Length = "0x2F")]
  protected void Start()
  {
  }

  [Token(Token = "0x600020B")]
  [Address(RVA = "0x354160", Offset = "0x352D60", Length = "0x1F5")]
  public void Set(Enemy boss, int currentPhase, int numOrbs, int orbIndex)
  {
  }

  [Token(Token = "0x600020C")]
  [Address(RVA = "0x353940", Offset = "0x352540", Length = "0x7B")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x600020D")]
  [Address(RVA = "0x3546D0", Offset = "0x3532D0", Length = "0x109")]
  private void Update()
  {
  }

  [Token(Token = "0x600020E")]
  [Address(RVA = "0x354360", Offset = "0x352F60", Length = "0x368")]
  private void ShootOrb()
  {
  }

  [Token(Token = "0x600020F")]
  [Address(RVA = "0x3539C0", Offset = "0x3525C0", Length = "0x288")]
  private void FloatMovement()
  {
  }

  [Token(Token = "0x6000210")]
  [Address(RVA = "0x353CD0", Offset = "0x3528D0", Length = "0x480")]
  private void OnCollisionEnter(Collision collision)
  {
  }

  [Token(Token = "0x6000211")]
  [Address(RVA = "0x353C50", Offset = "0x352850", Length = "0x79")]
  private float GetDamage() => 0.0f;

  [Token(Token = "0x6000212")]
  [Address(RVA = "0x3547E0", Offset = "0x3533E0", Length = "0x1C")]
  public BossOrbShooty()
  {
  }
}
