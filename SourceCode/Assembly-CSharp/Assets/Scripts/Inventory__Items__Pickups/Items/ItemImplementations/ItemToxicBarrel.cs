// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemToxicBarrel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003E3")]
  public class ItemToxicBarrel : ItemBase
  {
    [Token(Token = "0x40019DD")]
    public static Action<float> A_OnUse;
    [Token(Token = "0x40019DE")]
    [FieldOffset(Offset = "0x30")]
    private float radius;
    [Token(Token = "0x40019DF")]
    [FieldOffset(Offset = "0x34")]
    private float radiusPerAmount;
    [Token(Token = "0x40019E0")]
    [FieldOffset(Offset = "0x38")]
    private int poisonStacksPerAmount;
    [Token(Token = "0x40019E1")]
    [FieldOffset(Offset = "0x3C")]
    private int poisonStacks;
    [Token(Token = "0x40019E2")]
    [FieldOffset(Offset = "0x40")]
    private float cooldown;
    [Token(Token = "0x40019E3")]
    [FieldOffset(Offset = "0x44")]
    private float readyAtTime;
    [Token(Token = "0x40019E4")]
    [FieldOffset(Offset = "0x48")]
    private float poisonDuration;
    [Token(Token = "0x40019E5")]
    [FieldOffset(Offset = "0x50")]
    private string damageSource;
    [Token(Token = "0x40019E6")]
    [FieldOffset(Offset = "0x58")]
    private DamageContainer dc;

    [Token(Token = "0x6001C0A")]
    [Address(RVA = "0x4275E0", Offset = "0x4261E0", Length = "0x25")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001C0B")]
    [Address(RVA = "0x427490", Offset = "0x426090", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001C0C")]
    [Address(RVA = "0x427340", Offset = "0x425F40", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001C0D")]
    [Address(RVA = "0x427610", Offset = "0x426210", Length = "0x93")]
    private void OnTakeDamage(PlayerHealth ph, DamageContainer dc, bool shieldDamage)
    {
    }

    [Token(Token = "0x6001C0E")]
    [Address(RVA = "0x427120", Offset = "0x425D20", Length = "0x212")]
    private void Activate()
    {
    }

    [Token(Token = "0x6001C0F")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001C10")]
    [Address(RVA = "0x4276B0", Offset = "0x4262B0", Length = "0x11B")]
    public ItemToxicBarrel(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001C11")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001C12")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }
  }
}
