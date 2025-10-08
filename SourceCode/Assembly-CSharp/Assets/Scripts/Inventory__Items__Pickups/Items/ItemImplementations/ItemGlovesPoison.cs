// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemGlovesPoison
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003BF")]
  public class ItemGlovesPoison : ItemBase
  {
    [Token(Token = "0x4001919")]
    [FieldOffset(Offset = "0x30")]
    public float readyAtTime;
    [Token(Token = "0x400191A")]
    [FieldOffset(Offset = "0x34")]
    private float cooldown;
    [Token(Token = "0x400191B")]
    [FieldOffset(Offset = "0x38")]
    private float baseDamageMultiplier;
    [Token(Token = "0x400191C")]
    [FieldOffset(Offset = "0x3C")]
    private float baseRadius;
    [Token(Token = "0x400191D")]
    [FieldOffset(Offset = "0x40")]
    private int poisonStacksPerAmount;
    [Token(Token = "0x400191E")]
    private static string damageSource;
    [Token(Token = "0x400191F")]
    [FieldOffset(Offset = "0x48")]
    private DamageContainer reuseDc;
    [Token(Token = "0x4001920")]
    [FieldOffset(Offset = "0x50")]
    private EffectPlayer fx;

    [Token(Token = "0x6001AD0")]
    [Address(RVA = "0x410000", Offset = "0x40EC00", Length = "0xD9")]
    public ItemGlovesPoison(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001AD1")]
    [Address(RVA = "0x40FA30", Offset = "0x40E630", Length = "0x536")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001AD2")]
    [Address(RVA = "0x40F9A0", Offset = "0x40E5A0", Length = "0x84")]
    private float GetDamage() => 0.0f;

    [Token(Token = "0x6001AD3")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001AD4")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001AD5")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001AD6")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001AD7")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001AD8")]
    [Address(RVA = "0x40FF70", Offset = "0x40EB70", Length = "0x81")]
    static ItemGlovesPoison()
    {
    }
  }
}
