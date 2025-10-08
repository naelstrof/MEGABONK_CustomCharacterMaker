// Decompiled with JetBrains decompiler
// Type: CameraFollowBean
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000233")]
public class CameraFollowBean : MonoBehaviour
{
  [Token(Token = "0x4000F53")]
  [FieldOffset(Offset = "0x20")]
  public Transform target;
  [Token(Token = "0x4000F54")]
  [FieldOffset(Offset = "0x28")]
  public Rigidbody[] rbs;
  [Token(Token = "0x4000F55")]
  [FieldOffset(Offset = "0x30")]
  public float speed;
  [Token(Token = "0x4000F56")]
  [FieldOffset(Offset = "0x34")]
  public float rotationSpeed;
  [Token(Token = "0x4000F57")]
  [FieldOffset(Offset = "0x38")]
  public Camera camera;
  [Token(Token = "0x4000F58")]
  [FieldOffset(Offset = "0x40")]
  private bool falling;
  [Token(Token = "0x4000F59")]
  [FieldOffset(Offset = "0x44")]
  private float upOffset;
  [Token(Token = "0x4000F5A")]
  [FieldOffset(Offset = "0x48")]
  private float rightOffset;
  [Token(Token = "0x4000F5B")]
  [FieldOffset(Offset = "0x50")]
  public Animator animator;
  [Token(Token = "0x4000F5C")]
  [FieldOffset(Offset = "0x58")]
  public float force;
  [Token(Token = "0x4000F5D")]
  [FieldOffset(Offset = "0x5C")]
  public float rotationForce;
  [Token(Token = "0x4000F5E")]
  [FieldOffset(Offset = "0x60")]
  public GameObject animation;
  [Token(Token = "0x4000F5F")]
  [FieldOffset(Offset = "0x68")]
  public GameObject ragdoll;

  [Token(Token = "0x6000E39")]
  [Address(RVA = "0x51CC40", Offset = "0x51B840", Length = "0x7F4")]
  private void Update()
  {
  }

  [Token(Token = "0x6000E3A")]
  [Address(RVA = "0x51D440", Offset = "0x51C040", Length = "0x31")]
  public CameraFollowBean()
  {
  }
}
