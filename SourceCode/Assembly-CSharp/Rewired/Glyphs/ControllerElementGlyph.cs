// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.ControllerElementGlyph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Rewired.Glyphs
{
  [Token(Token = "0x2000274")]
  public abstract class ControllerElementGlyph : ControllerElementGlyphBase
  {
    [Token(Token = "0x40011BF")]
    [FieldOffset(Offset = "0x48")]
    [NonSerialized]
    private ActionElementMap _actionElementMap;
    [Token(Token = "0x40011C0")]
    [FieldOffset(Offset = "0x50")]
    [NonSerialized]
    private ControllerElementIdentifier _controllerElementIdentifier;
    [Token(Token = "0x40011C1")]
    [FieldOffset(Offset = "0x58")]
    [NonSerialized]
    private AxisRange _axisRange;

    [Token(Token = "0x170002DB")]
    public ActionElementMap actionElementMap
    {
      [Token(Token = "0x600125A"), Address(RVA = "0x345C40", Offset = "0x344840", Length = "0x5")] get => (ActionElementMap) null;
      [Token(Token = "0x600125B"), Address(RVA = "0x36CCA0", Offset = "0x36B8A0", Length = "0xD")] set
      {
      }
    }

    [Token(Token = "0x170002DC")]
    public ControllerElementIdentifier controllerElementIdentifier
    {
      [Token(Token = "0x600125C"), Address(RVA = "0x36CC90", Offset = "0x36B890", Length = "0x5")] get => (ControllerElementIdentifier) null;
      [Token(Token = "0x600125D"), Address(RVA = "0x36CCC0", Offset = "0x36B8C0", Length = "0xD")] set
      {
      }
    }

    [Token(Token = "0x170002DD")]
    public AxisRange axisRange
    {
      [Token(Token = "0x600125E"), Address(RVA = "0x36CC80", Offset = "0x36B880", Length = "0x4")] get => new AxisRange();
      [Token(Token = "0x600125F"), Address(RVA = "0x36CCB0", Offset = "0x36B8B0", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x6001260")]
    [Address(RVA = "0x36CA40", Offset = "0x36B640", Length = "0x222")]
    protected override void Update()
    {
    }

    [Token(Token = "0x6001261")]
    [Address(RVA = "0x36CC70", Offset = "0x36B870", Length = "0x7")]
    protected ControllerElementGlyph()
    {
    }
  }
}
