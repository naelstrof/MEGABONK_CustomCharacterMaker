// Decompiled with JetBrains decompiler
// Type: DeleteLaterCameraTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000005")]
public class DeleteLaterCameraTest : MonoBehaviour
{
  [Token(Token = "0x4000003")]
  [FieldOffset(Offset = "0x20")]
  public Transform target;
  [Token(Token = "0x4000004")]
  [FieldOffset(Offset = "0x28")]
  public float seconds;
  [Token(Token = "0x4000005")]
  [FieldOffset(Offset = "0x2C")]
  private Vector3 startPos;
  [Token(Token = "0x4000006")]
  [FieldOffset(Offset = "0x38")]
  private Vector3 desiredPos;
  [Token(Token = "0x4000007")]
  [FieldOffset(Offset = "0x44")]
  private float time;

  [Token(Token = "0x6000005")]
  [Address(RVA = "0x33BFB0", Offset = "0x33ABB0", Length = "0x64")]
  private void Start()
  {
  }

  [Token(Token = "0x6000006")]
  [Address(RVA = "0x33C020", Offset = "0x33AC20", Length = "0x10D")]
  private void Update()
  {
  }

  [Token(Token = "0x6000007")]
  [Address(RVA = "0x33C130", Offset = "0x33AD30", Length = "0xE")]
  public DeleteLaterCameraTest()
  {
  }
}
