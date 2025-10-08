// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.GlyphSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

namespace Rewired.Glyphs
{
  [Token(Token = "0x2000280")]
  [Serializable]
  public abstract class GlyphSet : ScriptableObject
  {
    [Tooltip("A list of base keys. Final keys will be composed of base key + glyph key. Setting multiple base keys allows one glyph set to apply to multiple controllers, for example.")]
    [SerializeField]
    [Token(Token = "0x40011DF")]
    [FieldOffset(Offset = "0x18")]
    private string[] _baseKeys;

    [Token(Token = "0x170002F1")]
    public string[] baseKeys
    {
      [Token(Token = "0x60012BC"), Address(RVA = "0x3684A0", Offset = "0x3670A0", Length = "0x5")] get => (string[]) null;
      [Token(Token = "0x60012BD"), Address(RVA = "0x36AC70", Offset = "0x369870", Length = "0xD")] set
      {
      }
    }

    [Token(Token = "0x170002F2")]
    public abstract int glyphCount { [Token(Token = "0x60012BE")] get; }

    [Token(Token = "0x60012BF")]
    public abstract GlyphSet.EntryBase GetEntry(int index);

    [Token(Token = "0x60012C0")]
    [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
    protected GlyphSet()
    {
    }

    [Token(Token = "0x2000281")]
    [Serializable]
    public abstract class EntryBase
    {
      [SerializeField]
      [Token(Token = "0x40011E0")]
      [FieldOffset(Offset = "0x10")]
      private string _key;

      [Token(Token = "0x170002F3")]
      public string key
      {
        [Token(Token = "0x60012C1"), Address(RVA = "0x36D7C0", Offset = "0x36C3C0", Length = "0x5")] get => (string) null;
        [Token(Token = "0x60012C2"), Address(RVA = "0x36D7D0", Offset = "0x36C3D0", Length = "0xD")] set
        {
        }
      }

      [Token(Token = "0x60012C3")]
      public abstract object GetValue();

      [Token(Token = "0x60012C4")]
      [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
      protected EntryBase()
      {
      }
    }

    [Token(Token = "0x2000282")]
    [Serializable]
    public abstract class EntryBase<TValue> : GlyphSet.EntryBase
    {
      [SerializeField]
      [Token(Token = "0x40011E1")]
      [FieldOffset(Offset = "0x0")]
      private TValue _value;

      [Token(Token = "0x170002F4")]
      public TValue value
      {
        [Token(Token = "0x60012C5"), Address(RVA = "0x3684A0", Offset = "0x3670A0", Length = "0x5")] get => default (TValue);
        [Token(Token = "0x60012C6"), Address(RVA = "0x36AC70", Offset = "0x369870", Length = "0xD")] set
        {
        }
      }

      [Token(Token = "0x60012C7")]
      [Address(RVA = "0x3684A0", Offset = "0x3670A0", Length = "0x5")]
      public override object GetValue() => (object) null;

      [Token(Token = "0x60012C8")]
      [Address(RVA = "0x33D450", Offset = "0x33C050", Length = "0x7")]
      protected EntryBase()
      {
      }
    }
  }
}
