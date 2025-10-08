// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemIceCrystal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003C7")]
  public class ItemIceCrystal : ItemBase
  {
    [Token(Token = "0x4001953")]
    [FieldOffset(Offset = "0x30")]
    private float freezeTime;
    [Token(Token = "0x4001954")]
    [FieldOffset(Offset = "0x34")]
    public float procChancePerAmount;
    [Token(Token = "0x4001955")]
    [FieldOffset(Offset = "0x38")]
    private float procChance;

    [Token(Token = "0x6001B15")]
    [Address(RVA = "0x412C90", Offset = "0x411890", Length = "0xF")]
    public ItemIceCrystal(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001B16")]
    [Address(RVA = "0x412BC0", Offset = "0x4117C0", Length = "0x5A")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001B17")]
    [Address(RVA = "0x412C20", Offset = "0x411820", Length = "0x67")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001B18")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001B19")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001B1A")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001B1B")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001B1C")]
    [Address(RVA = "0x412AE0", Offset = "0x4116E0", Length = "0xDE")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
