// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemGrandmasSecretTonic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003C4")]
  public class ItemGrandmasSecretTonic : ItemBase
  {
    [Token(Token = "0x400193C")]
    [FieldOffset(Offset = "0x30")]
    private float critChanceTotal;
    [Token(Token = "0x400193D")]
    [FieldOffset(Offset = "0x34")]
    private float baseRadius;
    [Token(Token = "0x400193E")]
    [FieldOffset(Offset = "0x38")]
    private float radiusPerAmount;
    [Token(Token = "0x400193F")]
    [FieldOffset(Offset = "0x3C")]
    private float maxRadius;
    [Token(Token = "0x4001940")]
    [FieldOffset(Offset = "0x40")]
    private float radius;
    [Token(Token = "0x4001941")]
    [FieldOffset(Offset = "0x44")]
    private float damageSpreadMultiplier;
    [Token(Token = "0x4001942")]
    [FieldOffset(Offset = "0x48")]
    private float procChance;
    [Token(Token = "0x4001943")]
    [FieldOffset(Offset = "0x50")]
    private DamageContainer procDc;
    [Token(Token = "0x4001944")]
    [FieldOffset(Offset = "0x58")]
    private string damageSource;
    [Token(Token = "0x4001945")]
    [FieldOffset(Offset = "0x60")]
    private int maxProcsPerTick;
    [Token(Token = "0x4001946")]
    [FieldOffset(Offset = "0x64")]
    private int numProcsThisTick;

    [Token(Token = "0x6001AFC")]
    [Address(RVA = "0x411770", Offset = "0x410370", Length = "0x80")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001AFD")]
    [Address(RVA = "0x411BA0", Offset = "0x4107A0", Length = "0x105")]
    public ItemGrandmasSecretTonic(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001AFE")]
    [Address(RVA = "0x4116F0", Offset = "0x4102F0", Length = "0x78")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001AFF")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001B00")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001B01")]
    [Address(RVA = "0x4117F0", Offset = "0x4103F0", Length = "0x399")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001B02")]
    [Address(RVA = "0x411B90", Offset = "0x410790", Length = "0x8")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001B03")]
    [Address(RVA = "0x4115B0", Offset = "0x4101B0", Length = "0x139")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
