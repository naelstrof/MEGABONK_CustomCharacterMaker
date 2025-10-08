// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Weapons.WeaponPassives.WeaponPassive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Items;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Weapons.WeaponPassives
{
  [Token(Token = "0x200036D")]
  public abstract class WeaponPassive
  {
    [Token(Token = "0x4001756")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<EStat, StatModifiersContainer> statModifiers;
    [Token(Token = "0x4001757")]
    [FieldOffset(Offset = "0x18")]
    protected WeaponBase weaponBase;

    [Token(Token = "0x6001890")]
    [Address(RVA = "0x3FD8F0", Offset = "0x3FC4F0", Length = "0x94")]
    public WeaponPassive(WeaponBase weaponBase)
    {
    }

    [Token(Token = "0x6001891")]
    [Address(RVA = "0x3FD7C0", Offset = "0x3FC3C0", Length = "0x120")]
    protected void SetStat(StatModifier statModifier)
    {
    }

    [Token(Token = "0x6001892")]
    public abstract void Init();

    [Token(Token = "0x6001893")]
    public abstract void Cleanup();
  }
}
