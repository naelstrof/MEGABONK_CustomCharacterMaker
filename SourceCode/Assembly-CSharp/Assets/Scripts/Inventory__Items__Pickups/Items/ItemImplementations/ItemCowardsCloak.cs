// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemCowardsCloak
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003A9")]
  public class ItemCowardsCloak : ItemBase
  {
    [Token(Token = "0x40018A6")]
    [FieldOffset(Offset = "0x30")]
    private float speedPerAmount;
    [Token(Token = "0x40018A7")]
    [FieldOffset(Offset = "0x34")]
    private float speedPerStack;
    [Token(Token = "0x40018A8")]
    [FieldOffset(Offset = "0x38")]
    private int maxStacks;
    [Token(Token = "0x40018A9")]
    [FieldOffset(Offset = "0x3C")]
    private int stacksPerAmount;
    [Token(Token = "0x40018AA")]
    [FieldOffset(Offset = "0x40")]
    private float extraDurationPerAmount;
    [Token(Token = "0x40018AB")]
    [FieldOffset(Offset = "0x44")]
    private float stacksResetAtTime;
    [Token(Token = "0x40018AC")]
    [FieldOffset(Offset = "0x48")]
    private int stacks;

    [Token(Token = "0x6001A0A")]
    [Address(RVA = "0x4060E0", Offset = "0x404CE0", Length = "0x7")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001A0B")]
    [Address(RVA = "0x406020", Offset = "0x404C20", Length = "0xB5")]
    private void OnDamage(PlayerHealth ph, DamageContainer dc, bool shieldDamage)
    {
    }

    [Token(Token = "0x6001A0C")]
    [Address(RVA = "0x405B30", Offset = "0x404730", Length = "0x93")]
    private void AddTemporaryStack()
    {
    }

    [Token(Token = "0x6001A0D")]
    [Address(RVA = "0x406210", Offset = "0x404E10", Length = "0x78")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001A0E")]
    [Address(RVA = "0x4060F0", Offset = "0x404CF0", Length = "0x110")]
    private void RefreshStats()
    {
    }

    [Token(Token = "0x6001A0F")]
    [Address(RVA = "0x405ED0", Offset = "0x404AD0", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001A10")]
    [Address(RVA = "0x405BD0", Offset = "0x4047D0", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001A11")]
    [Address(RVA = "0x406290", Offset = "0x404E90", Length = "0x24")]
    public ItemCowardsCloak(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001A12")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001A13")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001A14")]
    [Address(RVA = "0x405D20", Offset = "0x404920", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;
  }
}
