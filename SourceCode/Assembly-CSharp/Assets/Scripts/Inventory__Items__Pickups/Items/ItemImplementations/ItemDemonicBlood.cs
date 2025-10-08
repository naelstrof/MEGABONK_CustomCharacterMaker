// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemDemonicBlood
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003AF")]
  public class ItemDemonicBlood : ItemBase
  {
    [Token(Token = "0x40018C0")]
    private static readonly float hpPerStack;
    [Token(Token = "0x40018C1")]
    [FieldOffset(Offset = "0x30")]
    private int maxStacksPerAmount;
    [Token(Token = "0x40018C2")]
    [FieldOffset(Offset = "0x34")]
    private int stacks;
    [Token(Token = "0x40018C3")]
    [FieldOffset(Offset = "0x38")]
    private int maxStacks;
    [Token(Token = "0x40018C4")]
    [FieldOffset(Offset = "0x3C")]
    private int lastUsedStacks;
    [Token(Token = "0x40018C5")]
    [FieldOffset(Offset = "0x40")]
    private float nextUpdateTime;

    [Token(Token = "0x6001A3C")]
    [Address(RVA = "0x408640", Offset = "0x407240", Length = "0x13")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001A3D")]
    [Address(RVA = "0x408630", Offset = "0x407230", Length = "0xC")]
    private void OnEnemyDied(Enemy enemy, DamageContainer deathSource)
    {
    }

    [Token(Token = "0x6001A3E")]
    [Address(RVA = "0x408660", Offset = "0x407260", Length = "0x141")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001A3F")]
    [Address(RVA = "0x4084E0", Offset = "0x4070E0", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001A40")]
    [Address(RVA = "0x408150", Offset = "0x406D50", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001A41")]
    [Address(RVA = "0x4087F0", Offset = "0x4073F0", Length = "0x80")]
    public ItemDemonicBlood(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001A42")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001A43")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001A44")]
    [Address(RVA = "0x4082A0", Offset = "0x406EA0", Length = "0x232")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001A45")]
    [Address(RVA = "0x4087B0", Offset = "0x4073B0", Length = "0x39")]
    static ItemDemonicBlood()
    {
    }
  }
}
