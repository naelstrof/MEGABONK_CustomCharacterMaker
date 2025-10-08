// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemCampfire
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003A6")]
  public class ItemCampfire : ItemBase
  {
    [Token(Token = "0x400189B")]
    [FieldOffset(Offset = "0x30")]
    private float healthRegenPerMinutePerAmount;
    [Token(Token = "0x400189C")]
    [FieldOffset(Offset = "0x34")]
    private float healthRegen;
    [Token(Token = "0x400189D")]
    [FieldOffset(Offset = "0x38")]
    public Campfire campfire;
    [Token(Token = "0x400189E")]
    [FieldOffset(Offset = "0x40")]
    private Vector3 campfirePos;
    [Token(Token = "0x400189F")]
    [FieldOffset(Offset = "0x4C")]
    private float setupTime;
    [Token(Token = "0x40018A0")]
    [FieldOffset(Offset = "0x50")]
    private float distThreshold;
    [Token(Token = "0x40018A1")]
    [FieldOffset(Offset = "0x54")]
    private float startCampfireTime;
    [Token(Token = "0x40018A2")]
    [FieldOffset(Offset = "0x58")]
    private bool isCampActive;

    [Token(Token = "0x60019F1")]
    [Address(RVA = "0x403CA0", Offset = "0x4028A0", Length = "0x13")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x60019F2")]
    [Address(RVA = "0x4055C0", Offset = "0x4041C0", Length = "0x1D")]
    public ItemCampfire(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x60019F3")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x60019F4")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x60019F5")]
    [Address(RVA = "0x4052F0", Offset = "0x403EF0", Length = "0x2CA")]
    public override void Tick()
    {
    }

    [Token(Token = "0x60019F6")]
    [Address(RVA = "0x404E60", Offset = "0x403A60", Length = "0x3F4")]
    private void CreateCamp()
    {
    }

    [Token(Token = "0x60019F7")]
    [Address(RVA = "0x405260", Offset = "0x403E60", Length = "0x88")]
    private void RemoveCamp()
    {
    }

    [Token(Token = "0x60019F8")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x60019F9")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }
  }
}
