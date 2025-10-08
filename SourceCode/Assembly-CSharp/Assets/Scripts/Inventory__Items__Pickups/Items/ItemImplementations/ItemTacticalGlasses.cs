// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemTacticalGlasses
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003E1")]
  public class ItemTacticalGlasses : ItemBase
  {
    [Token(Token = "0x40019DA")]
    [FieldOffset(Offset = "0x30")]
    private float damagePerAmount;
    [Token(Token = "0x40019DB")]
    [FieldOffset(Offset = "0x34")]
    private float additiveDamage;

    [Token(Token = "0x6001BFA")]
    [Address(RVA = "0x403CA0", Offset = "0x4028A0", Length = "0x13")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001BFB")]
    [Address(RVA = "0x426E70", Offset = "0x425A70", Length = "0xF")]
    public ItemTacticalGlasses(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001BFC")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001BFD")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001BFE")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001BFF")]
    [Address(RVA = "0x426DB0", Offset = "0x4259B0", Length = "0xB0")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001C00")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001C01")]
    [Address(RVA = "0x426C40", Offset = "0x425840", Length = "0x160")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
