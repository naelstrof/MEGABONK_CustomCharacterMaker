// Decompiled with JetBrains decompiler
// Type: LowHpUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000134")]
public class LowHpUi : MonoBehaviour
{
  [Token(Token = "0x4000908")]
  [FieldOffset(Offset = "0x20")]
  public RawImage vignette;
  [Token(Token = "0x4000909")]
  [FieldOffset(Offset = "0x28")]
  private Color vignetteColor;
  [Token(Token = "0x400090A")]
  [FieldOffset(Offset = "0x38")]
  private float maxOpacity;

  [Token(Token = "0x60007B8")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void Awake()
  {
  }

  [Token(Token = "0x60007B9")]
  [Address(RVA = "0x4BCA70", Offset = "0x4BB670", Length = "0xF2")]
  private void Update()
  {
  }

  [Token(Token = "0x60007BA")]
  [Address(RVA = "0x475F10", Offset = "0x474B10", Length = "0xE")]
  public LowHpUi()
  {
  }
}
