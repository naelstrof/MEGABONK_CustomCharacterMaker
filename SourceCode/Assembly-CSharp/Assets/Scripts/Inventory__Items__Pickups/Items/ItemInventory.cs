// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemInventory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items
{
  [Token(Token = "0x2000395")]
  public class ItemInventory
  {
    [Token(Token = "0x4001853")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<EItem, ItemBase> items;
    [Token(Token = "0x4001854")]
    public static Action<EStat> A_StatsChanged;
    [Token(Token = "0x4001855")]
    public static Action<EItem> A_ItemAdded;
    [Token(Token = "0x4001856")]
    public static Action<EItem, bool> A_ItemRemoved;

    [Token(Token = "0x6001962")]
    [Address(RVA = "0x413CC0", Offset = "0x4128C0", Length = "0x1B7")]
    public void AddItem(EItem eItem)
    {
    }

    [Token(Token = "0x6001963")]
    [Address(RVA = "0x413AD0", Offset = "0x4126D0", Length = "0x1E9")]
    public void AddItem(EItem eItem, int count)
    {
    }

    [Token(Token = "0x6001964")]
    [Address(RVA = "0x414040", Offset = "0x412C40", Length = "0x85")]
    public ItemBase GetItem(EItem eItem) => (ItemBase) null;

    [Token(Token = "0x6001965")]
    [Address(RVA = "0x414650", Offset = "0x413250", Length = "0x1B1")]
    public void RemoveItem(EItem eItem, bool showEffect = true)
    {
    }

    [Token(Token = "0x6001966")]
    [Address(RVA = "0x414870", Offset = "0x413470", Length = "0x12B")]
    public void Tick()
    {
    }

    [Token(Token = "0x6001967")]
    [Address(RVA = "0x4144D0", Offset = "0x4130D0", Length = "0x172")]
    public StatComponents PreAttack(DamageContainer dc, StatComponents itemModifierStatComponents) => (StatComponents) null;

    [Token(Token = "0x6001968")]
    [Address(RVA = "0x414250", Offset = "0x412E50", Length = "0x27B")]
    public void PostDamage(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001969")]
    [Address(RVA = "0x414810", Offset = "0x413410", Length = "0x53")]
    public void StatWasModified(EStat stat)
    {
    }

    [Token(Token = "0x600196A")]
    [Address(RVA = "0x413FB0", Offset = "0x412BB0", Length = "0x8E")]
    public int GetAmount(EItem eItem) => 0;

    [Token(Token = "0x600196B")]
    [Address(RVA = "0x4140D0", Offset = "0x412CD0", Length = "0x176")]
    public int GetUniqueItemsInRarity(EItemRarity itemRarity) => 0;

    [Token(Token = "0x600196C")]
    [Address(RVA = "0x413E80", Offset = "0x412A80", Length = "0x12B")]
    public void Cleanup()
    {
    }

    [Token(Token = "0x600196D")]
    [Address(RVA = "0x4149A0", Offset = "0x4135A0", Length = "0x77")]
    public ItemInventory()
    {
    }
  }
}
