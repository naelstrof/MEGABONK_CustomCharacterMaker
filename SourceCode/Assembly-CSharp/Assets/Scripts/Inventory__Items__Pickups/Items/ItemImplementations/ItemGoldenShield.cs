// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemGoldenShield
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003C2")]
  public class ItemGoldenShield : ItemBase
  {
    [Token(Token = "0x400192F")]
    [FieldOffset(Offset = "0x30")]
    private float chancePerAmount;
    [Token(Token = "0x4001930")]
    [FieldOffset(Offset = "0x34")]
    private float chance;
    [Token(Token = "0x4001931")]
    [FieldOffset(Offset = "0x38")]
    private int extraGoldFromOverload;
    [Token(Token = "0x4001932")]
    [FieldOffset(Offset = "0x3C")]
    private int goldPerAmount;
    [Token(Token = "0x4001933")]
    [FieldOffset(Offset = "0x40")]
    private int goldOnHit;
    [Token(Token = "0x4001934")]
    [FieldOffset(Offset = "0x44")]
    private float cooldown;
    [Token(Token = "0x4001935")]
    [FieldOffset(Offset = "0x48")]
    private float readyAtTime;

    [Token(Token = "0x6001AEC")]
    [Address(RVA = "0x410FF0", Offset = "0x40FBF0", Length = "0xAD")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001AED")]
    [Address(RVA = "0x4110A0", Offset = "0x40FCA0", Length = "0x13C")]
    private void OnPlayerTakeDamage(PlayerHealth playerHealth, DamageContainer dc, bool b)
    {
    }

    [Token(Token = "0x6001AEE")]
    [Address(RVA = "0x363880", Offset = "0x362480", Length = "0x4")]
    private int GetGold() => 0;

    [Token(Token = "0x6001AEF")]
    [Address(RVA = "0x410EA0", Offset = "0x40FAA0", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001AF0")]
    [Address(RVA = "0x410D50", Offset = "0x40F950", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001AF1")]
    [Address(RVA = "0x4111E0", Offset = "0x40FDE0", Length = "0x1D")]
    public ItemGoldenShield(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001AF2")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001AF3")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001AF4")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }
  }
}
