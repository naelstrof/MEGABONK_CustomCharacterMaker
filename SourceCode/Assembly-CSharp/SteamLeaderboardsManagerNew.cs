// Decompiled with JetBrains decompiler
// Type: SteamLeaderboardsManagerNew
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Steam.LeaderboardsNew;
using Cpp2ILInjected;
using Steamworks;
using System.Collections.Generic;

[Token(Token = "0x2000116")]
public static class SteamLeaderboardsManagerNew
{
  [Token(Token = "0x4000851")]
  public const string lbVersion = "v2";
  [Token(Token = "0x4000852")]
  public const string killsLb = "kills";
  [Token(Token = "0x4000853")]
  public const string potatoLb = "potato";
  [Token(Token = "0x4000854")]
  private static List<SteamLeaderboardNew> leaderboardNames;
  [Token(Token = "0x4000855")]
  private static Dictionary<string, SteamLeaderboardNew> lbNameToLeaderboard;
  [Token(Token = "0x4000856")]
  private static Dictionary<string, CallResult<LeaderboardFindResult_t>> leaderboardFindResults;

  [Token(Token = "0x60006F3")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public static void Init()
  {
  }

  [Token(Token = "0x60006F4")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public static void OnDestroy()
  {
  }

  [Token(Token = "0x60006F5")]
  [Address(RVA = "0x4C5A20", Offset = "0x4C4620", Length = "0x11B")]
  public static void FindLeaderboard(string leaderboardName)
  {
  }

  [Token(Token = "0x60006F6")]
  [Address(RVA = "0x4C5B40", Offset = "0x4C4740", Length = "0x1E9")]
  private static void OnLeaderboardFindResult(LeaderboardFindResult_t param, bool bioFailure)
  {
  }

  [Token(Token = "0x60006F7")]
  [Address(RVA = "0x4C5D30", Offset = "0x4C4930", Length = "0x20A")]
  static SteamLeaderboardsManagerNew()
  {
  }
}
