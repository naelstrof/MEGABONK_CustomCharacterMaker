// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemPhantomShroud
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003D5")]
  public class ItemPhantomShroud : ItemBase
  {
    [Token(Token = "0x4001994")]
    [FieldOffset(Offset = "0x30")]
    private float evasionPerAmount;
    [Token(Token = "0x4001995")]
    [FieldOffset(Offset = "0x34")]
    private float damageMultiplierBase;
    [Token(Token = "0x4001996")]
    [FieldOffset(Offset = "0x38")]
    private float damageMultiplierPerAmount;
    [Token(Token = "0x4001997")]
    [FieldOffset(Offset = "0x3C")]
    private float speedAdditionBase;
    [Token(Token = "0x4001998")]
    [FieldOffset(Offset = "0x40")]
    private float speedAdditionPerAmount;
    [Token(Token = "0x4001999")]
    [FieldOffset(Offset = "0x44")]
    private float timeout;
    [Token(Token = "0x400199A")]
    [FieldOffset(Offset = "0x48")]
    private float attackSpeedPerStack;
    [Token(Token = "0x400199B")]
    [FieldOffset(Offset = "0x4C")]
    private float damagePerStack;
    [Token(Token = "0x400199C")]
    [FieldOffset(Offset = "0x50")]
    private int stacks;
    [Token(Token = "0x400199D")]
    [FieldOffset(Offset = "0x54")]
    private int maxStacks;
    [Token(Token = "0x400199E")]
    [FieldOffset(Offset = "0x58")]
    private bool hasEvaded;
    [Token(Token = "0x400199F")]
    [FieldOffset(Offset = "0x5C")]
    private float speedResetAtTime;
    [Token(Token = "0x40019A0")]
    [FieldOffset(Offset = "0x60")]
    private bool hasSpeed;

    [Token(Token = "0x6001B8E")]
    [Address(RVA = "0x422B40", Offset = "0x421740", Length = "0xBE")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001B8F")]
    [Address(RVA = "0x4229D0", Offset = "0x4215D0", Length = "0x16C")]
    private void OnEvade(Enemy enemy)
    {
    }

    [Token(Token = "0x6001B90")]
    [Address(RVA = "0x422C50", Offset = "0x421850", Length = "0x141")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001B91")]
    [Address(RVA = "0x422C00", Offset = "0x421800", Length = "0x45")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001B92")]
    [Address(RVA = "0x422880", Offset = "0x421480", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001B93")]
    [Address(RVA = "0x422540", Offset = "0x421140", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001B94")]
    [Address(RVA = "0x422DA0", Offset = "0x4219A0", Length = "0x40")]
    public ItemPhantomShroud(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001B95")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001B96")]
    [Address(RVA = "0x422690", Offset = "0x421290", Length = "0x1E3")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
