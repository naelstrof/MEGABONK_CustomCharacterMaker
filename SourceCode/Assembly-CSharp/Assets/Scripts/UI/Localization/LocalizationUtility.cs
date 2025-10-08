// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.Localization.LocalizationUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Assets.Scripts._Data.Progression;
using Assets.Scripts.Inventory__Items__Pickups;
using Assets.Scripts.Inventory__Items__Pickups.Items;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine.Localization;

namespace Assets.Scripts.UI.Localization
{
  [Token(Token = "0x20002F4")]
  public class LocalizationUtility
  {
    [Token(Token = "0x6001564")]
    [Address(RVA = "0x3AD980", Offset = "0x3AC580", Length = "0x48")]
    public static bool IsEnglish() => false;

    [Token(Token = "0x6001565")]
    [Address(RVA = "0x3ACF10", Offset = "0x3ABB10", Length = "0x140")]
    public static string GetLocalizedString(
      string table,
      string key,
      string defaultEnglishString,
      bool useEnglishDefaultIfAvailable = true)
    {
      return (string) null;
    }

    [Token(Token = "0x6001566")]
    [Address(RVA = "0x3AD220", Offset = "0x3ABE20", Length = "0x121")]
    public static string GetLocalizedString(string table, string key) => (string) null;

    [Token(Token = "0x6001567")]
    [Address(RVA = "0x3AD060", Offset = "0x3ABC60", Length = "0x1B2")]
    public static string GetLocalizedString(
      string table,
      string key,
      Dictionary<string, string> smartStrings)
    {
      return (string) null;
    }

    [Token(Token = "0x6001568")]
    [Address(RVA = "0x3ACCA0", Offset = "0x3AB8A0", Length = "0x172")]
    public static string GetLocalizedDamageSource(string source) => (string) null;

    [Token(Token = "0x6001569")]
    [Address(RVA = "0x3AD840", Offset = "0x3AC440", Length = "0x13D")]
    public static bool HasLocalizedString(string table, string key) => false;

    [Token(Token = "0x600156A")]
    [Address(RVA = "0x3ACE20", Offset = "0x3ABA20", Length = "0xEC")]
    public static LocalizedString GetLocalizedStringReference(string table, string key) => (LocalizedString) null;

    [Token(Token = "0x600156B")]
    [Address(RVA = "0x3AD6D0", Offset = "0x3AC2D0", Length = "0x163")]
    public static string GetStatName(EStat stat) => (string) null;

    [Token(Token = "0x600156C")]
    [Address(RVA = "0x3AD430", Offset = "0x3AC030", Length = "0x296")]
    public static string GetStatDesc(EStat stat) => (string) null;

    [Token(Token = "0x600156D")]
    [Address(RVA = "0x3AC660", Offset = "0x3AB260", Length = "0x6B")]
    public static string GetCharacterName(ECharacter character) => (string) null;

    [Token(Token = "0x600156E")]
    [Address(RVA = "0x3AC6D0", Offset = "0x3AB2D0", Length = "0x6D")]
    public static string GetEnemyName(EEnemy enemy) => (string) null;

    [Token(Token = "0x600156F")]
    [Address(RVA = "0x3AD3C0", Offset = "0x3ABFC0", Length = "0x6D")]
    public static string GetRarity(ERarity rarity) => (string) null;

    [Token(Token = "0x6001570")]
    [Address(RVA = "0x3AD350", Offset = "0x3ABF50", Length = "0x6D")]
    public static string GetRarity(EItemRarity rarity) => (string) null;

    [Token(Token = "0x6001571")]
    [Address(RVA = "0x3AC5D0", Offset = "0x3AB1D0", Length = "0x81")]
    public static string GetAchievementType(EAchievementType achievementType) => (string) null;

    [Token(Token = "0x6001572")]
    [Address(RVA = "0x3ACC80", Offset = "0x3AB880", Length = "0x1D")]
    public static string GetLanguageName(Locale locale) => (string) null;

    [Token(Token = "0x6001573")]
    [Address(RVA = "0x3AC740", Offset = "0x3AB340", Length = "0x531")]
    public static string GetLanguageName(string code) => (string) null;

    [Token(Token = "0x6001574")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public LocalizationUtility()
    {
    }
  }
}
