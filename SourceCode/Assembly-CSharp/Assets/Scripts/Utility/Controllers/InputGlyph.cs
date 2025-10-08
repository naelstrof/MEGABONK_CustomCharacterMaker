// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Utility.Controllers.InputGlyph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

namespace Assets.Scripts.Utility.Controllers
{
  [Token(Token = "0x20002E6")]
  [Serializable]
  public class InputGlyph
  {
    [Token(Token = "0x40013CE")]
    [FieldOffset(Offset = "0x10")]
    public KeyCode keycode;
    [Token(Token = "0x40013CF")]
    [FieldOffset(Offset = "0x18")]
    public Texture glyph;

    [Token(Token = "0x6001545")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public InputGlyph()
    {
    }
  }
}
