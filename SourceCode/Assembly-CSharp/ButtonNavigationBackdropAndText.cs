// Decompiled with JetBrains decompiler
// Type: ButtonNavigationBackdropAndText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x20001C8")]
public class ButtonNavigationBackdropAndText : 
  MonoBehaviour,
  IButton,
  IPointerEnterHandler,
  IEventSystemHandler,
  IPointerExitHandler,
  IPointerClickHandler
{
  [Token(Token = "0x4000CE5")]
  [FieldOffset(Offset = "0x20")]
  public MaskableGraphic overlay;
  [Token(Token = "0x4000CE6")]
  [FieldOffset(Offset = "0x28")]
  public MaskableGraphic overlay_disabled;
  [Token(Token = "0x4000CE7")]
  [FieldOffset(Offset = "0x30")]
  public MaskableGraphic text;
  [Token(Token = "0x4000CE8")]
  [FieldOffset(Offset = "0x38")]
  public GameObject associatedContent;
  [Token(Token = "0x4000CE9")]
  [FieldOffset(Offset = "0x40")]
  public bool isTabSelectable;
  [Range(0.5f, 2f)]
  [Token(Token = "0x4000CEA")]
  [FieldOffset(Offset = "0x44")]
  public float overlayMultiplier;
  [Token(Token = "0x4000CEB")]
  [FieldOffset(Offset = "0x48")]
  private Vector3 desiredScale;
  [Token(Token = "0x4000CEC")]
  [FieldOffset(Offset = "0x54")]
  private Color textDefaultColor;
  [Token(Token = "0x4000CED")]
  [FieldOffset(Offset = "0x64")]
  private Color textSelectedColor;
  [Token(Token = "0x4000CEE")]
  [FieldOffset(Offset = "0x74")]
  private Color c_overlayDefault;
  [Token(Token = "0x4000CEF")]
  [FieldOffset(Offset = "0x84")]
  private Color c_overlayHover;
  [Token(Token = "0x4000CF0")]
  [FieldOffset(Offset = "0x94")]
  private Color c_overlaySelected;
  [Token(Token = "0x4000CF1")]
  [FieldOffset(Offset = "0xA4")]
  private bool selected;
  [Token(Token = "0x4000CF2")]
  [FieldOffset(Offset = "0xA8")]
  private Button button;

  [Token(Token = "0x6000B94")]
  [Address(RVA = "0x5019A0", Offset = "0x5005A0", Length = "0x124")]
  public void Select()
  {
  }

  [Token(Token = "0x6000B95")]
  [Address(RVA = "0x501460", Offset = "0x500060", Length = "0x1A2")]
  public void Deselect(IButton newButton)
  {
  }

  [Token(Token = "0x6000B96")]
  [Address(RVA = "0x501750", Offset = "0x500350", Length = "0x99")]
  public Button GetButton() => (Button) null;

  [Token(Token = "0x6000B97")]
  [Address(RVA = "0x3967A0", Offset = "0x3953A0", Length = "0x5")]
  public GameObject GetAssociatedContent() => (GameObject) null;

  [Token(Token = "0x6000B98")]
  [Address(RVA = "0x3FC020", Offset = "0x3FAC20", Length = "0x5")]
  public bool IsTabSelectable() => false;

  [Token(Token = "0x6000B99")]
  [Address(RVA = "0x501820", Offset = "0x500420", Length = "0xF1")]
  public void OnPointerEnter(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000B9A")]
  [Address(RVA = "0x501920", Offset = "0x500520", Length = "0x7E")]
  public void OnPointerExit(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000B9B")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public void OnPointerClick(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000B9C")]
  [Address(RVA = "0x501AD0", Offset = "0x5006D0", Length = "0x119")]
  private void Update()
  {
  }

  [Token(Token = "0x6000B9D")]
  [Address(RVA = "0x5016B0", Offset = "0x5002B0", Length = "0x95")]
  public void Enable()
  {
  }

  [Token(Token = "0x6000B9E")]
  [Address(RVA = "0x501610", Offset = "0x500210", Length = "0x95")]
  public void Disable()
  {
  }

  [Token(Token = "0x6000B9F")]
  [Address(RVA = "0x5017F0", Offset = "0x5003F0", Length = "0x21")]
  public bool IsEnabled() => false;

  [Token(Token = "0x6000BA0")]
  [Address(RVA = "0x501BF0", Offset = "0x5007F0", Length = "0x96")]
  public ButtonNavigationBackdropAndText()
  {
  }
}
