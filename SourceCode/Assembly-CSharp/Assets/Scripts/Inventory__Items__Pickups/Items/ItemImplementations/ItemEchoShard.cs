// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemEchoShard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003B3")]
  public class ItemEchoShard : ItemBase
  {
    [Token(Token = "0x40018D6")]
    private static float chancePerAmount;
    [Token(Token = "0x40018D7")]
    [FieldOffset(Offset = "0x30")]
    public float chance;

    [Token(Token = "0x6001A61")]
    [Address(RVA = "0x409B20", Offset = "0x408720", Length = "0x62")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001A62")]
    [Address(RVA = "0x409A90", Offset = "0x408690", Length = "0x82")]
    public int GetExtraShards() => 0;

    [Token(Token = "0x6001A63")]
    [Address(RVA = "0x400A80", Offset = "0x3FF680", Length = "0x8")]
    public ItemEchoShard(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001A64")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001A65")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001A66")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001A67")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001A68")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001A69")]
    [Address(RVA = "0x409900", Offset = "0x408500", Length = "0x18B")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001A6A")]
    [Address(RVA = "0x409B90", Offset = "0x408790", Length = "0x39")]
    static ItemEchoShard()
    {
    }
  }
}
