// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Spawning.New.Summoners.StageSummoner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Spawning.New.Summoners
{
  [Token(Token = "0x200041C")]
  public class StageSummoner : BaseSummoner
  {
    [Token(Token = "0x4001AE0")]
    [FieldOffset(Offset = "0x68")]
    private List<EEnemy> enemyPool;
    [Token(Token = "0x4001AE1")]
    [FieldOffset(Offset = "0x70")]
    private float capReduction;

    [Token(Token = "0x6001D9A")]
    [Address(RVA = "0x4373D0", Offset = "0x435FD0", Length = "0x3CE")]
    public bool AddEnemyToPoolAndPickNewCard(List<EEnemy> eEnemy, out EEnemy selectedEnemy)
    {
      selectedEnemy = new EEnemy();
      return false;
    }

    [Token(Token = "0x6001D9B")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void Init()
    {
    }

    [Token(Token = "0x6001D9C")]
    [Address(RVA = "0x3992E0", Offset = "0x397EE0", Length = "0x5")]
    protected override List<EEnemy> GetEnemies() => (List<EEnemy>) null;

    [Token(Token = "0x6001D9D")]
    [Address(RVA = "0x437A70", Offset = "0x436670", Length = "0x5A")]
    public override float GetSummonInterval() => 0.0f;

    [Token(Token = "0x6001D9E")]
    [Address(RVA = "0x4377A0", Offset = "0x4363A0", Length = "0x80")]
    public float GetBaseCreditsPerSecondUncapped() => 0.0f;

    [Token(Token = "0x6001D9F")]
    [Address(RVA = "0x437820", Offset = "0x436420", Length = "0xAC")]
    public override float GetBaseCreditsPerSecond() => 0.0f;

    [Token(Token = "0x6001DA0")]
    [Address(RVA = "0x3573F0", Offset = "0x355FF0", Length = "0x4")]
    public override float GetInitialCredits() => 0.0f;

    [Token(Token = "0x6001DA1")]
    [Address(RVA = "0x4378D0", Offset = "0x4364D0", Length = "0x190")]
    public override int GetNumTargetEnemies() => 0;

    [Token(Token = "0x6001DA2")]
    [Address(RVA = "0x375D80", Offset = "0x374980", Length = "0x3")]
    protected override bool UseDirectionBias() => false;

    [Token(Token = "0x6001DA3")]
    [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
    protected override bool ForceSpawn() => false;

    [Token(Token = "0x6001DA4")]
    [Address(RVA = "0x437AD0", Offset = "0x4366D0", Length = "0x91")]
    private bool IsTargetEnemiesReached() => false;

    [Token(Token = "0x6001DA5")]
    [Address(RVA = "0x437B70", Offset = "0x436770", Length = "0x3ED")]
    public StageSummoner(int id, List<EEnemy> defaultEnemies)
      : base(0, (List<EEnemy>) null)
    {
    }
  }
}
