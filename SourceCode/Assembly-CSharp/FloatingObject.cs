// Decompiled with JetBrains decompiler
// Type: FloatingObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000FA")]
public class FloatingObject : MonoBehaviour
{
  [Token(Token = "0x40007D4")]
  [FieldOffset(Offset = "0x20")]
  private Vector3 defaultPosition;
  [Token(Token = "0x40007D5")]
  [FieldOffset(Offset = "0x2C")]
  public bool useMeTime;
  [Token(Token = "0x40007D6")]
  [FieldOffset(Offset = "0x30")]
  public float heightOffset;
  [Token(Token = "0x40007D7")]
  [FieldOffset(Offset = "0x34")]
  public float floatSpeed;
  [Token(Token = "0x40007D8")]
  [FieldOffset(Offset = "0x38")]
  public float rotationSpeed;

  [Token(Token = "0x60006AA")]
  [Address(RVA = "0x4B76E0", Offset = "0x4B62E0", Length = "0x3F")]
  private void Awake()
  {
  }

  [Token(Token = "0x60006AB")]
  [Address(RVA = "0x4B7900", Offset = "0x4B6500", Length = "0x1CB")]
  private void Update()
  {
  }

  [Token(Token = "0x60006AC")]
  [Address(RVA = "0x4B7AD0", Offset = "0x4B66D0", Length = "0x20")]
  public FloatingObject()
  {
  }
}
