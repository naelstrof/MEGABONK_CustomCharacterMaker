// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.UnityUI.UnityUIGlyphOrTextTMPro
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Glyphs.UnityUI
{
  [Token(Token = "0x200028D")]
  public class UnityUIGlyphOrTextTMPro : GlyphOrTextBase<Image, Sprite, TMP_Text>
  {
    [Token(Token = "0x170002FF")]
    protected override string textString
    {
      [Token(Token = "0x60012FD"), Address(RVA = "0x37CD30", Offset = "0x37B930", Length = "0xA7")] get => (string) null;
      [Token(Token = "0x60012FE"), Address(RVA = "0x37CE80", Offset = "0x37BA80", Length = "0x98")] set
      {
      }
    }

    [Token(Token = "0x17000300")]
    protected override Sprite glyphGraphic
    {
      [Token(Token = "0x60012FF"), Address(RVA = "0x37CCA0", Offset = "0x37B8A0", Length = "0x8C")] get => (Sprite) null;
      [Token(Token = "0x6001300"), Address(RVA = "0x37CDE0", Offset = "0x37B9E0", Length = "0x90")] set
      {
      }
    }

    [Token(Token = "0x6001301")]
    [Address(RVA = "0x37CC60", Offset = "0x37B860", Length = "0x39")]
    public UnityUIGlyphOrTextTMPro()
    {
    }
  }
}
