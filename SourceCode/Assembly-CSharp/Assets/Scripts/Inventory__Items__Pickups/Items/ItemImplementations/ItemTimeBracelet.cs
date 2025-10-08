// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemTimeBracelet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003E2")]
  public class ItemTimeBracelet : ItemBase
  {
    [Token(Token = "0x40019DC")]
    [FieldOffset(Offset = "0x30")]
    private float damagePerAmount;

    [Token(Token = "0x6001C02")]
    [Address(RVA = "0x427090", Offset = "0x425C90", Length = "0x84")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001C03")]
    [Address(RVA = "0x401380", Offset = "0x3FFF80", Length = "0xF")]
    public ItemTimeBracelet(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001C04")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001C05")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001C06")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001C07")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001C08")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001C09")]
    [Address(RVA = "0x426E80", Offset = "0x425A80", Length = "0x202")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
