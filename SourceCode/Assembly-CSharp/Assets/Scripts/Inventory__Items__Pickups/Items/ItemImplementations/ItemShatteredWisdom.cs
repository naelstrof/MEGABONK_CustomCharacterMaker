// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemShatteredWisdom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003D9")]
  public class ItemShatteredWisdom : ItemBase
  {
    [Token(Token = "0x40019B5")]
    private static float damage;
    [Token(Token = "0x40019B6")]
    public static float procChance;

    [Token(Token = "0x6001BB1")]
    [Address(RVA = "0x423F40", Offset = "0x422B40", Length = "0xBD")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001BB2")]
    [Address(RVA = "0x423EF0", Offset = "0x422AF0", Length = "0x4F")]
    public static float GetDamage() => 0.0f;

    [Token(Token = "0x6001BB3")]
    [Address(RVA = "0x400A80", Offset = "0x3FF680", Length = "0x8")]
    public ItemShatteredWisdom(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001BB4")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001BB5")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001BB6")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001BB7")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001BB8")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001BB9")]
    [Address(RVA = "0x424000", Offset = "0x422C00", Length = "0x3A")]
    static ItemShatteredWisdom()
    {
    }
  }
}
