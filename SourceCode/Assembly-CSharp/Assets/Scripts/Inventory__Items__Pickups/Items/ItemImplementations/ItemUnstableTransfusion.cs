// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemUnstableTransfusion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003E5")]
  public class ItemUnstableTransfusion : ItemBase
  {
    [Token(Token = "0x40019E8")]
    [FieldOffset(Offset = "0x30")]
    private float chanceToStackPerAmount;
    [Token(Token = "0x40019E9")]
    [FieldOffset(Offset = "0x34")]
    private float totalChance;

    [Token(Token = "0x6001C1B")]
    [Address(RVA = "0x403CA0", Offset = "0x4028A0", Length = "0x13")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001C1C")]
    [Address(RVA = "0x427C00", Offset = "0x426800", Length = "0xF4")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001C1D")]
    [Address(RVA = "0x427D00", Offset = "0x426900", Length = "0xF")]
    public ItemUnstableTransfusion(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001C1E")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001C1F")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001C20")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001C21")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001C22")]
    [Address(RVA = "0x427A00", Offset = "0x426600", Length = "0x1F9")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
