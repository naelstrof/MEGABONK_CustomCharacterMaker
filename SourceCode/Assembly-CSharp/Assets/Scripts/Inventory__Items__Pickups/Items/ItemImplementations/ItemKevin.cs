// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemKevin
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
  [Token(Token = "0x20003CB")]
  public class ItemKevin : ItemBase
  {
    [Token(Token = "0x4001973")]
    [FieldOffset(Offset = "0x30")]
    private float damageChancePerAmount;
    [Token(Token = "0x4001974")]
    [FieldOffset(Offset = "0x34")]
    private float damageChance;
    [Token(Token = "0x4001975")]
    [FieldOffset(Offset = "0x38")]
    private int numHits;
    [Token(Token = "0x4001976")]
    public static string damageSource;

    [Token(Token = "0x6001B39")]
    [Address(RVA = "0x403CA0", Offset = "0x4028A0", Length = "0x13")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001B3A")]
    [Address(RVA = "0x4157D0", Offset = "0x4143D0", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001B3B")]
    [Address(RVA = "0x415510", Offset = "0x414110", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001B3C")]
    [Address(RVA = "0x415920", Offset = "0x414520", Length = "0x8C")]
    private void OnEnemyDamaged(Enemy enemy, DamageContainer dc)
    {
    }

    [Token(Token = "0x6001B3D")]
    [Address(RVA = "0x4151A0", Offset = "0x413DA0", Length = "0x36E")]
    private void CheckSelfDamage()
    {
    }

    [Token(Token = "0x6001B3E")]
    [Address(RVA = "0x4159B0", Offset = "0x4145B0", Length = "0x7")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001B3F")]
    [Address(RVA = "0x415A50", Offset = "0x414650", Length = "0xF")]
    public ItemKevin(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001B40")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001B41")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001B42")]
    [Address(RVA = "0x415660", Offset = "0x414260", Length = "0x160")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001B43")]
    [Address(RVA = "0x4159C0", Offset = "0x4145C0", Length = "0x81")]
    static ItemKevin()
    {
    }
  }
}
