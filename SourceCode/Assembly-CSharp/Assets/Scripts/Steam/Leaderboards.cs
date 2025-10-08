// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Steam.Leaderboards
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Menu.Shop.Leaderboards;
using Cpp2ILInjected;

namespace Assets.Scripts.Steam
{
  [Token(Token = "0x200030C")]
  public class Leaderboards
  {
    [Token(Token = "0x40014B7")]
    public static int numMaxDeatils;

    [Token(Token = "0x60015DD")]
    [Address(RVA = "0x3ABB50", Offset = "0x3AA750", Length = "0x9E0")]
    public static void UploadScore(int score, ELeaderboardCategory category)
    {
    }

    [Token(Token = "0x60015DE")]
    [Address(RVA = "0x3AB920", Offset = "0x3AA520", Length = "0x225")]
    private static int[] GetWeapons() => (int[]) null;

    [Token(Token = "0x60015DF")]
    [Address(RVA = "0x3AB710", Offset = "0x3AA310", Length = "0x20F")]
    private static int[] GetTomes() => (int[]) null;

    [Token(Token = "0x60015E0")]
    [Address(RVA = "0x3AB630", Offset = "0x3AA230", Length = "0x22")]
    public static ECharacter GetCharacter(int[] details) => new ECharacter();

    [Token(Token = "0x60015E1")]
    [Address(RVA = "0x3AB010", Offset = "0x3A9C10", Length = "0x3A3")]
    public static bool CanShowScore(int score, int[] leaderboardDetails, out string s)
    {
      s = (string) null;
      return false;
    }

    [Token(Token = "0x60015E2")]
    [Address(RVA = "0x3AB660", Offset = "0x3AA260", Length = "0xAE")]
    private static string GetSecretKey() => (string) null;

    [Token(Token = "0x60015E3")]
    [Address(RVA = "0x3AB3C0", Offset = "0x3A9FC0", Length = "0x269")]
    private static int[] GenerateScoreHash(int score) => (int[]) null;

    [Token(Token = "0x60015E4")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public Leaderboards()
    {
    }

    [Token(Token = "0x60015E5")]
    [Address(RVA = "0x3AC540", Offset = "0x3AB140", Length = "0x39")]
    static Leaderboards()
    {
    }
  }
}
