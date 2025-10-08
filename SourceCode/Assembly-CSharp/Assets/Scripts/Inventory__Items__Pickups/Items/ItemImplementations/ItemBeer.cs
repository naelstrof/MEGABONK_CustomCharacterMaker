// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemBeer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x200039E")]
  public class ItemBeer : ItemBase
  {
    [Token(Token = "0x400186D")]
    [FieldOffset(Offset = "0x30")]
    private float damagePerStack;
    [Token(Token = "0x400186E")]
    [FieldOffset(Offset = "0x34")]
    private float maxHealthPerStack;

    [Token(Token = "0x60019A8")]
    [Address(RVA = "0x401CB0", Offset = "0x4008B0", Length = "0xC4")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x60019A9")]
    [Address(RVA = "0x401D80", Offset = "0x400980", Length = "0x16")]
    public ItemBeer(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x60019AA")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x60019AB")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x60019AC")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x60019AD")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x60019AE")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x60019AF")]
    [Address(RVA = "0x401AE0", Offset = "0x4006E0", Length = "0x1CA")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
