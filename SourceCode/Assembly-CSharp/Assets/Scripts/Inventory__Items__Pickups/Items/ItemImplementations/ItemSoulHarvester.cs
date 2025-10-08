// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemSoulHarvester
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003DD")]
  public class ItemSoulHarvester : ItemBase
  {
    [Token(Token = "0x40019C0")]
    [FieldOffset(Offset = "0x30")]
    private string damageSource;
    [Token(Token = "0x40019C1")]
    public const int maxProjectiles = 100;
    [Token(Token = "0x40019C2")]
    [FieldOffset(Offset = "0x38")]
    private int numProjectiles;
    [Token(Token = "0x40019C3")]
    [FieldOffset(Offset = "0x3C")]
    private float damageMultiplier;
    [Token(Token = "0x40019C4")]
    [FieldOffset(Offset = "0x40")]
    private float range;

    [Token(Token = "0x6001BD2")]
    [Address(RVA = "0x424BE0", Offset = "0x4237E0", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001BD3")]
    [Address(RVA = "0x424930", Offset = "0x423530", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001BD4")]
    [Address(RVA = "0x425040", Offset = "0x423C40", Length = "0xE")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001BD5")]
    [Address(RVA = "0x424A80", Offset = "0x423680", Length = "0x7C")]
    private float GetDamage() => 0.0f;

    [Token(Token = "0x6001BD6")]
    [Address(RVA = "0x424D30", Offset = "0x423930", Length = "0x303")]
    private void OnEnemyDied(Enemy enemy)
    {
    }

    [Token(Token = "0x6001BD7")]
    [Address(RVA = "0x425050", Offset = "0x423C50", Length = "0x24A")]
    private void SpawnProjectile(Vector3 pos)
    {
    }

    [Token(Token = "0x6001BD8")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001BD9")]
    [Address(RVA = "0x4252A0", Offset = "0x423EA0", Length = "0x8C")]
    public ItemSoulHarvester(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001BDA")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001BDB")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001BDC")]
    [Address(RVA = "0x424B00", Offset = "0x423700", Length = "0xD2")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
