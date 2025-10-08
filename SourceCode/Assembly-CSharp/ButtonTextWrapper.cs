// Decompiled with JetBrains decompiler
// Type: ButtonTextWrapper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000175")]
public class ButtonTextWrapper : MonoBehaviour
{
  [Token(Token = "0x4000ABE")]
  [FieldOffset(Offset = "0x20")]
  public RectTransform rect;
  [Token(Token = "0x4000ABF")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_text;
  [Token(Token = "0x4000AC0")]
  [FieldOffset(Offset = "0x30")]
  public int paddingX;
  [Token(Token = "0x4000AC1")]
  [FieldOffset(Offset = "0x34")]
  public int paddingY;
  [Token(Token = "0x4000AC2")]
  [FieldOffset(Offset = "0x38")]
  public float yOffsetRatio;
  [Token(Token = "0x4000AC3")]
  [FieldOffset(Offset = "0x3C")]
  public float offsetLeftX;

  [Token(Token = "0x6000963")]
  [Address(RVA = "0x4CCF90", Offset = "0x4CBB90", Length = "0x15F")]
  public void Refresh()
  {
  }

  [Token(Token = "0x6000964")]
  [Address(RVA = "0x4CCEA0", Offset = "0x4CBAA0", Length = "0xE7")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x6000965")]
  [Address(RVA = "0x4CD0F0", Offset = "0x4CBCF0", Length = "0x1C")]
  public ButtonTextWrapper()
  {
  }
}
