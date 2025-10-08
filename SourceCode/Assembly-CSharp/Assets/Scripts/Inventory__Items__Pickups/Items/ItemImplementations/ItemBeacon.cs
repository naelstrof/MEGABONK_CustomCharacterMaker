// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemBeacon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x200039C")]
  public class ItemBeacon : ItemBase
  {
    [Token(Token = "0x4001866")]
    [FieldOffset(Offset = "0x30")]
    private int extraShrinesPerAmount;
    [Token(Token = "0x4001867")]
    [FieldOffset(Offset = "0x34")]
    private float healingRadiusPerAmount;
    [Token(Token = "0x4001868")]
    [FieldOffset(Offset = "0x38")]
    private float healingFractionPerInterval;

    [Token(Token = "0x6001994")]
    [Address(RVA = "0x401550", Offset = "0x400150", Length = "0xA4")]
    public float GetHealingPerInterval() => 0.0f;

    [Token(Token = "0x6001995")]
    [Address(RVA = "0x401600", Offset = "0x400200", Length = "0x16")]
    public float GetRadius() => 0.0f;

    [Token(Token = "0x6001996")]
    [Address(RVA = "0x401540", Offset = "0x400140", Length = "0x8")]
    public int GetExtraShrines() => 0;

    [Token(Token = "0x6001997")]
    [Address(RVA = "0x401620", Offset = "0x400220", Length = "0x1D")]
    public ItemBeacon(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001998")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001999")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x600199A")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x600199B")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x600199C")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x600199D")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x600199E")]
    [Address(RVA = "0x401390", Offset = "0x3FFF90", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
