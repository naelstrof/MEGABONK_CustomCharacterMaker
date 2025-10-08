// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Spawning.New.Timelines.TimelineEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Spawning.New.Timelines
{
  [Token(Token = "0x2000418")]
  [Serializable]
  public class TimelineEvent
  {
    [Token(Token = "0x4001ADA")]
    [FieldOffset(Offset = "0x10")]
    public ETimelineEvent eTimelineEvent;
    [Token(Token = "0x4001ADB")]
    [FieldOffset(Offset = "0x18")]
    public List<EEnemy> enemies;
    [Token(Token = "0x4001ADC")]
    [FieldOffset(Offset = "0x20")]
    public float timeMinutes;
    [Token(Token = "0x4001ADD")]
    [FieldOffset(Offset = "0x24")]
    public float duration;

    [Token(Token = "0x6001D79")]
    [Address(RVA = "0x43A210", Offset = "0x438E10", Length = "0x24")]
    public float GetTimeSeconds() => 0.0f;

    [Token(Token = "0x6001D7A")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public TimelineEvent()
    {
    }
  }
}
