// Decompiled with JetBrains decompiler
// Type: AuraAttacks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Combat.ConstantAttacks;
using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x2000011")]
public class AuraAttacks : MonoBehaviour
{
  [Token(Token = "0x4000040")]
  [FieldOffset(Offset = "0x20")]
  private Dictionary<EWeapon, ConstantAttack> auras;
  [Token(Token = "0x4000041")]
  [FieldOffset(Offset = "0x28")]
  public AegisAttack aegisAttack;

  [Token(Token = "0x6000038")]
  [Address(RVA = "0x33ABD0", Offset = "0x3397D0", Length = "0x410")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000039")]
  [Address(RVA = "0x33AFF0", Offset = "0x339BF0", Length = "0x410")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600003A")]
  [Address(RVA = "0x33B410", Offset = "0x33A010", Length = "0x7")]
  private void OnInventoryInitialized(PlayerInventory inventory)
  {
  }

  [Token(Token = "0x600003B")]
  [Address(RVA = "0x33BBE0", Offset = "0x33A7E0", Length = "0x36")]
  private void Start()
  {
  }

  [Token(Token = "0x600003C")]
  [Address(RVA = "0x33B9C0", Offset = "0x33A5C0", Length = "0x219")]
  private void Refresh()
  {
  }

  [Token(Token = "0x600003D")]
  [Address(RVA = "0x33B420", Offset = "0x33A020", Length = "0x330")]
  private void OnWeaponAdded(WeaponBase weaponBase)
  {
  }

  [Token(Token = "0x600003E")]
  [Address(RVA = "0x33B760", Offset = "0x33A360", Length = "0x113")]
  private void OnWeaponRemoved(WeaponBase weaponBase)
  {
  }

  [Token(Token = "0x600003F")]
  [Address(RVA = "0x33B880", Offset = "0x33A480", Length = "0x13B")]
  private void OnWeaponToggle(WeaponBase weaponBase)
  {
  }

  [Token(Token = "0x6000040")]
  [Address(RVA = "0x33BC20", Offset = "0x33A820", Length = "0x307")]
  private void Update()
  {
  }

  [Token(Token = "0x6000041")]
  [Address(RVA = "0x33BF30", Offset = "0x33AB30", Length = "0x77")]
  public AuraAttacks()
  {
  }
}
