// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemSpikyShield
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003E0")]
  public class ItemSpikyShield : ItemBase
  {
    [Token(Token = "0x40019D6")]
    [FieldOffset(Offset = "0x30")]
    private float armorPerAmount;
    [Token(Token = "0x40019D7")]
    [FieldOffset(Offset = "0x34")]
    private float retaliationPerArmorPerAmount;
    [Token(Token = "0x40019D8")]
    [FieldOffset(Offset = "0x38")]
    private float lastStoredArmor;
    [Token(Token = "0x40019D9")]
    [FieldOffset(Offset = "0x3C")]
    private float nextUpdateTime;

    [Token(Token = "0x6001BF1")]
    [Address(RVA = "0x426940", Offset = "0x425540", Length = "0xBD")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001BF2")]
    [Address(RVA = "0x426B50", Offset = "0x425750", Length = "0xCC")]
    private void UpdateRetaliation()
    {
    }

    [Token(Token = "0x6001BF3")]
    [Address(RVA = "0x426A00", Offset = "0x425600", Length = "0x148")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001BF4")]
    [Address(RVA = "0x426C20", Offset = "0x425820", Length = "0x16")]
    public ItemSpikyShield(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001BF5")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001BF6")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001BF7")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001BF8")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001BF9")]
    [Address(RVA = "0x426730", Offset = "0x425330", Length = "0x204")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
