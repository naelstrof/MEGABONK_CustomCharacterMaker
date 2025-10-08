// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Steam.SteamLeaderboardsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Menu.Shop.Leaderboards;
using Cpp2ILInjected;
using Steamworks;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Steam
{
  [Token(Token = "0x200030D")]
  public static class SteamLeaderboardsManager
  {
    [Token(Token = "0x40014B8")]
    public const string categoryKills = "kills";
    [Token(Token = "0x40014B9")]
    public const string categorySpeedrun = "speedrun";
    [Token(Token = "0x40014BA")]
    public const string groupGlobal = "global";
    [Token(Token = "0x40014BB")]
    public const string groupFriends = "friends";
    [Token(Token = "0x40014BC")]
    public static string lbKillsGlobal;
    [Token(Token = "0x40014BD")]
    public static string lbKillsFriends;
    [Token(Token = "0x40014BE")]
    private static string[] leaderboardNames;
    [Token(Token = "0x40014BF")]
    public static Dictionary<string, LeaderboardContainer> leaderboards;
    [Token(Token = "0x40014C0")]
    public static Action<string> A_LeaderboardScoreDownloaded;
    [Token(Token = "0x40014C1")]
    public static Action<string> A_LeaderboardScoreDownloadedLocal;
    [Token(Token = "0x40014C2")]
    private static Dictionary<string, CallResult<LeaderboardFindResult_t>> leaderboardFindResults;
    [Token(Token = "0x40014C3")]
    private static Dictionary<string, CallResult<LeaderboardScoresDownloaded_t>> leaderboardScoresDownloadedResults;
    [Token(Token = "0x40014C4")]
    private static Dictionary<string, CallResult<LeaderboardScoresDownloaded_t>> leaderboardScoresDownloadedLocalResults;
    [Token(Token = "0x40014C5")]
    private static Dictionary<string, CallResult<LeaderboardScoreUploaded_t>> leaderboardScoreUploadResults;
    [Token(Token = "0x40014C6")]
    public static Action<string> A_LeaderboardScoreUploaded;

    [Token(Token = "0x60015E6")]
    [Address(RVA = "0x3B9430", Offset = "0x3B8030", Length = "0x1C1")]
    public static void Init()
    {
    }

    [Token(Token = "0x60015E7")]
    [Address(RVA = "0x3BA8A0", Offset = "0x3B94A0", Length = "0x13C")]
    public static void TryFindAllLeaderboards()
    {
    }

    [Token(Token = "0x60015E8")]
    [Address(RVA = "0x3B91D0", Offset = "0x3B7DD0", Length = "0x11B")]
    public static void FindLeaderboard(string leaderboardName)
    {
    }

    [Token(Token = "0x60015E9")]
    [Address(RVA = "0x3BA9E0", Offset = "0x3B95E0", Length = "0x3FD")]
    public static void UpdateLeaderboard(string leaderboardName)
    {
    }

    [Token(Token = "0x60015EA")]
    [Address(RVA = "0x3BADE0", Offset = "0x3B99E0", Length = "0x3A7")]
    public static void UploadLeaderboardScore(
      string leaderboardName,
      int score,
      int[] details,
      ELeaderboardCategory category)
    {
    }

    [Token(Token = "0x60015EB")]
    [Address(RVA = "0x3B9600", Offset = "0x3B8200", Length = "0x1EF")]
    private static void LeaderboardFound(LeaderboardFindResult_t param, bool biofailure)
    {
    }

    [Token(Token = "0x60015EC")]
    [Address(RVA = "0x3B9F70", Offset = "0x3B8B70", Length = "0x449")]
    private static void LeaderboardScoresDownloaded(
      LeaderboardScoresDownloaded_t param,
      bool biofailure)
    {
    }

    [Token(Token = "0x60015ED")]
    [Address(RVA = "0x3B9990", Offset = "0x3B8590", Length = "0x5D3")]
    private static void LeaderboardScoresDownloadedLocal(
      LeaderboardScoresDownloaded_t param,
      bool biofailure)
    {
    }

    [Token(Token = "0x60015EE")]
    [Address(RVA = "0x3B97F0", Offset = "0x3B83F0", Length = "0x193")]
    private static void LeaderboardScoreUploaded(LeaderboardScoreUploaded_t param, bool biofailure)
    {
    }

    [Token(Token = "0x60015EF")]
    [Address(RVA = "0x3B92F0", Offset = "0x3B7EF0", Length = "0x138")]
    public static bool HasLocalScore(string leaderboardName) => false;

    [Token(Token = "0x60015F0")]
    [Address(RVA = "0x3BA3C0", Offset = "0x3B8FC0", Length = "0x4D1")]
    public static void OnDestroy()
    {
    }

    [Token(Token = "0x60015F1")]
    [Address(RVA = "0x3BB190", Offset = "0x3B9D90", Length = "0x2C9")]
    static SteamLeaderboardsManager()
    {
    }
  }
}
