// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemCreditCardRed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003AB")]
  public class ItemCreditCardRed : ItemBase
  {
    [Token(Token = "0x40018B0")]
    [FieldOffset(Offset = "0x30")]
    private float damagePerChestAmount;
    [Token(Token = "0x40018B1")]
    [FieldOffset(Offset = "0x34")]
    private float damagePerChest;
    [Token(Token = "0x40018B2")]
    [FieldOffset(Offset = "0x38")]
    private float accumulatedDamage;

    [Token(Token = "0x6001A1E")]
    [Address(RVA = "0x403CA0", Offset = "0x4028A0", Length = "0x13")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001A1F")]
    [Address(RVA = "0x406AD0", Offset = "0x4056D0", Length = "0x119")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001A20")]
    [Address(RVA = "0x406800", Offset = "0x405400", Length = "0x119")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001A21")]
    [Address(RVA = "0x406BF0", Offset = "0x4057F0", Length = "0x12A")]
    private void OnChestWindowOpen()
    {
    }

    [Token(Token = "0x6001A22")]
    [Address(RVA = "0x406D20", Offset = "0x405920", Length = "0xF")]
    public ItemCreditCardRed(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001A23")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001A24")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001A25")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001A26")]
    [Address(RVA = "0x406920", Offset = "0x405520", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
