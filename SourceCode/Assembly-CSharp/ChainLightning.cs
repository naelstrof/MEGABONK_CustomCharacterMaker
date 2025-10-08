// Decompiled with JetBrains decompiler
// Type: ChainLightning
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x200004D")]
public class ChainLightning : MonoBehaviour
{
  [Token(Token = "0x400028B")]
  [FieldOffset(Offset = "0x20")]
  public LineRenderer lineRenderer;

  [Token(Token = "0x6000213")]
  [Address(RVA = "0x3563F0", Offset = "0x354FF0", Length = "0xD2")]
  public void Set(List<Vector3> positions)
  {
  }

  [Token(Token = "0x6000214")]
  [Address(RVA = "0x3563C0", Offset = "0x354FC0", Length = "0x26")]
  private void DisableSelf()
  {
  }

  [Token(Token = "0x6000215")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ChainLightning()
  {
  }
}
