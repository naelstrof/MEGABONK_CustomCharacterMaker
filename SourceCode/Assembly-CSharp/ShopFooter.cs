// Decompiled with JetBrains decompiler
// Type: ShopFooter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001E3")]
public class ShopFooter : MonoBehaviour
{
  [Token(Token = "0x4000D83")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_title;
  [Token(Token = "0x4000D84")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_description;
  [Token(Token = "0x4000D85")]
  [FieldOffset(Offset = "0x30")]
  public ShopContainer shopContainer;
  [Token(Token = "0x4000D86")]
  [FieldOffset(Offset = "0x38")]
  public RequirementsContainer requirementsContainer;
  [Token(Token = "0x4000D87")]
  [FieldOffset(Offset = "0x40")]
  public GameObject buy;
  [Token(Token = "0x4000D88")]
  [FieldOffset(Offset = "0x48")]
  public GameObject refund;

  [Token(Token = "0x6000C87")]
  [Address(RVA = "0x516AE0", Offset = "0x5156E0", Length = "0x248")]
  public void Set(ShopContainer shopContainerClicked)
  {
  }

  [Token(Token = "0x6000C88")]
  [Address(RVA = "0x516A20", Offset = "0x515620", Length = "0x44")]
  private void SetLocked(ShopItemData shopItem)
  {
  }

  [Token(Token = "0x6000C89")]
  [Address(RVA = "0x516A70", Offset = "0x515670", Length = "0x6B")]
  private void SetUnlocked(ShopItemData shopItem)
  {
  }

  [Token(Token = "0x6000C8A")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ShopFooter()
  {
  }
}
