// Decompiled with JetBrains decompiler
// Type: MapDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000E9")]
public class MapDisplay : MonoBehaviour
{
  [Token(Token = "0x4000791")]
  [FieldOffset(Offset = "0x20")]
  public Renderer textureRender;
  [Token(Token = "0x4000792")]
  [FieldOffset(Offset = "0x28")]
  public MeshFilter meshFilter;
  [Token(Token = "0x4000793")]
  [FieldOffset(Offset = "0x30")]
  public MeshRenderer meshRenderer;
  [Token(Token = "0x4000794")]
  [FieldOffset(Offset = "0x38")]
  public MeshCollider meshCollider;

  [Token(Token = "0x600065C")]
  [Address(RVA = "0x49E3D0", Offset = "0x49CFD0", Length = "0xEA")]
  public void DrawTexture(Texture2D texture)
  {
  }

  [Token(Token = "0x600065D")]
  [Address(RVA = "0x49E2E0", Offset = "0x49CEE0", Length = "0xEF")]
  public void DrawMesh(MeshData meshData)
  {
  }

  [Token(Token = "0x600065E")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MapDisplay()
  {
  }
}
