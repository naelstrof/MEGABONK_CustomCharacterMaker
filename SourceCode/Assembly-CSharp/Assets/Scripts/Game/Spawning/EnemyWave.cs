// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Spawning.EnemyWave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Spawning
{
  [Token(Token = "0x200040E")]
  [Serializable]
  public class EnemyWave
  {
    [Token(Token = "0x4001A8E")]
    [FieldOffset(Offset = "0x10")]
    public EWaveType eWaveType;
    [Token(Token = "0x4001A8F")]
    [FieldOffset(Offset = "0x18")]
    public List<EEnemy> enemies;
    [Token(Token = "0x4001A90")]
    [FieldOffset(Offset = "0x20")]
    public List<EnemyData> enemyDatas;
    [Token(Token = "0x4001A91")]
    [FieldOffset(Offset = "0x28")]
    public int waveTime;
    [Token(Token = "0x4001A92")]
    [FieldOffset(Offset = "0x2C")]
    public int minNumEnemies;
    [Token(Token = "0x4001A93")]
    [FieldOffset(Offset = "0x30")]
    public float spawnInterval;

    [Token(Token = "0x6001D2D")]
    [Address(RVA = "0x420190", Offset = "0x41ED90", Length = "0xA7")]
    public override string ToString() => (string) null;

    [Token(Token = "0x6001D2E")]
    [Address(RVA = "0x420180", Offset = "0x41ED80", Length = "0xE")]
    public float EnemiesPerSecond() => 0.0f;

    [Token(Token = "0x6001D2F")]
    [Address(RVA = "0x420240", Offset = "0x41EE40", Length = "0x1C")]
    public EnemyWave()
    {
    }
  }
}
