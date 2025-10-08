// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemCreditCardGreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003AA")]
  public class ItemCreditCardGreen : ItemBase
  {
    [Token(Token = "0x40018AD")]
    [FieldOffset(Offset = "0x30")]
    private float luckPerChestPerAmount;
    [Token(Token = "0x40018AE")]
    [FieldOffset(Offset = "0x34")]
    private float luckPerChest;
    [Token(Token = "0x40018AF")]
    [FieldOffset(Offset = "0x38")]
    private float accumulatedLuck;

    [Token(Token = "0x6001A15")]
    [Address(RVA = "0x403CA0", Offset = "0x4028A0", Length = "0x13")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001A16")]
    [Address(RVA = "0x406590", Offset = "0x405190", Length = "0x119")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001A17")]
    [Address(RVA = "0x4062C0", Offset = "0x404EC0", Length = "0x119")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001A18")]
    [Address(RVA = "0x4066B0", Offset = "0x4052B0", Length = "0x130")]
    private void OnChestWindowOpen()
    {
    }

    [Token(Token = "0x6001A19")]
    [Address(RVA = "0x4067F0", Offset = "0x4053F0", Length = "0xF")]
    public ItemCreditCardGreen(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001A1A")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001A1B")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001A1C")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001A1D")]
    [Address(RVA = "0x4063E0", Offset = "0x404FE0", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
