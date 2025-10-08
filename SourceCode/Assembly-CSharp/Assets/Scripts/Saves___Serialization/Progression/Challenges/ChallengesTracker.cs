// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.Challenges.ChallengesTracker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Saves___Serialization.Progression.Challenges
{
  [Token(Token = "0x2000332")]
  public class ChallengesTracker
  {
    [Token(Token = "0x40015B4")]
    public const string MODIFIER_NO_MOVEMENT = "no_movement";
    [Token(Token = "0x40015B5")]
    public const string MODIFIER_NO_ITEMS = "no_items";
    [Token(Token = "0x40015B6")]
    public const string MODIFIER_NO_WEAPONS = "no_weapons";
    [Token(Token = "0x40015B7")]
    private static ChallengeWinCondition winCondition;
    [Token(Token = "0x40015B8")]
    public static ChallengeModifier[] challengeModifiers;
    [Token(Token = "0x40015B9")]
    private static HashSet<string> modifierNames;
    [Token(Token = "0x40015BA")]
    public const float silverAddPerChallenge = 0.01f;
    [Token(Token = "0x40015BB")]
    private static bool victory;
    [Token(Token = "0x40015BC")]
    public static Action<ChallengeData> A_ChallengeCompleted;

    [Token(Token = "0x60016BE")]
    [Address(RVA = "0x3C92E0", Offset = "0x3C7EE0", Length = "0x41C")]
    public static void Init()
    {
    }

    [Token(Token = "0x60016BF")]
    [Address(RVA = "0x3C8B50", Offset = "0x3C7750", Length = "0x448")]
    public static void Cleanup()
    {
    }

    [Token(Token = "0x60016C0")]
    [Address(RVA = "0x3C9E50", Offset = "0x3C8A50", Length = "0x559")]
    private static void OnNewRunStarted()
    {
    }

    [Token(Token = "0x60016C1")]
    [Address(RVA = "0x3CA6D0", Offset = "0x3C92D0", Length = "0xF7")]
    public static void Tick()
    {
    }

    [Token(Token = "0x60016C2")]
    [Address(RVA = "0x3C8970", Offset = "0x3C7570", Length = "0x1DB")]
    private static void CleanupChallengeModifiers()
    {
    }

    [Token(Token = "0x60016C3")]
    [Address(RVA = "0x3C8FA0", Offset = "0x3C7BA0", Length = "0x14B")]
    public static void CompleteChallenge()
    {
    }

    [Token(Token = "0x60016C4")]
    [Address(RVA = "0x3C9160", Offset = "0x3C7D60", Length = "0x79")]
    public static bool HasChallengeModifier(string internalName) => false;

    [Token(Token = "0x60016C5")]
    [Address(RVA = "0x3C90F0", Offset = "0x3C7CF0", Length = "0x66")]
    public static List<string> GetChallengeModifiers() => (List<string>) null;

    [Token(Token = "0x60016C6")]
    [Address(RVA = "0x3C98D0", Offset = "0x3C84D0", Length = "0x570")]
    private static void OnInventoryInitialized(PlayerInventory pinv)
    {
    }

    [Token(Token = "0x60016C7")]
    [Address(RVA = "0x3C91E0", Offset = "0x3C7DE0", Length = "0xF0")]
    public static bool HasChallenge() => false;

    [Token(Token = "0x60016C8")]
    [Address(RVA = "0x3C9700", Offset = "0x3C8300", Length = "0x1C7")]
    private static void OnGameOver()
    {
    }

    [Token(Token = "0x60016C9")]
    [Address(RVA = "0x3CA3B0", Offset = "0x3C8FB0", Length = "0x311")]
    private static void OnStagebossDefeated()
    {
    }

    [Token(Token = "0x60016CA")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public ChallengesTracker()
    {
    }

    [Token(Token = "0x60016CB")]
    [Address(RVA = "0x3CA7D0", Offset = "0x3C93D0", Length = "0x9C")]
    static ChallengesTracker()
    {
    }
  }
}
