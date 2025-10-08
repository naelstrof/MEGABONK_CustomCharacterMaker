// Decompiled with JetBrains decompiler
// Type: ControllerGlyphs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Utility.Controllers;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x200020D")]
public class ControllerGlyphs : MonoBehaviour
{
  [Token(Token = "0x4000E6F")]
  [FieldOffset(Offset = "0x20")]
  public List<InputGlyph> xboxGlyphs;
  [Token(Token = "0x4000E70")]
  [FieldOffset(Offset = "0x28")]
  public List<InputGlyph> playstationGlyphs;
  [Token(Token = "0x4000E71")]
  [FieldOffset(Offset = "0x30")]
  public List<InputGlyph> pcGlyphs;
  [Token(Token = "0x4000E72")]
  [FieldOffset(Offset = "0x38")]
  public Dictionary<KeyCode, Texture> xboxGlyphsDict;
  [Token(Token = "0x4000E73")]
  [FieldOffset(Offset = "0x40")]
  public Dictionary<KeyCode, Texture> playstationGlyphsDict;
  [Token(Token = "0x4000E74")]
  [FieldOffset(Offset = "0x48")]
  public Dictionary<KeyCode, Texture> pcGlyphsDict;

  [Token(Token = "0x6000D6B")]
  [Address(RVA = "0x51F5A0", Offset = "0x51E1A0", Length = "0x2F0")]
  public void Init()
  {
  }

  [Token(Token = "0x6000D6C")]
  [Address(RVA = "0x51F470", Offset = "0x51E070", Length = "0x12D")]
  public Texture GetGlyph(EControllerType controller, KeyCode keycode) => (Texture) null;

  [Token(Token = "0x6000D6D")]
  [Address(RVA = "0x51F8A0", Offset = "0x51E4A0", Length = "0xD3")]
  public ControllerGlyphs()
  {
  }
}
