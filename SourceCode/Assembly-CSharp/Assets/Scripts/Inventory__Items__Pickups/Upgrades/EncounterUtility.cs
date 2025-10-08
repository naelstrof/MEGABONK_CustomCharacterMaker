// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Upgrades.EncounterUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.Menu.Shop;
using Assets.Scripts.UI.InGame.Rewards;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Upgrades
{
  [Token(Token = "0x200037A")]
  public class EncounterUtility
  {
    [Token(Token = "0x4001799")]
    public static List<EStat> upgradableStats;
    [Token(Token = "0x400179A")]
    private static List<EStat> upgradableStatsBalanceShrine;

    [Token(Token = "0x60018E3")]
    [Address(RVA = "0x3E2930", Offset = "0x3E1530", Length = "0x20D")]
    public static List<EStat> GetRandomStats(int amount) => (List<EStat>) null;

    [Token(Token = "0x60018E4")]
    [Address(RVA = "0x3E2720", Offset = "0x3E1320", Length = "0x20D")]
    public static List<EStat> GetRandomStatsBalanceShrine(int amount) => (List<EStat>) null;

    [Token(Token = "0x60018E5")]
    [Address(RVA = "0x3E20A0", Offset = "0x3E0CA0", Length = "0x518")]
    public static List<EncounterOffer> GetRandomStatOffers(int amount, bool forceLegendary = false) => (List<EncounterOffer>) null;

    [Token(Token = "0x60018E6")]
    [Address(RVA = "0x3E1D60", Offset = "0x3E0960", Length = "0x332")]
    public static List<EncounterOffer> GetBalanceShrineOffers(int amount) => (List<EncounterOffer>) null;

    [Token(Token = "0x60018E7")]
    [Address(RVA = "0x3E25D0", Offset = "0x3E11D0", Length = "0xD0")]
    private static float GetRandomStatValue(EStat stat, out EStatModifyType type)
    {
      type = new EStatModifyType();
      return 0.0f;
    }

    [Token(Token = "0x60018E8")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public EncounterUtility()
    {
    }

    [Token(Token = "0x60018E9")]
    [Address(RVA = "0x3E2B40", Offset = "0x3E1740", Length = "0xFF7")]
    static EncounterUtility()
    {
    }
  }
}
