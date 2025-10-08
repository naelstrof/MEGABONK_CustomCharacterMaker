// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.RunUnlockables
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Items;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups
{
  [Token(Token = "0x2000360")]
  public static class RunUnlockables
  {
    [Token(Token = "0x4001717")]
    public static HashSet<ItemData> banishedItems;
    [Token(Token = "0x4001718")]
    public static HashSet<UnlockableBase> banishedUpgradables;
    [Token(Token = "0x4001719")]
    public static Dictionary<EItemRarity, List<ItemData>> availableItems;
    [Token(Token = "0x400171A")]
    public static Action A_Inited;
    [Token(Token = "0x400171B")]
    private static int maxOverpoweredLamps;
    [Token(Token = "0x400171C")]
    private static int maxAnvils;

    [Token(Token = "0x600181D")]
    [Address(RVA = "0x3F58D0", Offset = "0x3F44D0", Length = "0x336")]
    public static void Init()
    {
    }

    [Token(Token = "0x600181E")]
    [Address(RVA = "0x3F5590", Offset = "0x3F4190", Length = "0x336")]
    public static void Cleanup()
    {
    }

    [Token(Token = "0x600181F")]
    [Address(RVA = "0x3F5E10", Offset = "0x3F4A10", Length = "0x5E2")]
    private static void OnNewRunStarted()
    {
    }

    [Token(Token = "0x6001820")]
    [Address(RVA = "0x3F6400", Offset = "0x3F5000", Length = "0x40")]
    public static void Testing()
    {
    }

    [Token(Token = "0x6001821")]
    [Address(RVA = "0x3F51C0", Offset = "0x3F3DC0", Length = "0x1F7")]
    private static void AddItemToPool(ItemData item)
    {
    }

    [Token(Token = "0x6001822")]
    [Address(RVA = "0x3F5C10", Offset = "0x3F4810", Length = "0x1F3")]
    private static void OnItemAdded(EItem eItem)
    {
    }

    [Token(Token = "0x6001823")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    private static void OnAchievementUnlocked(MyAchievement ach)
    {
    }

    [Token(Token = "0x6001824")]
    [Address(RVA = "0x3F53C0", Offset = "0x3F3FC0", Length = "0x149")]
    public static void BanishItem(ItemData unlockable)
    {
    }

    [Token(Token = "0x6001825")]
    [Address(RVA = "0x3F5510", Offset = "0x3F4110", Length = "0x79")]
    public static void BanishUpgradable(UnlockableBase upgradable)
    {
    }

    [Token(Token = "0x6001826")]
    [Address(RVA = "0x3F6440", Offset = "0x3F5040", Length = "0xB4")]
    static RunUnlockables()
    {
    }
  }
}
