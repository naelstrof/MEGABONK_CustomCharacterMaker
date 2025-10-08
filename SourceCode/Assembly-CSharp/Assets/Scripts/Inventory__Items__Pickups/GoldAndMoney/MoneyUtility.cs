// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.GoldAndMoney.MoneyUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups.Items;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.GoldAndMoney
{
  [Token(Token = "0x20003EA")]
  public class MoneyUtility
  {
    [Token(Token = "0x40019F8")]
    public static int[] moneyTiers;
    [Token(Token = "0x40019F9")]
    private const float spawnInterval = 60f;
    [Token(Token = "0x40019FA")]
    private static float nextSilverSpawnTime;
    [Token(Token = "0x40019FB")]
    private static Dictionary<GameObject, MoneyFlying> flyingMoneyDict;
    [Token(Token = "0x40019FC")]
    private static MoneyFlying lastSpawnedMoney;
    [Token(Token = "0x40019FD")]
    private static int chestBasePrice;
    [Token(Token = "0x40019FE")]
    private static int priceIncreasePerChest;
    [Token(Token = "0x40019FF")]
    private static int priceIncreasePerChestOver10;
    [Token(Token = "0x4001A00")]
    private static int priceIncreasePerChestOver20;
    [Token(Token = "0x4001A01")]
    private static int priceIncreasePerChestOver30;
    [Token(Token = "0x4001A02")]
    private static int priceIncreasePerChestOver40;
    [Token(Token = "0x4001A03")]
    private static int priceIncreasePerChestOver50;
    [Token(Token = "0x4001A04")]
    private static float chestPriceIncrease;
    [Token(Token = "0x4001A05")]
    private static int chestsPurchased;
    [Token(Token = "0x4001A06")]
    private static float bigPotMultiplier;
    [Token(Token = "0x4001A07")]
    private static float potMoneyFractionOfChest;
    [Token(Token = "0x4001A08")]
    public static Action A_ChestPriceIncreased;

    [Token(Token = "0x6001C46")]
    [Address(RVA = "0x428BC0", Offset = "0x4277C0", Length = "0x233")]
    public static void Init()
    {
    }

    [Token(Token = "0x6001C47")]
    [Address(RVA = "0x428210", Offset = "0x426E10", Length = "0x233")]
    public static void Cleanup()
    {
    }

    [Token(Token = "0x6001C48")]
    [Address(RVA = "0x428E00", Offset = "0x427A00", Length = "0x389")]
    private static void OnEnemyDied(Enemy enemy, DamageContainer deathSource)
    {
    }

    [Token(Token = "0x6001C49")]
    [Address(RVA = "0x428100", Offset = "0x426D00", Length = "0x10B")]
    private static void CheckSilver(Enemy enemy)
    {
    }

    [Token(Token = "0x6001C4A")]
    [Address(RVA = "0x429AD0", Offset = "0x4286D0", Length = "0x83")]
    private static void SpawnSilver(Enemy enemy)
    {
    }

    [Token(Token = "0x6001C4B")]
    [Address(RVA = "0x429B60", Offset = "0x428760", Length = "0x20C")]
    public static void SpawnSilver(Vector3 pos)
    {
    }

    [Token(Token = "0x6001C4C")]
    [Address(RVA = "0x429870", Offset = "0x428470", Length = "0x250")]
    public static void SpawnSilverNoTimerImpact(int amount, Vector3 pos)
    {
    }

    [Token(Token = "0x6001C4D")]
    [Address(RVA = "0x429190", Offset = "0x427D90", Length = "0x85")]
    private static void OnNewRun()
    {
    }

    [Token(Token = "0x6001C4E")]
    [Address(RVA = "0x428450", Offset = "0x427050", Length = "0x17B")]
    public static List<int> Exchange(int amount) => (List<int>) null;

    [Token(Token = "0x6001C4F")]
    [Address(RVA = "0x429220", Offset = "0x427E20", Length = "0x644")]
    public static void SpawnMoney(int amount, Vector3 pos)
    {
    }

    [Token(Token = "0x6001C50")]
    [Address(RVA = "0x4285D0", Offset = "0x4271D0", Length = "0x244")]
    public static int GetChestPrice() => 0;

    [Token(Token = "0x6001C51")]
    [Address(RVA = "0x428A60", Offset = "0x427660", Length = "0xDE")]
    public static int GetShadyguyPrice() => 0;

    [Token(Token = "0x6001C52")]
    [Address(RVA = "0x428820", Offset = "0x427420", Length = "0x16C")]
    public static int GetItemPriceShadyGuy(EItemRarity rarity) => 0;

    [Token(Token = "0x6001C53")]
    [Address(RVA = "0x428990", Offset = "0x427590", Length = "0xC1")]
    public static int GetPotMoney(bool isBig) => 0;

    [Token(Token = "0x6001C54")]
    [Address(RVA = "0x428B40", Offset = "0x427740", Length = "0x7A")]
    public static void IncreaseChestPrice()
    {
    }

    [Token(Token = "0x6001C55")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public MoneyUtility()
    {
    }

    [Token(Token = "0x6001C56")]
    [Address(RVA = "0x429D70", Offset = "0x428970", Length = "0x1D6")]
    static MoneyUtility()
    {
    }
  }
}
