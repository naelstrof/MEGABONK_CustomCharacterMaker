// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.MapGeneration.MapInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.MapGeneration
{
  [Token(Token = "0x2000341")]
  public static class MapInfo
  {
    [Token(Token = "0x4001680")]
    public static Vector3 mapBoundsLower;
    [Token(Token = "0x4001681")]
    public static Vector3 mapBoundsUpper;
    [Token(Token = "0x4001682")]
    public static Vector3 mapCenter;
    [Token(Token = "0x4001683")]
    public static Vector3 mapSize;

    [Token(Token = "0x6001779")]
    [Address(RVA = "0x3CDCF0", Offset = "0x3CC8F0", Length = "0x58")]
    public static float DespawnEnemyHeight() => 0.0f;

    [Token(Token = "0x600177A")]
    [Address(RVA = "0x3CDD50", Offset = "0x3CC950", Length = "0x8C")]
    static MapInfo()
    {
    }
  }
}
