// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemForbiddenJuice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003B7")]
  public class ItemForbiddenJuice : ItemBase
  {
    [Token(Token = "0x40018EA")]
    [FieldOffset(Offset = "0x30")]
    private float critPerStack;

    [Token(Token = "0x6001A85")]
    [Address(RVA = "0x40CC60", Offset = "0x40B860", Length = "0x84")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001A86")]
    [Address(RVA = "0x40CCF0", Offset = "0x40B8F0", Length = "0xF")]
    public ItemForbiddenJuice(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001A87")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001A88")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001A89")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001A8A")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001A8B")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001A8C")]
    [Address(RVA = "0x40CAB0", Offset = "0x40B6B0", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
