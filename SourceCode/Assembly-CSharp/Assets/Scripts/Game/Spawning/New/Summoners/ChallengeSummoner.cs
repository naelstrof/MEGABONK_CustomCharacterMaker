// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Spawning.New.Summoners.ChallengeSummoner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Game.Spawning.New.Summoners
{
  [Token(Token = "0x200041A")]
  public class ChallengeSummoner : BaseSummoner
  {
    [Token(Token = "0x4001ADE")]
    [FieldOffset(Offset = "0x68")]
    private List<EEnemy> enemyPool;
    [Token(Token = "0x4001ADF")]
    [FieldOffset(Offset = "0x70")]
    private Vector3 pos;

    [Token(Token = "0x6001D84")]
    [Address(RVA = "0x41EF00", Offset = "0x41DB00", Length = "0x96")]
    public ChallengeSummoner(int id, List<EEnemy> defaultEnemies)
      : base(0, (List<EEnemy>) null)
    {
    }

    [Token(Token = "0x6001D85")]
    [Address(RVA = "0x41E8A0", Offset = "0x41D4A0", Length = "0x345")]
    protected override void Init()
    {
    }

    [Token(Token = "0x6001D86")]
    [Address(RVA = "0x41EBF0", Offset = "0x41D7F0", Length = "0x28")]
    public List<Enemy> SpawnEnemies(bool onlyElites, Vector3 position) => (List<Enemy>) null;

    [Token(Token = "0x6001D87")]
    [Address(RVA = "0x41EC20", Offset = "0x41D820", Length = "0x2D4")]
    public override List<Enemy> SpendCredits(bool useWeights = true) => (List<Enemy>) null;

    [Token(Token = "0x6001D88")]
    [Address(RVA = "0x41E7E0", Offset = "0x41D3E0", Length = "0x5")]
    protected override List<EEnemy> GetEnemies() => (List<EEnemy>) null;

    [Token(Token = "0x6001D89")]
    [Address(RVA = "0x3573F0", Offset = "0x355FF0", Length = "0x4")]
    public override float GetSummonInterval() => 0.0f;

    [Token(Token = "0x6001D8A")]
    [Address(RVA = "0x3573F0", Offset = "0x355FF0", Length = "0x4")]
    public override float GetBaseCreditsPerSecond() => 0.0f;

    [Token(Token = "0x6001D8B")]
    [Address(RVA = "0x41E7F0", Offset = "0x41D3F0", Length = "0x9A")]
    public override float GetInitialCredits() => 0.0f;

    [Token(Token = "0x6001D8C")]
    [Address(RVA = "0x41E890", Offset = "0x41D490", Length = "0x6")]
    public override int GetNumTargetEnemies() => 0;

    [Token(Token = "0x6001D8D")]
    [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
    protected override bool UseDirectionBias() => false;

    [Token(Token = "0x6001D8E")]
    [Address(RVA = "0x375D80", Offset = "0x374980", Length = "0x3")]
    protected override bool ForceSpawn() => false;
  }
}
