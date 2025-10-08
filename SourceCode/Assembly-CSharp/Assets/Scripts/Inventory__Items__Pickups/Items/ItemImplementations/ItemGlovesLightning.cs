// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemGlovesLightning
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003BE")]
  public class ItemGlovesLightning : ItemBase
  {
    [Token(Token = "0x4001912")]
    [FieldOffset(Offset = "0x30")]
    public float readyAtTime;
    [Token(Token = "0x4001913")]
    [FieldOffset(Offset = "0x34")]
    private float cooldown;
    [Token(Token = "0x4001914")]
    [FieldOffset(Offset = "0x38")]
    private float baseDamageMultiplier;
    [Token(Token = "0x4001915")]
    [FieldOffset(Offset = "0x3C")]
    private float baseRadius;
    [Token(Token = "0x4001916")]
    private static string damageSource;
    [Token(Token = "0x4001917")]
    [FieldOffset(Offset = "0x40")]
    private DamageContainer reuseDc;
    [Token(Token = "0x4001918")]
    [FieldOffset(Offset = "0x48")]
    private EffectPlayer fx;

    [Token(Token = "0x6001AC6")]
    [Address(RVA = "0x40F8C0", Offset = "0x40E4C0", Length = "0xD2")]
    public ItemGlovesLightning(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001AC7")]
    [Address(RVA = "0x40F2E0", Offset = "0x40DEE0", Length = "0x54C")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001AC8")]
    [Address(RVA = "0x40F170", Offset = "0x40DD70", Length = "0x84")]
    private float GetDamage() => 0.0f;

    [Token(Token = "0x6001AC9")]
    [Address(RVA = "0x40F200", Offset = "0x40DE00", Length = "0xD6")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;

    [Token(Token = "0x6001ACA")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001ACB")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001ACC")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001ACD")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001ACE")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001ACF")]
    [Address(RVA = "0x40F830", Offset = "0x40E430", Length = "0x81")]
    static ItemGlovesLightning()
    {
    }
  }
}
