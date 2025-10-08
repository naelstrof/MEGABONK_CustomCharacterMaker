// Decompiled with JetBrains decompiler
// Type: AlertIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000123")]
public class AlertIcon : MonoBehaviour
{
  [Token(Token = "0x400089A")]
  [FieldOffset(Offset = "0x20")]
  private float fps;
  [Token(Token = "0x400089B")]
  [FieldOffset(Offset = "0x24")]
  private float nextUpdateTime;
  [Token(Token = "0x400089C")]
  [FieldOffset(Offset = "0x28")]
  private float rotationAmount;
  [Token(Token = "0x400089D")]
  [FieldOffset(Offset = "0x2C")]
  private float rotationSpeed;
  [Token(Token = "0x400089E")]
  [FieldOffset(Offset = "0x30")]
  private float scaleAmount;
  [Token(Token = "0x400089F")]
  [FieldOffset(Offset = "0x34")]
  private float scaleSpeed;
  [Token(Token = "0x40008A0")]
  [FieldOffset(Offset = "0x38")]
  private float defaultZRot;

  [Token(Token = "0x6000748")]
  [Address(RVA = "0x4B1C20", Offset = "0x4B0820", Length = "0x36")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000749")]
  [Address(RVA = "0x4B1C60", Offset = "0x4B0860", Length = "0x184")]
  private void Update()
  {
  }

  [Token(Token = "0x600074A")]
  [Address(RVA = "0x4B1DF0", Offset = "0x4B09F0", Length = "0x2A")]
  public AlertIcon()
  {
  }
}
