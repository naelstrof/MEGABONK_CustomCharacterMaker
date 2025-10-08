// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Steam.SteamStatsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Stats;
using Cpp2ILInjected;
using Steamworks;
using System.Collections.Generic;

namespace Assets.Scripts.Steam
{
  [Token(Token = "0x2000310")]
  public static class SteamStatsManager
  {
    [Token(Token = "0x40014D3")]
    public static bool areStatsReady;
    [Token(Token = "0x40014D4")]
    private static Callback<UserStatsReceived_t> m_UserStatsReceived;
    [Token(Token = "0x40014D5")]
    private static bool hasQueuedUpload;
    [Token(Token = "0x40014D6")]
    private static float uploadReadyAtTime;
    [Token(Token = "0x40014D7")]
    private static float uploadCooldown;
    [Token(Token = "0x40014D8")]
    private static Dictionary<string, int> cachedStatUpdates;
    [Token(Token = "0x40014D9")]
    private static float setCachedStatsInterval;
    [Token(Token = "0x40014DA")]
    private static float nextSetCachedStatsTime;
    [Token(Token = "0x40014DB")]
    private static bool hasChanges;

    [Token(Token = "0x6001608")]
    [Address(RVA = "0x3BCA00", Offset = "0x3BB600", Length = "0x617")]
    public static void Init()
    {
    }

    [Token(Token = "0x6001609")]
    [Address(RVA = "0x3BD020", Offset = "0x3BBC20", Length = "0x4F3")]
    public static void OnDestroy()
    {
    }

    [Token(Token = "0x600160A")]
    [Address(RVA = "0x3BD7D0", Offset = "0x3BC3D0", Length = "0x7")]
    public static void RequestStats()
    {
    }

    [Token(Token = "0x600160B")]
    [Address(RVA = "0x3BD760", Offset = "0x3BC360", Length = "0x6E")]
    private static void QueueUpload()
    {
    }

    [Token(Token = "0x600160C")]
    [Address(RVA = "0x3BDBF0", Offset = "0x3BC7F0", Length = "0x2CB")]
    private static void Update()
    {
    }

    [Token(Token = "0x600160D")]
    [Address(RVA = "0x3BDA10", Offset = "0x3BC610", Length = "0x1D2")]
    private static void TryUploadStats()
    {
    }

    [Token(Token = "0x600160E")]
    [Address(RVA = "0x3BD520", Offset = "0x3BC120", Length = "0x99")]
    private static void OnStatUpdated(string arg1, MyStat arg2)
    {
    }

    [Token(Token = "0x600160F")]
    [Address(RVA = "0x3BD7E0", Offset = "0x3BC3E0", Length = "0x225")]
    private static void SetCachedStats()
    {
    }

    [Token(Token = "0x6001610")]
    [Address(RVA = "0x3BD5C0", Offset = "0x3BC1C0", Length = "0x195")]
    private static void OnUserStatsReceived(UserStatsReceived_t param)
    {
    }

    [Token(Token = "0x6001611")]
    [Address(RVA = "0x3BDEC0", Offset = "0x3BCAC0", Length = "0xD7")]
    static SteamStatsManager()
    {
    }
  }
}
