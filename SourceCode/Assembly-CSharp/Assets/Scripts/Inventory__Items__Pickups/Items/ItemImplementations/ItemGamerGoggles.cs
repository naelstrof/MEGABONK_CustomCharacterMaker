// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemGamerGoggles
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003B8")]
  public class ItemGamerGoggles : ItemBase
  {
    [Token(Token = "0x40018EB")]
    [FieldOffset(Offset = "0x30")]
    private float maxDamagePerAmount;
    [Token(Token = "0x40018EC")]
    [FieldOffset(Offset = "0x34")]
    private float maxDamage;
    [Token(Token = "0x40018ED")]
    [FieldOffset(Offset = "0x38")]
    private float updateCooldown;
    [Token(Token = "0x40018EE")]
    [FieldOffset(Offset = "0x3C")]
    private float nextUpdateTime;
    [Token(Token = "0x40018EF")]
    [FieldOffset(Offset = "0x40")]
    private float lastValue;

    [Token(Token = "0x6001A8D")]
    [Address(RVA = "0x403CA0", Offset = "0x4028A0", Length = "0x13")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001A8E")]
    [Address(RVA = "0x40CDC0", Offset = "0x40B9C0", Length = "0x207")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001A8F")]
    [Address(RVA = "0x40CFD0", Offset = "0x40BBD0", Length = "0x1D")]
    public ItemGamerGoggles(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001A90")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001A91")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001A92")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001A93")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001A94")]
    [Address(RVA = "0x40CD00", Offset = "0x40B900", Length = "0xB2")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
