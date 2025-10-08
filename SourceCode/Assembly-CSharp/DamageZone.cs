// Decompiled with JetBrains decompiler
// Type: DamageZone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000056")]
public class DamageZone : MonoBehaviour
{
  [Token(Token = "0x40002E1")]
  [FieldOffset(Offset = "0x20")]
  private WeaponBase weaponBase;
  [Token(Token = "0x40002E2")]
  [FieldOffset(Offset = "0x28")]
  public float cooldown;
  [Token(Token = "0x40002E3")]
  [FieldOffset(Offset = "0x30")]
  public TrailRenderer trailRenderer;
  [Token(Token = "0x40002E4")]
  [FieldOffset(Offset = "0x38")]
  public float defaultRadius;
  [Token(Token = "0x40002E5")]
  [FieldOffset(Offset = "0x3C")]
  private float radius;
  [Token(Token = "0x40002E6")]
  [FieldOffset(Offset = "0x40")]
  private float nextCheckDamageTime;

  [Token(Token = "0x6000255")]
  [Address(RVA = "0x359F90", Offset = "0x358B90", Length = "0x165")]
  public void Set(WeaponBase weaponBase)
  {
  }

  [Token(Token = "0x6000256")]
  [Address(RVA = "0x35A100", Offset = "0x358D00", Length = "0x158")]
  private void UpdateSize()
  {
  }

  [Token(Token = "0x6000257")]
  [Address(RVA = "0x359A50", Offset = "0x358650", Length = "0x4C7")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000258")]
  [Address(RVA = "0x359F20", Offset = "0x358B20", Length = "0x60")]
  private void OnDrawGizmosSelected()
  {
  }

  [Token(Token = "0x6000259")]
  [Address(RVA = "0x35A260", Offset = "0x358E60", Length = "0x15")]
  public DamageZone()
  {
  }
}
