// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemDemonBlade
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
  [Token(Token = "0x20003AE")]
  public class ItemDemonBlade : ItemBase
  {
    [Token(Token = "0x40018BD")]
    [FieldOffset(Offset = "0x30")]
    private float critChance;
    [Token(Token = "0x40018BE")]
    [FieldOffset(Offset = "0x34")]
    private float healChancePerStack;
    [Token(Token = "0x40018BF")]
    [FieldOffset(Offset = "0x38")]
    private float totalHealChance;

    [Token(Token = "0x6001A33")]
    [Address(RVA = "0x4080A0", Offset = "0x406CA0", Length = "0x8A")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001A34")]
    [Address(RVA = "0x407F30", Offset = "0x406B30", Length = "0x16E")]
    private void OnEnemyDamaged(Enemy e, DamageContainer dc)
    {
    }

    [Token(Token = "0x6001A35")]
    [Address(RVA = "0x408130", Offset = "0x406D30", Length = "0x16")]
    public ItemDemonBlade(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001A36")]
    [Address(RVA = "0x407DE0", Offset = "0x4069E0", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001A37")]
    [Address(RVA = "0x407B20", Offset = "0x406720", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001A38")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001A39")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001A3A")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001A3B")]
    [Address(RVA = "0x407C70", Offset = "0x406870", Length = "0x160")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
