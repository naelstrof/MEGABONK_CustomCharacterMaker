// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemTurboSocks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003E4")]
  public class ItemTurboSocks : ItemBase
  {
    [Token(Token = "0x40019E7")]
    [FieldOffset(Offset = "0x30")]
    private float moveSpeedPerAmount;

    [Token(Token = "0x6001C13")]
    [Address(RVA = "0x427980", Offset = "0x426580", Length = "0x7E")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001C14")]
    [Address(RVA = "0x403D90", Offset = "0x402990", Length = "0xF")]
    public ItemTurboSocks(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001C15")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001C16")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001C17")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001C18")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001C19")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001C1A")]
    [Address(RVA = "0x4277D0", Offset = "0x4263D0", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
