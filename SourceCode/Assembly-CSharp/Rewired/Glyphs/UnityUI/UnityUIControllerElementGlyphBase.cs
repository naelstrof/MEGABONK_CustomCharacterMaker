// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.UnityUI.UnityUIControllerElementGlyphBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

namespace Rewired.Glyphs.UnityUI
{
  [Token(Token = "0x2000289")]
  public abstract class UnityUIControllerElementGlyphBase : ControllerElementGlyphBase
  {
    [Token(Token = "0x40011EF")]
    private static GameObject s_defaultGlyphOrTextPrefab;
    [Token(Token = "0x40011F0")]
    private static Func<GameObject> s_defaultGlyphOrTextPrefabProvider;

    [Token(Token = "0x60012EC")]
    [Address(RVA = "0x37C660", Offset = "0x37B260", Length = "0x7")]
    protected override GameObject GetDefaultGlyphOrTextPrefab() => (GameObject) null;

    [Token(Token = "0x170002FB")]
    public static GameObject defaultGlyphOrTextPrefab
    {
      [Token(Token = "0x60012ED"), Address(RVA = "0x37C6B0", Offset = "0x37B2B0", Length = "0xB6")] get => (GameObject) null;
      [Token(Token = "0x60012EE"), Address(RVA = "0x37C7D0", Offset = "0x37B3D0", Length = "0x51")] set
      {
      }
    }

    [Token(Token = "0x170002FC")]
    public static Func<GameObject> defaultGlyphOrTextPrefabProvider
    {
      [Token(Token = "0x60012EF"), Address(RVA = "0x37C670", Offset = "0x37B270", Length = "0x37")] get => (Func<GameObject>) null;
      [Token(Token = "0x60012F0"), Address(RVA = "0x37C770", Offset = "0x37B370", Length = "0x56")] set
      {
      }
    }

    [Token(Token = "0x60012F1")]
    [Address(RVA = "0x37C2C0", Offset = "0x37AEC0", Length = "0x39F")]
    private static GameObject CreateDefaultGlyphOrTextPrefab() => (GameObject) null;

    [Token(Token = "0x60012F2")]
    [Address(RVA = "0x36CC70", Offset = "0x36B870", Length = "0x7")]
    protected UnityUIControllerElementGlyphBase()
    {
    }
  }
}
