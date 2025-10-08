// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemSpicyMeatball
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003DF")]
  public class ItemSpicyMeatball : ItemBase
  {
    [Token(Token = "0x40019CC")]
    [FieldOffset(Offset = "0x30")]
    private float baseRadius;
    [Token(Token = "0x40019CD")]
    [FieldOffset(Offset = "0x34")]
    private float radiusPerAmount;
    [Token(Token = "0x40019CE")]
    [FieldOffset(Offset = "0x38")]
    private float maxRadius;
    [Token(Token = "0x40019CF")]
    [FieldOffset(Offset = "0x3C")]
    private float radius;
    [Token(Token = "0x40019D0")]
    [FieldOffset(Offset = "0x40")]
    private float damageSpreadMultiplier;
    [Token(Token = "0x40019D1")]
    [FieldOffset(Offset = "0x44")]
    private float procChance;
    [Token(Token = "0x40019D2")]
    [FieldOffset(Offset = "0x48")]
    private string damageSource;
    [Token(Token = "0x40019D3")]
    [FieldOffset(Offset = "0x50")]
    private DamageContainer reuseDc;
    [Token(Token = "0x40019D4")]
    [FieldOffset(Offset = "0x58")]
    private int maxProcsPerTick;
    [Token(Token = "0x40019D5")]
    [FieldOffset(Offset = "0x5C")]
    private int numProcsThisTick;

    [Token(Token = "0x6001BE9")]
    [Address(RVA = "0x4261D0", Offset = "0x424DD0", Length = "0x80")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001BEA")]
    [Address(RVA = "0x426250", Offset = "0x424E50", Length = "0x391")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001BEB")]
    [Address(RVA = "0x4265F0", Offset = "0x4251F0", Length = "0x8")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001BEC")]
    [Address(RVA = "0x426600", Offset = "0x425200", Length = "0x124")]
    public ItemSpicyMeatball(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001BED")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001BEE")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001BEF")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001BF0")]
    [Address(RVA = "0x426040", Offset = "0x424C40", Length = "0x184")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
