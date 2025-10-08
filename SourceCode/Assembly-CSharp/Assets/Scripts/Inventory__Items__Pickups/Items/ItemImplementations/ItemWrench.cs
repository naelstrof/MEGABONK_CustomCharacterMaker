// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemWrench
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003E7")]
  public class ItemWrench : ItemBase
  {
    [Token(Token = "0x40019F0")]
    [FieldOffset(Offset = "0x30")]
    private float chargeSpeedIncrease;
    [Token(Token = "0x40019F1")]
    [FieldOffset(Offset = "0x34")]
    private float chargeRewardIncrease;

    [Token(Token = "0x6001C2A")]
    [Address(RVA = "0x427E60", Offset = "0x426A60", Length = "0xE")]
    public float GetChargeSpeedIncrease() => 0.0f;

    [Token(Token = "0x6001C2B")]
    [Address(RVA = "0x427E40", Offset = "0x426A40", Length = "0x16")]
    public float GetChargeRewardMultiplier() => 0.0f;

    [Token(Token = "0x6001C2C")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001C2D")]
    [Address(RVA = "0x4280A0", Offset = "0x426CA0", Length = "0x16")]
    public ItemWrench(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001C2E")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001C2F")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001C30")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001C31")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001C32")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001C33")]
    [Address(RVA = "0x427E70", Offset = "0x426A70", Length = "0x222")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
