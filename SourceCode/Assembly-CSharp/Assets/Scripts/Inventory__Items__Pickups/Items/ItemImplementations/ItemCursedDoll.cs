// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemCursedDoll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003AC")]
  public class ItemCursedDoll : ItemBase
  {
    [Token(Token = "0x40018B3")]
    [FieldOffset(Offset = "0x30")]
    private int maxNumCursedEnemies;
    [Token(Token = "0x40018B4")]
    [FieldOffset(Offset = "0x34")]
    private float damageMaxHpPercentage;
    [Token(Token = "0x40018B5")]
    [FieldOffset(Offset = "0x38")]
    private int amountPerDoll;
    [Token(Token = "0x40018B6")]
    [FieldOffset(Offset = "0x40")]
    private DamageContainer reuseDc;
    [Token(Token = "0x40018B7")]
    [FieldOffset(Offset = "0x48")]
    private string damageSource;
    [Token(Token = "0x40018B8")]
    [FieldOffset(Offset = "0x50")]
    private HashSet<Enemy> cursedEnemies;
    [Token(Token = "0x40018B9")]
    [FieldOffset(Offset = "0x58")]
    private float attackCooldown;
    [Token(Token = "0x40018BA")]
    [FieldOffset(Offset = "0x5C")]
    private float nextAttackTime;

    [Token(Token = "0x6001A27")]
    [Address(RVA = "0x4071C0", Offset = "0x405DC0", Length = "0xB")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001A28")]
    [Address(RVA = "0x4071D0", Offset = "0x405DD0", Length = "0x7D9")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001A29")]
    [Address(RVA = "0x407140", Offset = "0x405D40", Length = "0x7C")]
    private void OnEnemyDied(Enemy enemy)
    {
    }

    [Token(Token = "0x6001A2A")]
    [Address(RVA = "0x406FF0", Offset = "0x405BF0", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001A2B")]
    [Address(RVA = "0x406D30", Offset = "0x405930", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001A2C")]
    [Address(RVA = "0x4079B0", Offset = "0x4065B0", Length = "0x161")]
    public ItemCursedDoll(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001A2D")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001A2E")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001A2F")]
    [Address(RVA = "0x406E80", Offset = "0x405A80", Length = "0x160")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
