// Decompiled with JetBrains decompiler
// Type: LookAtCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000035")]
public class LookAtCamera : MonoBehaviour
{
  [Token(Token = "0x4000195")]
  [FieldOffset(Offset = "0x20")]
  public bool invert;
  [Token(Token = "0x4000196")]
  [FieldOffset(Offset = "0x21")]
  public bool xzOnly;
  [Token(Token = "0x4000197")]
  [FieldOffset(Offset = "0x28")]
  private Transform target;

  [Token(Token = "0x600017B")]
  [Address(RVA = "0x35DE10", Offset = "0x35CA10", Length = "0x290")]
  private void Update()
  {
  }

  [Token(Token = "0x600017C")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public LookAtCamera()
  {
  }
}
