// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemKey
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003CC")]
  public class ItemKey : ItemBase
  {
    [Token(Token = "0x4001977")]
    [FieldOffset(Offset = "0x30")]
    private float chancePerStack;
    [Token(Token = "0x4001978")]
    [FieldOffset(Offset = "0x34")]
    private float currentChance;

    [Token(Token = "0x6001B44")]
    [Address(RVA = "0x415BE0", Offset = "0x4147E0", Length = "0x22")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001B45")]
    [Address(RVA = "0x415A60", Offset = "0x414660", Length = "0x6")]
    public float GetChance() => 0.0f;

    [Token(Token = "0x6001B46")]
    [Address(RVA = "0x415C10", Offset = "0x414810", Length = "0x16")]
    public ItemKey(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001B47")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001B48")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001B49")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001B4A")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001B4B")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001B4C")]
    [Address(RVA = "0x415A70", Offset = "0x414670", Length = "0x160")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
