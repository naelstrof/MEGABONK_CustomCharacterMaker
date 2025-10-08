// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.TomeInventory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.Tomes;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups
{
  [Token(Token = "0x2000361")]
  public class TomeInventory
  {
    [Token(Token = "0x400171D")]
    [FieldOffset(Offset = "0x10")]
    private bool isMaxed;
    [Token(Token = "0x400171E")]
    public static Action<ETome, EStat> A_TomeUpgrade;
    [Token(Token = "0x400171F")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<ETome, int> tomeLevels;
    [Token(Token = "0x4001720")]
    [FieldOffset(Offset = "0x20")]
    public Dictionary<EStat, HashSet<ETome>> statToTomes;
    [Token(Token = "0x4001721")]
    [FieldOffset(Offset = "0x28")]
    public Dictionary<ETome, StatModifier> tomeUpgrade;

    [Token(Token = "0x6001827")]
    [Address(RVA = "0x3F7410", Offset = "0x3F6010", Length = "0x534")]
    public void AddTome(TomeData tomeData, List<StatModifier> upgradeOffer, ERarity rarity)
    {
    }

    [Token(Token = "0x6001828")]
    [Address(RVA = "0x3F7240", Offset = "0x3F5E40", Length = "0x1CC")]
    public void AddMaxedTome(TomeData tomeData)
    {
    }

    [Token(Token = "0x6001829")]
    [Address(RVA = "0x3F7BD0", Offset = "0x3F67D0", Length = "0x85")]
    public int GetTomeLevel(ETome tome) => 0;

    [Token(Token = "0x600182A")]
    [Address(RVA = "0x3F7B80", Offset = "0x3F6780", Length = "0x44")]
    public int GetNumTomes() => 0;

    [Token(Token = "0x600182B")]
    [Address(RVA = "0x3F7950", Offset = "0x3F6550", Length = "0x223")]
    private void CheckMaxed()
    {
    }

    [Token(Token = "0x600182C")]
    [Address(RVA = "0x3F7CC0", Offset = "0x3F68C0", Length = "0xC9")]
    private bool IsMaxLevel(ETome eTome) => false;

    [Token(Token = "0x600182D")]
    [Address(RVA = "0x36C9C0", Offset = "0x36B5C0", Length = "0x5")]
    public bool IsMaxed() => false;

    [Token(Token = "0x600182E")]
    [Address(RVA = "0x3F7C60", Offset = "0x3F6860", Length = "0x51")]
    public bool HasTome(ETome eTome) => false;

    [Token(Token = "0x600182F")]
    [Address(RVA = "0x3F7D90", Offset = "0x3F6990", Length = "0x103")]
    public TomeInventory()
    {
    }
  }
}
