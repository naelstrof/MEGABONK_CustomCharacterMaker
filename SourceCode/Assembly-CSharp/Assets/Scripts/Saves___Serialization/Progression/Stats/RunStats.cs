// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.Stats.RunStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Saves___Serialization.Progression.Stats
{
  [Token(Token = "0x200032F")]
  public static class RunStats
  {
    [Token(Token = "0x40015A6")]
    private static Dictionary<string, float> stats;
    [Token(Token = "0x40015A7")]
    public static Dictionary<string, DamageSource> damageSources;
    [Token(Token = "0x40015A8")]
    public static List<MyAchievement> achievements;
    [Token(Token = "0x40015A9")]
    public static Action<string, float> A_StatChange;

    [Token(Token = "0x6001690")]
    [Address(RVA = "0x3DBAA0", Offset = "0x3DA6A0", Length = "0x236")]
    public static void Init()
    {
    }

    [Token(Token = "0x6001691")]
    [Address(RVA = "0x3DB700", Offset = "0x3DA300", Length = "0x236")]
    public static void Cleanup()
    {
    }

    [Token(Token = "0x6001692")]
    [Address(RVA = "0x3DBEC0", Offset = "0x3DAAC0", Length = "0x1D7")]
    private static void OnNewRun()
    {
    }

    [Token(Token = "0x6001693")]
    [Address(RVA = "0x3DC0A0", Offset = "0x3DACA0", Length = "0x1A6")]
    private static void Reset()
    {
    }

    [Token(Token = "0x6001694")]
    [Address(RVA = "0x3DB4B0", Offset = "0x3DA0B0", Length = "0x83")]
    public static void AddValue(EMyStat stat, int value)
    {
    }

    [Token(Token = "0x6001695")]
    [Address(RVA = "0x3DB940", Offset = "0x3DA540", Length = "0x75")]
    public static int GetStat(EMyStat stat) => 0;

    [Token(Token = "0x6001696")]
    [Address(RVA = "0x3DB540", Offset = "0x3DA140", Length = "0x1BA")]
    public static void AddValue(string stat, int value)
    {
    }

    [Token(Token = "0x6001697")]
    [Address(RVA = "0x3DB9C0", Offset = "0x3DA5C0", Length = "0xD4")]
    public static int GetStat(string stat) => 0;

    [Token(Token = "0x6001698")]
    [Address(RVA = "0x3DB3E0", Offset = "0x3D9FE0", Length = "0xCE")]
    public static void AddAchievement(MyAchievement achievement)
    {
    }

    [Token(Token = "0x6001699")]
    [Address(RVA = "0x3DBCE0", Offset = "0x3DA8E0", Length = "0x1D8")]
    private static void OnEnemyDamaged(Enemy enemy, DamageContainer dc)
    {
    }

    [Token(Token = "0x600169A")]
    [Address(RVA = "0x3DC250", Offset = "0x3DAE50", Length = "0x148")]
    static RunStats()
    {
    }
  }
}
