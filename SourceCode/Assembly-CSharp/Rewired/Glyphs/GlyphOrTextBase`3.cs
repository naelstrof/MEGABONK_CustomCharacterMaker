// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.GlyphOrTextBase`3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Glyphs
{
  [Token(Token = "0x200027E")]
  public abstract class GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent> : 
    GlyphOrTextBase
    where TGlyphComponent : Behaviour
    where TGlyphGraphic : class
    where TTextComponent : Behaviour
  {
    [SerializeField]
    [Token(Token = "0x40011D9")]
    [FieldOffset(Offset = "0x0")]
    private TTextComponent _textComponent;
    [SerializeField]
    [Token(Token = "0x40011DA")]
    [FieldOffset(Offset = "0x0")]
    private TGlyphComponent _glyphComponent;

    [Token(Token = "0x170002EB")]
    public TTextComponent textComponent
    {
      [Token(Token = "0x60012A4"), Address(RVA = "0x36C790", Offset = "0x36B390", Length = "0x5")] get => default (TTextComponent);
      [Token(Token = "0x60012A5"), Address(RVA = "0x359A30", Offset = "0x358630", Length = "0xD")] set
      {
      }
    }

    [Token(Token = "0x170002EC")]
    public TGlyphComponent glyphComponent
    {
      [Token(Token = "0x60012A6"), Address(RVA = "0x36D750", Offset = "0x36C350", Length = "0x5")] get => default (TGlyphComponent);
      [Token(Token = "0x60012A7"), Address(RVA = "0x386DE0", Offset = "0x3859E0", Length = "0xD")] set
      {
      }
    }

    [Token(Token = "0x170002ED")]
    protected abstract TGlyphGraphic glyphGraphic { [Token(Token = "0x60012A8")] get; [Token(Token = "0x60012A9")] set; }

    [Token(Token = "0x60012AA")]
    [Address(RVA = "0xF3D1F0", Offset = "0xF3BDF0", Length = "0x154")]
    public override void ShowText(string text)
    {
    }

    [Token(Token = "0x60012AB")]
    [Address(RVA = "0xF3CF00", Offset = "0xF3BB00", Length = "0x194")]
    public override void ShowGlyph(object glyph)
    {
    }

    [Token(Token = "0x60012AC")]
    [Address(RVA = "0xF3D0A0", Offset = "0xF3BCA0", Length = "0x143")]
    public virtual void ShowGlyph(TGlyphGraphic glyph)
    {
    }

    [Token(Token = "0x60012AD")]
    [Address(RVA = "0xF3CCF0", Offset = "0xF3B8F0", Length = "0x20D")]
    protected override void Hide(GlyphOrTextBase.TypeFlags flags)
    {
    }

    [Token(Token = "0x60012AE")]
    [Address(RVA = "0x357E60", Offset = "0x356A60", Length = "0x7")]
    protected GlyphOrTextBase()
    {
    }
  }
}
