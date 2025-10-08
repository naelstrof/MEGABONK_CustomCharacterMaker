// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemCactus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003A5")]
  public class ItemCactus : ItemBase
  {
    [Token(Token = "0x4001896")]
    [FieldOffset(Offset = "0x30")]
    private float damagePerAmount;
    [Token(Token = "0x4001897")]
    [FieldOffset(Offset = "0x34")]
    private int numProjectilesPerAmount;
    [Token(Token = "0x4001898")]
    [FieldOffset(Offset = "0x38")]
    private float damage;
    [Token(Token = "0x4001899")]
    [FieldOffset(Offset = "0x3C")]
    private int numProjectiles;
    [Token(Token = "0x400189A")]
    public static string damageSource;

    [Token(Token = "0x60019E7")]
    [Address(RVA = "0x4042D0", Offset = "0x402ED0", Length = "0x1F")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x60019E8")]
    [Address(RVA = "0x404180", Offset = "0x402D80", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x60019E9")]
    [Address(RVA = "0x403EF0", Offset = "0x402AF0", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x60019EA")]
    [Address(RVA = "0x4042F0", Offset = "0x402EF0", Length = "0xAB5")]
    private void OnTakeDamage(PlayerHealth ph, DamageContainer dc, bool isShieldDamage)
    {
    }

    [Token(Token = "0x60019EB")]
    [Address(RVA = "0x404E40", Offset = "0x403A40", Length = "0x16")]
    public ItemCactus(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x60019EC")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x60019ED")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x60019EE")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x60019EF")]
    [Address(RVA = "0x404040", Offset = "0x402C40", Length = "0x13C")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x60019F0")]
    [Address(RVA = "0x404DB0", Offset = "0x4039B0", Length = "0x81")]
    static ItemCactus()
    {
    }
  }
}
