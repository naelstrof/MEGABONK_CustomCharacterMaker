// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemIceCube
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003C8")]
  public class ItemIceCube : ItemBase
  {
    [Token(Token = "0x4001956")]
    [FieldOffset(Offset = "0x30")]
    public float procChancePerAmount;
    [Token(Token = "0x4001957")]
    [FieldOffset(Offset = "0x34")]
    private float procChance;
    [Token(Token = "0x4001958")]
    [FieldOffset(Offset = "0x38")]
    private float freezeChancePerAmount;
    [Token(Token = "0x4001959")]
    [FieldOffset(Offset = "0x3C")]
    private float freezeChance;
    [Token(Token = "0x400195A")]
    [FieldOffset(Offset = "0x40")]
    public float damageRatio;
    [Token(Token = "0x400195B")]
    [FieldOffset(Offset = "0x44")]
    public float damageRatioPerAmount;
    [Token(Token = "0x400195C")]
    [FieldOffset(Offset = "0x48")]
    private string damageSource;
    [Token(Token = "0x400195D")]
    [FieldOffset(Offset = "0x50")]
    private DamageContainer reuseDc;
    [Token(Token = "0x400195E")]
    public static Action A_FreezeEnemy;

    [Token(Token = "0x6001B1D")]
    [Address(RVA = "0x413240", Offset = "0x411E40", Length = "0x116")]
    public ItemIceCube(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001B1E")]
    [Address(RVA = "0x412D80", Offset = "0x411980", Length = "0x55")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001B1F")]
    [Address(RVA = "0x412DE0", Offset = "0x4119E0", Length = "0x38B")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001B20")]
    [Address(RVA = "0x413170", Offset = "0x411D70", Length = "0xC7")]
    private void TryProcFreeze(DamageContainer dc, float overrideProcCoefficient = -1f)
    {
    }

    [Token(Token = "0x6001B21")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001B22")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001B23")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001B24")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001B25")]
    [Address(RVA = "0x412CA0", Offset = "0x4118A0", Length = "0xDE")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
