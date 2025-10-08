// Decompiled with JetBrains decompiler
// Type: XpDamager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000AE")]
public class XpDamager : MonoBehaviour
{
  [Token(Token = "0x4000575")]
  [FieldOffset(Offset = "0x20")]
  public Pickup pickup;
  [Token(Token = "0x4000576")]
  [FieldOffset(Offset = "0x28")]
  private bool isEnabled;
  [Token(Token = "0x4000577")]
  [FieldOffset(Offset = "0x2C")]
  private float damage;
  [Token(Token = "0x4000578")]
  [FieldOffset(Offset = "0x30")]
  private float radius;
  [Token(Token = "0x4000579")]
  [FieldOffset(Offset = "0x34")]
  private Vector3 dir;
  [Token(Token = "0x400057A")]
  [FieldOffset(Offset = "0x40")]
  private Vector3 lastPos;
  [Token(Token = "0x400057B")]
  [FieldOffset(Offset = "0x50")]
  private Dictionary<Collider, float> enemyHitCooldowns;
  [Token(Token = "0x400057C")]
  [FieldOffset(Offset = "0x58")]
  private float hitCooldown;
  [Token(Token = "0x400057D")]
  [FieldOffset(Offset = "0x60")]
  private string damageSource;
  [Token(Token = "0x400057E")]
  [FieldOffset(Offset = "0x68")]
  private DamageContainer reuseDc;

  [Token(Token = "0x6000465")]
  [Address(RVA = "0x490FE0", Offset = "0x48FBE0", Length = "0x186")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000466")]
  [Address(RVA = "0x490A20", Offset = "0x48F620", Length = "0xFC")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000467")]
  [Address(RVA = "0x490EE0", Offset = "0x48FAE0", Length = "0xFC")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000468")]
  [Address(RVA = "0x491170", Offset = "0x48FD70", Length = "0x9E")]
  private void OnValueUpdated(int value)
  {
  }

  [Token(Token = "0x6000469")]
  [Address(RVA = "0x490B20", Offset = "0x48F720", Length = "0x18")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x600046A")]
  [Address(RVA = "0x491210", Offset = "0x48FE10", Length = "0x23C")]
  protected virtual void StepMovement()
  {
  }

  [Token(Token = "0x600046B")]
  [Address(RVA = "0x490B40", Offset = "0x48F740", Length = "0x399")]
  private void HitEnemy(Collider collider)
  {
  }

  [Token(Token = "0x600046C")]
  [Address(RVA = "0x491450", Offset = "0x490050", Length = "0x20F")]
  public XpDamager()
  {
  }
}
