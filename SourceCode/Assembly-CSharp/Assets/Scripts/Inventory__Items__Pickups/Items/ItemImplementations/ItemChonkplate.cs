// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemChonkplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003A7")]
  public class ItemChonkplate : ItemBase
  {
    [Token(Token = "0x40018A3")]
    [FieldOffset(Offset = "0x30")]
    private float overhealPerAmount;
    [Token(Token = "0x40018A4")]
    [FieldOffset(Offset = "0x34")]
    private float lifestealPerAmount;

    [Token(Token = "0x60019FA")]
    [Address(RVA = "0x4057E0", Offset = "0x4043E0", Length = "0xD4")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x60019FB")]
    [Address(RVA = "0x4058C0", Offset = "0x4044C0", Length = "0x16")]
    public ItemChonkplate(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x60019FC")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x60019FD")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x60019FE")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x60019FF")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001A00")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001A01")]
    [Address(RVA = "0x4055E0", Offset = "0x4041E0", Length = "0x1F9")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
