// Decompiled with JetBrains decompiler
// Type: MeshData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000ED")]
public class MeshData
{
  [Token(Token = "0x40007A9")]
  [FieldOffset(Offset = "0x10")]
  public Vector3[] vertices;
  [Token(Token = "0x40007AA")]
  [FieldOffset(Offset = "0x18")]
  public int[] triangles;
  [Token(Token = "0x40007AB")]
  [FieldOffset(Offset = "0x20")]
  public Vector2[] uvs;
  [Token(Token = "0x40007AC")]
  [FieldOffset(Offset = "0x28")]
  private int triangleIndex;

  [Token(Token = "0x600066C")]
  [Address(RVA = "0x49FE50", Offset = "0x49EA50", Length = "0xD2")]
  public MeshData(int meshWidth, int meshHeight)
  {
  }

  [Token(Token = "0x600066D")]
  [Address(RVA = "0x49FD40", Offset = "0x49E940", Length = "0x65")]
  public void AddTriangle(int a, int b, int c)
  {
  }

  [Token(Token = "0x600066E")]
  [Address(RVA = "0x49FDB0", Offset = "0x49E9B0", Length = "0x91")]
  public Mesh CreateMesh() => (Mesh) null;
}
