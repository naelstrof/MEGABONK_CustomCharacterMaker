// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemGlovesPower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003C0")]
  public class ItemGlovesPower : ItemBase
  {
    [Token(Token = "0x4001921")]
    [FieldOffset(Offset = "0x30")]
    private float knockbackForce;
    [Token(Token = "0x4001922")]
    [FieldOffset(Offset = "0x34")]
    public float procChancePerAmount;
    [Token(Token = "0x4001923")]
    [FieldOffset(Offset = "0x38")]
    private float procChance;
    [Token(Token = "0x4001924")]
    [FieldOffset(Offset = "0x3C")]
    private float baseDamageMultiplier;
    [Token(Token = "0x4001925")]
    [FieldOffset(Offset = "0x40")]
    private float radiusPerAmount;
    [Token(Token = "0x4001926")]
    [FieldOffset(Offset = "0x44")]
    private float radius;
    [Token(Token = "0x4001927")]
    private static string damageSource;
    [Token(Token = "0x4001928")]
    [FieldOffset(Offset = "0x48")]
    private DamageContainer reuseDc;
    [Token(Token = "0x4001929")]
    [FieldOffset(Offset = "0x50")]
    private EffectPlayer fx;
    [Token(Token = "0x400192A")]
    [FieldOffset(Offset = "0x58")]
    private float readyAtTime;
    [Token(Token = "0x400192B")]
    [FieldOffset(Offset = "0x5C")]
    private float cooldown;

    [Token(Token = "0x6001AD9")]
    [Address(RVA = "0x4109D0", Offset = "0x40F5D0", Length = "0xE7")]
    public ItemGlovesPower(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001ADA")]
    [Address(RVA = "0x410250", Offset = "0x40EE50", Length = "0x7B")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001ADB")]
    [Address(RVA = "0x4102D0", Offset = "0x40EED0", Length = "0x666")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001ADC")]
    [Address(RVA = "0x4100E0", Offset = "0x40ECE0", Length = "0x84")]
    private float GetDamage() => 0.0f;

    [Token(Token = "0x6001ADD")]
    [Address(RVA = "0x410170", Offset = "0x40ED70", Length = "0xDE")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;

    [Token(Token = "0x6001ADE")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001ADF")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001AE0")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001AE1")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001AE2")]
    [Address(RVA = "0x410940", Offset = "0x40F540", Length = "0x81")]
    static ItemGlovesPower()
    {
    }
  }
}
