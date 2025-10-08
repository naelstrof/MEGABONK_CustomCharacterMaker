// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemJoesDagger
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
  [Token(Token = "0x20003CA")]
  public class ItemJoesDagger : ItemBase
  {
    [Token(Token = "0x400196A")]
    [FieldOffset(Offset = "0x30")]
    private float attackDamagePerProc;
    [Token(Token = "0x400196B")]
    [FieldOffset(Offset = "0x34")]
    private float accumulatedDamaged;
    [Token(Token = "0x400196C")]
    [FieldOffset(Offset = "0x38")]
    private float executionChancePerAmount;
    [Token(Token = "0x400196D")]
    [FieldOffset(Offset = "0x3C")]
    private float executionChance;
    [Token(Token = "0x400196E")]
    [FieldOffset(Offset = "0x40")]
    private int stacks;
    [Token(Token = "0x400196F")]
    [FieldOffset(Offset = "0x44")]
    private int maxStacks;
    [Token(Token = "0x4001970")]
    [FieldOffset(Offset = "0x48")]
    private int lastUsedStacks;
    [Token(Token = "0x4001971")]
    [FieldOffset(Offset = "0x4C")]
    private float nextUpdateTime;
    [Token(Token = "0x4001972")]
    [FieldOffset(Offset = "0x50")]
    private string damageSource;

    [Token(Token = "0x6001B30")]
    [Address(RVA = "0x414F30", Offset = "0x413B30", Length = "0x16")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001B31")]
    [Address(RVA = "0x415000", Offset = "0x413C00", Length = "0xF4")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001B32")]
    [Address(RVA = "0x414ED0", Offset = "0x413AD0", Length = "0x53")]
    private void OnEnemyDamage(Enemy e, DamageContainer dc)
    {
    }

    [Token(Token = "0x6001B33")]
    [Address(RVA = "0x414D80", Offset = "0x413980", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001B34")]
    [Address(RVA = "0x414A20", Offset = "0x413620", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001B35")]
    [Address(RVA = "0x415100", Offset = "0x413D00", Length = "0x9A")]
    public ItemJoesDagger(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001B36")]
    [Address(RVA = "0x414F50", Offset = "0x413B50", Length = "0xAB")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001B37")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001B38")]
    [Address(RVA = "0x414B70", Offset = "0x413770", Length = "0x20C")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
