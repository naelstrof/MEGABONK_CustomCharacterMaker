// Decompiled with JetBrains decompiler
// Type: ItemsHud
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Items;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x2000131")]
public class ItemsHud : MonoBehaviour
{
  [Token(Token = "0x40008FD")]
  [FieldOffset(Offset = "0x20")]
  public GameObject prefab;
  [Token(Token = "0x40008FE")]
  [FieldOffset(Offset = "0x28")]
  private Dictionary<EItem, ItemsHudElementPrefab> itemToPrefab;

  [Token(Token = "0x60007A3")]
  [Address(RVA = "0x4BAD80", Offset = "0x4B9980", Length = "0x3D9")]
  private void Start()
  {
  }

  [Token(Token = "0x60007A4")]
  [Address(RVA = "0x4BA700", Offset = "0x4B9300", Length = "0x229")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60007A5")]
  [Address(RVA = "0x4BA930", Offset = "0x4B9530", Length = "0x252")]
  private void OnItemAdded(EItem item)
  {
  }

  [Token(Token = "0x60007A6")]
  [Address(RVA = "0x4BAB90", Offset = "0x4B9790", Length = "0x1E6")]
  private void OnItemRemoved(EItem item, bool showEffect)
  {
  }

  [Token(Token = "0x60007A7")]
  [Address(RVA = "0x4BB160", Offset = "0x4B9D60", Length = "0x77")]
  public ItemsHud()
  {
  }
}
