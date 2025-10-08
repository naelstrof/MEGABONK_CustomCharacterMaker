// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemBobDead
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003A0")]
  public class ItemBobDead : ItemBase
  {
    [Token(Token = "0x4001875")]
    [FieldOffset(Offset = "0x30")]
    private string damageSource;
    [Token(Token = "0x4001876")]
    public const int maxGhosts = 80;
    [Token(Token = "0x4001877")]
    [FieldOffset(Offset = "0x38")]
    private float unitsPerProjectile;
    [Token(Token = "0x4001878")]
    [FieldOffset(Offset = "0x3C")]
    private float minSpawnTime;
    [Token(Token = "0x4001879")]
    [FieldOffset(Offset = "0x40")]
    private float nextCheckTime;
    [Token(Token = "0x400187A")]
    [FieldOffset(Offset = "0x44")]
    private float accumulatedDistance;
    [Token(Token = "0x400187B")]
    [FieldOffset(Offset = "0x48")]
    private Vector3 lastPos;

    [Token(Token = "0x60019BA")]
    [Address(RVA = "0x402670", Offset = "0x401270", Length = "0x8A")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x60019BB")]
    [Address(RVA = "0x402800", Offset = "0x401400", Length = "0x308")]
    public override void Tick()
    {
    }

    [Token(Token = "0x60019BC")]
    [Address(RVA = "0x402500", Offset = "0x401100", Length = "0x69")]
    private float GetDamage() => 0.0f;

    [Token(Token = "0x60019BD")]
    [Address(RVA = "0x402700", Offset = "0x401300", Length = "0xF9")]
    private void SpawnGhost()
    {
    }

    [Token(Token = "0x60019BE")]
    [Address(RVA = "0x402570", Offset = "0x401170", Length = "0x1B")]
    private float GetDuration() => 0.0f;

    [Token(Token = "0x60019BF")]
    [Address(RVA = "0x402B10", Offset = "0x401710", Length = "0x8C")]
    public ItemBobDead(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x60019C0")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x60019C1")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x60019C2")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x60019C3")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x60019C4")]
    [Address(RVA = "0x402590", Offset = "0x401190", Length = "0xD6")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
