// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemGoldenGlove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003C1")]
  public class ItemGoldenGlove : ItemBase
  {
    [Token(Token = "0x400192C")]
    [FieldOffset(Offset = "0x30")]
    private float chancePerAmount;
    [Token(Token = "0x400192D")]
    [FieldOffset(Offset = "0x34")]
    private float chance;
    [Token(Token = "0x400192E")]
    [FieldOffset(Offset = "0x38")]
    private int extraGoldFromOverload;

    [Token(Token = "0x6001AE3")]
    [Address(RVA = "0x410CC0", Offset = "0x40F8C0", Length = "0x89")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001AE4")]
    [Address(RVA = "0x410C30", Offset = "0x40F830", Length = "0x84")]
    public int GetExtraGold() => 0;

    [Token(Token = "0x6001AE5")]
    [Address(RVA = "0x403D90", Offset = "0x402990", Length = "0xF")]
    public ItemGoldenGlove(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001AE6")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001AE7")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001AE8")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001AE9")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001AEA")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001AEB")]
    [Address(RVA = "0x410AC0", Offset = "0x40F6C0", Length = "0x160")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
