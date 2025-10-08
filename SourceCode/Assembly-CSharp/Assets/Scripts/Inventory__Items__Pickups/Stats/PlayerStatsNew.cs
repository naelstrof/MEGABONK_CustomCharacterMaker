// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Stats.PlayerStatsNew
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.ShopItems;
using Assets.Scripts._Data.Tomes;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Stats
{
  [Token(Token = "0x200037F")]
  public class PlayerStatsNew
  {
    [Token(Token = "0x40017B4")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<EStat, float> stats;
    [Token(Token = "0x40017B5")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<EStat, float> rawStats;
    [Token(Token = "0x40017B6")]
    [FieldOffset(Offset = "0x20")]
    public Dictionary<EStat, StatComponents> statValuesMap;
    [Token(Token = "0x40017B7")]
    [FieldOffset(Offset = "0x28")]
    private PlayerInventory playerInventory;
    [Token(Token = "0x40017B8")]
    public static Action<EStat> A_StatUpdate;
    [Token(Token = "0x40017B9")]
    [FieldOffset(Offset = "0x30")]
    private HashSet<EStat> queuedUpdateStats;
    [Token(Token = "0x40017BA")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<EStat, HashSet<EShopItem>> statToShopItems;
    [Token(Token = "0x40017BB")]
    [FieldOffset(Offset = "0x40")]
    private bool ignoreShopItems;

    [Token(Token = "0x60018ED")]
    [Address(RVA = "0x3EDD70", Offset = "0x3EC970", Length = "0xC85")]
    public PlayerStatsNew(PlayerInventory inventory, bool ignoreShopItems = false)
    {
    }

    [Token(Token = "0x60018EE")]
    [Address(RVA = "0x3EC210", Offset = "0x3EAE10", Length = "0x4CD")]
    public void OnDestroy()
    {
    }

    [Token(Token = "0x60018EF")]
    [Address(RVA = "0x3EC7A0", Offset = "0x3EB3A0", Length = "0x168")]
    public void Tick()
    {
    }

    [Token(Token = "0x60018F0")]
    [Address(RVA = "0x3EC6E0", Offset = "0x3EB2E0", Length = "0x52")]
    private void QueueUpdateStatTome(ETome eTome, EStat stat)
    {
    }

    [Token(Token = "0x60018F1")]
    [Address(RVA = "0x3EC740", Offset = "0x3EB340", Length = "0x51")]
    private void QueueUpdateStat(EStat stat)
    {
    }

    [Token(Token = "0x60018F2")]
    [Address(RVA = "0x3EC910", Offset = "0x3EB510", Length = "0x145B")]
    private void UpdateStat(EStat stat)
    {
    }

    [Token(Token = "0x60018F3")]
    [Address(RVA = "0x3EBEC0", Offset = "0x3EAAC0", Length = "0x8B")]
    private void ApplyStatModifier(
      StatModifier modifier,
      int amount,
      ref float flatValues,
      ref float additionValues,
      ref float multiplicationValues)
    {
    }

    [Token(Token = "0x60018F4")]
    [Address(RVA = "0x3EBF50", Offset = "0x3EAB50", Length = "0x52")]
    private float CheckFinalValue(EStat stat, float value) => 0.0f;

    [Token(Token = "0x60018F5")]
    [Address(RVA = "0x3EBFB0", Offset = "0x3EABB0", Length = "0x60")]
    public static float GetBaseValue(EStat stat) => 0.0f;

    [Token(Token = "0x60018F6")]
    [Address(RVA = "0x3EC0D0", Offset = "0x3EACD0", Length = "0xD0")]
    public float GetStat(EStat stat) => 0.0f;

    [Token(Token = "0x60018F7")]
    [Address(RVA = "0x3EC070", Offset = "0x3EAC70", Length = "0x51")]
    public float GetRawStat(EStat stat) => 0.0f;

    [Token(Token = "0x60018F8")]
    [Address(RVA = "0x3EC1B0", Offset = "0x3EADB0", Length = "0x51")]
    public float GetUnclampedStat(EStat stat) => 0.0f;
  }
}
