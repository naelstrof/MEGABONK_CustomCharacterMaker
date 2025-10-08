// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemEagleClaw
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003B2")]
  public class ItemEagleClaw : ItemBase
  {
    [Token(Token = "0x40018D1")]
    [FieldOffset(Offset = "0x30")]
    public float procChancePerAmount;
    [Token(Token = "0x40018D2")]
    [FieldOffset(Offset = "0x34")]
    private float procChance;
    [Token(Token = "0x40018D3")]
    [FieldOffset(Offset = "0x38")]
    public float damageAddition;
    [Token(Token = "0x40018D4")]
    [FieldOffset(Offset = "0x3C")]
    public float damageAdditionPerAmount;
    [Token(Token = "0x40018D5")]
    [FieldOffset(Offset = "0x40")]
    private float knockupForce;

    [Token(Token = "0x6001A59")]
    [Address(RVA = "0x4096B0", Offset = "0x4082B0", Length = "0x34")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001A5A")]
    [Address(RVA = "0x4096F0", Offset = "0x4082F0", Length = "0xC8")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001A5B")]
    [Address(RVA = "0x4097C0", Offset = "0x4083C0", Length = "0x109")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001A5C")]
    [Address(RVA = "0x4098D0", Offset = "0x4084D0", Length = "0x24")]
    public ItemEagleClaw(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001A5D")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001A5E")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001A5F")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001A60")]
    [Address(RVA = "0x409520", Offset = "0x408120", Length = "0x184")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
