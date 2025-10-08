// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemySpecialAttacks.EnemySpecialAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using System;
using UnityEngine;

namespace Assets.Scripts.Game.Combat.EnemySpecialAttacks
{
  [Token(Token = "0x200042D")]
  [Serializable]
  public class EnemySpecialAttack
  {
    [Token(Token = "0x4001B3F")]
    [FieldOffset(Offset = "0x10")]
    public bool isEnabled;
    [Token(Token = "0x4001B40")]
    [FieldOffset(Offset = "0x18")]
    public string attackName;
    [Token(Token = "0x4001B41")]
    [FieldOffset(Offset = "0x20")]
    public GameObject attackPrefab;
    [Header("Attack Settings")]
    [Token(Token = "0x4001B42")]
    [FieldOffset(Offset = "0x28")]
    public float attackChargeTime;
    [Token(Token = "0x4001B43")]
    [FieldOffset(Offset = "0x2C")]
    public float attackRadius;
    [Token(Token = "0x4001B44")]
    [FieldOffset(Offset = "0x30")]
    public float attackCooldown;
    [Token(Token = "0x4001B45")]
    [FieldOffset(Offset = "0x34")]
    public float duration;
    [Token(Token = "0x4001B46")]
    [FieldOffset(Offset = "0x38")]
    public float nextSpecialAttackCooldown;
    [Token(Token = "0x4001B47")]
    [FieldOffset(Offset = "0x3C")]
    public float triggerDistance;
    [Token(Token = "0x4001B48")]
    [FieldOffset(Offset = "0x40")]
    public float endLag;
    [Token(Token = "0x4001B49")]
    [FieldOffset(Offset = "0x44")]
    public float damageMultiplier;

    [Token(Token = "0x6001DF0")]
    [Address(RVA = "0x442380", Offset = "0x440F80", Length = "0x5B")]
    public float GetDamage(Enemy enemy) => 0.0f;

    [Token(Token = "0x6001DF1")]
    [Address(RVA = "0x4423E0", Offset = "0x440FE0", Length = "0x3C")]
    public EnemySpecialAttack()
    {
    }
  }
}
