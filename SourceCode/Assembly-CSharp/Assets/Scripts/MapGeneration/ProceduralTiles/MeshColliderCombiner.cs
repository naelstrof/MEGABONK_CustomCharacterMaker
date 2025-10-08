// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.MapGeneration.ProceduralTiles.MeshColliderCombiner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.MapGeneration.ProceduralTiles
{
  [Token(Token = "0x2000353")]
  public class MeshColliderCombiner
  {
    [Token(Token = "0x600179E")]
    [Address(RVA = "0x3CFC10", Offset = "0x3CE810", Length = "0x699")]
    public static GameObject CombineMeshes(List<GameObject> pieces) => (GameObject) null;

    [Token(Token = "0x600179F")]
    [Address(RVA = "0x3CF7D0", Offset = "0x3CE3D0", Length = "0x43D")]
    private static void AutoWeld(Mesh mesh, float threshold)
    {
    }

    [Token(Token = "0x60017A0")]
    [Address(RVA = "0x3D02B0", Offset = "0x3CEEB0", Length = "0x873")]
    private static void SimplifyMesh(Mesh mesh)
    {
    }

    [Token(Token = "0x60017A1")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public MeshColliderCombiner()
    {
    }
  }
}
