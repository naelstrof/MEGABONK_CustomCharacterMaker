// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Utility.MyColorUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.Progression;
using Assets.Scripts.Game.Combat;
using Assets.Scripts.Inventory__Items__Pickups;
using Assets.Scripts.Inventory__Items__Pickups.Items;
using Assets.Scripts.Inventory__Items__Pickups.Pickups;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Utility
{
  [Token(Token = "0x20002E2")]
  public static class MyColorUtility
  {
    [Token(Token = "0x4001391")]
    public const string white = "#ffffff";
    [Token(Token = "0x4001392")]
    public static string positiveColorString;
    [Token(Token = "0x4001393")]
    public static string negativeColorString;
    [Token(Token = "0x4001394")]
    public static Color aegisColor;
    [Token(Token = "0x4001395")]
    public static Color weakAegisColor;
    [Token(Token = "0x4001396")]
    public static Color bleedColor;
    [Token(Token = "0x4001397")]
    public static Color tier1Color;
    [Token(Token = "0x4001398")]
    public static Color tier2Color;
    [Token(Token = "0x4001399")]
    public static Color tier3Color;
    [Token(Token = "0x400139A")]
    private static Dictionary<EStatCategory, Color> statCategoryColors;
    [Token(Token = "0x400139B")]
    private static Color hasteColor;
    [Token(Token = "0x400139C")]
    private static Color magnetColor;
    [Token(Token = "0x400139D")]
    private static Color shieldColor;
    [Token(Token = "0x400139E")]
    private static Color timeFreezeColor;
    [Token(Token = "0x400139F")]
    private static Color healthColor;
    [Token(Token = "0x40013A0")]
    private static Color rageColor;
    [Token(Token = "0x40013A1")]
    private static Color stonksColor;
    [Token(Token = "0x40013A2")]
    private static Color newColor;
    [Token(Token = "0x40013A3")]
    private static Color commonColor;
    [Token(Token = "0x40013A4")]
    private static Color uncommonColor;
    [Token(Token = "0x40013A5")]
    private static Color rareColor;
    [Token(Token = "0x40013A6")]
    private static Color epicColor;
    [Token(Token = "0x40013A7")]
    private static Color legendaryColor;
    [Token(Token = "0x40013A8")]
    public static Color interactOutlineColor;
    [Token(Token = "0x40013A9")]
    public static Color interactDisabledOutlineColor;
    [Token(Token = "0x40013AA")]
    public static string requirementCompletedColor;
    [Token(Token = "0x40013AB")]
    public static string requirementMissingColor;
    [Token(Token = "0x40013AC")]
    public static Color evadeColor;
    [Token(Token = "0x40013AD")]
    public static Color evadePhantomColor;
    [Token(Token = "0x40013AE")]
    public static Color critMegaColor;
    [Token(Token = "0x40013AF")]
    public static Color bonkColor;
    [Token(Token = "0x40013B0")]
    public static Color poisonColor;
    [Token(Token = "0x40013B1")]
    public static Color fireColor;
    [Token(Token = "0x40013B2")]
    public static Color executeColor;
    [Token(Token = "0x40013B3")]
    public static Color echoColor;
    [Token(Token = "0x40013B4")]
    public static Color bloodmarkColor;
    [Token(Token = "0x40013B5")]
    private static Color easyColor;
    [Token(Token = "0x40013B6")]
    private static Color mediumColor;
    [Token(Token = "0x40013B7")]
    private static Color hardColor;
    [Token(Token = "0x40013B8")]
    private static Color cookedColor;
    [Token(Token = "0x40013B9")]
    private static Color rankTier1Color;
    [Token(Token = "0x40013BA")]
    private static Color rankTier2Color;
    [Token(Token = "0x40013BB")]
    private static Color rankTier3Color;
    [Token(Token = "0x40013BC")]
    private static Color rankTier4Color;
    [Token(Token = "0x40013BD")]
    private static Color rankTier5Color;
    [Token(Token = "0x40013BE")]
    private static Color rankTier6Color;

    [Token(Token = "0x600151F")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public static void Init()
    {
    }

    [Token(Token = "0x6001520")]
    [Address(RVA = "0x38F440", Offset = "0x38E040", Length = "0x95")]
    public static Color GetStatCategoryColor(EStatCategory statCategory) => new Color();

    [Token(Token = "0x6001521")]
    [Address(RVA = "0x38EBF0", Offset = "0x38D7F0", Length = "0x29")]
    private static Color StringToColor(string s) => new Color();

    [Token(Token = "0x6001522")]
    [Address(RVA = "0x38F610", Offset = "0x38E210", Length = "0x248")]
    public static Color PickupToColor(EPickup ePickup) => new Color();

    [Token(Token = "0x6001523")]
    [Address(RVA = "0x38F880", Offset = "0x38E480", Length = "0x1BC")]
    public static Color RarityToColor(ERarity rarity) => new Color();

    [Token(Token = "0x6001524")]
    [Address(RVA = "0x38F1A0", Offset = "0x38DDA0", Length = "0x210")]
    public static Color GetRarityColorBackground(ERarity rarity) => new Color();

    [Token(Token = "0x6001525")]
    [Address(RVA = "0x38EFB0", Offset = "0x38DBB0", Length = "0x1D8")]
    public static Color GetRarityColorBackground(EItemRarity rarity) => new Color();

    [Token(Token = "0x6001526")]
    [Address(RVA = "0x38EC20", Offset = "0x38D820", Length = "0x188")]
    public static Color GetItemRarityColor(EItemRarity rarity) => new Color();

    [Token(Token = "0x6001527")]
    [Address(RVA = "0x38E8C0", Offset = "0x38D4C0", Length = "0x2A4")]
    public static Color GetDamageEffectColor(EDamageEffect effect) => new Color();

    [Token(Token = "0x6001528")]
    [Address(RVA = "0x38F4E0", Offset = "0x38E0E0", Length = "0x48")]
    public static string GetStatTextColor(bool isPositive) => (string) null;

    [Token(Token = "0x6001529")]
    [Address(RVA = "0x38F3D0", Offset = "0x38DFD0", Length = "0x6E")]
    public static Color GetRedToGreenGradient(float t) => new Color();

    [Token(Token = "0x600152A")]
    [Address(RVA = "0x38EB90", Offset = "0x38D790", Length = "0x52")]
    public static Color GetHealthBarColor(EHpBarColor color) => new Color();

    [Token(Token = "0x600152B")]
    [Address(RVA = "0x38F530", Offset = "0x38E130", Length = "0xDC")]
    public static Color GetTierColor(int tier) => new Color();

    [Token(Token = "0x600152C")]
    [Address(RVA = "0x38EDC0", Offset = "0x38D9C0", Length = "0x54")]
    public static Color GetRankColor(int rank) => new Color();

    [Token(Token = "0x600152D")]
    [Address(RVA = "0x38E760", Offset = "0x38D360", Length = "0x160")]
    public static Color DifficultyToColor(EAchievementDifficulty difficulty) => new Color();

    [Token(Token = "0x600152E")]
    [Address(RVA = "0x38EBF0", Offset = "0x38D7F0", Length = "0x29")]
    public static Color GetHexToColor(string hex) => new Color();

    [Token(Token = "0x600152F")]
    [Address(RVA = "0x38E740", Offset = "0x38D340", Length = "0x1D")]
    public static string ColorToHex(Color color) => (string) null;

    [Token(Token = "0x6001530")]
    [Address(RVA = "0x38FA60", Offset = "0x38E660", Length = "0xD0E")]
    static MyColorUtility()
    {
    }
  }
}
