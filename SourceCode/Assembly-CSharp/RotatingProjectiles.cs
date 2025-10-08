// Decompiled with JetBrains decompiler
// Type: RotatingProjectiles
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;
using Utility;

[Token(Token = "0x2000051")]
public class RotatingProjectiles : MonoBehaviour
{
  [Token(Token = "0x40002A1")]
  [FieldOffset(Offset = "0x20")]
  public GameObject prefab;
  [Token(Token = "0x40002A2")]
  [FieldOffset(Offset = "0x28")]
  public float baseProjectileRadius;
  [Token(Token = "0x40002A3")]
  [FieldOffset(Offset = "0x30")]
  public AudioSource audioSpawn;
  [Token(Token = "0x40002A4")]
  [FieldOffset(Offset = "0x38")]
  public AudioSource audioLoop;
  [Token(Token = "0x40002A5")]
  [FieldOffset(Offset = "0x40")]
  private float baseLoopVolume;
  [Token(Token = "0x40002A6")]
  [FieldOffset(Offset = "0x48")]
  private List<ParticleSystem> prefabs;
  [Token(Token = "0x40002A7")]
  [FieldOffset(Offset = "0x50")]
  private int amount;
  [Token(Token = "0x40002A8")]
  [FieldOffset(Offset = "0x54")]
  private float projectileRadius;
  [Token(Token = "0x40002A9")]
  [FieldOffset(Offset = "0x58")]
  private float rotationSpeed;
  [Token(Token = "0x40002AA")]
  private const int maxQuantity = 50;
  [Token(Token = "0x40002AB")]
  [FieldOffset(Offset = "0x5C")]
  private float maxRotationSpeed;
  [Token(Token = "0x40002AC")]
  [FieldOffset(Offset = "0x60")]
  private Vector3[] rockPositions;
  [Token(Token = "0x40002AD")]
  [FieldOffset(Offset = "0x68")]
  private List<RaycastUtility.ConeSphere> debugSpheres;
  [Token(Token = "0x40002AE")]
  [FieldOffset(Offset = "0x70")]
  private Dictionary<int, Dictionary<Collider, float>> projectileEnemiesCooldowns;
  [Token(Token = "0x40002AF")]
  [FieldOffset(Offset = "0x78")]
  private float enemyHitCooldown;
  [Token(Token = "0x40002B0")]
  [FieldOffset(Offset = "0x80")]
  public WeaponBase weaponBase;
  [Token(Token = "0x40002B1")]
  [FieldOffset(Offset = "0x88")]
  private float fadeTimer;
  [Token(Token = "0x40002B2")]
  [FieldOffset(Offset = "0x8C")]
  private float fadeTime;
  [Token(Token = "0x40002B3")]
  [FieldOffset(Offset = "0x90")]
  private bool isActive;
  [Token(Token = "0x40002B4")]
  [FieldOffset(Offset = "0x94")]
  private float startTime;
  [Token(Token = "0x40002B5")]
  [FieldOffset(Offset = "0x98")]
  private float endTime;
  [Token(Token = "0x40002B6")]
  [FieldOffset(Offset = "0x9C")]
  private float duration;
  [Token(Token = "0x40002B7")]
  [FieldOffset(Offset = "0xA0")]
  public float baseDistance;
  [Token(Token = "0x40002B8")]
  [FieldOffset(Offset = "0xA4")]
  private Vector3 defaultScale;
  [Token(Token = "0x40002B9")]
  [FieldOffset(Offset = "0xB0")]
  private Vector3 projectileScale;
  [Token(Token = "0x40002BA")]
  [FieldOffset(Offset = "0xBC")]
  private float scaleMultiplier;
  [Token(Token = "0x40002BB")]
  [FieldOffset(Offset = "0xC0")]
  private float distance;

  [Token(Token = "0x600022B")]
  [Address(RVA = "0x365D50", Offset = "0x364950", Length = "0x28")]
  public void SetWeapon(WeaponBase weaponBase)
  {
  }

  [Token(Token = "0x600022C")]
  [Address(RVA = "0x3660D0", Offset = "0x364CD0", Length = "0x120")]
  private void TryInit()
  {
  }

  [Token(Token = "0x600022D")]
  [Address(RVA = "0x366200", Offset = "0x364E00", Length = "0x52F")]
  private void Update()
  {
  }

  [Token(Token = "0x600022E")]
  [Address(RVA = "0x3654E0", Offset = "0x3640E0", Length = "0x1F")]
  private bool CanHitbox() => false;

  [Token(Token = "0x600022F")]
  [Address(RVA = "0x365500", Offset = "0x364100", Length = "0x7")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000230")]
  [Address(RVA = "0x365E30", Offset = "0x364A30", Length = "0x298")]
  private void StepHitboxes()
  {
  }

  [Token(Token = "0x6000231")]
  [Address(RVA = "0x365530", Offset = "0x364130", Length = "0x552")]
  private bool HitEnemy(int projectileIndex, Collider collider) => false;

  [Token(Token = "0x6000232")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void OnDrawGizmos()
  {
  }

  [Token(Token = "0x6000233")]
  [Address(RVA = "0x365D80", Offset = "0x364980", Length = "0xA4")]
  public void Show()
  {
  }

  [Token(Token = "0x6000234")]
  [Address(RVA = "0x365510", Offset = "0x364110", Length = "0x12")]
  public void Hide()
  {
  }

  [Token(Token = "0x6000235")]
  [Address(RVA = "0x365A90", Offset = "0x364690", Length = "0x1F7")]
  public void SetAmount(int newAmount)
  {
  }

  [Token(Token = "0x6000236")]
  [Address(RVA = "0x365CA0", Offset = "0x3648A0", Length = "0x90")]
  public void SetSize(float multiplier)
  {
  }

  [Token(Token = "0x6000237")]
  [Address(RVA = "0x365D30", Offset = "0x364930", Length = "0x1E")]
  public void SetSpeed(float speed)
  {
  }

  [Token(Token = "0x6000238")]
  [Address(RVA = "0x365C90", Offset = "0x364890", Length = "0x9")]
  public void SetDuration(float duration)
  {
  }

  [Token(Token = "0x6000239")]
  [Address(RVA = "0x366730", Offset = "0x365330", Length = "0x124")]
  public RotatingProjectiles()
  {
  }
}
