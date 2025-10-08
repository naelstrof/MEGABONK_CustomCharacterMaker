// Decompiled with JetBrains decompiler
// Type: HoverHighlight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001A3")]
public class HoverHighlight : MonoBehaviour
{
  [Token(Token = "0x4000BDE")]
  [FieldOffset(Offset = "0x20")]
  public Color defaultColor;
  [Token(Token = "0x4000BDF")]
  [FieldOffset(Offset = "0x30")]
  public Color highlightColor;
  [Token(Token = "0x4000BE0")]
  [FieldOffset(Offset = "0x40")]
  private MaskableGraphic graphic;
  [Token(Token = "0x4000BE1")]
  [FieldOffset(Offset = "0x48")]
  private RectTransform rectTransform;
  [Token(Token = "0x4000BE2")]
  [FieldOffset(Offset = "0x50")]
  private bool mouseOver;

  [Token(Token = "0x6000A94")]
  [Address(RVA = "0x4EDC20", Offset = "0x4EC820", Length = "0x7F")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000A95")]
  [Address(RVA = "0x4EDCA0", Offset = "0x4EC8A0", Length = "0x117")]
  private void Update()
  {
  }

  [Token(Token = "0x6000A96")]
  [Address(RVA = "0x4EDCA0", Offset = "0x4EC8A0", Length = "0x117")]
  private void CustomPointerHandler()
  {
  }

  [Token(Token = "0x6000A97")]
  [Address(RVA = "0x4EDDC0", Offset = "0x4EC9C0", Length = "0x3C")]
  private void OnPointerEnter()
  {
  }

  [Token(Token = "0x6000A98")]
  [Address(RVA = "0x4EDE00", Offset = "0x4ECA00", Length = "0x3C")]
  private void OnPointerExit()
  {
  }

  [Token(Token = "0x6000A99")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public HoverHighlight()
  {
  }
}
