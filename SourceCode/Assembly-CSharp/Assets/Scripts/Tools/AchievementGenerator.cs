// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Tools.AchievementGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data;
using Assets.Scripts._Data.Progression;
using Assets.Scripts.Saves___Serialization.Progression;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

namespace Assets.Scripts.Tools
{
  [Token(Token = "0x2000306")]
  public class AchievementGenerator : MonoBehaviour
  {
    [Token(Token = "0x4001480")]
    [FieldOffset(Offset = "0x20")]
    public LocalizedString stageBossLocalizedKey;
    [Token(Token = "0x4001481")]
    [FieldOffset(Offset = "0x28")]
    public LocalizedString tierLocalizedKey;
    [Token(Token = "0x4001482")]
    [FieldOffset(Offset = "0x30")]
    public LocalizedString finalBossLocalizedKey;
    [Token(Token = "0x4001483")]
    [FieldOffset(Offset = "0x38")]
    public LocalizedString rankLocalizedKey;
    [Token(Token = "0x4001484")]
    [FieldOffset(Offset = "0x40")]
    public LocalizedString localizedKills;
    [Token(Token = "0x4001485")]
    [FieldOffset(Offset = "0x48")]
    public LocalizedString localizedLevel;
    [Token(Token = "0x4001486")]
    [FieldOffset(Offset = "0x50")]
    public LocalizedString localizedFinalBoss;
    [Token(Token = "0x4001487")]
    [FieldOffset(Offset = "0x58")]
    public LocalizedString localizedSpeedrun;
    [Token(Token = "0x4001488")]
    [FieldOffset(Offset = "0x60")]
    public LocalizedString localizedGold;
    [Token(Token = "0x4001489")]
    [FieldOffset(Offset = "0x68")]
    public DataManager dataManager;
    [Token(Token = "0x400148A")]
    private static Dictionary<(ECharacter, ESkinType), string> skinAchievementNameCache;

    [Token(Token = "0x60015BB")]
    [Address(RVA = "0x3A2890", Offset = "0x3A1490", Length = "0x2C")]
    private string GetPath() => (string) null;

    [Token(Token = "0x60015BC")]
    [Address(RVA = "0x3A2A90", Offset = "0x3A1690", Length = "0x14")]
    public static int GetSkinAchValue(ESkinType skinType) => 0;

    [Token(Token = "0x60015BD")]
    [Address(RVA = "0x3A28C0", Offset = "0x3A14C0", Length = "0x1B4")]
    private string GetSkinAchValueStat(ESkinType skinType, ECharacter character) => (string) null;

    [Token(Token = "0x60015BE")]
    [Address(RVA = "0x3A24D0", Offset = "0x3A10D0", Length = "0x38")]
    private LocalizedString GetLocalizedDescription(ESkinType skinType) => (LocalizedString) null;

    [Token(Token = "0x60015BF")]
    [Address(RVA = "0x3A2520", Offset = "0x3A1120", Length = "0xB0")]
    private List<LocalizationKey> GetLocalizedKeys(ESkinType skinType, CharacterData characterData) => (List<LocalizationKey>) null;

    [Token(Token = "0x60015C0")]
    [Address(RVA = "0x3A2AF0", Offset = "0x3A16F0", Length = "0x252")]
    public static string GetSkinAchievementName(ECharacter character, ESkinType skinType) => (string) null;

    [Token(Token = "0x60015C1")]
    [Address(RVA = "0x3A2D50", Offset = "0x3A1950", Length = "0x15")]
    private static EAchievementDifficulty GetSkinDifficulty(ESkinType skinType) => new EAchievementDifficulty();

    [Token(Token = "0x60015C2")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public AchievementGenerator()
    {
    }

    [Token(Token = "0x60015C3")]
    [Address(RVA = "0x3A2D70", Offset = "0x3A1970", Length = "0x84")]
    static AchievementGenerator()
    {
    }
  }
}
