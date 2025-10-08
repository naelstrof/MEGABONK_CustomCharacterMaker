// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Spawning.New.Summoners.SwarmSummoner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Spawning.New.Summoners
{
  [Token(Token = "0x200041D")]
  public class SwarmSummoner : BaseSummoner
  {
    [Token(Token = "0x4001AE2")]
    [FieldOffset(Offset = "0x68")]
    private List<EEnemy> finalSwarmEnemies;
    [Token(Token = "0x4001AE3")]
    [FieldOffset(Offset = "0x70")]
    private bool hasSwappedEnemy;
    [Token(Token = "0x4001AE4")]
    [FieldOffset(Offset = "0x78")]
    private List<Enemy> spawnedEnemies;
    [Token(Token = "0x4001AE5")]
    [FieldOffset(Offset = "0x80")]
    private float swarmHpMultiplier;
    [Token(Token = "0x4001AE6")]
    [FieldOffset(Offset = "0x84")]
    private float swarmSpeedMultiplier;

    [Token(Token = "0x6001DA6")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void Init()
    {
    }

    [Token(Token = "0x6001DA7")]
    [Address(RVA = "0x4539A0", Offset = "0x4525A0", Length = "0x128")]
    protected override void TickExtra()
    {
    }

    [Token(Token = "0x6001DA8")]
    [Address(RVA = "0x453520", Offset = "0x452120", Length = "0x5F")]
    protected override List<EEnemy> GetEnemies() => (List<EEnemy>) null;

    [Token(Token = "0x6001DA9")]
    [Address(RVA = "0x453700", Offset = "0x452300", Length = "0x9")]
    public override float GetSummonInterval() => 0.0f;

    [Token(Token = "0x6001DAA")]
    [Address(RVA = "0x453360", Offset = "0x451F60", Length = "0x1BF")]
    public override float GetBaseCreditsPerSecond() => 0.0f;

    [Token(Token = "0x6001DAB")]
    [Address(RVA = "0x3573F0", Offset = "0x355FF0", Length = "0x4")]
    public override float GetInitialCredits() => 0.0f;

    [Token(Token = "0x6001DAC")]
    [Address(RVA = "0x453580", Offset = "0x452180", Length = "0x17F")]
    public override int GetNumTargetEnemies() => 0;

    [Token(Token = "0x6001DAD")]
    [Address(RVA = "0x375D80", Offset = "0x374980", Length = "0x3")]
    protected override bool UseDirectionBias() => false;

    [Token(Token = "0x6001DAE")]
    [Address(RVA = "0x453710", Offset = "0x452310", Length = "0x28A")]
    public override List<Enemy> SpendCredits(bool useWeights = true) => (List<Enemy>) null;

    [Token(Token = "0x6001DAF")]
    [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
    protected override bool ForceSpawn() => false;

    [Token(Token = "0x6001DB0")]
    [Address(RVA = "0x453AD0", Offset = "0x4526D0", Length = "0x165")]
    public SwarmSummoner(int id, List<EEnemy> defaultEnemies)
      : base(0, (List<EEnemy>) null)
    {
    }
  }
}
