// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Spawning.New.SummonerController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Game.Spawning.New.Summoners;
using Assets.Scripts.Game.Spawning.New.Timelines;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Game.Spawning.New
{
  [Token(Token = "0x2000414")]
  public class SummonerController
  {
    [Token(Token = "0x4001ABA")]
    [FieldOffset(Offset = "0x10")]
    public StageSummoner stageSummoner;
    [Token(Token = "0x4001ABB")]
    [FieldOffset(Offset = "0x18")]
    private SpecialSkeletonSummoner specialSkeletonSummoner;
    [Token(Token = "0x4001ABC")]
    [FieldOffset(Offset = "0x20")]
    private BaseSummoner swarmSummoner;
    [Token(Token = "0x4001ABD")]
    [FieldOffset(Offset = "0x28")]
    private BaseSummoner finalSwarmSummoner;
    [Token(Token = "0x4001ABE")]
    [FieldOffset(Offset = "0x30")]
    private List<BaseSummoner> summoners;
    [Token(Token = "0x4001ABF")]
    [FieldOffset(Offset = "0x38")]
    private int id;
    [Token(Token = "0x4001AC0")]
    [FieldOffset(Offset = "0x3C")]
    private int currentTimelineEvent;
    [Token(Token = "0x4001AC1")]
    [FieldOffset(Offset = "0x40")]
    private StageTimeline timeline;
    [Token(Token = "0x4001AC2")]
    public static Action A_SwarmStarted;
    [Token(Token = "0x4001AC3")]
    public static Action A_FinalSwarmStarted;
    [Token(Token = "0x4001AC4")]
    public static Action A_MiniBoss;
    [Token(Token = "0x4001AC5")]
    [FieldOffset(Offset = "0x48")]
    private float lastAddedNewEnemyTime;
    [Token(Token = "0x4001AC6")]
    [FieldOffset(Offset = "0x4C")]
    private bool hadEventThisTick;
    [Token(Token = "0x4001AC7")]
    [FieldOffset(Offset = "0x50")]
    private float swarmOverAtTime;
    [Token(Token = "0x4001AC9")]
    [FieldOffset(Offset = "0x58")]
    private List<EEnemy> minibossPool;
    [Token(Token = "0x4001ACA")]
    [FieldOffset(Offset = "0x60")]
    private bool isFinalSwarmStarted;
    [Token(Token = "0x4001ACB")]
    [FieldOffset(Offset = "0x64")]
    private float bossDeadGracePeriod;
    [Token(Token = "0x4001ACC")]
    [FieldOffset(Offset = "0x68")]
    private bool isFinalBossDead;
    [Token(Token = "0x4001ACD")]
    [FieldOffset(Offset = "0x69")]
    private bool areSummonersDestroyed;

    [Token(Token = "0x6001D60")]
    [Address(RVA = "0x439EB0", Offset = "0x438AB0", Length = "0x330")]
    public SummonerController()
    {
    }

    [Token(Token = "0x6001D61")]
    [Address(RVA = "0x439970", Offset = "0x438570", Length = "0x13B")]
    public void Tick()
    {
    }

    [Token(Token = "0x6001D62")]
    [Address(RVA = "0x438CC0", Offset = "0x4378C0", Length = "0x5D")]
    public float GetMaxTimeLength() => 0.0f;

    [Token(Token = "0x6001D63")]
    [Address(RVA = "0x439540", Offset = "0x438140", Length = "0x428")]
    private void TickTimeline()
    {
    }

    [Token(Token = "0x6001D64")]
    [Address(RVA = "0x439AB0", Offset = "0x4386B0", Length = "0x21C")]
    private void TryAddNewEnemyCard()
    {
    }

    [Token(Token = "0x6001D65")]
    [Address(RVA = "0x439170", Offset = "0x437D70", Length = "0x23D")]
    public void StartEvent(int eventIndex)
    {
    }

    [Token(Token = "0x6001D66")]
    [Address(RVA = "0x438B30", Offset = "0x437730", Length = "0x180")]
    private void EventSwarm(TimelineEvent timelineEvent)
    {
    }

    [field: Token(Token = "0x4001AC8")]
    [field: FieldOffset(Offset = "0x54")]
    [Token(Token = "0x1700038B")]
    public int minibossCount { [Token(Token = "0x6001D67"), Address(RVA = "0x43A1F0", Offset = "0x438DF0", Length = "0x4")] get; [Token(Token = "0x6001D68"), Address(RVA = "0x43A200", Offset = "0x438E00", Length = "0x4")] private set; }

    [Token(Token = "0x6001D69")]
    [Address(RVA = "0x438420", Offset = "0x437020", Length = "0x703")]
    public void EventMiniboss(TimelineEvent timelineEvent)
    {
    }

    [Token(Token = "0x6001D6A")]
    [Address(RVA = "0x4381B0", Offset = "0x436DB0", Length = "0x19")]
    private bool CanAddNewEnemyCard() => false;

    [Token(Token = "0x6001D6B")]
    [Address(RVA = "0x371820", Offset = "0x370420", Length = "0x5")]
    public bool IsFinalSwarm() => false;

    [Token(Token = "0x6001D6C")]
    [Address(RVA = "0x4393B0", Offset = "0x437FB0", Length = "0x181")]
    private void StartFinalSwarm()
    {
    }

    [Token(Token = "0x6001D6D")]
    [Address(RVA = "0x438100", Offset = "0x436D00", Length = "0xAA")]
    private void AddSummoner(BaseSummoner summoner)
    {
    }

    [Token(Token = "0x6001D6E")]
    [Address(RVA = "0x4383B0", Offset = "0x436FB0", Length = "0x62")]
    private void DestroySummoner(BaseSummoner summoner)
    {
    }

    [Token(Token = "0x6001D6F")]
    [Address(RVA = "0x438E70", Offset = "0x437A70", Length = "0x2F8")]
    public List<Enemy> SpawnStageBoss(Vector3 pos) => (List<Enemy>) null;

    [Token(Token = "0x6001D70")]
    [Address(RVA = "0x438D20", Offset = "0x437920", Length = "0x149")]
    private void OnBossDied(bool isLastStage)
    {
    }

    [Token(Token = "0x6001D71")]
    [Address(RVA = "0x439CD0", Offset = "0x4388D0", Length = "0x1D0")]
    private void TryStopSummoners()
    {
    }

    [Token(Token = "0x6001D72")]
    [Address(RVA = "0x4381D0", Offset = "0x436DD0", Length = "0x1D3")]
    public void Cleanup()
    {
    }
  }
}
