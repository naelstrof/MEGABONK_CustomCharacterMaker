// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.UnityUI.UnityUIGlyphOrText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Glyphs.UnityUI
{
  [Token(Token = "0x200028C")]
  public class UnityUIGlyphOrText : GlyphOrTextBase<Image, Sprite, Text>
  {
    [Token(Token = "0x170002FD")]
    protected override string textString
    {
      [Token(Token = "0x60012F8"), Address(RVA = "0x37CFF0", Offset = "0x37BBF0", Length = "0xA7")] get => (string) null;
      [Token(Token = "0x60012F9"), Address(RVA = "0x37D140", Offset = "0x37BD40", Length = "0x98")] set
      {
      }
    }

    [Token(Token = "0x170002FE")]
    protected override Sprite glyphGraphic
    {
      [Token(Token = "0x60012FA"), Address(RVA = "0x37CF60", Offset = "0x37BB60", Length = "0x8C")] get => (Sprite) null;
      [Token(Token = "0x60012FB"), Address(RVA = "0x37D0A0", Offset = "0x37BCA0", Length = "0x90")] set
      {
      }
    }

    [Token(Token = "0x60012FC")]
    [Address(RVA = "0x37CF20", Offset = "0x37BB20", Length = "0x39")]
    public UnityUIGlyphOrText()
    {
    }
  }
}
