// Decompiled with JetBrains decompiler
// Type: CircleWarning
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

[Token(Token = "0x200006B")]
public class CircleWarning : MonoBehaviour
{
  [Token(Token = "0x400034A")]
  [FieldOffset(Offset = "0x20")]
  public float warningTime;
  [Token(Token = "0x400034B")]
  [FieldOffset(Offset = "0x28")]
  public Transform filler;
  [Token(Token = "0x400034C")]
  [FieldOffset(Offset = "0x30")]
  private float defaultProjectorSize;
  [Token(Token = "0x400034D")]
  [FieldOffset(Offset = "0x34")]
  private float timer;
  [Token(Token = "0x400034E")]
  [FieldOffset(Offset = "0x38")]
  private Action finishAction;
  [Token(Token = "0x400034F")]
  [FieldOffset(Offset = "0x40")]
  private Vector3 desiredScale;

  [Token(Token = "0x60002B4")]
  [Address(RVA = "0x45EEE0", Offset = "0x45DAE0", Length = "0x11B")]
  public void Set(float radius, float warningTime, Action finishAction)
  {
  }

  [Token(Token = "0x60002B5")]
  [Address(RVA = "0x45F000", Offset = "0x45DC00", Length = "0x27A")]
  private void Update()
  {
  }

  [Token(Token = "0x60002B6")]
  [Address(RVA = "0x45EE20", Offset = "0x45DA20", Length = "0xB8")]
  public void ReleaseToPool()
  {
  }

  [Token(Token = "0x60002B7")]
  [Address(RVA = "0x45F280", Offset = "0x45DE80", Length = "0x15")]
  public CircleWarning()
  {
  }
}
