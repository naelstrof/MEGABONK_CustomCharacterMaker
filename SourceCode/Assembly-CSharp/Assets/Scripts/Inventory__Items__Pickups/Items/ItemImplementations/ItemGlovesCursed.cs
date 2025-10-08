// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemGlovesCursed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003BD")]
  public class ItemGlovesCursed : ItemBase
  {
    [Token(Token = "0x4001909")]
    [FieldOffset(Offset = "0x30")]
    public float procChancePerAmount;
    [Token(Token = "0x400190A")]
    [FieldOffset(Offset = "0x34")]
    private float procChance;
    [Token(Token = "0x400190B")]
    [FieldOffset(Offset = "0x38")]
    private float difficultyPerAmount;
    [Token(Token = "0x400190C")]
    [FieldOffset(Offset = "0x3C")]
    private float maxHpMultiplierPerAmount;
    [Token(Token = "0x400190D")]
    [FieldOffset(Offset = "0x40")]
    private float baseDamageMultiplier;
    [Token(Token = "0x400190E")]
    [FieldOffset(Offset = "0x44")]
    private float baseRadius;
    [Token(Token = "0x400190F")]
    private static string damageSource;
    [Token(Token = "0x4001910")]
    [FieldOffset(Offset = "0x48")]
    private DamageContainer reuseDc;
    [Token(Token = "0x4001911")]
    [FieldOffset(Offset = "0x50")]
    private EffectPlayer fx;

    [Token(Token = "0x6001ABC")]
    [Address(RVA = "0x40F090", Offset = "0x40DC90", Length = "0xE0")]
    public ItemGlovesCursed(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001ABD")]
    [Address(RVA = "0x40EA80", Offset = "0x40D680", Length = "0x102")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001ABE")]
    [Address(RVA = "0x40EB90", Offset = "0x40D790", Length = "0x463")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001ABF")]
    [Address(RVA = "0x40E7C0", Offset = "0x40D3C0", Length = "0x84")]
    private float GetDamage() => 0.0f;

    [Token(Token = "0x6001AC0")]
    [Address(RVA = "0x40E850", Offset = "0x40D450", Length = "0x22D")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;

    [Token(Token = "0x6001AC1")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001AC2")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001AC3")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001AC4")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001AC5")]
    [Address(RVA = "0x40F000", Offset = "0x40DC00", Length = "0x81")]
    static ItemGlovesCursed()
    {
    }
  }
}
