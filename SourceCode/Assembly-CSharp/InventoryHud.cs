// Decompiled with JetBrains decompiler
// Type: InventoryHud
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.Tomes;
using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x2000130")]
public class InventoryHud : MonoBehaviour
{
  [Token(Token = "0x40008F8")]
  [FieldOffset(Offset = "0x20")]
  public GameObject itemContainerPrefab;
  [Token(Token = "0x40008F9")]
  [FieldOffset(Offset = "0x28")]
  public Transform weaponParent;
  [Token(Token = "0x40008FA")]
  [FieldOffset(Offset = "0x30")]
  public Transform tomeParent;
  [Token(Token = "0x40008FB")]
  [FieldOffset(Offset = "0x38")]
  private List<InventoryItemPrefabUI> weaponContainers;
  [Token(Token = "0x40008FC")]
  [FieldOffset(Offset = "0x40")]
  private List<InventoryItemPrefabUI> tomeContainers;

  [Token(Token = "0x600079C")]
  [Address(RVA = "0x4BA200", Offset = "0x4B8E00", Length = "0x342")]
  private void Start()
  {
  }

  [Token(Token = "0x600079D")]
  [Address(RVA = "0x4B9840", Offset = "0x4B8440", Length = "0x338")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600079E")]
  [Address(RVA = "0x4B9B80", Offset = "0x4B8780", Length = "0x7")]
  private void OnInventoryInit(PlayerInventory obj)
  {
  }

  [Token(Token = "0x600079F")]
  [Address(RVA = "0x4B9B90", Offset = "0x4B8790", Length = "0x668")]
  public void Refresh()
  {
  }

  [Token(Token = "0x60007A0")]
  [Address(RVA = "0x4B9B80", Offset = "0x4B8780", Length = "0x7")]
  private void OnTomeAdded(ETome eTome, EStat obj)
  {
  }

  [Token(Token = "0x60007A1")]
  [Address(RVA = "0x4B9B80", Offset = "0x4B8780", Length = "0x7")]
  private void OnWeaponAdded(WeaponBase obj)
  {
  }

  [Token(Token = "0x60007A2")]
  [Address(RVA = "0x4BA550", Offset = "0x4B9150", Length = "0xA5")]
  public InventoryHud()
  {
  }
}
