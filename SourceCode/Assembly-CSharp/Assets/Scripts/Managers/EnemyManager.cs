// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Managers.EnemyManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Game.Spawning.New;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Managers
{
  [Token(Token = "0x2000356")]
  public class EnemyManager : MonoBehaviour
  {
    [Token(Token = "0x40016BF")]
    [FieldOffset(Offset = "0x20")]
    public EnemyData testEnemy;
    [Token(Token = "0x40016C0")]
    [FieldOffset(Offset = "0x28")]
    public Dictionary<uint, Enemy> enemies;
    [Token(Token = "0x40016C1")]
    [FieldOffset(Offset = "0x30")]
    public Dictionary<Collider, Enemy> collidersToEnemies;
    [Token(Token = "0x40016C2")]
    [FieldOffset(Offset = "0x38")]
    public Dictionary<GameObject, Enemy> gameobjectsToEnemies;
    [Token(Token = "0x40016C3")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<int, int> waveEnemies;
    [Token(Token = "0x40016C4")]
    [FieldOffset(Offset = "0x48")]
    private uint id;
    [Token(Token = "0x40016C5")]
    public static EnemyManager Instance;
    [Token(Token = "0x40016C6")]
    [FieldOffset(Offset = "0x4C")]
    public bool enabledWaves;
    [Token(Token = "0x40016C7")]
    [FieldOffset(Offset = "0x50")]
    public SummonerController summonerController;
    [Token(Token = "0x40016C8")]
    [FieldOffset(Offset = "0x58")]
    private List<Enemy> stageBosses;
    [Token(Token = "0x40016C9")]
    public static Action A_StageBossDied;
    [Token(Token = "0x40016CB")]
    public static int maxNumEnemiesPooled;
    [Token(Token = "0x40016CC")]
    [FieldOffset(Offset = "0x64")]
    public int numEnemies;
    [Token(Token = "0x40016CD")]
    [FieldOffset(Offset = "0x68")]
    private float nextDebuffTickTime;
    [Token(Token = "0x40016CE")]
    [FieldOffset(Offset = "0x6C")]
    private float zoomValue;
    [Token(Token = "0x40016CF")]
    [FieldOffset(Offset = "0x70")]
    private float currentValue;
    [Token(Token = "0x40016D0")]
    [FieldOffset(Offset = "0x74")]
    private bool started;

    [Token(Token = "0x60017AB")]
    [Address(RVA = "0x3CA9B0", Offset = "0x3C95B0", Length = "0x224")]
    private void Awake()
    {
    }

    [Token(Token = "0x60017AC")]
    [Address(RVA = "0x3CBEB0", Offset = "0x3CAAB0", Length = "0x5C")]
    private void Start()
    {
    }

    [Token(Token = "0x60017AD")]
    [Address(RVA = "0x3CB220", Offset = "0x3C9E20", Length = "0x1C3")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60017AE")]
    [Address(RVA = "0x3CBCB0", Offset = "0x3CA8B0", Length = "0x13B")]
    public Enemy SpawnEnemy(
      EnemyData enemyData,
      int summonerId,
      bool forceSpawn,
      EEnemyFlag flag = EEnemyFlag.None,
      bool useDirectionBias = true)
    {
      return (Enemy) null;
    }

    [Token(Token = "0x60017AF")]
    [Address(RVA = "0x3CB7E0", Offset = "0x3CA3E0", Length = "0x4CC")]
    public Enemy SpawnEnemy(
      EnemyData enemyData,
      Vector3 pos,
      int waveNumber,
      bool forceSpawn = false,
      EEnemyFlag flag = EEnemyFlag.None,
      bool canBeElite = true)
    {
      return (Enemy) null;
    }

    [Token(Token = "0x60017B0")]
    [Address(RVA = "0x3CB5F0", Offset = "0x3CA1F0", Length = "0x1EB")]
    public Enemy SpawnBoss(EEnemy eEnemy, int summonerId, EEnemyFlag enemyFlag, Vector3 pos) => (Enemy) null;

    [Token(Token = "0x60017B1")]
    [Address(RVA = "0x3CB3F0", Offset = "0x3C9FF0", Length = "0x1F9")]
    public void RemoveEnemy(Enemy enemy)
    {
    }

    [Token(Token = "0x60017B2")]
    [Address(RVA = "0x3CBDF0", Offset = "0x3CA9F0", Length = "0xB9")]
    private void StageBossDied()
    {
    }

    [field: Token(Token = "0x40016CA")]
    [field: FieldOffset(Offset = "0x60")]
    [Token(Token = "0x17000381")]
    public bool stageBossIsDead { [Token(Token = "0x60017B3"), Address(RVA = "0x371820", Offset = "0x370420", Length = "0x5")] get; [Token(Token = "0x60017B4"), Address(RVA = "0x371830", Offset = "0x370430", Length = "0x4")] private set; }

    [Token(Token = "0x60017B5")]
    [Address(RVA = "0x3CABE0", Offset = "0x3C97E0", Length = "0x1B")]
    public bool CanSpawnEnemy() => false;

    [Token(Token = "0x60017B6")]
    [Address(RVA = "0x3CB1E0", Offset = "0x3C9DE0", Length = "0x1B")]
    public bool HasMaxEnemies() => false;

    [Token(Token = "0x60017B7")]
    [Address(RVA = "0x3CB150", Offset = "0x3C9D50", Length = "0x83")]
    public int GetNumMaxEnemies() => 0;

    [Token(Token = "0x60017B8")]
    [Address(RVA = "0x3CB140", Offset = "0x3C9D40", Length = "0x4")]
    public int GetNumEnemies() => 0;

    [Token(Token = "0x60017B9")]
    [Address(RVA = "0x3CAF40", Offset = "0x3C9B40", Length = "0x85")]
    public int GetEnemiesFromSummoner(int wave) => 0;

    [Token(Token = "0x60017BA")]
    [Address(RVA = "0x3CB200", Offset = "0x3C9E00", Length = "0x13")]
    public bool IsFinalSwarm() => false;

    [Token(Token = "0x60017BB")]
    [Address(RVA = "0x3CBF10", Offset = "0x3CAB10", Length = "0x131")]
    private void Update()
    {
    }

    [Token(Token = "0x60017BC")]
    [Address(RVA = "0x3CAC00", Offset = "0x3C9800", Length = "0x335")]
    private void FixedUpdate()
    {
    }

    [Token(Token = "0x60017BD")]
    [Address(RVA = "0x3CAFD0", Offset = "0x3C9BD0", Length = "0xD6")]
    public bool GetEnemy(Collider collider, out Enemy enemy)
    {
      enemy = (Enemy) null;
      return false;
    }

    [Token(Token = "0x60017BE")]
    [Address(RVA = "0x3CB0B0", Offset = "0x3C9CB0", Length = "0x87")]
    public bool GetEnemy(GameObject enemyObject, out Enemy enemy)
    {
      enemy = (Enemy) null;
      return false;
    }

    [Token(Token = "0x60017BF")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    private void TestSpawnEnemy()
    {
    }

    [Token(Token = "0x60017C0")]
    [Address(RVA = "0x3CC090", Offset = "0x3CAC90", Length = "0x18F")]
    public EnemyManager()
    {
    }

    [Token(Token = "0x60017C1")]
    [Address(RVA = "0x3CC050", Offset = "0x3CAC50", Length = "0x3A")]
    static EnemyManager()
    {
    }
  }
}
