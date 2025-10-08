// Decompiled with JetBrains decompiler
// Type: SkinContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x200018D")]
public class SkinContainer : MyButton, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
  [Token(Token = "0x4000B5C")]
  [FieldOffset(Offset = "0x58")]
  public RawImage skinIcon;
  [Token(Token = "0x4000B5D")]
  [FieldOffset(Offset = "0x60")]
  public GameObject locked;
  [Token(Token = "0x4000B5E")]
  [FieldOffset(Offset = "0x68")]
  public GameObject notSelectedOverlay;
  [Token(Token = "0x4000B5F")]
  [FieldOffset(Offset = "0x70")]
  public GameObject purchaseOverlay;
  [Token(Token = "0x4000B60")]
  [FieldOffset(Offset = "0x78")]
  public TextMeshProUGUI t_price;
  [Token(Token = "0x4000B61")]
  [FieldOffset(Offset = "0x80")]
  public SkinData skin;
  [Token(Token = "0x4000B62")]
  public static Action<SkinContainer> A_Hover;
  [Token(Token = "0x4000B63")]
  public static Action<SkinContainer> A_HoverMouse;
  [Token(Token = "0x4000B64")]
  public static Action<SkinContainer> A_HoverMouseExit;
  [Token(Token = "0x4000B65")]
  public static Action<SkinData> A_Purchased;

  [Token(Token = "0x6000A04")]
  [Address(RVA = "0x4FB730", Offset = "0x4FA330", Length = "0x1F7")]
  public void SetSkin(SkinData skin)
  {
  }

  [Token(Token = "0x6000A05")]
  [Address(RVA = "0x4FB6F0", Offset = "0x4FA2F0", Length = "0x39")]
  public void SetSelected(bool isSelected)
  {
  }

  [Token(Token = "0x6000A06")]
  [Address(RVA = "0x4FB930", Offset = "0x4FA530", Length = "0x78")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x6000A07")]
  [Address(RVA = "0x4FB1D0", Offset = "0x4F9DD0", Length = "0x1D")]
  private bool IsLocked() => false;

  [Token(Token = "0x6000A08")]
  [Address(RVA = "0x4FB1F0", Offset = "0x4F9DF0", Length = "0x56")]
  private bool NeedPurchase() => false;

  [Token(Token = "0x6000A09")]
  [Address(RVA = "0x4FB1B0", Offset = "0x4F9DB0", Length = "0x1D")]
  public ECharacter GetCharacter() => new ECharacter();

  [Token(Token = "0x6000A0A")]
  [Address(RVA = "0x4FB5B0", Offset = "0x4FA1B0", Length = "0x46")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x6000A0B")]
  [Address(RVA = "0x4FB5B0", Offset = "0x4FA1B0", Length = "0x46")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000A0C")]
  [Address(RVA = "0x4FB250", Offset = "0x4F9E50", Length = "0x354")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x6000A0D")]
  [Address(RVA = "0x4FB9B0", Offset = "0x4FA5B0", Length = "0xF9")]
  private void TooltipHoverEnter()
  {
  }

  [Token(Token = "0x6000A0E")]
  [Address(RVA = "0x4FB5B0", Offset = "0x4FA1B0", Length = "0x46")]
  private void TooltipHoverExit()
  {
  }

  [Token(Token = "0x6000A0F")]
  [Address(RVA = "0x4FB600", Offset = "0x4FA200", Length = "0x59")]
  public void OnPointerEnter(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000A10")]
  [Address(RVA = "0x4FB660", Offset = "0x4FA260", Length = "0x8D")]
  public void OnPointerExit(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000A11")]
  [Address(RVA = "0x4F0AE0", Offset = "0x4EF6E0", Length = "0x7")]
  public SkinContainer()
  {
  }
}
