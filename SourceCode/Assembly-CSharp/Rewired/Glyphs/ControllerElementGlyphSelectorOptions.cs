// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.ControllerElementGlyphSelectorOptions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

namespace Rewired.Glyphs
{
  [Token(Token = "0x2000278")]
  [Serializable]
  public class ControllerElementGlyphSelectorOptions
  {
    [Tooltip("Determines if the Player's last active controller is used for glyph selection.")]
    [SerializeField]
    [Token(Token = "0x40011CE")]
    [FieldOffset(Offset = "0x10")]
    private bool _useLastActiveController;
    [Tooltip("List of controller type priority. First in list corresponds to highest priority. This determines which controller types take precedence when displaying glyphs. If use last active controller is enabled, the active controller will always take priority, however, if there is no last active controller, selection will fall back based on this priority. In addition, keyboard and mouse are treated as a single controller for the purposes of glyph handling, so to prioritze keyboard over mouse or vice versa, the one that is lower in the list will take precedence.")]
    [SerializeField]
    [Token(Token = "0x40011CF")]
    [FieldOffset(Offset = "0x18")]
    private ControllerType[] _controllerTypeOrder;
    [Token(Token = "0x40011D0")]
    private static ControllerElementGlyphSelectorOptions s_defaultOptions;

    [Token(Token = "0x170002E3")]
    public bool useLastActiveController
    {
      [Token(Token = "0x6001287"), Address(RVA = "0x36C9C0", Offset = "0x36B5C0", Length = "0x5")] get => false;
      [Token(Token = "0x6001288"), Address(RVA = "0x36CA30", Offset = "0x36B630", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x170002E4")]
    public ControllerType[] controllerTypeOrder
    {
      [Token(Token = "0x6001289"), Address(RVA = "0x3684A0", Offset = "0x3670A0", Length = "0x5")] get => (ControllerType[]) null;
      [Token(Token = "0x600128A"), Address(RVA = "0x36AC70", Offset = "0x369870", Length = "0xD")] set
      {
      }
    }

    [Token(Token = "0x600128B")]
    [Address(RVA = "0x36C7F0", Offset = "0x36B3F0", Length = "0x39")]
    public virtual bool TryGetControllerTypeOrder(int index, out ControllerType controllerType)
    {
      controllerType = new ControllerType();
      return false;
    }

    [Token(Token = "0x170002E5")]
    public static ControllerElementGlyphSelectorOptions defaultOptions
    {
      [Token(Token = "0x600128C"), Address(RVA = "0x36C8C0", Offset = "0x36B4C0", Length = "0xF3")] get => (ControllerElementGlyphSelectorOptions) null;
      [Token(Token = "0x600128D"), Address(RVA = "0x36C9D0", Offset = "0x36B5D0", Length = "0x51")] set
      {
      }
    }

    [Token(Token = "0x600128E")]
    [Address(RVA = "0x36C830", Offset = "0x36B430", Length = "0x83")]
    public ControllerElementGlyphSelectorOptions()
    {
    }
  }
}
