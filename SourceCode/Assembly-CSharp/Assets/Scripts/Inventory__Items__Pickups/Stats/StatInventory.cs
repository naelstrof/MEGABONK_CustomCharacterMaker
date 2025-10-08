// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Stats.StatInventory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Stats
{
  [Token(Token = "0x2000383")]
  public class StatInventory
  {
    [Token(Token = "0x40017CC")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<EStat, List<StatModifier>> permanentChanges;
    [Token(Token = "0x40017CD")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<EStat, List<TemporaryStat>> temporaryChanges;
    [Token(Token = "0x40017CE")]
    [FieldOffset(Offset = "0x20")]
    public Dictionary<string, StatModifier> movingStats;
    [Token(Token = "0x40017CF")]
    public static Action<EStat> A_StatsChanged;
    [Token(Token = "0x40017D0")]
    [FieldOffset(Offset = "0x28")]
    private HashSet<EStat> refreshStats;

    [Token(Token = "0x6001918")]
    [Address(RVA = "0x3F6670", Offset = "0x3F5270", Length = "0x3B3")]
    public void ChangeStat(StatModifier stat, bool permanent, float timeout, bool addToShrineLog)
    {
    }

    [Token(Token = "0x6001919")]
    [Address(RVA = "0x3F65E0", Offset = "0x3F51E0", Length = "0x8C")]
    public void ChangeMovingStat(string name, StatModifier statModifier)
    {
    }

    [Token(Token = "0x600191A")]
    [Address(RVA = "0x3F6A30", Offset = "0x3F5630", Length = "0xD5")]
    public void RemoveMovingStat(string name)
    {
    }

    [Token(Token = "0x600191B")]
    [Address(RVA = "0x3F6B10", Offset = "0x3F5710", Length = "0x5D0")]
    public void Tick()
    {
    }

    [Token(Token = "0x600191C")]
    [Address(RVA = "0x3F70F0", Offset = "0x3F5CF0", Length = "0x149")]
    public StatInventory()
    {
    }
  }
}
