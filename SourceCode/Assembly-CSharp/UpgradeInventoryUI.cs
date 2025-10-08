// Decompiled with JetBrains decompiler
// Type: UpgradeInventoryUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x200015B")]
public class UpgradeInventoryUI : MonoBehaviour
{
  [Token(Token = "0x4000A34")]
  [FieldOffset(Offset = "0x20")]
  public GameObject itemContainerPrefab;
  [Token(Token = "0x4000A35")]
  [FieldOffset(Offset = "0x28")]
  public Transform weaponParent;
  [Token(Token = "0x4000A36")]
  [FieldOffset(Offset = "0x30")]
  public Transform tomeParent;
  [Token(Token = "0x4000A37")]
  [FieldOffset(Offset = "0x38")]
  public Transform itemParent;
  [Token(Token = "0x4000A38")]
  [FieldOffset(Offset = "0x40")]
  private List<InventoryItemPrefabUI> weaponContainers;
  [Token(Token = "0x4000A39")]
  [FieldOffset(Offset = "0x48")]
  private List<InventoryItemPrefabUI> tomeContainers;
  [Token(Token = "0x4000A3A")]
  [FieldOffset(Offset = "0x50")]
  private List<InventoryItemPrefabUI> itemContainers;

  [Token(Token = "0x60008C0")]
  [Address(RVA = "0x4E52E0", Offset = "0x4E3EE0", Length = "0x7")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60008C1")]
  [Address(RVA = "0x4E52F0", Offset = "0x4E3EF0", Length = "0x85D")]
  public void Refresh()
  {
  }

  [Token(Token = "0x60008C2")]
  [Address(RVA = "0x4E5B50", Offset = "0x4E4750", Length = "0xD3")]
  public UpgradeInventoryUI()
  {
  }
}
