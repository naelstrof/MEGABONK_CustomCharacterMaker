// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.UnityUI.UnityUIPlayerControllerElementGlyph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

namespace Rewired.Glyphs.UnityUI
{
  [AddComponentMenu("Rewired/Glyphs/Unity UI/Unity UI Player Controller Element Glyph")]
  [Token(Token = "0x200028E")]
  public class UnityUIPlayerControllerElementGlyph : UnityUIPlayerControllerElementGlyphBase
  {
    [Tooltip("The Player id.")]
    [SerializeField]
    [Token(Token = "0x40011F1")]
    [FieldOffset(Offset = "0x88")]
    private int _playerId;
    [Tooltip("The Action name.")]
    [SerializeField]
    [Token(Token = "0x40011F2")]
    [FieldOffset(Offset = "0x90")]
    private string _actionName;
    [Token(Token = "0x40011F3")]
    [FieldOffset(Offset = "0x98")]
    [NonSerialized]
    private int _actionId;
    [Token(Token = "0x40011F4")]
    [FieldOffset(Offset = "0x9C")]
    [NonSerialized]
    private bool _actionIdCached;

    [Token(Token = "0x17000301")]
    public override int playerId
    {
      [Token(Token = "0x6001302"), Address(RVA = "0x399690", Offset = "0x398290", Length = "0x7")] get => 0;
      [Token(Token = "0x6001303"), Address(RVA = "0x399820", Offset = "0x398420", Length = "0x7")] set
      {
      }
    }

    [Token(Token = "0x17000302")]
    public override int actionId
    {
      [Token(Token = "0x6001304"), Address(RVA = "0x399640", Offset = "0x398240", Length = "0x31")] get => 0;
      [Token(Token = "0x6001305"), Address(RVA = "0x3996A0", Offset = "0x3982A0", Length = "0x145")] set
      {
      }
    }

    [Token(Token = "0x17000303")]
    public string actionName
    {
      [Token(Token = "0x6001306"), Address(RVA = "0x399680", Offset = "0x398280", Length = "0x8")] get => (string) null;
      [Token(Token = "0x6001307"), Address(RVA = "0x3997F0", Offset = "0x3983F0", Length = "0x2B")] set
      {
      }
    }

    [Token(Token = "0x6001308")]
    [Address(RVA = "0x399420", Offset = "0x398020", Length = "0xEA")]
    private void CacheActionId()
    {
    }

    [Token(Token = "0x6001309")]
    [Address(RVA = "0x399510", Offset = "0x398110", Length = "0x129")]
    public UnityUIPlayerControllerElementGlyph()
    {
    }
  }
}
