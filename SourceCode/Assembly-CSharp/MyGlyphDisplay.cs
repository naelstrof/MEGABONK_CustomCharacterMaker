// Decompiled with JetBrains decompiler
// Type: MyGlyphDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001DF")]
public class MyGlyphDisplay : MonoBehaviour
{
  [Token(Token = "0x4000D72")]
  [FieldOffset(Offset = "0x20")]
  public Image i_glyph;
  [Token(Token = "0x4000D73")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_text;
  [Token(Token = "0x4000D74")]
  [FieldOffset(Offset = "0x30")]
  private RectTransform rectTransform;
  [Token(Token = "0x4000D75")]
  [FieldOffset(Offset = "0x38")]
  public GameObject hoverOverlay;
  [Token(Token = "0x4000D76")]
  [FieldOffset(Offset = "0x40")]
  public bool autoHeight;
  [Token(Token = "0x4000D77")]
  [FieldOffset(Offset = "0x41")]
  public bool autoWidth;
  [Token(Token = "0x4000D78")]
  [FieldOffset(Offset = "0x48")]
  private ActionElementMap elementMap;

  [Token(Token = "0x6000C6B")]
  [Address(RVA = "0x50CF70", Offset = "0x50BB70", Length = "0x1E")]
  public void Hover(bool isHovering)
  {
  }

  [Token(Token = "0x6000C6C")]
  [Address(RVA = "0x50D1B0", Offset = "0x50BDB0", Length = "0xCA")]
  public void SetAction(string action)
  {
  }

  [Token(Token = "0x6000C6D")]
  [Address(RVA = "0x50D280", Offset = "0x50BE80", Length = "0xEE")]
  public void Set(ActionElementMap elementMap)
  {
  }

  [Token(Token = "0x6000C6E")]
  [Address(RVA = "0x50CF90", Offset = "0x50BB90", Length = "0x21D")]
  private void RefreshGlyphSize()
  {
  }

  [Token(Token = "0x6000C6F")]
  [Address(RVA = "0x50D370", Offset = "0x50BF70", Length = "0xD")]
  public MyGlyphDisplay()
  {
  }
}
