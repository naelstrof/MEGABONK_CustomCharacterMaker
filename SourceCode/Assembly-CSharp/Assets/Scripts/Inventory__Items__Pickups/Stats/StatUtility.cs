// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Stats.StatUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Stats
{
  [Token(Token = "0x2000388")]
  public static class StatUtility
  {
    [Token(Token = "0x6001926")]
    [Address(RVA = "0x41A570", Offset = "0x419170", Length = "0xEE")]
    public static string GetUpgradeDescriptionWeapon(
      List<StatModifier> modifiers,
      WeaponData weaponData)
    {
      return (string) null;
    }

    [Token(Token = "0x6001927")]
    [Address(RVA = "0x41A220", Offset = "0x418E20", Length = "0xEE")]
    public static string GetUpgradeDescriptionTome(List<StatModifier> modifiers, TomeData tomeData) => (string) null;

    [Token(Token = "0x6001928")]
    [Address(RVA = "0x41A310", Offset = "0x418F10", Length = "0x259")]
    public static string GetUpgradeDescriptionWeaponModifier(
      StatModifier modifier,
      WeaponData weaponData,
      string color = "#ffffff")
    {
      return (string) null;
    }

    [Token(Token = "0x6001929")]
    [Address(RVA = "0x419F10", Offset = "0x418B10", Length = "0x302")]
    public static string GetUpgradeDescriptionTomeModifier(
      StatModifier modifier,
      TomeData tomeData,
      string color = "#ffffff")
    {
      return (string) null;
    }

    [Token(Token = "0x600192A")]
    [Address(RVA = "0x419CC0", Offset = "0x4188C0", Length = "0x24D")]
    public static string GetUpgradeDescriptionStat(StatModifier modifier, string color = "#ffffff") => (string) null;

    [Token(Token = "0x600192B")]
    [Address(RVA = "0x419620", Offset = "0x418220", Length = "0x114")]
    public static string EncapsulateNumber(string number, string color) => (string) null;

    [Token(Token = "0x600192C")]
    [Address(RVA = "0x419740", Offset = "0x418340", Length = "0x64")]
    public static string EncapsulateNumber(float number, string color) => (string) null;

    [Token(Token = "0x600192D")]
    [Address(RVA = "0x4197B0", Offset = "0x4183B0", Length = "0x35")]
    public static string GetModificationString(StatModifier modifier, bool addOneToMultiplication = true) => (string) null;

    [Token(Token = "0x600192E")]
    [Address(RVA = "0x4197F0", Offset = "0x4183F0", Length = "0x2F9")]
    public static string GetModificationString(
      EStatModifyType modifyType,
      EStat stat,
      float value,
      bool addOneToMultiplication = true,
      bool usePrefix = true)
    {
      return (string) null;
    }

    [Token(Token = "0x600192F")]
    [Address(RVA = "0x41A660", Offset = "0x419260", Length = "0x14B")]
    public static string GetWeaponModificationString(
      EStatModifyType modifyType,
      EStat stat,
      float value,
      bool addOneToMultiplication = true)
    {
      return (string) null;
    }

    [Token(Token = "0x6001930")]
    [Address(RVA = "0x41A7B0", Offset = "0x4193B0", Length = "0x4")]
    private static string ModifyStatName(string statName, EWeapon eWeapon) => (string) null;

    [Token(Token = "0x6001931")]
    [Address(RVA = "0x419AF0", Offset = "0x4186F0", Length = "0xBB")]
    public static float GetRarityValue(float value, ERarity rarity, int decimals = 2) => 0.0f;

    [Token(Token = "0x6001932")]
    [Address(RVA = "0x419BB0", Offset = "0x4187B0", Length = "0x48")]
    public static EStatCategory GetStatCategory(EStat eStat) => new EStatCategory();
  }
}
