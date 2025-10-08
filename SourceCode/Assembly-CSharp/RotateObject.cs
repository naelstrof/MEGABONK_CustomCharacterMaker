// Decompiled with JetBrains decompiler
// Type: RotateObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000106")]
public class RotateObject : MonoBehaviour
{
  [Token(Token = "0x40007FF")]
  [FieldOffset(Offset = "0x20")]
  public bool useMeTime;
  [Token(Token = "0x4000800")]
  [FieldOffset(Offset = "0x24")]
  public float speed;
  [Token(Token = "0x4000801")]
  [FieldOffset(Offset = "0x28")]
  public Vector3 axis;

  [Token(Token = "0x60006CE")]
  [Address(RVA = "0x4C2290", Offset = "0x4C0E90", Length = "0x115")]
  private void Update()
  {
  }

  [Token(Token = "0x60006CF")]
  [Address(RVA = "0x4C23B0", Offset = "0x4C0FB0", Length = "0x26")]
  public RotateObject()
  {
  }
}
