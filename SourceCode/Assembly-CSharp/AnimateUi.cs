// Decompiled with JetBrains decompiler
// Type: AnimateUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000124")]
public class AnimateUi : MonoBehaviour
{
  [Token(Token = "0x40008A1")]
  [FieldOffset(Offset = "0x20")]
  private float fps;
  [Token(Token = "0x40008A2")]
  [FieldOffset(Offset = "0x24")]
  private float nextUpdateTime;
  [Token(Token = "0x40008A3")]
  [FieldOffset(Offset = "0x28")]
  public float rotationAmount;
  [Token(Token = "0x40008A4")]
  [FieldOffset(Offset = "0x2C")]
  public float rotationSpeed;
  [Token(Token = "0x40008A5")]
  [FieldOffset(Offset = "0x30")]
  public float scaleAmount;
  [Token(Token = "0x40008A6")]
  [FieldOffset(Offset = "0x34")]
  public float scaleSpeed;
  [Token(Token = "0x40008A7")]
  [FieldOffset(Offset = "0x38")]
  public bool animateScale;
  [Token(Token = "0x40008A8")]
  [FieldOffset(Offset = "0x3C")]
  private float defaultZRot;

  [Token(Token = "0x600074B")]
  [Address(RVA = "0x4B2CA0", Offset = "0x4B18A0", Length = "0x36")]
  private void Awake()
  {
  }

  [Token(Token = "0x600074C")]
  [Address(RVA = "0x4B2CE0", Offset = "0x4B18E0", Length = "0x18E")]
  private void Update()
  {
  }

  [Token(Token = "0x600074D")]
  [Address(RVA = "0x4B2E70", Offset = "0x4B1A70", Length = "0x2E")]
  public AnimateUi()
  {
  }
}
