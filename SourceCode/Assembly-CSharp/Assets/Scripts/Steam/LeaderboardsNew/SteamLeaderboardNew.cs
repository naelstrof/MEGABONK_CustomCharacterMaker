// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Steam.LeaderboardsNew.SteamLeaderboardNew
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Steamworks;

namespace Assets.Scripts.Steam.LeaderboardsNew
{
  [Token(Token = "0x2000313")]
  public class SteamLeaderboardNew
  {
    [Token(Token = "0x40014DC")]
    [FieldOffset(Offset = "0x10")]
    public string lbName;
    [Token(Token = "0x40014DD")]
    [FieldOffset(Offset = "0x18")]
    public string lbNamePotato;
    [Token(Token = "0x40014DE")]
    [FieldOffset(Offset = "0x20")]
    public SteamLeaderboard_t lbHandle;
    [Token(Token = "0x40014DF")]
    [FieldOffset(Offset = "0x28")]
    public SteamLeaderboard_t lbPotatoHandle;

    [Token(Token = "0x600161E")]
    [Address(RVA = "0x3B9130", Offset = "0x3B7D30", Length = "0x97")]
    public SteamLeaderboardNew(string name)
    {
    }

    [Token(Token = "0x600161F")]
    [Address(RVA = "0x3B90B0", Offset = "0x3B7CB0", Length = "0x7C")]
    public void SetHandle(SteamLeaderboard_t handle, string lbName)
    {
    }
  }
}
