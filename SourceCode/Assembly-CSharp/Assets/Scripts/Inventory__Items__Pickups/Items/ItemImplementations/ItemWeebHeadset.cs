// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemWeebHeadset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003E6")]
  public class ItemWeebHeadset : ItemBase
  {
    [Token(Token = "0x40019EA")]
    [FieldOffset(Offset = "0x30")]
    public float charmChancePerAmount;
    [Token(Token = "0x40019EB")]
    [FieldOffset(Offset = "0x34")]
    private float durationPerAmount;
    [Token(Token = "0x40019EC")]
    [FieldOffset(Offset = "0x38")]
    private float charmDuration;
    [Token(Token = "0x40019ED")]
    [FieldOffset(Offset = "0x3C")]
    private float charmChance;
    [Token(Token = "0x40019EE")]
    [FieldOffset(Offset = "0x40")]
    private int maxProcsPerTick;
    [Token(Token = "0x40019EF")]
    [FieldOffset(Offset = "0x44")]
    private int numProcsThisTick;

    [Token(Token = "0x6001C23")]
    [Address(RVA = "0x427E20", Offset = "0x426A20", Length = "0x1D")]
    public ItemWeebHeadset(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001C24")]
    [Address(RVA = "0x427D10", Offset = "0x426910", Length = "0x67")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001C25")]
    [Address(RVA = "0x427D80", Offset = "0x426980", Length = "0x8C")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001C26")]
    [Address(RVA = "0x427E10", Offset = "0x426A10", Length = "0x8")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001C27")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001C28")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001C29")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }
  }
}
