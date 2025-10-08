// Decompiled with JetBrains decompiler
// Type: ControllerManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200020E")]
public class ControllerManager : MonoBehaviour
{
  [Token(Token = "0x4000E75")]
  [FieldOffset(Offset = "0x20")]
  public ControllerGlyphs controllerGlyphs;
  [Token(Token = "0x4000E76")]
  public static ControllerManager Instance;

  [Token(Token = "0x6000D6E")]
  [Address(RVA = "0x51F980", Offset = "0x51E580", Length = "0xE8")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000D6F")]
  [Address(RVA = "0x51FA70", Offset = "0x51E670", Length = "0x1C2")]
  public bool GetGlyph(KeyCode keycode, out Texture glyph)
  {
    glyph = (Texture) null;
    return false;
  }

  [Token(Token = "0x6000D70")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ControllerManager()
  {
  }
}
