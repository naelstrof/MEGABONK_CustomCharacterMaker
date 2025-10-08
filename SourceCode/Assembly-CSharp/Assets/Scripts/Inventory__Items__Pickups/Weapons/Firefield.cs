// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Weapons.Firefield
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Weapons
{
  [Token(Token = "0x2000364")]
  public class Firefield : MonoBehaviour
  {
    [Token(Token = "0x4001727")]
    [FieldOffset(Offset = "0x20")]
    private float collisionCooldown;
    [Token(Token = "0x4001728")]
    [FieldOffset(Offset = "0x24")]
    private float spawnTime;
    [Token(Token = "0x4001729")]
    [FieldOffset(Offset = "0x28")]
    private float aliveTime;
    [Token(Token = "0x400172A")]
    [FieldOffset(Offset = "0x2C")]
    private float spawnRadius;
    [Token(Token = "0x400172B")]
    [FieldOffset(Offset = "0x30")]
    private Vector3 normal;
    [Token(Token = "0x400172C")]
    [FieldOffset(Offset = "0x40")]
    private WeaponBase weaponBase;
    [Token(Token = "0x400172D")]
    [FieldOffset(Offset = "0x48")]
    private float damage;
    [Token(Token = "0x400172E")]
    [FieldOffset(Offset = "0x50")]
    private string damageSource;
    [Token(Token = "0x400172F")]
    [FieldOffset(Offset = "0x58")]
    private DamageContainer recycledDx;
    [Token(Token = "0x4001730")]
    [FieldOffset(Offset = "0x60")]
    private float nextCheckDamageTime;
    [Token(Token = "0x4001731")]
    [FieldOffset(Offset = "0x64")]
    private float visualRadius;
    [Token(Token = "0x4001732")]
    [FieldOffset(Offset = "0x68")]
    private float desiredVisualRadius;

    [Token(Token = "0x6001834")]
    [Address(RVA = "0x3E6550", Offset = "0x3E5150", Length = "0x723")]
    public void Set(
      Vector3 pos,
      Vector3 fallbackPos,
      float radius,
      float duration,
      float damage,
      WeaponBase weaponBase,
      string damageSource)
    {
    }

    [Token(Token = "0x6001835")]
    [Address(RVA = "0x3E5F20", Offset = "0x3E4B20", Length = "0x218")]
    protected void FixedUpdate()
    {
    }

    [Token(Token = "0x6001836")]
    [Address(RVA = "0x3E6240", Offset = "0x3E4E40", Length = "0x9")]
    private bool IsWeaponAttack() => false;

    [Token(Token = "0x6001837")]
    [Address(RVA = "0x3E5960", Offset = "0x3E4560", Length = "0x5B7")]
    private void CheckDamage()
    {
    }

    [Token(Token = "0x6001838")]
    [Address(RVA = "0x3E6140", Offset = "0x3E4D40", Length = "0x71")]
    private float GetEffectiveRadius() => 0.0f;

    [Token(Token = "0x6001839")]
    [Address(RVA = "0x3E61C0", Offset = "0x3E4DC0", Length = "0x79")]
    private float GetHitboxRadius() => 0.0f;

    [Token(Token = "0x600183A")]
    [Address(RVA = "0x3E6C80", Offset = "0x3E5880", Length = "0x1DB")]
    protected void Update()
    {
    }

    [Token(Token = "0x600183B")]
    [Address(RVA = "0x3E6250", Offset = "0x3E4E50", Length = "0x16E")]
    private void OnDrawGizmosSelected()
    {
    }

    [Token(Token = "0x600183C")]
    [Address(RVA = "0x3E63C0", Offset = "0x3E4FC0", Length = "0x18A")]
    private void OnDrawGizmos()
    {
    }

    [Token(Token = "0x600183D")]
    [Address(RVA = "0x3E6E60", Offset = "0x3E5A60", Length = "0x84")]
    public Firefield()
    {
    }
  }
}
