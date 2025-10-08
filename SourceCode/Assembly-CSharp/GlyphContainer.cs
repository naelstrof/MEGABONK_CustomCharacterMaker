// Decompiled with JetBrains decompiler
// Type: GlyphContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200020F")]
public class GlyphContainer : MonoBehaviour
{
  [Token(Token = "0x4000E77")]
  [FieldOffset(Offset = "0x20")]
  public RawImage glyph;
  [Token(Token = "0x4000E78")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI manualText;
  [Token(Token = "0x4000E79")]
  [FieldOffset(Offset = "0x30")]
  public GameObject manualParent;
  [Token(Token = "0x4000E7A")]
  [FieldOffset(Offset = "0x38")]
  public TextSizer textSizer;

  [Token(Token = "0x6000D71")]
  [Address(RVA = "0x5240C0", Offset = "0x522CC0", Length = "0x1DF")]
  public void Set(KeyCode keycode)
  {
  }

  [Token(Token = "0x6000D72")]
  [Address(RVA = "0x523FA0", Offset = "0x522BA0", Length = "0x68")]
  private void SetGlyph(Texture texture)
  {
  }

  [Token(Token = "0x6000D73")]
  [Address(RVA = "0x524010", Offset = "0x522C10", Length = "0xAA")]
  private void SetNonGlyph(KeyCode keycode)
  {
  }

  [Token(Token = "0x6000D74")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public GlyphContainer()
  {
  }
}
