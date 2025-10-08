// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemEnergyCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003B5")]
  public class ItemEnergyCore : ItemBase
  {
    [Token(Token = "0x40018DE")]
    [FieldOffset(Offset = "0x30")]
    private int orbsPerAmount;
    [Token(Token = "0x40018DF")]
    [FieldOffset(Offset = "0x34")]
    private int numOrbs;
    [Token(Token = "0x40018E0")]
    [FieldOffset(Offset = "0x38")]
    private float range;
    [Token(Token = "0x40018E1")]
    [FieldOffset(Offset = "0x3C")]
    private float cooldown;
    [Token(Token = "0x40018E2")]
    [FieldOffset(Offset = "0x40")]
    private float cooldownPerOrb;
    [Token(Token = "0x40018E3")]
    [FieldOffset(Offset = "0x44")]
    private float nextSpawnTime;
    [Token(Token = "0x40018E4")]
    [FieldOffset(Offset = "0x48")]
    private int orbsLeftToShoot;
    [Token(Token = "0x40018E5")]
    [FieldOffset(Offset = "0x4C")]
    private float nextOrbTime;
    [Token(Token = "0x40018E6")]
    [FieldOffset(Offset = "0x50")]
    private string damageSource;

    [Token(Token = "0x6001A74")]
    [Address(RVA = "0x40A850", Offset = "0x409450", Length = "0x35")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001A75")]
    [Address(RVA = "0x40A7E0", Offset = "0x4093E0", Length = "0x6D")]
    private float GetDamage() => 0.0f;

    [Token(Token = "0x6001A76")]
    [Address(RVA = "0x40A890", Offset = "0x409490", Length = "0x121")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001A77")]
    [Address(RVA = "0x40A510", Offset = "0x409110", Length = "0x2C0")]
    private void FireOrb(int index)
    {
    }

    [Token(Token = "0x6001A78")]
    [Address(RVA = "0x40A9C0", Offset = "0x4095C0", Length = "0xA1")]
    public ItemEnergyCore(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001A79")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001A7A")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001A7B")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001A7C")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }
  }
}
