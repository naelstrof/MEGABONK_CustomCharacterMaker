// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Weapons.EnemyTargeting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Weapons
{
  [Token(Token = "0x2000366")]
  public static class EnemyTargeting
  {
    [Token(Token = "0x400173A")]
    private static int currentBufferCount;
    [Token(Token = "0x400173B")]
    private static Collider[] enemyBuffer;
    [Token(Token = "0x400173C")]
    private static RaycastHit[] losBuf;
    [Token(Token = "0x400173D")]
    private static EnemyScanContainer currentBufferContainer;
    [Token(Token = "0x400173E")]
    private static readonly Dictionary<Type, Collider[]> buffers;

    [Token(Token = "0x6001841")]
    [Address(RVA = "0x3E55D0", Offset = "0x3E41D0", Length = "0x112")]
    public static void Init()
    {
    }

    [Token(Token = "0x6001842")]
    [Address(RVA = "0x3E3D10", Offset = "0x3E2910", Length = "0x112")]
    public static void Cleanup()
    {
    }

    [Token(Token = "0x6001843")]
    [Address(RVA = "0x3E56F0", Offset = "0x3E42F0", Length = "0x70")]
    private static void Reset()
    {
    }

    [Token(Token = "0x6001844")]
    [Address(RVA = "0x3E41C0", Offset = "0x3E2DC0", Length = "0x220")]
    public static int GetEnemiesInRadiusSafe(
      object owner,
      Vector3 pos,
      float range,
      out Collider[] buffer)
    {
      buffer = (Collider[]) null;
      return 0;
    }

    [Token(Token = "0x6001845")]
    [Address(RVA = "0x3E46E0", Offset = "0x3E32E0", Length = "0x3C0")]
    public static Enemy GetEnemy(
      Vector3 position,
      float range,
      int projectileIndex,
      bool useVision,
      GameObject exceptObject)
    {
      return (Enemy) null;
    }

    [Token(Token = "0x6001846")]
    [Address(RVA = "0x3E43F0", Offset = "0x3E2FF0", Length = "0x2E8")]
    public static int GetEnemiesInRadius(Vector3 position, float range, out Collider[] enemies)
    {
      enemies = (Collider[]) null;
      return 0;
    }

    [Token(Token = "0x6001847")]
    [Address(RVA = "0x3E5450", Offset = "0x3E4050", Length = "0x176")]
    private static Enemy GetTargetedEnemy(
      Collider[] colliders,
      int count,
      Vector3 pos,
      bool useVision,
      GameObject exceptObject)
    {
      return (Enemy) null;
    }

    [Token(Token = "0x6001848")]
    [Address(RVA = "0x3E4DF0", Offset = "0x3E39F0", Length = "0x653")]
    private static Enemy GetSmartEnemy(
      Collider[] colliders,
      int count,
      Vector3 pos,
      bool useVision,
      GameObject exceptObject)
    {
      return (Enemy) null;
    }

    [Token(Token = "0x6001849")]
    [Address(RVA = "0x3E3E30", Offset = "0x3E2A30", Length = "0x384")]
    private static Enemy GetClosestEnemy(
      Collider[] colliders,
      int count,
      Vector3 pos,
      bool useVision,
      GameObject exceptObject)
    {
      return (Enemy) null;
    }

    [Token(Token = "0x600184A")]
    [Address(RVA = "0x3E4AB0", Offset = "0x3E36B0", Length = "0x33C")]
    private static Enemy GetRandomEnemy(
      Collider[] colliders,
      int count,
      Vector3 pos,
      bool useVision,
      GameObject exceptObject)
    {
      return (Enemy) null;
    }

    [Token(Token = "0x600184B")]
    [Address(RVA = "0x3E5770", Offset = "0x3E4370", Length = "0x96")]
    private static bool ShouldPickRandom(int idx, float ratio) => false;

    [Token(Token = "0x600184C")]
    [Address(RVA = "0x3E5810", Offset = "0x3E4410", Length = "0x14D")]
    static EnemyTargeting()
    {
    }
  }
}
