// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemIdleJuice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003C9")]
  public class ItemIdleJuice : ItemBase
  {
    [Token(Token = "0x400195F")]
    [FieldOffset(Offset = "0x30")]
    private float damagePerAmount;
    [Token(Token = "0x4001960")]
    [FieldOffset(Offset = "0x34")]
    private float maxDamage;
    [Token(Token = "0x4001961")]
    [FieldOffset(Offset = "0x38")]
    private float damagePerSecond;
    [Token(Token = "0x4001962")]
    [FieldOffset(Offset = "0x3C")]
    private Vector3 campfirePos;
    [Token(Token = "0x4001963")]
    [FieldOffset(Offset = "0x48")]
    private float setupTime;
    [Token(Token = "0x4001964")]
    [FieldOffset(Offset = "0x4C")]
    private float distThreshold;
    [Token(Token = "0x4001965")]
    [FieldOffset(Offset = "0x50")]
    private float startCampfireTime;
    [Token(Token = "0x4001966")]
    [FieldOffset(Offset = "0x54")]
    private bool isCampActive;
    [Token(Token = "0x4001967")]
    [FieldOffset(Offset = "0x58")]
    private float currentDamage;
    [Token(Token = "0x4001968")]
    [FieldOffset(Offset = "0x5C")]
    private float nextUpdateDamageTime;
    [Token(Token = "0x4001969")]
    [FieldOffset(Offset = "0x60")]
    private float updateDamageInterval;

    [Token(Token = "0x6001B26")]
    [Address(RVA = "0x403CA0", Offset = "0x4028A0", Length = "0x13")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001B27")]
    [Address(RVA = "0x413630", Offset = "0x412230", Length = "0x463")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001B28")]
    [Address(RVA = "0x413360", Offset = "0x411F60", Length = "0xD6")]
    private void CreateCamp()
    {
    }

    [Token(Token = "0x6001B29")]
    [Address(RVA = "0x4135B0", Offset = "0x4121B0", Length = "0x7F")]
    private void RemoveCamp()
    {
    }

    [Token(Token = "0x6001B2A")]
    [Address(RVA = "0x413AA0", Offset = "0x4126A0", Length = "0x2B")]
    public ItemIdleJuice(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001B2B")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001B2C")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001B2D")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001B2E")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001B2F")]
    [Address(RVA = "0x413440", Offset = "0x412040", Length = "0x160")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
