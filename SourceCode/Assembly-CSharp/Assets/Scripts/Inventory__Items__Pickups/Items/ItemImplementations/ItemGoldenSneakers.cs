// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemGoldenSneakers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003C3")]
  public class ItemGoldenSneakers : ItemBase
  {
    [Token(Token = "0x4001936")]
    [FieldOffset(Offset = "0x30")]
    private float goldPerMeter;
    [Token(Token = "0x4001937")]
    [FieldOffset(Offset = "0x34")]
    private float goldPerMeterBase;
    [Token(Token = "0x4001938")]
    [FieldOffset(Offset = "0x38")]
    private float checkInterval;
    [Token(Token = "0x4001939")]
    [FieldOffset(Offset = "0x3C")]
    private float nextCheckTime;
    [Token(Token = "0x400193A")]
    [FieldOffset(Offset = "0x40")]
    private Vector3 lastPos;
    [Token(Token = "0x400193B")]
    [FieldOffset(Offset = "0x4C")]
    private float accumulatedGold;

    [Token(Token = "0x6001AF5")]
    [Address(RVA = "0x411590", Offset = "0x410190", Length = "0x16")]
    public ItemGoldenSneakers(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001AF6")]
    [Address(RVA = "0x411200", Offset = "0x40FE00", Length = "0xB1")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001AF7")]
    [Address(RVA = "0x4112C0", Offset = "0x40FEC0", Length = "0x2C9")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001AF8")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001AF9")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001AFA")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001AFB")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }
  }
}
