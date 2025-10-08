// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.GlyphSetCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rewired.Glyphs
{
  [Token(Token = "0x2000283")]
  [Serializable]
  public class GlyphSetCollection : ScriptableObject
  {
    [Tooltip("The list of glyph sets.")]
    [SerializeField]
    [Token(Token = "0x40011E2")]
    [FieldOffset(Offset = "0x18")]
    private List<GlyphSet> _sets;
    [Tooltip("The list of glyph set collections.")]
    [SerializeField]
    [Token(Token = "0x40011E3")]
    [FieldOffset(Offset = "0x20")]
    private List<GlyphSetCollection> _collections;

    [Token(Token = "0x170002F5")]
    public List<GlyphSet> sets
    {
      [Token(Token = "0x60012C9"), Address(RVA = "0x3684A0", Offset = "0x3670A0", Length = "0x5")] get => (List<GlyphSet>) null;
      [Token(Token = "0x60012CA"), Address(RVA = "0x36AC70", Offset = "0x369870", Length = "0xD")] set
      {
      }
    }

    [Token(Token = "0x170002F6")]
    public List<GlyphSetCollection> collections
    {
      [Token(Token = "0x60012CB"), Address(RVA = "0x36C790", Offset = "0x36B390", Length = "0x5")] get => (List<GlyphSetCollection>) null;
      [Token(Token = "0x60012CC"), Address(RVA = "0x36EFA0", Offset = "0x36DBA0", Length = "0xAD")] set
      {
      }
    }

    [Token(Token = "0x60012CD")]
    [Address(RVA = "0x36EE50", Offset = "0x36DA50", Length = "0xEB")]
    public virtual IEnumerable<GlyphSet> IterateSetsRecursively() => (IEnumerable<GlyphSet>) null;

    [Token(Token = "0x60012CE")]
    [Address(RVA = "0x36EDC0", Offset = "0x36D9C0", Length = "0x8E")]
    protected virtual IEnumerable<GlyphSet> IterateSetsRecursively(
      List<GlyphSetCollection> processedCollections)
    {
      return (IEnumerable<GlyphSet>) null;
    }

    [Token(Token = "0x60012CF")]
    [Address(RVA = "0x36EF40", Offset = "0x36DB40", Length = "0x53")]
    private static void LogCircularDependency()
    {
    }

    [Token(Token = "0x60012D0")]
    [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
    public GlyphSetCollection()
    {
    }
  }
}
