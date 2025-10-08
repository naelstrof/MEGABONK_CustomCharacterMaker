// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemScarf
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003D8")]
  public class ItemScarf : ItemBase
  {
    [Token(Token = "0x40019B2")]
    [FieldOffset(Offset = "0x30")]
    private float damageAddPerAmount;
    [Token(Token = "0x40019B3")]
    [FieldOffset(Offset = "0x34")]
    private float damageAdd;
    [Token(Token = "0x40019B4")]
    [FieldOffset(Offset = "0x38")]
    private float lastValueSet;

    [Token(Token = "0x6001BA7")]
    [Address(RVA = "0x423D40", Offset = "0x422940", Length = "0xF1")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001BA8")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001BA9")]
    [Address(RVA = "0x423D30", Offset = "0x422930", Length = "0x8")]
    private void OnGroundedChange(bool grounded)
    {
    }

    [Token(Token = "0x6001BAA")]
    [Address(RVA = "0x423E40", Offset = "0x422A40", Length = "0x99")]
    private void UpdateDamage(bool grounded)
    {
    }

    [Token(Token = "0x6001BAB")]
    [Address(RVA = "0x423EE0", Offset = "0x422AE0", Length = "0xF")]
    public ItemScarf(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001BAC")]
    [Address(RVA = "0x423C00", Offset = "0x422800", Length = "0x128")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001BAD")]
    [Address(RVA = "0x4239A0", Offset = "0x4225A0", Length = "0x128")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001BAE")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001BAF")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001BB0")]
    [Address(RVA = "0x423AD0", Offset = "0x4226D0", Length = "0x125")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
