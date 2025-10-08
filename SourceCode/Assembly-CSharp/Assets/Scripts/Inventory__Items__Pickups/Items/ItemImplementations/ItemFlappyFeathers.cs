// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemFlappyFeathers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003B6")]
  public class ItemFlappyFeathers : ItemBase
  {
    [Token(Token = "0x40018E7")]
    [FieldOffset(Offset = "0x30")]
    private float speedBoostPerAmount;
    [Token(Token = "0x40018E8")]
    [FieldOffset(Offset = "0x34")]
    private float jumpHeightAdditionPerAmount;
    [Token(Token = "0x40018E9")]
    [FieldOffset(Offset = "0x38")]
    private float speedBoost;

    [Token(Token = "0x6001A7D")]
    [Address(RVA = "0x40C8A0", Offset = "0x40B4A0", Length = "0x91")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001A7E")]
    [Address(RVA = "0x40C940", Offset = "0x40B540", Length = "0x141")]
    private void OnJumped(PlayerMovement pm)
    {
    }

    [Token(Token = "0x6001A7F")]
    [Address(RVA = "0x40C770", Offset = "0x40B370", Length = "0x121")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001A80")]
    [Address(RVA = "0x40C640", Offset = "0x40B240", Length = "0x121")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001A81")]
    [Address(RVA = "0x40CA90", Offset = "0x40B690", Length = "0x16")]
    public ItemFlappyFeathers(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001A82")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001A83")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001A84")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }
  }
}
