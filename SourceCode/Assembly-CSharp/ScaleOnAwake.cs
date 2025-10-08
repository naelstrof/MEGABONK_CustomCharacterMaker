// Decompiled with JetBrains decompiler
// Type: ScaleOnAwake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000108")]
public class ScaleOnAwake : MonoBehaviour
{
  [Token(Token = "0x4000806")]
  [FieldOffset(Offset = "0x20")]
  private Vector3 defaultScale;
  [Token(Token = "0x4000807")]
  [FieldOffset(Offset = "0x2C")]
  public float scaleTime;
  [Token(Token = "0x4000808")]
  [FieldOffset(Offset = "0x30")]
  private float t;

  [Token(Token = "0x60006D4")]
  [Address(RVA = "0x4C4560", Offset = "0x4C3160", Length = "0x141")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60006D5")]
  [Address(RVA = "0x4C4520", Offset = "0x4C3120", Length = "0x3F")]
  private void FindScale()
  {
  }

  [Token(Token = "0x60006D6")]
  [Address(RVA = "0x4C46B0", Offset = "0x4C32B0", Length = "0x23B")]
  private void Update()
  {
  }

  [Token(Token = "0x60006D7")]
  [Address(RVA = "0x4C48F0", Offset = "0x4C34F0", Length = "0xE")]
  public ScaleOnAwake()
  {
  }
}
