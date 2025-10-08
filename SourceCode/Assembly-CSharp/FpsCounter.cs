// Decompiled with JetBrains decompiler
// Type: FpsCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000128")]
public class FpsCounter : MonoBehaviour
{
  [Token(Token = "0x40008BE")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI text;
  [Token(Token = "0x40008BF")]
  [FieldOffset(Offset = "0x28")]
  private List<float> samples;

  [Token(Token = "0x6000760")]
  [Address(RVA = "0x4B7C00", Offset = "0x4B6800", Length = "0x9D")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000761")]
  [Address(RVA = "0x4B7CA0", Offset = "0x4B68A0", Length = "0xBE")]
  private void UpdateFps()
  {
  }

  [Token(Token = "0x6000762")]
  [Address(RVA = "0x4B7D60", Offset = "0x4B6960", Length = "0xAF")]
  private void Update()
  {
  }

  [Token(Token = "0x6000763")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public FpsCounter()
  {
  }
}
