// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Steam.SteamAchievementsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Steam
{
  [Token(Token = "0x200030E")]
  public static class SteamAchievementsManager
  {
    [Token(Token = "0x40014C7")]
    public static bool ENABLED;
    [Token(Token = "0x40014C8")]
    private static bool hasQueuedUpload;
    [Token(Token = "0x40014C9")]
    private static float uploadAtTime;

    [Token(Token = "0x60015F2")]
    [Address(RVA = "0x3B88C0", Offset = "0x3B74C0", Length = "0x24A")]
    public static void Init()
    {
    }

    [Token(Token = "0x60015F3")]
    [Address(RVA = "0x3B8B10", Offset = "0x3B7710", Length = "0x24A")]
    public static void OnDestroy()
    {
    }

    [Token(Token = "0x60015F4")]
    [Address(RVA = "0x3B8F90", Offset = "0x3B7B90", Length = "0xDB")]
    private static void Update()
    {
    }

    [Token(Token = "0x60015F5")]
    [Address(RVA = "0x3B8DE0", Offset = "0x3B79E0", Length = "0x197")]
    public static void TryUnlockAchievement(string achievementKey)
    {
    }

    [Token(Token = "0x60015F6")]
    [Address(RVA = "0x3B8D60", Offset = "0x3B7960", Length = "0x7E")]
    private static void QueueUpload()
    {
    }

    [Token(Token = "0x60015F7")]
    [Address(RVA = "0x3B8F80", Offset = "0x3B7B80", Length = "0x7")]
    private static void TryUploadAchievements()
    {
    }

    [Token(Token = "0x60015F8")]
    [Address(RVA = "0x3B8740", Offset = "0x3B7340", Length = "0x17F")]
    public static void CheckAchievements()
    {
    }

    [Token(Token = "0x60015F9")]
    [Address(RVA = "0x3B9070", Offset = "0x3B7C70", Length = "0x36")]
    static SteamAchievementsManager()
    {
    }
  }
}
