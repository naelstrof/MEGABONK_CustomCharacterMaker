// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Spawning.New.Timelines.StageTimeline
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Spawning.New.Timelines
{
  [Token(Token = "0x2000416")]
  [Serializable]
  public class StageTimeline
  {
    [Token(Token = "0x4001AD2")]
    [FieldOffset(Offset = "0x10")]
    public float stageTime;
    [Token(Token = "0x4001AD3")]
    [FieldOffset(Offset = "0x14")]
    public float checkNewEnemyInterval;
    [Token(Token = "0x4001AD4")]
    [FieldOffset(Offset = "0x18")]
    public List<EEnemy> startEnemies;
    [Token(Token = "0x4001AD5")]
    [FieldOffset(Offset = "0x20")]
    public List<TimelineEvent> events;
    [Token(Token = "0x4001AD6")]
    [FieldOffset(Offset = "0x28")]
    public EnemyData boss;
    [Token(Token = "0x4001AD7")]
    [FieldOffset(Offset = "0x30")]
    public List<EEnemy> minibosses;

    [Token(Token = "0x6001D73")]
    [Address(RVA = "0x437F60", Offset = "0x436B60", Length = "0x52")]
    public float GetStageTime() => 0.0f;

    [Token(Token = "0x6001D74")]
    [Address(RVA = "0x437FC0", Offset = "0x436BC0", Length = "0x11B")]
    public void Sort()
    {
    }

    [Token(Token = "0x6001D75")]
    [Address(RVA = "0x4380E0", Offset = "0x436CE0", Length = "0x15")]
    public StageTimeline()
    {
    }
  }
}
