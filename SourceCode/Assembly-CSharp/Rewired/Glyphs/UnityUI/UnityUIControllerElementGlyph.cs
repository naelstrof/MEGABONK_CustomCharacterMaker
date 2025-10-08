// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.UnityUI.UnityUIControllerElementGlyph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Glyphs.UnityUI
{
  [AddComponentMenu("Rewired/Glyphs/Unity UI/Unity UI Controller Element Glyph")]
  [Token(Token = "0x2000288")]
  public class UnityUIControllerElementGlyph : ControllerElementGlyph
  {
    [Token(Token = "0x60012EA")]
    [Address(RVA = "0x37C660", Offset = "0x37B260", Length = "0x7")]
    protected override GameObject GetDefaultGlyphOrTextPrefab() => (GameObject) null;

    [Token(Token = "0x60012EB")]
    [Address(RVA = "0x36CC70", Offset = "0x36B870", Length = "0x7")]
    public UnityUIControllerElementGlyph()
    {
    }
  }
}
