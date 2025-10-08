// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.ControllerElementGlyphSelectorOptionsSOBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

namespace Rewired.Glyphs
{
  [Token(Token = "0x200027A")]
  [Serializable]
  public abstract class ControllerElementGlyphSelectorOptionsSOBase : ScriptableObject
  {
    [Token(Token = "0x170002E7")]
    public abstract ControllerElementGlyphSelectorOptions options { [Token(Token = "0x6001291")] get; }

    [Token(Token = "0x6001292")]
    [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
    protected ControllerElementGlyphSelectorOptionsSOBase()
    {
    }
  }
}
