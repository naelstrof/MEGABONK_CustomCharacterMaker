// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemSpeedBoi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003DE")]
  public class ItemSpeedBoi : ItemBase
  {
    [Token(Token = "0x40019C5")]
    [FieldOffset(Offset = "0x30")]
    private float damageMultiplierDuringFreeze;
    [Token(Token = "0x40019C6")]
    [FieldOffset(Offset = "0x34")]
    private float duration;
    [Token(Token = "0x40019C7")]
    [FieldOffset(Offset = "0x38")]
    private float durationPerAmount;
    [Token(Token = "0x40019C8")]
    [FieldOffset(Offset = "0x3C")]
    private float normalCooldown;
    [Token(Token = "0x40019C9")]
    [FieldOffset(Offset = "0x40")]
    private float slowdownReadyAtTime;
    [Token(Token = "0x40019CA")]
    public static Action A_Slowdown;
    [Token(Token = "0x40019CB")]
    [FieldOffset(Offset = "0x44")]
    private float slowdownHpRatio;

    [Token(Token = "0x6001BDD")]
    [Address(RVA = "0x426010", Offset = "0x424C10", Length = "0x24")]
    public ItemSpeedBoi(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001BDE")]
    [Address(RVA = "0x425810", Offset = "0x424410", Length = "0x346")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001BDF")]
    [Address(RVA = "0x425330", Offset = "0x423F30", Length = "0x346")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001BE0")]
    [Address(RVA = "0x425D20", Offset = "0x424920", Length = "0x137")]
    private void RefreshTimeScale()
    {
    }

    [Token(Token = "0x6001BE1")]
    [Address(RVA = "0x425B60", Offset = "0x424760", Length = "0x3B")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001BE2")]
    [Address(RVA = "0x425BA0", Offset = "0x4247A0", Length = "0x175")]
    private void OnTakeDamage(PlayerHealth ph, DamageContainer dc, bool shieldDamage)
    {
    }

    [Token(Token = "0x6001BE3")]
    [Address(RVA = "0x425EE0", Offset = "0x424AE0", Length = "0x12A")]
    private void Slowdown()
    {
    }

    [Token(Token = "0x6001BE4")]
    [Address(RVA = "0x425E60", Offset = "0x424A60", Length = "0x79")]
    private void ResetStats()
    {
    }

    [Token(Token = "0x6001BE5")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001BE6")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001BE7")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001BE8")]
    [Address(RVA = "0x425680", Offset = "0x424280", Length = "0x187")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
