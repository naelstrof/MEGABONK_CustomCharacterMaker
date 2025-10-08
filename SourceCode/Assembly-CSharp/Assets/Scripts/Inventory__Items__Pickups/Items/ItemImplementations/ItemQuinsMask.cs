// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemQuinsMask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003D6")]
  public class ItemQuinsMask : ItemBase
  {
    [Token(Token = "0x40019A1")]
    [FieldOffset(Offset = "0x30")]
    private float thornsPerAmount;
    [Token(Token = "0x40019A2")]
    [FieldOffset(Offset = "0x34")]
    private float baseRadius;
    [Token(Token = "0x40019A3")]
    [FieldOffset(Offset = "0x38")]
    private float radiusPerAmount;
    [Token(Token = "0x40019A4")]
    [FieldOffset(Offset = "0x3C")]
    private float maxRadius;
    [Token(Token = "0x40019A5")]
    [FieldOffset(Offset = "0x40")]
    private float radius;
    [Token(Token = "0x40019A6")]
    [FieldOffset(Offset = "0x44")]
    private float damageSpreadMultiplier;
    [Token(Token = "0x40019A7")]
    [FieldOffset(Offset = "0x48")]
    private float procChance;
    [Token(Token = "0x40019A8")]
    [FieldOffset(Offset = "0x50")]
    private HashSet<string> damageSources;
    [Token(Token = "0x40019A9")]
    [FieldOffset(Offset = "0x58")]
    private DamageContainer procDc;
    [Token(Token = "0x40019AA")]
    [FieldOffset(Offset = "0x60")]
    private string damageSource;
    [Token(Token = "0x40019AB")]
    [FieldOffset(Offset = "0x68")]
    private string aegisDamageSource;
    [Token(Token = "0x40019AC")]
    [FieldOffset(Offset = "0x70")]
    private int maxProcsPerTick;
    [Token(Token = "0x40019AD")]
    [FieldOffset(Offset = "0x74")]
    private int numProcsThisTick;

    [Token(Token = "0x6001B97")]
    [Address(RVA = "0x423080", Offset = "0x421C80", Length = "0xE6")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001B98")]
    [Address(RVA = "0x423580", Offset = "0x422180", Length = "0x105")]
    public ItemQuinsMask(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001B99")]
    [Address(RVA = "0x422EC0", Offset = "0x421AC0", Length = "0x1B3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001B9A")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001B9B")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001B9C")]
    [Address(RVA = "0x423170", Offset = "0x421D70", Length = "0x401")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001B9D")]
    [Address(RVA = "0x38D2B0", Offset = "0x38BEB0", Length = "0x8")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001B9E")]
    [Address(RVA = "0x422DE0", Offset = "0x4219E0", Length = "0xDE")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
