// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemGiantFork
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003BB")]
  public class ItemGiantFork : ItemBase
  {
    [Token(Token = "0x40018FD")]
    [FieldOffset(Offset = "0x30")]
    private float critChancePerAmount;
    [Token(Token = "0x40018FE")]
    [FieldOffset(Offset = "0x34")]
    private float megaCritChancePerAmount;
    [Token(Token = "0x40018FF")]
    [FieldOffset(Offset = "0x38")]
    private float megaCritChance;
    [Token(Token = "0x4001900")]
    [FieldOffset(Offset = "0x3C")]
    private float megaCritDamageMultiplier;

    [Token(Token = "0x6001AAB")]
    [Address(RVA = "0x40DD80", Offset = "0x40C980", Length = "0x96")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001AAC")]
    [Address(RVA = "0x40DE20", Offset = "0x40CA20", Length = "0x4E")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001AAD")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001AAE")]
    [Address(RVA = "0x40DE70", Offset = "0x40CA70", Length = "0x1D")]
    public ItemGiantFork(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001AAF")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001AB0")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001AB1")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }
  }
}
