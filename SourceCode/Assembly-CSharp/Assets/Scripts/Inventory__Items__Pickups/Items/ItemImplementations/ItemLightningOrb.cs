// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemLightningOrb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003CE")]
  public class ItemLightningOrb : ItemBase
  {
    [Token(Token = "0x400197B")]
    [FieldOffset(Offset = "0x30")]
    public float procChancePerAmount;
    [Token(Token = "0x400197C")]
    [FieldOffset(Offset = "0x34")]
    private float procChance;
    [Token(Token = "0x400197D")]
    [FieldOffset(Offset = "0x38")]
    private float stunChancePerAmount;
    [Token(Token = "0x400197E")]
    [FieldOffset(Offset = "0x3C")]
    private float stunChance;
    [Token(Token = "0x400197F")]
    [FieldOffset(Offset = "0x40")]
    private float baseRadius;
    [Token(Token = "0x4001980")]
    [FieldOffset(Offset = "0x44")]
    public float damageRatio;
    [Token(Token = "0x4001981")]
    [FieldOffset(Offset = "0x48")]
    public float damageRatioPerAmount;
    [Token(Token = "0x4001982")]
    [FieldOffset(Offset = "0x4C")]
    private float foundEnemiesAtTime;
    [Token(Token = "0x4001983")]
    [FieldOffset(Offset = "0x50")]
    private List<Collider> enemies;
    [Token(Token = "0x4001984")]
    [FieldOffset(Offset = "0x58")]
    private string damageSource;
    [Token(Token = "0x4001985")]
    [FieldOffset(Offset = "0x60")]
    private DamageContainer yepDc;

    [Token(Token = "0x6001B55")]
    [Address(RVA = "0x416530", Offset = "0x415130", Length = "0xF7")]
    public ItemLightningOrb(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001B56")]
    [Address(RVA = "0x415FD0", Offset = "0x414BD0", Length = "0x65")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001B57")]
    [Address(RVA = "0x416040", Offset = "0x414C40", Length = "0x465")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001B58")]
    [Address(RVA = "0x4164B0", Offset = "0x4150B0", Length = "0x71")]
    private void TryProcStun(DamageContainer dc, float overrideProcCoefficient = -1f)
    {
    }

    [Token(Token = "0x6001B59")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001B5A")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001B5B")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001B5C")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001B5D")]
    [Address(RVA = "0x415EF0", Offset = "0x414AF0", Length = "0xDE")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
