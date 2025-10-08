// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.ConstantAttacks.ConstantAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Game.Combat.ConstantAttacks
{
  [Token(Token = "0x2000443")]
  public abstract class ConstantAttack : MonoBehaviour
  {
    [Token(Token = "0x4001B99")]
    [FieldOffset(Offset = "0x20")]
    protected WeaponBase weaponBase;

    [Token(Token = "0x6001E79")]
    [Address(RVA = "0x43D0E0", Offset = "0x43BCE0", Length = "0x2F")]
    public void Set(WeaponBase weaponBase)
    {
    }

    [Token(Token = "0x6001E7A")]
    [Address(RVA = "0x43CC80", Offset = "0x43B880", Length = "0x226")]
    protected void Awake()
    {
    }

    [Token(Token = "0x6001E7B")]
    [Address(RVA = "0x43CEB0", Offset = "0x43BAB0", Length = "0x226")]
    protected void OnDestroy()
    {
    }

    [Token(Token = "0x6001E7C")]
    protected abstract void Init();

    [Token(Token = "0x6001E7D")]
    protected abstract void OnWeaponStatUpdate(EStat stat, EWeapon weapon);

    [Token(Token = "0x6001E7E")]
    protected abstract void OnStatUpdate(EStat stat);

    [Token(Token = "0x6001E7F")]
    public abstract float GetAuraRotationSpeed();

    [Token(Token = "0x6001E80")]
    [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
    public virtual bool IsManualRotation() => false;

    [Token(Token = "0x6001E81")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    protected ConstantAttack()
    {
    }
  }
}
