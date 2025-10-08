// Decompiled with JetBrains decompiler
// Type: ShopWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001E4")]
public class ShopWindow : MonoBehaviour
{
  [Token(Token = "0x4000D89")]
  [FieldOffset(Offset = "0x20")]
  public GameObject shopContainerPrefab;
  [Token(Token = "0x4000D8A")]
  [FieldOffset(Offset = "0x28")]
  public Transform contentParent;
  [Token(Token = "0x4000D8B")]
  [FieldOffset(Offset = "0x30")]
  public TabGridNavigation navigation;
  [Token(Token = "0x4000D8C")]
  [FieldOffset(Offset = "0x38")]
  public Button btnBack;
  [Token(Token = "0x4000D8D")]
  [FieldOffset(Offset = "0x40")]
  public ShopFooter shopFooter;
  [Token(Token = "0x4000D8E")]
  [FieldOffset(Offset = "0x48")]
  public MyButtonNormal btnBuy;
  [Token(Token = "0x4000D8F")]
  [FieldOffset(Offset = "0x50")]
  public MyButtonNormal btnRefund;
  [Token(Token = "0x4000D90")]
  [FieldOffset(Offset = "0x58")]
  public TextMeshProUGUI t_buy;
  [Token(Token = "0x4000D91")]
  [FieldOffset(Offset = "0x60")]
  public TextMeshProUGUI t_refund;
  [Token(Token = "0x4000D93")]
  [FieldOffset(Offset = "0x70")]
  private List<ShopContainer> shopContainers;
  [Token(Token = "0x4000D94")]
  public static Action<ShopContainer> A_LevelChanged;

  [field: Token(Token = "0x4000D92")]
  [field: FieldOffset(Offset = "0x68")]
  [Token(Token = "0x17000077")]
  public ShopContainer currentContainer { [Token(Token = "0x6000C8B"), Address(RVA = "0x41E7E0", Offset = "0x41D3E0", Length = "0x5")] get; [Token(Token = "0x6000C8C"), Address(RVA = "0x517ED0", Offset = "0x516AD0", Length = "0xD")] private set; }

  [Token(Token = "0x6000C8D")]
  [Address(RVA = "0x516D30", Offset = "0x515930", Length = "0x216")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000C8E")]
  [Address(RVA = "0x5171E0", Offset = "0x515DE0", Length = "0x216")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000C8F")]
  [Address(RVA = "0x517A40", Offset = "0x516640", Length = "0x48C")]
  private void Start()
  {
  }

  [Token(Token = "0x6000C90")]
  [Address(RVA = "0x516F50", Offset = "0x515B50", Length = "0x28D")]
  public void Buy()
  {
  }

  [Token(Token = "0x6000C91")]
  [Address(RVA = "0x5177F0", Offset = "0x5163F0", Length = "0x24D")]
  public void Refund()
  {
  }

  [Token(Token = "0x6000C92")]
  [Address(RVA = "0x5175D0", Offset = "0x5161D0", Length = "0x21A")]
  private void RefreshPrices()
  {
  }

  [Token(Token = "0x6000C93")]
  [Address(RVA = "0x517400", Offset = "0x516000", Length = "0x142")]
  private void OnShopClicked(ShopContainer shopContainerClicked)
  {
  }

  [Token(Token = "0x6000C94")]
  [Address(RVA = "0x517550", Offset = "0x516150", Length = "0x7C")]
  public void OnShopSelect(ShopContainer shopContainerClicked)
  {
  }

  [Token(Token = "0x6000C95")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ShopWindow()
  {
  }
}
