// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Weapons.WeaponBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.WeaponPassives;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Weapons
{
  [Token(Token = "0x2000368")]
  public class WeaponBase
  {
    [Token(Token = "0x4001740")]
    [FieldOffset(Offset = "0x10")]
    private float usedWeaponAtTime;
    [Token(Token = "0x4001741")]
    [FieldOffset(Offset = "0x18")]
    public WeaponData weaponData;
    [Token(Token = "0x4001742")]
    [FieldOffset(Offset = "0x20")]
    public int level;
    [Token(Token = "0x4001743")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<EStat, float> weaponStats;
    [Token(Token = "0x4001744")]
    [FieldOffset(Offset = "0x30")]
    private List<List<StatModifier>> upgrades;
    [Token(Token = "0x4001745")]
    [FieldOffset(Offset = "0x38")]
    private WeaponPassive passive;
    [Token(Token = "0x4001746")]
    public static Action<EStat, EWeapon> A_WeaponStatUpdate;

    [Token(Token = "0x6001850")]
    [Address(RVA = "0x3FBCA0", Offset = "0x3FA8A0", Length = "0x37D")]
    public WeaponBase(WeaponData data)
    {
    }

    [Token(Token = "0x6001851")]
    [Address(RVA = "0x3FA6F0", Offset = "0x3F92F0", Length = "0x1D")]
    public void Cleanup()
    {
    }

    [field: Token(Token = "0x4001747")]
    [field: FieldOffset(Offset = "0x40")]
    [Token(Token = "0x17000384")]
    public bool enabled { [Token(Token = "0x6001852"), Address(RVA = "0x3FC020", Offset = "0x3FAC20", Length = "0x5")] get; [Token(Token = "0x6001853"), Address(RVA = "0x3FC030", Offset = "0x3FAC30", Length = "0x4")] private set; }

    [Token(Token = "0x6001854")]
    [Address(RVA = "0x3FA710", Offset = "0x3F9310", Length = "0x5")]
    public void Disable()
    {
    }

    [Token(Token = "0x6001855")]
    [Address(RVA = "0x3FA720", Offset = "0x3F9320", Length = "0x5")]
    public void Enable()
    {
    }

    [Token(Token = "0x6001856")]
    [Address(RVA = "0x3FBA50", Offset = "0x3FA650", Length = "0x237")]
    public void Use()
    {
    }

    [Token(Token = "0x6001857")]
    [Address(RVA = "0x3FB8A0", Offset = "0x3FA4A0", Length = "0x1AE")]
    public void Upgrade(List<StatModifier> upgradeOffer)
    {
    }

    [Token(Token = "0x6001858")]
    [Address(RVA = "0x3FB1C0", Offset = "0x3F9DC0", Length = "0x6DF")]
    private void UpdateStat(EStat stat)
    {
    }

    [Token(Token = "0x6001859")]
    [Address(RVA = "0x3FA8A0", Offset = "0x3F94A0", Length = "0x6EE")]
    public float GetTestUpdateStat(EStat stat, StatModifier testUpgrade) => 0.0f;

    [Token(Token = "0x600185A")]
    [Address(RVA = "0x3FAF90", Offset = "0x3F9B90", Length = "0x66")]
    public float GetValue(EStat stat) => 0.0f;

    [Token(Token = "0x600185B")]
    [Address(RVA = "0x3FBC90", Offset = "0x3FA890", Length = "0x8")]
    public void WeaponPassiveChanged(EStat stat)
    {
    }

    [Token(Token = "0x600185C")]
    [Address(RVA = "0x3FA730", Offset = "0x3F9330", Length = "0x1E")]
    private float GetBaseValue(EStat stat) => 0.0f;

    [Token(Token = "0x600185D")]
    [Address(RVA = "0x3EBEC0", Offset = "0x3EAAC0", Length = "0x8B")]
    private void ApplyStatModifier(
      StatModifier modifier,
      int amount,
      ref float flatValues,
      ref float additionValues,
      ref float multiplicationValues)
    {
    }

    [Token(Token = "0x600185E")]
    [Address(RVA = "0x3FB000", Offset = "0x3F9C00", Length = "0x1BB")]
    private bool IsCooldown() => false;

    [Token(Token = "0x600185F")]
    [Address(RVA = "0x3FA750", Offset = "0x3F9350", Length = "0x14F")]
    private float GetCooldown() => 0.0f;
  }
}
