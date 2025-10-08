// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Weapons.WeaponInventory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Weapons
{
  [Token(Token = "0x2000369")]
  public class WeaponInventory
  {
    [Token(Token = "0x4001748")]
    [FieldOffset(Offset = "0x10")]
    private bool isMaxed;
    [Token(Token = "0x4001749")]
    [FieldOffset(Offset = "0x11")]
    private bool hasAimableWeapon;
    [Token(Token = "0x400174A")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<EWeapon, WeaponBase> weapons;
    [Token(Token = "0x400174B")]
    public static Action<WeaponBase> A_WeaponAdded;
    [Token(Token = "0x400174C")]
    public static Action<WeaponBase> A_WeaponRemoved;
    [Token(Token = "0x400174D")]
    public static Action<WeaponBase> A_WeaponToggled;

    [Token(Token = "0x6001860")]
    [Address(RVA = "0x3FC040", Offset = "0x3FAC40", Length = "0x21F")]
    public void AddWeapon(WeaponData weaponData, List<StatModifier> upgradeOffer)
    {
    }

    [Token(Token = "0x6001861")]
    [Address(RVA = "0x3FC8D0", Offset = "0x3FB4D0", Length = "0x107")]
    public void ToggleWeapon(EWeapon eWeapon, bool enable)
    {
    }

    [Token(Token = "0x6001862")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    private void RemoveWeapon()
    {
    }

    [Token(Token = "0x6001863")]
    [Address(RVA = "0x3FC7B0", Offset = "0x3FB3B0", Length = "0x11F")]
    public void Tick()
    {
    }

    [Token(Token = "0x6001864")]
    [Address(RVA = "0x3FC5E0", Offset = "0x3FB1E0", Length = "0x44")]
    public int GetNumWeapons() => 0;

    [Token(Token = "0x6001865")]
    [Address(RVA = "0x3FC630", Offset = "0x3FB230", Length = "0x8E")]
    public int GetWeaponLevel(EWeapon eWeapon) => 0;

    [Token(Token = "0x6001866")]
    [Address(RVA = "0x3FC260", Offset = "0x3FAE60", Length = "0x23E")]
    private void CheckMaxed()
    {
    }

    [Token(Token = "0x6001867")]
    [Address(RVA = "0x3FC6D0", Offset = "0x3FB2D0", Length = "0xD2")]
    private bool IsMaxLevel(EWeapon eWeapon) => false;

    [Token(Token = "0x6001868")]
    [Address(RVA = "0x36C9C0", Offset = "0x36B5C0", Length = "0x5")]
    public bool IsMaxed() => false;

    [Token(Token = "0x6001869")]
    [Address(RVA = "0x3FC6C0", Offset = "0x3FB2C0", Length = "0x5")]
    public bool HasAimableWeapon() => false;

    [Token(Token = "0x600186A")]
    [Address(RVA = "0x3FC4A0", Offset = "0x3FB0A0", Length = "0x136")]
    public void Cleanup()
    {
    }

    [Token(Token = "0x600186B")]
    [Address(RVA = "0x3FC9E0", Offset = "0x3FB5E0", Length = "0x77")]
    public WeaponInventory()
    {
    }
  }
}
