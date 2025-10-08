// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.SaveFiles.StatsSaveFile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Assets.Scripts.Saves___Serialization.Progression;
using Assets.Scripts.Saves___Serialization.Progression.Stats;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Saves___Serialization.SaveFiles
{
  [Token(Token = "0x2000320")]
  [Serializable]
  public class StatsSaveFile
  {
    [Token(Token = "0x4001548")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<string, MyStat> stats;
    [Token(Token = "0x4001549")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<EEnemy, EnemyLog> enemyLogs;

    [Token(Token = "0x600164F")]
    [Address(RVA = "0x3B82E0", Offset = "0x3B6EE0", Length = "0x39C")]
    public void Init()
    {
    }

    [Token(Token = "0x6001650")]
    [Address(RVA = "0x3B8680", Offset = "0x3B7280", Length = "0xBD")]
    public StatsSaveFile()
    {
    }
  }
}
