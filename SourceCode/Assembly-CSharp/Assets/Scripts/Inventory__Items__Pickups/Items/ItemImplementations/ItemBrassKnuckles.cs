// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemBrassKnuckles
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003A4")]
  public class ItemBrassKnuckles : ItemBase
  {
    [Token(Token = "0x4001893")]
    [FieldOffset(Offset = "0x30")]
    private float damagePerAmount;
    [Token(Token = "0x4001894")]
    [FieldOffset(Offset = "0x34")]
    private float additiveValue;
    [Token(Token = "0x4001895")]
    [FieldOffset(Offset = "0x38")]
    private float radius;

    [Token(Token = "0x60019DF")]
    [Address(RVA = "0x403CA0", Offset = "0x4028A0", Length = "0x13")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x60019E0")]
    [Address(RVA = "0x403E80", Offset = "0x402A80", Length = "0x4F")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x60019E1")]
    [Address(RVA = "0x403ED0", Offset = "0x402AD0", Length = "0x16")]
    public ItemBrassKnuckles(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x60019E2")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x60019E3")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x60019E4")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x60019E5")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x60019E6")]
    [Address(RVA = "0x403DA0", Offset = "0x4029A0", Length = "0xDE")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
