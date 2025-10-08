// Decompiled with JetBrains decompiler
// Type: FloatingObject2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000FB")]
public class FloatingObject2 : MonoBehaviour
{
  [Token(Token = "0x40007D9")]
  [FieldOffset(Offset = "0x20")]
  private Vector3 defaultPosition;
  [Token(Token = "0x40007DA")]
  [FieldOffset(Offset = "0x2C")]
  public float heightOffset;
  [Token(Token = "0x40007DB")]
  [FieldOffset(Offset = "0x30")]
  public float rotationSpeed;
  [Token(Token = "0x40007DC")]
  [FieldOffset(Offset = "0x34")]
  public int moveSpeed;

  [Token(Token = "0x60006AD")]
  [Address(RVA = "0x4B76E0", Offset = "0x4B62E0", Length = "0x3F")]
  private void Start()
  {
  }

  [Token(Token = "0x60006AE")]
  [Address(RVA = "0x4B7720", Offset = "0x4B6320", Length = "0x1BE")]
  private void Update()
  {
  }

  [Token(Token = "0x60006AF")]
  [Address(RVA = "0x4B78E0", Offset = "0x4B64E0", Length = "0x1C")]
  public FloatingObject2()
  {
  }
}
