// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.GlyphOrTextBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

namespace Rewired.Glyphs
{
  [Token(Token = "0x200027C")]
  public abstract class GlyphOrTextBase : MonoBehaviour
  {
    [Token(Token = "0x170002EA")]
    protected abstract string textString { [Token(Token = "0x600129D")] get; [Token(Token = "0x600129E")] set; }

    [Token(Token = "0x600129F")]
    public abstract void ShowText(string text);

    [Token(Token = "0x60012A0")]
    public abstract void ShowGlyph(object glyph);

    [Token(Token = "0x60012A1")]
    [Address(RVA = "0x36DD60", Offset = "0x36C960", Length = "0x16")]
    public virtual void Hide()
    {
    }

    [Token(Token = "0x60012A2")]
    protected abstract void Hide(GlyphOrTextBase.TypeFlags flags);

    [Token(Token = "0x60012A3")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    protected GlyphOrTextBase()
    {
    }

    [Flags]
    [Token(Token = "0x200027D")]
    protected enum TypeFlags
    {
      [Token(Token = "0x40011D5")] None = 0,
      [Token(Token = "0x40011D6")] Glyph = 1,
      [Token(Token = "0x40011D7")] Text = 2,
      [Token(Token = "0x40011D8")] All = -1, // 0xFFFFFFFF
    }
  }
}
