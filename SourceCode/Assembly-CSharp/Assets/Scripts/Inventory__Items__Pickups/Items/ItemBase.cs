// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items
{
  [Token(Token = "0x2000391")]
  public abstract class ItemBase
  {
    [Token(Token = "0x4001849")]
    [FieldOffset(Offset = "0x10")]
    private string damageSource;
    [Token(Token = "0x400184A")]
    [FieldOffset(Offset = "0x18")]
    public int amount;
    [Token(Token = "0x400184B")]
    [FieldOffset(Offset = "0x20")]
    private ItemInventory itemInventoryRef;
    [Token(Token = "0x400184C")]
    [FieldOffset(Offset = "0x28")]
    public Dictionary<EStat, StatModifiersContainer> statModifiers;
    [Token(Token = "0x400184D")]
    public static Action<ItemBase> A_ItemAdded;
    [Token(Token = "0x400184E")]
    public static Action<ItemBase> A_ItemRemoved;

    [Token(Token = "0x600194E")]
    [Address(RVA = "0x4010A0", Offset = "0x3FFCA0", Length = "0x94")]
    protected ItemBase(ItemInventory itemInventoryRef)
    {
    }

    [Token(Token = "0x600194F")]
    [Address(RVA = "0x400EA0", Offset = "0x3FFAA0", Length = "0x1F6")]
    protected void SetStat(StatModifier statModifier)
    {
    }

    [Token(Token = "0x6001950")]
    [Address(RVA = "0x400CB0", Offset = "0x3FF8B0", Length = "0x6B")]
    public void AddAmount()
    {
    }

    [Token(Token = "0x6001951")]
    [Address(RVA = "0x400E30", Offset = "0x3FFA30", Length = "0x6C")]
    public void RemoveAmount()
    {
    }

    [Token(Token = "0x6001952")]
    public abstract void Init();

    [Token(Token = "0x6001953")]
    public abstract void Cleanup();

    [Token(Token = "0x6001954")]
    protected abstract void OnInitOrAmountChanged();

    [Token(Token = "0x6001955")]
    public abstract void Tick();

    [Token(Token = "0x6001956")]
    public abstract void PreAttack(DamageContainer dc, StatComponents itemAttackModifier);

    [Token(Token = "0x6001957")]
    public abstract void ProcOnHitEffects(DamageContainer dc);

    [Token(Token = "0x6001958")]
    [Address(RVA = "0x395320", Offset = "0x393F20", Length = "0x3")]
    protected virtual Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;

    [Token(Token = "0x6001959")]
    [Address(RVA = "0x400D20", Offset = "0x3FF920", Length = "0x10C")]
    public virtual string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
