// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Steam.LeaderboardEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Steamworks;

namespace Assets.Scripts.Steam
{
  [Token(Token = "0x200030B")]
  public class LeaderboardEntry
  {
    [Token(Token = "0x40014B5")]
    [FieldOffset(Offset = "0x10")]
    public LeaderboardEntry_t leaderboardEntry;
    [Token(Token = "0x40014B6")]
    [FieldOffset(Offset = "0x30")]
    public int[] details;

    [Token(Token = "0x60015DB")]
    [Address(RVA = "0x3AAFC0", Offset = "0x3A9BC0", Length = "0x4D")]
    public LeaderboardEntry(LeaderboardEntry_t leaderboardEntry, int[] details)
    {
    }

    [Token(Token = "0x60015DC")]
    [Address(RVA = "0x3AAF60", Offset = "0x3A9B60", Length = "0x5D")]
    public ECharacter GetCharacter() => new ECharacter();
  }
}
