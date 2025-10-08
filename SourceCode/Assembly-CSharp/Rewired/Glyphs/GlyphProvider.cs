// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.GlyphProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Rewired.Interfaces;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rewired.Glyphs
{
  [Token(Token = "0x200027F")]
  public class GlyphProvider : MonoBehaviour, IGlyphProvider
  {
    [SerializeField]
    [Tooltip("Determines if glyphs should be fetched immediately in bulk when available. If false, glyphs will be fetched when queried.")]
    [Token(Token = "0x40011DB")]
    [FieldOffset(Offset = "0x20")]
    private bool _prefetch;
    [SerializeField]
    [Tooltip("A list of glyph set collections. At least one collection must be assigned.")]
    [Token(Token = "0x40011DC")]
    [FieldOffset(Offset = "0x28")]
    private List<GlyphSetCollection> _glyphSetCollections;
    [Token(Token = "0x40011DD")]
    [FieldOffset(Offset = "0x30")]
    [NonSerialized]
    private readonly Dictionary<string, object> _glyphs;
    [Token(Token = "0x40011DE")]
    [FieldOffset(Offset = "0x38")]
    [NonSerialized]
    private bool _initialized;

    [Token(Token = "0x170002EE")]
    public bool prefetch
    {
      [Token(Token = "0x60012AF"), Address(RVA = "0x36EB80", Offset = "0x36D780", Length = "0x5")] get => false;
      [Token(Token = "0x60012B0"), Address(RVA = "0x36ECB0", Offset = "0x36D8B0", Length = "0x10C")] set
      {
      }
    }

    [Token(Token = "0x170002EF")]
    public List<GlyphSetCollection> glyphSetCollections
    {
      [Token(Token = "0x60012B1"), Address(RVA = "0x36D750", Offset = "0x36C350", Length = "0x5")] get => (List<GlyphSetCollection>) null;
      [Token(Token = "0x60012B2"), Address(RVA = "0x36EB90", Offset = "0x36D790", Length = "0x11C")] set
      {
      }
    }

    [Token(Token = "0x170002F0")]
    protected Dictionary<string, object> glyphs
    {
      [Token(Token = "0x60012B3"), Address(RVA = "0x36C780", Offset = "0x36B380", Length = "0x5")] get => (Dictionary<string, object>) null;
    }

    [Token(Token = "0x60012B4")]
    [Address(RVA = "0x36E710", Offset = "0x36D310", Length = "0x38")]
    protected virtual void OnEnable()
    {
    }

    [Token(Token = "0x60012B5")]
    [Address(RVA = "0x36E5C0", Offset = "0x36D1C0", Length = "0x14C")]
    protected virtual void OnDisable()
    {
    }

    [Token(Token = "0x60012B6")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected virtual void Update()
    {
    }

    [Token(Token = "0x60012B7")]
    [Address(RVA = "0x36E8F0", Offset = "0x36D4F0", Length = "0x208")]
    protected virtual void TrySetGlyphProvider()
    {
    }

    [Token(Token = "0x60012B8")]
    [Address(RVA = "0x36E0A0", Offset = "0x36CCA0", Length = "0x51C")]
    protected virtual bool Initialize() => false;

    [Token(Token = "0x60012B9")]
    [Address(RVA = "0x36E750", Offset = "0x36D350", Length = "0x10F")]
    public void Reload()
    {
    }

    [Token(Token = "0x60012BA")]
    [Address(RVA = "0x36E860", Offset = "0x36D460", Length = "0x8C")]
    bool IGlyphProvider.TryGetGlyph(string key, out object result)
    {
      result = (object) null;
      return false;
    }

    [Token(Token = "0x60012BB")]
    [Address(RVA = "0x36EB00", Offset = "0x36D700", Length = "0x77")]
    public GlyphProvider()
    {
    }
  }
}
