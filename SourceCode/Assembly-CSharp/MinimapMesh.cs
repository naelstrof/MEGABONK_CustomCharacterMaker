// Decompiled with JetBrains decompiler
// Type: MinimapMesh
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000F0")]
public class MinimapMesh : MonoBehaviour
{
  [Token(Token = "0x40007AD")]
  [FieldOffset(Offset = "0x20")]
  public MeshRenderer meshRenderer;
  [Token(Token = "0x40007AE")]
  [FieldOffset(Offset = "0x28")]
  public MeshFilter meshFilter;

  [Token(Token = "0x6000674")]
  [Address(RVA = "0x4A0590", Offset = "0x49F190", Length = "0x102")]
  public void Set(Mesh mesh, Color fogColor)
  {
  }

  [Token(Token = "0x6000675")]
  [Address(RVA = "0x4A0500", Offset = "0x49F100", Length = "0x88")]
  private Color GetSaturatedColor(Color color) => new Color();

  [Token(Token = "0x6000676")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MinimapMesh()
  {
  }
}
