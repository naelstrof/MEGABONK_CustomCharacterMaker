// Decompiled with JetBrains decompiler
// Type: SmokeAndShakeObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

[Token(Token = "0x2000109")]
public class SmokeAndShakeObject : MonoBehaviour
{
  [Range(0.5f, 3f)]
  [Token(Token = "0x4000809")]
  [FieldOffset(Offset = "0x20")]
  public float shakeStrength;
  [Token(Token = "0x400080A")]
  [FieldOffset(Offset = "0x24")]
  private float readyAtTime;
  [Token(Token = "0x400080B")]
  [FieldOffset(Offset = "0x28")]
  private float maxDistanceToPlayer;
  [Token(Token = "0x400080C")]
  [FieldOffset(Offset = "0x2C")]
  private float minSpeed;
  [Token(Token = "0x400080D")]
  [FieldOffset(Offset = "0x30")]
  private float maxSpeed;
  [Token(Token = "0x400080E")]
  public static Action<float> A_Impact;

  [Token(Token = "0x60006D8")]
  [Address(RVA = "0x4C5770", Offset = "0x4C4370", Length = "0x279")]
  private void OnCollisionEnter(Collision other)
  {
  }

  [Token(Token = "0x60006D9")]
  [Address(RVA = "0x4C59F0", Offset = "0x4C45F0", Length = "0x23")]
  public SmokeAndShakeObject()
  {
  }
}
