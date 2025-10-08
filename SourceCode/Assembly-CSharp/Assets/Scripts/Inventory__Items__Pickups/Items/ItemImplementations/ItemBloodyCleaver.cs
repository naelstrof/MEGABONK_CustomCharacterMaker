// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemBloodyCleaver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x200039F")]
  public class ItemBloodyCleaver : ItemBase
  {
    [Token(Token = "0x400186F")]
    [FieldOffset(Offset = "0x30")]
    private int stacksPerAmount;
    [Token(Token = "0x4001870")]
    [FieldOffset(Offset = "0x34")]
    private int stacks;
    [Token(Token = "0x4001871")]
    [FieldOffset(Offset = "0x38")]
    private float chanceToStackPerAmount;
    [Token(Token = "0x4001872")]
    [FieldOffset(Offset = "0x3C")]
    private float totalChance;
    [Token(Token = "0x4001873")]
    private static string damageSource;
    [Token(Token = "0x4001874")]
    [FieldOffset(Offset = "0x40")]
    private DamageContainer dc;

    [Token(Token = "0x60019B0")]
    [Address(RVA = "0x4021F0", Offset = "0x400DF0", Length = "0x1D")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x60019B1")]
    [Address(RVA = "0x4020A0", Offset = "0x400CA0", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x60019B2")]
    [Address(RVA = "0x401DA0", Offset = "0x4009A0", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x60019B3")]
    [Address(RVA = "0x402280", Offset = "0x400E80", Length = "0x110")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x60019B4")]
    [Address(RVA = "0x402210", Offset = "0x400E10", Length = "0x6A")]
    private void OnLifestealProc(Enemy enemy, int lifestealAmount)
    {
    }

    [Token(Token = "0x60019B5")]
    [Address(RVA = "0x402430", Offset = "0x401030", Length = "0xCB")]
    public ItemBloodyCleaver(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x60019B6")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x60019B7")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x60019B8")]
    [Address(RVA = "0x401EF0", Offset = "0x400AF0", Length = "0x1AD")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;

    [Token(Token = "0x60019B9")]
    [Address(RVA = "0x4023A0", Offset = "0x400FA0", Length = "0x81")]
    static ItemBloodyCleaver()
    {
    }
  }
}
