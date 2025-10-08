// Decompiled with JetBrains decompiler
// Type: ItemsHudElementPrefab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000132")]
public class ItemsHudElementPrefab : MonoBehaviour
{
  [Token(Token = "0x40008FF")]
  [FieldOffset(Offset = "0x20")]
  public RawImage icon;
  [Token(Token = "0x4000900")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_amount;

  [Token(Token = "0x60007A8")]
  [Address(RVA = "0x4BA6B0", Offset = "0x4B92B0", Length = "0x45")]
  public void Set(ItemData itemData)
  {
  }

  [Token(Token = "0x60007A9")]
  [Address(RVA = "0x4BA600", Offset = "0x4B9200", Length = "0xAB")]
  public void SetAmount(int amount)
  {
  }

  [Token(Token = "0x60007AA")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ItemsHudElementPrefab()
  {
  }
}
