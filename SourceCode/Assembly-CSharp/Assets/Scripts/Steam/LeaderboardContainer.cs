// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Steam.LeaderboardContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Steamworks;
using System.Collections.Generic;

namespace Assets.Scripts.Steam
{
  [Token(Token = "0x200030A")]
  public class LeaderboardContainer
  {
    [Token(Token = "0x40014B1")]
    [FieldOffset(Offset = "0x10")]
    public int numEntries;
    [Token(Token = "0x40014B2")]
    [FieldOffset(Offset = "0x18")]
    public SteamLeaderboard_t leaderboardHandle;
    [Token(Token = "0x40014B3")]
    [FieldOffset(Offset = "0x20")]
    public List<LeaderboardEntry> globalEntries;
    [Token(Token = "0x40014B4")]
    [FieldOffset(Offset = "0x28")]
    public LeaderboardEntry localEntry;

    [Token(Token = "0x60015DA")]
    [Address(RVA = "0x3AAF30", Offset = "0x3A9B30", Length = "0x26")]
    public LeaderboardContainer(SteamLeaderboard_t handle)
    {
    }
  }
}
