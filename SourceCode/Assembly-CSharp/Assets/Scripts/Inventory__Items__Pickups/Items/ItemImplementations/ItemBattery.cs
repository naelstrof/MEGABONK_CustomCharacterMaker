// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemBattery
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x200039B")]
  public class ItemBattery : ItemBase
  {
    [Token(Token = "0x4001865")]
    [FieldOffset(Offset = "0x30")]
    private float attackSpeedPerStack;

    [Token(Token = "0x600198C")]
    [Address(RVA = "0x4012F0", Offset = "0x3FFEF0", Length = "0x84")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x600198D")]
    [Address(RVA = "0x401380", Offset = "0x3FFF80", Length = "0xF")]
    public ItemBattery(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x600198E")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x600198F")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001990")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001991")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001992")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001993")]
    [Address(RVA = "0x401140", Offset = "0x3FFD40", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
