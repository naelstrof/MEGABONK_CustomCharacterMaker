// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemDemonicSoul
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
  [Token(Token = "0x20003B0")]
  public class ItemDemonicSoul : ItemBase
  {
    [Token(Token = "0x40018C6")]
    private static readonly float attackDamagePerStack;
    [Token(Token = "0x40018C7")]
    [FieldOffset(Offset = "0x30")]
    private int maxStacksPerAmount;
    [Token(Token = "0x40018C8")]
    [FieldOffset(Offset = "0x34")]
    private int stacks;
    [Token(Token = "0x40018C9")]
    [FieldOffset(Offset = "0x38")]
    private int maxStacks;
    [Token(Token = "0x40018CA")]
    [FieldOffset(Offset = "0x3C")]
    private int lastUsedStacks;
    [Token(Token = "0x40018CB")]
    [FieldOffset(Offset = "0x40")]
    private float nextUpdateTime;

    [Token(Token = "0x6001A46")]
    [Address(RVA = "0x408640", Offset = "0x407240", Length = "0x13")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001A47")]
    [Address(RVA = "0x408CB0", Offset = "0x4078B0", Length = "0x1D")]
    private void OnEnemyDied(Enemy enemy, DamageContainer deathSource)
    {
    }

    [Token(Token = "0x6001A48")]
    [Address(RVA = "0x408CD0", Offset = "0x4078D0", Length = "0x141")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001A49")]
    [Address(RVA = "0x408B60", Offset = "0x407760", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001A4A")]
    [Address(RVA = "0x408870", Offset = "0x407470", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001A4B")]
    [Address(RVA = "0x408E60", Offset = "0x407A60", Length = "0x80")]
    public ItemDemonicSoul(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001A4C")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001A4D")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001A4E")]
    [Address(RVA = "0x4089C0", Offset = "0x4075C0", Length = "0x19E")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;

    [Token(Token = "0x6001A4F")]
    [Address(RVA = "0x408E20", Offset = "0x407A20", Length = "0x39")]
    static ItemDemonicSoul()
    {
    }
  }
}
