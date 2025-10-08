// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Spawning.SpawnPositions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Game.Spawning
{
  [Token(Token = "0x2000410")]
  public static class SpawnPositions
  {
    [Token(Token = "0x4001A99")]
    public static Vector3 INVALID_POS;
    [Token(Token = "0x4001A9A")]
    private static float lastFoundSpawnBounds;
    [Token(Token = "0x4001A9B")]
    private static float minX;
    [Token(Token = "0x4001A9C")]
    private static float minZ;
    [Token(Token = "0x4001A9D")]
    private static float maxX;
    [Token(Token = "0x4001A9E")]
    private static float maxZ;

    [Token(Token = "0x6001D30")]
    [Address(RVA = "0x436430", Offset = "0x435030", Length = "0xEF")]
    public static Vector3 GetEnemySpawnPosition(
      EnemyData enemyData,
      int attempts = 50,
      bool useDirectionBias = true)
    {
      return new Vector3();
    }

    [Token(Token = "0x6001D31")]
    [Address(RVA = "0x435F90", Offset = "0x434B90", Length = "0x498")]
    public static Vector3 GetEnemySpawnPositionTest(EnemyData enemyData, int attempts = 50) => new Vector3();

    [Token(Token = "0x6001D32")]
    [Address(RVA = "0x436DA0", Offset = "0x4359A0", Length = "0xAE")]
    private static void GetSpawnDistances(out float min, out float max)
    {
      min = new float();
      max = new float();
    }

    [Token(Token = "0x6001D33")]
    [Address(RVA = "0x434910", Offset = "0x433510", Length = "0x243")]
    private static void FindBounds()
    {
    }

    [Token(Token = "0x6001D34")]
    [Address(RVA = "0x435430", Offset = "0x434030", Length = "0xB51")]
    private static Vector3 GetEnemySpawnPositionBiased(
      EnemyData enemyData,
      float playerDirectionBias,
      int attempts = 50)
    {
      return new Vector3();
    }

    [Token(Token = "0x6001D35")]
    [Address(RVA = "0x434FF0", Offset = "0x433BF0", Length = "0x436")]
    public static Vector3 GetEnemySpawnPositionAroundPoint(
      Vector3 pos,
      float minRadius,
      float maxRadius,
      int attempts = 50,
      bool onlyGround = false,
      float fromHeight = 999f)
    {
      return new Vector3();
    }

    [Token(Token = "0x6001D36")]
    [Address(RVA = "0x436F70", Offset = "0x435B70", Length = "0x1F9")]
    private static Vector3 SampleBiasedDirection(Vector3 biasedTowards, float bias) => new Vector3();

    [Token(Token = "0x6001D37")]
    [Address(RVA = "0x436B70", Offset = "0x435770", Length = "0x77")]
    private static Vector3 GetPlayerMovementDirection() => new Vector3();

    [Token(Token = "0x6001D38")]
    [Address(RVA = "0x436520", Offset = "0x435120", Length = "0x64C")]
    public static Vector3 GetObjectSpawnPosition(
      Vector3 center,
      Vector3 size,
      float checkRadius,
      int layerMask,
      out Vector3 normal,
      int attempts = 50,
      bool onlyUseGroundLayer = true,
      bool debug = false,
      bool canSpawnInWater = false,
      float maxSlopeAngle = 44f,
      float extraRayFromHeight = 0.0f)
    {
      normal = new Vector3();
      return new Vector3();
    }

    [Token(Token = "0x6001D39")]
    [Address(RVA = "0x434B60", Offset = "0x433760", Length = "0x48B")]
    public static RaycastHit FindHitClosestToPlayerY(
      RaycastHit[] hits,
      out bool foundPosition,
      bool canChooseObject = true)
    {
      foundPosition = new bool();
      return new RaycastHit();
    }

    [Token(Token = "0x6001D3A")]
    [Address(RVA = "0x436E50", Offset = "0x435A50", Length = "0x112")]
    public static Vector3 PredictPlayerPosition(float time) => new Vector3();

    [Token(Token = "0x6001D3B")]
    [Address(RVA = "0x436BF0", Offset = "0x4357F0", Length = "0x1A5")]
    public static Vector3 GetRandomSpawnPositionOnMap(float extraHeight = 0.0f) => new Vector3();

    [Token(Token = "0x6001D3C")]
    [Address(RVA = "0x437170", Offset = "0x435D70", Length = "0x4A")]
    static SpawnPositions()
    {
    }
  }
}
