// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemDragonfire
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003B1")]
  public class ItemDragonfire : ItemBase
  {
    [Token(Token = "0x40018CC")]
    [FieldOffset(Offset = "0x30")]
    public float procChancePerAmount;
    [Token(Token = "0x40018CD")]
    [FieldOffset(Offset = "0x34")]
    private float procChance;
    [Token(Token = "0x40018CE")]
    [FieldOffset(Offset = "0x38")]
    private float burnChancePerAmount;
    [Token(Token = "0x40018CF")]
    [FieldOffset(Offset = "0x3C")]
    private float burnChance;
    [Token(Token = "0x40018D0")]
    [FieldOffset(Offset = "0x40")]
    private string damageSource;

    [Token(Token = "0x6001A50")]
    [Address(RVA = "0x408FC0", Offset = "0x407BC0", Length = "0x43")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001A51")]
    [Address(RVA = "0x409010", Offset = "0x407C10", Length = "0x3F0")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001A52")]
    [Address(RVA = "0x409410", Offset = "0x408010", Length = "0x71")]
    private void TryProcBurn(DamageContainer dc, float overrideProcCoefficient = -1f)
    {
    }

    [Token(Token = "0x6001A53")]
    [Address(RVA = "0x409490", Offset = "0x408090", Length = "0x8C")]
    public ItemDragonfire(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001A54")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001A55")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001A56")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001A57")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001A58")]
    [Address(RVA = "0x408EE0", Offset = "0x407AE0", Length = "0xDE")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
