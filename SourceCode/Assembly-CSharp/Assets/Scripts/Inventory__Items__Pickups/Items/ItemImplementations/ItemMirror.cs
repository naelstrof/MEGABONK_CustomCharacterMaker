// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemMirror
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003D0")]
  public class ItemMirror : ItemBase
  {
    [Token(Token = "0x4001987")]
    public static Action<bool> A_MirrorReady;
    [Token(Token = "0x4001988")]
    [FieldOffset(Offset = "0x30")]
    public float cooldown;
    [Token(Token = "0x4001989")]
    [FieldOffset(Offset = "0x34")]
    private float minCooldown;
    [Token(Token = "0x400198A")]
    [FieldOffset(Offset = "0x38")]
    private float damageMultiplier;
    [Token(Token = "0x400198B")]
    [FieldOffset(Offset = "0x3C")]
    private float damagePerAmount;
    [Token(Token = "0x400198C")]
    [FieldOffset(Offset = "0x40")]
    private float lastReflectedTime;
    [Token(Token = "0x400198D")]
    [FieldOffset(Offset = "0x44")]
    private bool canReflect;
    [Token(Token = "0x400198E")]
    [FieldOffset(Offset = "0x48")]
    private string damageSource;
    [Token(Token = "0x400198F")]
    [FieldOffset(Offset = "0x50")]
    private DamageContainer reuseDc;

    [Token(Token = "0x6001B66")]
    [Address(RVA = "0x416BC0", Offset = "0x4157C0", Length = "0x8C")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001B67")]
    [Address(RVA = "0x416A00", Offset = "0x415600", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001B68")]
    [Address(RVA = "0x416880", Offset = "0x415480", Length = "0x170")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001B69")]
    [Address(RVA = "0x417600", Offset = "0x416200", Length = "0xA4")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001B6A")]
    [Address(RVA = "0x416B50", Offset = "0x415750", Length = "0x5")]
    private bool IsReady() => false;

    [Token(Token = "0x6001B6B")]
    [Address(RVA = "0x416C50", Offset = "0x415850", Length = "0x9AD")]
    private bool ReflectDamage(DamageContainer dc) => false;

    [Token(Token = "0x6001B6C")]
    [Address(RVA = "0x416B60", Offset = "0x415760", Length = "0x50")]
    private void OnCheckStopDamage(DamageContainer dc, bool shieldDamage)
    {
    }

    [Token(Token = "0x6001B6D")]
    [Address(RVA = "0x4176B0", Offset = "0x4162B0", Length = "0x11B")]
    public ItemMirror(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001B6E")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001B6F")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }
  }
}
