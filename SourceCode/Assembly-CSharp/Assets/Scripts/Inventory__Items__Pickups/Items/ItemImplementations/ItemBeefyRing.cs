// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemBeefyRing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x200039D")]
  public class ItemBeefyRing : ItemBase
  {
    [Token(Token = "0x4001869")]
    [FieldOffset(Offset = "0x30")]
    private int maxHpPerStack;
    [Token(Token = "0x400186A")]
    [FieldOffset(Offset = "0x34")]
    private float powerPerHpPerAmount;
    [Token(Token = "0x400186B")]
    [FieldOffset(Offset = "0x38")]
    private int lastStoredMaxHp;
    [Token(Token = "0x400186C")]
    [FieldOffset(Offset = "0x3C")]
    private float nextUpdateTime;

    [Token(Token = "0x600199F")]
    [Address(RVA = "0x401810", Offset = "0x400410", Length = "0xCA")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x60019A0")]
    [Address(RVA = "0x4018E0", Offset = "0x4004E0", Length = "0xAE")]
    private void RefreshPower()
    {
    }

    [Token(Token = "0x60019A1")]
    [Address(RVA = "0x401990", Offset = "0x400590", Length = "0x12B")]
    public override void Tick()
    {
    }

    [Token(Token = "0x60019A2")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x60019A3")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x60019A4")]
    [Address(RVA = "0x401AC0", Offset = "0x4006C0", Length = "0x16")]
    public ItemBeefyRing(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x60019A5")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x60019A6")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x60019A7")]
    [Address(RVA = "0x401640", Offset = "0x400240", Length = "0x1C7")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
