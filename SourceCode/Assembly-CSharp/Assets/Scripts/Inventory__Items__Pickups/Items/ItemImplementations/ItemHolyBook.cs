// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemHolyBook
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
  [Token(Token = "0x20003C6")]
  public class ItemHolyBook : ItemBase
  {
    [Token(Token = "0x4001948")]
    public static Action<float> A_OnUse;
    [Token(Token = "0x4001949")]
    [FieldOffset(Offset = "0x30")]
    private float maxHpPerAmount;
    [Token(Token = "0x400194A")]
    [FieldOffset(Offset = "0x34")]
    private float hpRegenPerAmount;
    [Token(Token = "0x400194B")]
    [FieldOffset(Offset = "0x38")]
    private float overhealPerAmount;
    [Token(Token = "0x400194C")]
    [FieldOffset(Offset = "0x3C")]
    private float radius;
    [Token(Token = "0x400194D")]
    [FieldOffset(Offset = "0x40")]
    private float radiusPerAmount;
    [Token(Token = "0x400194E")]
    [FieldOffset(Offset = "0x44")]
    private float healsThisTick;
    [Token(Token = "0x400194F")]
    [FieldOffset(Offset = "0x48")]
    private float nextDamageTime;
    [Token(Token = "0x4001950")]
    [FieldOffset(Offset = "0x4C")]
    private float cooldown;
    [Token(Token = "0x4001951")]
    [FieldOffset(Offset = "0x50")]
    private string damageSource;
    [Token(Token = "0x4001952")]
    [FieldOffset(Offset = "0x58")]
    private DamageContainer dc;

    [Token(Token = "0x6001B0C")]
    [Address(RVA = "0x412350", Offset = "0x410F50", Length = "0x13F")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001B0D")]
    [Address(RVA = "0x4129B0", Offset = "0x4115B0", Length = "0x122")]
    public ItemHolyBook(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001B0E")]
    [Address(RVA = "0x4121F0", Offset = "0x410DF0", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001B0F")]
    [Address(RVA = "0x411EF0", Offset = "0x410AF0", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001B10")]
    [Address(RVA = "0x412340", Offset = "0x410F40", Length = "0x10")]
    private void OnHeal(PlayerHealth ph, float hpHealed, bool isShield)
    {
    }

    [Token(Token = "0x6001B11")]
    [Address(RVA = "0x412490", Offset = "0x411090", Length = "0x51C")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001B12")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001B13")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001B14")]
    [Address(RVA = "0x412040", Offset = "0x410C40", Length = "0x1AE")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
