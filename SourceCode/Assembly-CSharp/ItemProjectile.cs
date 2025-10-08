// Decompiled with JetBrains decompiler
// Type: ItemProjectile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Pool;

[Token(Token = "0x20000A5")]
public class ItemProjectile : MonoBehaviour
{
  [Token(Token = "0x400050F")]
  [FieldOffset(Offset = "0x20")]
  public bool ignoreGroundCollision;
  [Token(Token = "0x4000510")]
  [FieldOffset(Offset = "0x24")]
  public float projectileSpeed;
  [Token(Token = "0x4000511")]
  [FieldOffset(Offset = "0x28")]
  public float projectileRadius;
  [Token(Token = "0x4000512")]
  [FieldOffset(Offset = "0x2C")]
  private float damage;
  [Token(Token = "0x4000513")]
  [FieldOffset(Offset = "0x30")]
  protected float spawnedAtTime;
  [Token(Token = "0x4000514")]
  [FieldOffset(Offset = "0x34")]
  private float finalProjectileSpeed;
  [Token(Token = "0x4000515")]
  [FieldOffset(Offset = "0x38")]
  private float upTime;
  [Token(Token = "0x4000516")]
  [FieldOffset(Offset = "0x3C")]
  protected float expirationTime;
  [Token(Token = "0x4000517")]
  [FieldOffset(Offset = "0x40")]
  private string damageSource;
  [Token(Token = "0x4000518")]
  [FieldOffset(Offset = "0x48")]
  protected int projectileIndex;
  [Token(Token = "0x4000519")]
  [FieldOffset(Offset = "0x4C")]
  protected int projectilesCount;
  [Token(Token = "0x400051A")]
  [FieldOffset(Offset = "0x50")]
  private float range;
  [Token(Token = "0x400051B")]
  [FieldOffset(Offset = "0x54")]
  private Vector3 startDirection;
  [Token(Token = "0x400051C")]
  [FieldOffset(Offset = "0x60")]
  private Vector3 lastDirection;
  [Token(Token = "0x400051D")]
  [FieldOffset(Offset = "0x70")]
  private Enemy targetEnemy;
  [Token(Token = "0x400051E")]
  [FieldOffset(Offset = "0x78")]
  private Vector3 currentDir;
  [Token(Token = "0x400051F")]
  [FieldOffset(Offset = "0x84")]
  private float nextFindTime;
  [Token(Token = "0x4000520")]
  [FieldOffset(Offset = "0x88")]
  private float procCoefficient;
  [Token(Token = "0x4000521")]
  [FieldOffset(Offset = "0x90")]
  private DamageContainer reuseDc;
  [Token(Token = "0x4000522")]
  [FieldOffset(Offset = "0x98")]
  public ObjectPool<GameObject> projectilePool;
  [Token(Token = "0x4000523")]
  [FieldOffset(Offset = "0xA0")]
  public GameObject projectileHitEffect;

  [Token(Token = "0x6000416")]
  [Address(RVA = "0x47CDD0", Offset = "0x47B9D0", Length = "0x271")]
  public void Set(
    Vector3 pos,
    float damage,
    float procCoefficient,
    string damageSource,
    ObjectPool<GameObject> projectilePool,
    int projectileIndex,
    int totalProjectiles,
    float duration,
    float range)
  {
  }

  [Token(Token = "0x6000417")]
  [Address(RVA = "0x47BDE0", Offset = "0x47A9E0", Length = "0xB")]
  public void AddDamage(float damage)
  {
  }

  [Token(Token = "0x6000418")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected virtual void Init()
  {
  }

  [Token(Token = "0x6000419")]
  [Address(RVA = "0x47C630", Offset = "0x47B230", Length = "0xF5")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x600041A")]
  [Address(RVA = "0x47D460", Offset = "0x47C060", Length = "0x11")]
  protected virtual void Step()
  {
  }

  [Token(Token = "0x600041B")]
  [Address(RVA = "0x47C730", Offset = "0x47B330", Length = "0x32B")]
  protected virtual Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x600041C")]
  [Address(RVA = "0x47C2B0", Offset = "0x47AEB0", Length = "0x37D")]
  private void FindTarget()
  {
  }

  [Token(Token = "0x600041D")]
  [Address(RVA = "0x47D050", Offset = "0x47BC50", Length = "0x40E")]
  protected virtual void StepAttackMovement()
  {
  }

  [Token(Token = "0x600041E")]
  [Address(RVA = "0x47C0A0", Offset = "0x47ACA0", Length = "0x162")]
  protected virtual void CheckSpawnCollision()
  {
  }

  [Token(Token = "0x600041F")]
  [Address(RVA = "0x47BDF0", Offset = "0x47A9F0", Length = "0x2A9")]
  protected virtual bool CheckCollision(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x6000420")]
  [Address(RVA = "0x47CA60", Offset = "0x47B660", Length = "0x1D8")]
  private bool HitEnemy(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x6000421")]
  [Address(RVA = "0x47CC40", Offset = "0x47B840", Length = "0x11")]
  private void HitOther(Collider collider, Vector3 normal)
  {
  }

  [Token(Token = "0x6000422")]
  [Address(RVA = "0x47C210", Offset = "0x47AE10", Length = "0x97")]
  private void CheckTimeout()
  {
  }

  [Token(Token = "0x6000423")]
  [Address(RVA = "0x47CC60", Offset = "0x47B860", Length = "0x165")]
  protected virtual void ProjectileDone()
  {
  }

  [Token(Token = "0x6000424")]
  [Address(RVA = "0x47D480", Offset = "0x47C080", Length = "0x9D")]
  public ItemProjectile()
  {
  }
}
