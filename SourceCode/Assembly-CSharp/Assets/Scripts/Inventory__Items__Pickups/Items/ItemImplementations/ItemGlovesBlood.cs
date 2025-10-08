// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemGlovesBlood
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003BC")]
  public class ItemGlovesBlood : ItemBase
  {
    [Token(Token = "0x4001901")]
    [FieldOffset(Offset = "0x30")]
    public float readyAtTime;
    [Token(Token = "0x4001902")]
    [FieldOffset(Offset = "0x34")]
    private float cooldown;
    [Token(Token = "0x4001903")]
    [FieldOffset(Offset = "0x38")]
    private float baseDamageMultiplier;
    [Token(Token = "0x4001904")]
    [FieldOffset(Offset = "0x3C")]
    private float baseRadius;
    [Token(Token = "0x4001905")]
    [FieldOffset(Offset = "0x40")]
    private float healPercentage;
    [Token(Token = "0x4001906")]
    private static string damageSource;
    [Token(Token = "0x4001907")]
    [FieldOffset(Offset = "0x48")]
    private DamageContainer reuseDc;
    [Token(Token = "0x4001908")]
    [FieldOffset(Offset = "0x50")]
    private EffectPlayer fx;

    [Token(Token = "0x6001AB2")]
    [Address(RVA = "0x40E6E0", Offset = "0x40D2E0", Length = "0xD9")]
    public ItemGlovesBlood(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001AB3")]
    [Address(RVA = "0x40E060", Offset = "0x40CC60", Length = "0x5E9")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001AB4")]
    [Address(RVA = "0x40DE90", Offset = "0x40CA90", Length = "0x84")]
    private float GetDamage() => 0.0f;

    [Token(Token = "0x6001AB5")]
    [Address(RVA = "0x40DF20", Offset = "0x40CB20", Length = "0x13D")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;

    [Token(Token = "0x6001AB6")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001AB7")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001AB8")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001AB9")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001ABA")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001ABB")]
    [Address(RVA = "0x40E650", Offset = "0x40D250", Length = "0x81")]
    static ItemGlovesBlood()
    {
    }
  }
}
