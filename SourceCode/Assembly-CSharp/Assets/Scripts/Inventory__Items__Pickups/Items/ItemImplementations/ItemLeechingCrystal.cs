// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemLeechingCrystal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003CD")]
  public class ItemLeechingCrystal : ItemBase
  {
    [Token(Token = "0x4001979")]
    [FieldOffset(Offset = "0x30")]
    private float regenAdditivePerAmount;
    [Token(Token = "0x400197A")]
    [FieldOffset(Offset = "0x34")]
    private float maxHpPerAmount;

    [Token(Token = "0x6001B4D")]
    [Address(RVA = "0x415E00", Offset = "0x414A00", Length = "0xCA")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001B4E")]
    [Address(RVA = "0x415ED0", Offset = "0x414AD0", Length = "0x16")]
    public ItemLeechingCrystal(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001B4F")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001B50")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001B51")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001B52")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001B53")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001B54")]
    [Address(RVA = "0x415C30", Offset = "0x414830", Length = "0x1C2")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
