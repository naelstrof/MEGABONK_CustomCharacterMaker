// Decompiled with JetBrains decompiler
// Type: DisableFogForCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000032")]
public class DisableFogForCamera : MonoBehaviour
{
  [Token(Token = "0x400018E")]
  [FieldOffset(Offset = "0x20")]
  private bool originalFogState;

  [Token(Token = "0x6000170")]
  [Address(RVA = "0x35A290", Offset = "0x358E90", Length = "0x21")]
  private void OnPreRender()
  {
  }

  [Token(Token = "0x6000171")]
  [Address(RVA = "0x35A280", Offset = "0x358E80", Length = "0xB")]
  private void OnPostRender()
  {
  }

  [Token(Token = "0x6000172")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public DisableFogForCamera()
  {
  }
}
