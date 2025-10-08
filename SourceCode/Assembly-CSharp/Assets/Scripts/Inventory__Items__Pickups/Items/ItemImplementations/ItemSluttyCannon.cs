// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemSluttyCannon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003DC")]
  public class ItemSluttyCannon : ItemBase
  {
    [Token(Token = "0x40019B9")]
    [FieldOffset(Offset = "0x30")]
    private float procChance;
    [Token(Token = "0x40019BA")]
    [FieldOffset(Offset = "0x34")]
    public float procChancePerAmount;
    [Token(Token = "0x40019BB")]
    [FieldOffset(Offset = "0x38")]
    public float damageRatio;
    [Token(Token = "0x40019BC")]
    [FieldOffset(Offset = "0x3C")]
    public float damageRatioPerAmount;
    [Token(Token = "0x40019BD")]
    [FieldOffset(Offset = "0x40")]
    private string damageSource;
    [Token(Token = "0x40019BE")]
    [FieldOffset(Offset = "0x48")]
    private int maxProcsPerTick;
    [Token(Token = "0x40019BF")]
    [FieldOffset(Offset = "0x4C")]
    private int numProcsThisTick;

    [Token(Token = "0x6001BCA")]
    [Address(RVA = "0x4245B0", Offset = "0x4231B0", Length = "0x63")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001BCB")]
    [Address(RVA = "0x424620", Offset = "0x423220", Length = "0x25D")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001BCC")]
    [Address(RVA = "0x424880", Offset = "0x423480", Length = "0x8")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001BCD")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001BCE")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001BCF")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001BD0")]
    [Address(RVA = "0x424890", Offset = "0x423490", Length = "0x9A")]
    public ItemSluttyCannon(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001BD1")]
    [Address(RVA = "0x4244D0", Offset = "0x4230D0", Length = "0xDE")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
