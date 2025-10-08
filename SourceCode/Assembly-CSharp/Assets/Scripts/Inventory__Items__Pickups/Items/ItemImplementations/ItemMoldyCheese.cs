// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemMoldyCheese
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003D1")]
  public class ItemMoldyCheese : ItemBase
  {
    [Token(Token = "0x4001990")]
    [FieldOffset(Offset = "0x30")]
    private float chanceToStackPerAmount;
    [Token(Token = "0x4001991")]
    [FieldOffset(Offset = "0x34")]
    private float totalChance;
    [Token(Token = "0x4001992")]
    [FieldOffset(Offset = "0x38")]
    private int procsSinceLastTick;

    [Token(Token = "0x6001B70")]
    [Address(RVA = "0x4222E0", Offset = "0x420EE0", Length = "0xF")]
    public ItemMoldyCheese(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001B71")]
    [Address(RVA = "0x403CA0", Offset = "0x4028A0", Length = "0x13")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001B72")]
    [Address(RVA = "0x422170", Offset = "0x420D70", Length = "0xFB")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001B73")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001B74")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001B75")]
    [Address(RVA = "0x422270", Offset = "0x420E70", Length = "0x66")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001B76")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001B77")]
    [Address(RVA = "0x422000", Offset = "0x420C00", Length = "0x160")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
