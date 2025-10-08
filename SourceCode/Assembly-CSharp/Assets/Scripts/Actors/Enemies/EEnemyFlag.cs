// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Actors.Enemies.EEnemyFlag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Assets.Scripts.Actors.Enemies
{
  [Flags]
  [Token(Token = "0x2000452")]
  public enum EEnemyFlag
  {
    [Token(Token = "0x4001C27")] None = 0,
    [Token(Token = "0x4001C28")] Elite = 1,
    [Token(Token = "0x4001C29")] Boss = 2,
    [Token(Token = "0x4001C2A")] StageBoss = 4,
    [Token(Token = "0x4001C2B")] Challenge = 8,
    [Token(Token = "0x4001C2C")] SummonerMiniboss = 16, // 0x00000010
    [Token(Token = "0x4001C2D")] FinalBoss = 32, // 0x00000020
    [Token(Token = "0x4001C2E")] AnyBoss = FinalBoss | SummonerMiniboss | StageBoss | Boss, // 0x00000036
  }
}
