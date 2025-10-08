// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemRollerblades
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003D7")]
  public class ItemRollerblades : ItemBase
  {
    [Token(Token = "0x40019AE")]
    [FieldOffset(Offset = "0x30")]
    private float cap;
    [Token(Token = "0x40019AF")]
    [FieldOffset(Offset = "0x34")]
    private float maxAttackSpeedPerAmount;
    [Token(Token = "0x40019B0")]
    [FieldOffset(Offset = "0x38")]
    private float updateStatsInterval;
    [Token(Token = "0x40019B1")]
    [FieldOffset(Offset = "0x3C")]
    private float nextUpdateTime;

    [Token(Token = "0x6001B9F")]
    [Address(RVA = "0x4237C0", Offset = "0x4223C0", Length = "0x13")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001BA0")]
    [Address(RVA = "0x423980", Offset = "0x422580", Length = "0x16")]
    public ItemRollerblades(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001BA1")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001BA2")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001BA3")]
    [Address(RVA = "0x4237E0", Offset = "0x4223E0", Length = "0x19F")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001BA4")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001BA5")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001BA6")]
    [Address(RVA = "0x423690", Offset = "0x422290", Length = "0x125")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
