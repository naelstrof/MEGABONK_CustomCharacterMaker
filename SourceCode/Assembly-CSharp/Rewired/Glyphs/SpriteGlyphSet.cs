// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.SpriteGlyphSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rewired.Glyphs
{
  [Token(Token = "0x2000286")]
  [Serializable]
  public class SpriteGlyphSet : GlyphSet
  {
    [Tooltip("The list of glyphs.")]
    [SerializeField]
    [Token(Token = "0x40011EE")]
    [FieldOffset(Offset = "0x20")]
    private List<SpriteGlyphSet.Entry> _glyphs;

    [Token(Token = "0x170002F9")]
    public List<SpriteGlyphSet.Entry> glyphs
    {
      [Token(Token = "0x60012E4"), Address(RVA = "0x36C790", Offset = "0x36B390", Length = "0x5")] get => (List<SpriteGlyphSet.Entry>) null;
      [Token(Token = "0x60012E5"), Address(RVA = "0x359A30", Offset = "0x358630", Length = "0xD")] set
      {
      }
    }

    [Token(Token = "0x170002FA")]
    public override int glyphCount
    {
      [Token(Token = "0x60012E6"), Address(RVA = "0x37B180", Offset = "0x379D80", Length = "0x41")] get => 0;
    }

    [Token(Token = "0x60012E7")]
    [Address(RVA = "0x37B0C0", Offset = "0x379CC0", Length = "0xB7")]
    public override GlyphSet.EntryBase GetEntry(int index) => (GlyphSet.EntryBase) null;

    [Token(Token = "0x60012E8")]
    [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
    public SpriteGlyphSet()
    {
    }

    [Token(Token = "0x2000287")]
    [Serializable]
    public class Entry : GlyphSet.EntryBase<Sprite>
    {
      [Token(Token = "0x60012E9")]
      [Address(RVA = "0x36DD20", Offset = "0x36C920", Length = "0x39")]
      public Entry()
      {
      }
    }
  }
}
