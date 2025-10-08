// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemBonker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003A1")]
  public class ItemBonker : ItemBase
  {
    [Token(Token = "0x400187C")]
    [FieldOffset(Offset = "0x30")]
    private float baseChance;
    [Token(Token = "0x400187D")]
    [FieldOffset(Offset = "0x34")]
    private float baseDamageMultiplier;
    [Token(Token = "0x400187E")]
    [FieldOffset(Offset = "0x38")]
    private float chancePerStack;
    [Token(Token = "0x400187F")]
    [FieldOffset(Offset = "0x3C")]
    private float damageMultiplierPerStack;
    [Token(Token = "0x4001880")]
    [FieldOffset(Offset = "0x40")]
    private float radiusPerStack;
    [Token(Token = "0x4001881")]
    [FieldOffset(Offset = "0x44")]
    private float radius;
    [Token(Token = "0x4001882")]
    [FieldOffset(Offset = "0x48")]
    private float maxRadius;
    [Token(Token = "0x4001883")]
    [FieldOffset(Offset = "0x4C")]
    private float chance;
    [Token(Token = "0x4001884")]
    [FieldOffset(Offset = "0x50")]
    private float damageMultiplier;
    [Token(Token = "0x4001885")]
    [FieldOffset(Offset = "0x58")]
    private string damageSource;
    [Token(Token = "0x4001886")]
    [FieldOffset(Offset = "0x60")]
    private DamageContainer reuseDc;
    [Token(Token = "0x4001887")]
    [FieldOffset(Offset = "0x68")]
    private int maxProcsPerTick;
    [Token(Token = "0x4001888")]
    [FieldOffset(Offset = "0x6C")]
    private int numProcsThisTick;

    [Token(Token = "0x60019C5")]
    [Address(RVA = "0x402D30", Offset = "0x401930", Length = "0x75")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x60019C6")]
    [Address(RVA = "0x402DB0", Offset = "0x4019B0", Length = "0x572")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x60019C7")]
    [Address(RVA = "0x403330", Offset = "0x401F30", Length = "0x8")]
    public override void Tick()
    {
    }

    [Token(Token = "0x60019C8")]
    [Address(RVA = "0x403340", Offset = "0x401F40", Length = "0x132")]
    public ItemBonker(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x60019C9")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x60019CA")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x60019CB")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x60019CC")]
    [Address(RVA = "0x402BA0", Offset = "0x4017A0", Length = "0x188")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
