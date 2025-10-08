// Decompiled with JetBrains decompiler
// Type: KeyDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
[Token(Token = "0x20001D2")]
public class KeyDisplay : MonoBehaviour
{
  [Token(Token = "0x4000D13")]
  [FieldOffset(Offset = "0x20")]
  public RawImage background;
  [Token(Token = "0x4000D14")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI text;
  [Token(Token = "0x4000D15")]
  [FieldOffset(Offset = "0x30")]
  public TextSizer textSizer;
  [Token(Token = "0x4000D16")]
  [FieldOffset(Offset = "0x38")]
  public RawImage glyph;
  [Token(Token = "0x4000D17")]
  private static Dictionary<KeyCode, string> buttonMappings;

  [Token(Token = "0x6000BEE")]
  [Address(RVA = "0x509BA0", Offset = "0x5087A0", Length = "0x108")]
  public void SetKey(KeyCode key)
  {
  }

  [Token(Token = "0x6000BEF")]
  [Address(RVA = "0x509B00", Offset = "0x508700", Length = "0x99")]
  private void SetGlyph(Texture glyphTexture)
  {
  }

  [Token(Token = "0x6000BF0")]
  [Address(RVA = "0x509CB0", Offset = "0x5088B0", Length = "0x303")]
  private void SetNonGlyph(KeyCode keycode)
  {
  }

  [Token(Token = "0x6000BF1")]
  [Address(RVA = "0x509A90", Offset = "0x508690", Length = "0x61")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000BF2")]
  [Address(RVA = "0x5098E0", Offset = "0x5084E0", Length = "0x1A0")]
  public static string GetKeyName(KeyCode key) => (string) null;

  [Token(Token = "0x6000BF3")]
  [Address(RVA = "0x5097D0", Offset = "0x5083D0", Length = "0x106")]
  public static string GetControllerButtonName(KeyCode keycode) => (string) null;

  [Token(Token = "0x6000BF4")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public KeyDisplay()
  {
  }

  [Token(Token = "0x6000BF5")]
  [Address(RVA = "0x509FC0", Offset = "0x508BC0", Length = "0x276")]
  static KeyDisplay()
  {
  }
}
