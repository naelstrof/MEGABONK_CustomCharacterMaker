// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.LogUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Cpp2ILInjected;

namespace Assets.Scripts.Saves___Serialization.Progression
{
  [Token(Token = "0x2000327")]
  public static class LogUtility
  {
    [Token(Token = "0x400155E")]
    public static int numMaxChallenges;

    [Token(Token = "0x600165C")]
    [Address(RVA = "0x3ADDC0", Offset = "0x3AC9C0", Length = "0x83")]
    public static int GetNumMaxEntries() => 0;

    [Token(Token = "0x600165D")]
    [Address(RVA = "0x3ADE50", Offset = "0x3ACA50", Length = "0x36F")]
    public static int GetNumUnlockedEntries() => 0;

    [Token(Token = "0x600165E")]
    [Address(RVA = "0x3AE770", Offset = "0x3AD370", Length = "0xC4")]
    public static bool IsEntryUnlocked(EEnemy enemy) => false;

    [Token(Token = "0x600165F")]
    [Address(RVA = "0x3AD9D0", Offset = "0x3AC5D0", Length = "0x293")]
    public static void GetChallengeProgress(
      EEnemy eEnemy,
      out float currentChallengeProgress,
      out int numChallengesClaimed,
      out int numKills,
      out int numKillsForNextChallengeTier)
    {
      currentChallengeProgress = new float();
      numChallengesClaimed = new int();
      numKills = new int();
      numKillsForNextChallengeTier = new int();
    }

    [Token(Token = "0x6001660")]
    [Address(RVA = "0x3AE6A0", Offset = "0x3AD2A0", Length = "0xCD")]
    public static bool HasUnclaimedReward(EEnemy eEnemy) => false;

    [Token(Token = "0x6001661")]
    [Address(RVA = "0x3AE290", Offset = "0x3ACE90", Length = "0x30F")]
    public static bool HasAnyUnclaimedReward() => false;

    [Token(Token = "0x6001662")]
    [Address(RVA = "0x3AE5A0", Offset = "0x3AD1A0", Length = "0xF7")]
    public static bool HasClaimedAllRewards(EEnemy eEnemy) => false;

    [Token(Token = "0x6001663")]
    [Address(RVA = "0x3ADC70", Offset = "0x3AC870", Length = "0x14C")]
    public static int GetNumChallengeKills(EEnemy eEnemy, int tier) => 0;

    [Token(Token = "0x6001664")]
    [Address(RVA = "0x3AE1C0", Offset = "0x3ACDC0", Length = "0xC5")]
    public static int GetReward(EEnemy eEnemy) => 0;

    [Token(Token = "0x6001665")]
    [Address(RVA = "0x3AE840", Offset = "0x3AD440", Length = "0x39")]
    static LogUtility()
    {
    }
  }
}
