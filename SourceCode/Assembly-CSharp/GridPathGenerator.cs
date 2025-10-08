// Decompiled with JetBrains decompiler
// Type: GridPathGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000F1")]
public static class GridPathGenerator
{
  [Token(Token = "0x6000677")]
  [Address(RVA = "0x49C4A0", Offset = "0x49B0A0", Length = "0xE2")]
  public static List<Vector2Int> GenerateRandomPath(int size, int pathLength) => (List<Vector2Int>) null;

  [Token(Token = "0x6000678")]
  [Address(RVA = "0x49C590", Offset = "0x49B190", Length = "0x4FE")]
  private static Dictionary<Vector2Int, Vector2Int?> GenerateRandomSpanningTree(int size) => (Dictionary<Vector2Int, Vector2Int?>) null;

  [Token(Token = "0x6000679")]
  [Address(RVA = "0x49C130", Offset = "0x49AD30", Length = "0x369")]
  private static List<Vector2Int> ExtractRandomPathFromTree(
    Dictionary<Vector2Int, Vector2Int?> tree,
    int pathLength)
  {
    return (List<Vector2Int>) null;
  }

  [Token(Token = "0x600067A")]
  [Address(RVA = "0x49CA90", Offset = "0x49B690", Length = "0x1B9")]
  private static List<Vector2Int> GetNeighbors(Vector2Int pos, int size) => (List<Vector2Int>) null;

  [Token(Token = "0x600067B")]
  [Address(RVA = "0x49CC50", Offset = "0x49B850", Length = "0x2AD")]
  private static List<Vector2Int> GetTreeNeighbors(
    Vector2Int node,
    Dictionary<Vector2Int, Vector2Int?> tree)
  {
    return (List<Vector2Int>) null;
  }
}
