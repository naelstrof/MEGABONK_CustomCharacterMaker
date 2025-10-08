// Decompiled with JetBrains decompiler
// Type: SpinAroundCharacter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200003B")]
public class SpinAroundCharacter : MonoBehaviour
{
  [Token(Token = "0x40001BB")]
  [FieldOffset(Offset = "0x20")]
  public Transform camera;
  [Token(Token = "0x40001BC")]
  [FieldOffset(Offset = "0x28")]
  public Transform target;
  [Token(Token = "0x40001BD")]
  [FieldOffset(Offset = "0x30")]
  public float distanceFromTarget;
  [Token(Token = "0x40001BE")]
  [FieldOffset(Offset = "0x34")]
  public float cameraHeight;
  [Token(Token = "0x40001BF")]
  [FieldOffset(Offset = "0x38")]
  public Vector3 targetOffset;
  [Token(Token = "0x40001C0")]
  [FieldOffset(Offset = "0x44")]
  public float rotationSpeed;
  [Token(Token = "0x40001C1")]
  [FieldOffset(Offset = "0x48")]
  private float currentAngle;

  [Token(Token = "0x60001AC")]
  [Address(RVA = "0x367C80", Offset = "0x366880", Length = "0x2C4")]
  private void Update()
  {
  }

  [Token(Token = "0x60001AD")]
  [Address(RVA = "0x367F50", Offset = "0x366B50", Length = "0x1C")]
  public SpinAroundCharacter()
  {
  }
}
