// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.MapGeneration.ProceduralTiles.Maze
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.MapGeneration.ProceduralTiles
{
  [Token(Token = "0x2000347")]
  public static class Maze
  {
    [Token(Token = "0x40016A4")]
    public static readonly Dictionary<int, int> Opposite;
    [Token(Token = "0x40016A5")]
    public static readonly (Vector2Int direction, int dirValue)[] DirectionsWithVectors;

    [Token(Token = "0x6001780")]
    [Address(RVA = "0x3CEE60", Offset = "0x3CDA60", Length = "0x663")]
    public static NodeTree Generate(int width, int height, int seed) => (NodeTree) null;

    [Token(Token = "0x6001781")]
    [Address(RVA = "0x3CF500", Offset = "0x3CE100", Length = "0xE")]
    private static int ToIndex(Vector2Int position, int width) => 0;

    [Token(Token = "0x6001782")]
    [Address(RVA = "0x3CF510", Offset = "0x3CE110", Length = "0x1D")]
    private static Vector2Int ToPosition(int index, int width) => new Vector2Int();

    [Token(Token = "0x6001783")]
    [Address(RVA = "0x3CF4D0", Offset = "0x3CE0D0", Length = "0x23")]
    private static bool IsValidPosition(Vector2Int position, int width, int height) => false;

    [Token(Token = "0x6001784")]
    [Address(RVA = "0x712180", Offset = "0x710D80", Length = "0x129")]
    private static List<T> Shuffle<T>(List<T> list, System.Random rand) => (List<T>) null;

    [Token(Token = "0x6001785")]
    [Address(RVA = "0x3CF530", Offset = "0x3CE130", Length = "0x29E")]
    static Maze()
    {
    }

    [Token(Token = "0x2000348")]
    public static class Directions
    {
      [Token(Token = "0x40016A6")]
      public const int TOP = 1;
      [Token(Token = "0x40016A7")]
      public const int RIGHT = 2;
      [Token(Token = "0x40016A8")]
      public const int BOTTOM = 4;
      [Token(Token = "0x40016A9")]
      public const int LEFT = 8;
    }
  }
}
