// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemBorgor
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
  [Token(Token = "0x20003A2")]
  public class ItemBorgor : ItemBase
  {
    [Token(Token = "0x4001889")]
    public const int maxAmountAbsolute = 20;
    [Token(Token = "0x400188A")]
    private const float maxSpawnDistance = 30f;
    [Token(Token = "0x400188B")]
    [FieldOffset(Offset = "0x30")]
    private float baseChance;
    [Token(Token = "0x400188C")]
    [FieldOffset(Offset = "0x34")]
    private float chancePerAmount;
    [Token(Token = "0x400188D")]
    [FieldOffset(Offset = "0x38")]
    private float ratioHeal;
    [Token(Token = "0x400188E")]
    [FieldOffset(Offset = "0x3C")]
    private int flatHealPerAmount;
    [Token(Token = "0x400188F")]
    [FieldOffset(Offset = "0x40")]
    private int flatHeal;
    [Token(Token = "0x4001890")]
    [FieldOffset(Offset = "0x44")]
    private float chance;

    [Token(Token = "0x60019CD")]
    [Address(RVA = "0x403AD0", Offset = "0x4026D0", Length = "0x29")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x60019CE")]
    [Address(RVA = "0x4038A0", Offset = "0x4024A0", Length = "0x220")]
    private void OnEnemyDied(Enemy enemy, DamageContainer deathSource)
    {
    }

    [Token(Token = "0x60019CF")]
    [Address(RVA = "0x403750", Offset = "0x402350", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x60019D0")]
    [Address(RVA = "0x403480", Offset = "0x402080", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x60019D1")]
    [Address(RVA = "0x403740", Offset = "0x402340", Length = "0x6")]
    public static int GetMaxAmount() => 0;

    [Token(Token = "0x60019D2")]
    [Address(RVA = "0x403B00", Offset = "0x402700", Length = "0x2B")]
    public ItemBorgor(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x60019D3")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x60019D4")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x60019D5")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x60019D6")]
    [Address(RVA = "0x4035D0", Offset = "0x4021D0", Length = "0x160")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
