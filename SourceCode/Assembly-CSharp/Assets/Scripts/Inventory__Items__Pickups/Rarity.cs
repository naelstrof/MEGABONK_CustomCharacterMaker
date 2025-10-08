// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Rarity
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Items;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups
{
  [Token(Token = "0x200035F")]
  public static class Rarity
  {
    [Token(Token = "0x6001817")]
    [Address(RVA = "0x3F4A80", Offset = "0x3F3680", Length = "0x12D")]
    public static ERarity GetUpgradeOfferRarity(float luck) => new ERarity();

    [Token(Token = "0x6001818")]
    [Address(RVA = "0x3F4A80", Offset = "0x3F3680", Length = "0x12D")]
    public static ERarity GetEncounterOfferRarity(float luck) => new ERarity();

    [Token(Token = "0x6001819")]
    [Address(RVA = "0x3F4BB0", Offset = "0x3F37B0", Length = "0x44D")]
    public static EItemRarity GetItemRarity(float luck) => new EItemRarity();

    [Token(Token = "0x600181A")]
    [Address(RVA = "0x3F5060", Offset = "0x3F3C60", Length = "0x153")]
    public static EItemRarity GetShadyGuyRarity(float luck, float[] customWeights = null) => new EItemRarity();

    [Token(Token = "0x600181B")]
    [Address(RVA = "0x3F4970", Offset = "0x3F3570", Length = "0x104")]
    public static void CalculateRarityWeights(float[] rarityWeights, float luck)
    {
    }

    [Token(Token = "0x600181C")]
    [Address(RVA = "0x3F5000", Offset = "0x3F3C00", Length = "0x48")]
    public static float GetMultiplier(ERarity rarity) => 0.0f;
  }
}
