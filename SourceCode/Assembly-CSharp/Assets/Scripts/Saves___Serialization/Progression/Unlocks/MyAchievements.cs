// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.Unlocks.MyAchievements
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.Progression;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Assets.Scripts.Saves___Serialization.Progression.Stats;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Saves___Serialization.Progression.Unlocks
{
  [Token(Token = "0x2000333")]
  public static class MyAchievements
  {
    [Token(Token = "0x40015BD")]
    public static bool testUnlockEverything;
    [Token(Token = "0x40015BE")]
    private static bool hasUnsavedChanges;
    [Token(Token = "0x40015BF")]
    public static Action<MyAchievement> A_Unlocked;
    [Token(Token = "0x40015C0")]
    public static Action<string> A_TryUnlock;
    [Token(Token = "0x40015C1")]
    private static Dictionary<string, List<MyAchievement>> statTrackers;
    [Token(Token = "0x40015C2")]
    private static bool startedTracking;
    [Token(Token = "0x40015C3")]
    public static int fakeCharacters;
    [Token(Token = "0x40015C4")]
    public static int fakeWeapons;
    [Token(Token = "0x40015C5")]
    public static int fakeItems;
    [Token(Token = "0x40015C6")]
    public static int fakeMaps;
    [Token(Token = "0x40015C7")]
    public static int fakeTomes;
    [Token(Token = "0x40015C8")]
    public static int fakeAchievements;
    [Token(Token = "0x40015C9")]
    private static HashSet<MyStat> queuedStatNames;
    [Token(Token = "0x40015CA")]
    private static float statTrackersCooldown;
    [Token(Token = "0x40015CB")]
    private static float nextStatTrackersCheck;
    [Token(Token = "0x40015CC")]
    private static float nextSaveTimeReady;
    [Token(Token = "0x40015CD")]
    private static float saveCooldown;

    [Token(Token = "0x60016CC")]
    [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
    public static bool IsTestUnlockEverything() => false;

    [Token(Token = "0x60016CD")]
    [Address(RVA = "0x3D2820", Offset = "0x3D1420", Length = "0x555")]
    public static void Init()
    {
    }

    [Token(Token = "0x60016CE")]
    [Address(RVA = "0x3D1F50", Offset = "0x3D0B50", Length = "0x52D")]
    public static void Cleanup()
    {
    }

    [Token(Token = "0x60016CF")]
    [Address(RVA = "0x3D3ED0", Offset = "0x3D2AD0", Length = "0x4C0")]
    private static void TryStartStatTracking()
    {
    }

    [Token(Token = "0x60016D0")]
    [Address(RVA = "0x3D43A0", Offset = "0x3D2FA0", Length = "0x23B")]
    public static bool TryUnlock(string unlockName) => false;

    [Token(Token = "0x60016D1")]
    [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
    private static bool AreAchievementsDisabled() => false;

    [Token(Token = "0x60016D2")]
    [Address(RVA = "0x3D3DF0", Offset = "0x3D29F0", Length = "0xD4")]
    private static void OnStatUpdated(string statName, MyStat stat)
    {
    }

    [Token(Token = "0x60016D3")]
    [Address(RVA = "0x3D45E0", Offset = "0x3D31E0", Length = "0x643")]
    public static void Update()
    {
    }

    [Token(Token = "0x60016D4")]
    [Address(RVA = "0x3D2D80", Offset = "0x3D1980", Length = "0xDA")]
    public static bool IsAchievementDone(string achName) => false;

    [Token(Token = "0x60016D5")]
    [Address(RVA = "0x3D1E20", Offset = "0x3D0A20", Length = "0x121")]
    public static bool CheckAchievementValue(string achievementName, int value) => false;

    [Token(Token = "0x60016D6")]
    [Address(RVA = "0x3D24E0", Offset = "0x3D10E0", Length = "0x5A")]
    public static int GetAchievementTargetValue(string achName) => 0;

    [Token(Token = "0x60016D7")]
    [Address(RVA = "0x3D2480", Offset = "0x3D1080", Length = "0x5C")]
    public static float GetAchievementTargetValueFloat(string achName) => 0.0f;

    [Token(Token = "0x60016D8")]
    [Address(RVA = "0x3D3430", Offset = "0x3D2030", Length = "0x523")]
    public static bool IsUnlocked(UnlockableBase unlockable, out string requirementsString)
    {
      requirementsString = (string) null;
      return false;
    }

    [Token(Token = "0x60016D9")]
    [Address(RVA = "0x3D3380", Offset = "0x3D1F80", Length = "0xAC")]
    public static bool IsUnlocked(MyAchievement myAchievement) => false;

    [Token(Token = "0x60016DA")]
    [Address(RVA = "0x3D3330", Offset = "0x3D1F30", Length = "0x49")]
    public static bool IsUnlockedInternalNameAch(string achName) => false;

    [Token(Token = "0x60016DB")]
    [Address(RVA = "0x3D3960", Offset = "0x3D2560", Length = "0xDA")]
    private static bool IsUnlocked(string unlockName) => false;

    [Token(Token = "0x60016DC")]
    [Address(RVA = "0x3D3200", Offset = "0x3D1E00", Length = "0x12F")]
    public static bool IsPurchased(UnlockableBase unlockable) => false;

    [Token(Token = "0x60016DD")]
    [Address(RVA = "0x3D2FF0", Offset = "0x3D1BF0", Length = "0x207")]
    public static bool IsAvailable(UnlockableBase unlockable) => false;

    [Token(Token = "0x60016DE")]
    [Address(RVA = "0x3D2E60", Offset = "0x3D1A60", Length = "0x186")]
    public static bool IsActivated(UnlockableBase unlockable) => false;

    [Token(Token = "0x60016DF")]
    [Address(RVA = "0x3D1C80", Offset = "0x3D0880", Length = "0x195")]
    public static bool CanToggleActivation(UnlockableBase unlockable) => false;

    [Token(Token = "0x60016E0")]
    [Address(RVA = "0x3D3DA0", Offset = "0x3D29A0", Length = "0x4F")]
    private static void OnProgressionSaved()
    {
    }

    [Token(Token = "0x60016E1")]
    [Address(RVA = "0x3D3D60", Offset = "0x3D2960", Length = "0x40")]
    private static void OnProgressionLoaded()
    {
    }

    [Token(Token = "0x60016E2")]
    [Address(RVA = "0x3D3BE0", Offset = "0x3D27E0", Length = "0x40")]
    private static void OnDataLoaded()
    {
    }

    [Token(Token = "0x60016E3")]
    [Address(RVA = "0x3D3C20", Offset = "0x3D2820", Length = "0x13B")]
    private static void OnPause(bool paused)
    {
    }

    [Token(Token = "0x60016E4")]
    [Address(RVA = "0x3D3A40", Offset = "0x3D2640", Length = "0xA8")]
    public static int NumCompletedAchievements() => 0;

    [Token(Token = "0x60016E5")]
    [Address(RVA = "0x3D3AF0", Offset = "0x3D26F0", Length = "0xE1")]
    public static int NumTotalAchievements() => 0;

    [Token(Token = "0x60016E6")]
    [Address(RVA = "0x3D1AB0", Offset = "0x3D06B0", Length = "0x1CD")]
    public static bool AreAllQuestsCompleted() => false;

    [Token(Token = "0x60016E7")]
    [Address(RVA = "0x3D2540", Offset = "0x3D1140", Length = "0x2D2")]
    public static void GetAchievementTypeProgress(
      EAchievementType achievementType,
      out int completed,
      out int total,
      out int unclaimed)
    {
      completed = new int();
      total = new int();
      unclaimed = new int();
    }

    [Token(Token = "0x60016E8")]
    [Address(RVA = "0x3D4C30", Offset = "0x3D3830", Length = "0x18F")]
    static MyAchievements()
    {
    }
  }
}
