// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations.EnemySpecialAttackPrefab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations
{
  [Token(Token = "0x2000433")]
  public abstract class EnemySpecialAttackPrefab : MonoBehaviour
  {
    [Token(Token = "0x4001B61")]
    [FieldOffset(Offset = "0x20")]
    public GameObject attackEffectPrefab;
    [Token(Token = "0x4001B62")]
    [FieldOffset(Offset = "0x28")]
    public EEnemyAttack eAttack;
    [Token(Token = "0x4001B64")]
    [FieldOffset(Offset = "0x38")]
    protected Enemy enemy;
    [Token(Token = "0x4001B65")]
    [FieldOffset(Offset = "0x40")]
    protected CircleWarning circleWarning;
    [Token(Token = "0x4001B66")]
    [FieldOffset(Offset = "0x48")]
    private bool isActive;

    [field: Token(Token = "0x4001B63")]
    [field: FieldOffset(Offset = "0x30")]
    [Token(Token = "0x1700038F")]
    public EnemySpecialAttack specialAttack { [Token(Token = "0x6001E06"), Address(RVA = "0x36C780", Offset = "0x36B380", Length = "0x5")] get; [Token(Token = "0x6001E07"), Address(RVA = "0x370A90", Offset = "0x36F690", Length = "0xD")] private set; }

    [Token(Token = "0x6001E08")]
    [Address(RVA = "0x4422D0", Offset = "0x440ED0", Length = "0x4F")]
    public void Set(EnemySpecialAttack attack, Enemy enemy)
    {
    }

    [Token(Token = "0x6001E09")]
    protected abstract void Init();

    [Token(Token = "0x6001E0A")]
    [Address(RVA = "0x441EC0", Offset = "0x440AC0", Length = "0xC4")]
    protected void CreateWarningSphere(Vector3 pos, Action completeAction)
    {
    }

    [Token(Token = "0x6001E0B")]
    [Address(RVA = "0x441DD0", Offset = "0x4409D0", Length = "0xEC")]
    protected bool CreateWarningHitscan(
      Vector3 pos,
      Vector3 dir,
      float distance,
      Action completeAction)
    {
      return false;
    }

    [Token(Token = "0x6001E0C")]
    [Address(RVA = "0x441FF0", Offset = "0x440BF0", Length = "0x69")]
    protected GameObject GetEffectPrefab() => (GameObject) null;

    [Token(Token = "0x6001E0D")]
    [Address(RVA = "0x441C80", Offset = "0x440880", Length = "0x140")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001E0E")]
    [Address(RVA = "0x442060", Offset = "0x440C60", Length = "0x140")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6001E0F")]
    [Address(RVA = "0x4421B0", Offset = "0x440DB0", Length = "0x76")]
    private void OnEnemyDied(Enemy enemy)
    {
    }

    [Token(Token = "0x6001E10")]
    [Address(RVA = "0x442230", Offset = "0x440E30", Length = "0x91")]
    protected void ReturnToPool()
    {
    }

    [Token(Token = "0x6001E11")]
    [Address(RVA = "0x442320", Offset = "0x440F20", Length = "0x5D")]
    protected IEnumerator WaitForSecondsCustom(float time) => (IEnumerator) null;

    [Token(Token = "0x6001E12")]
    [Address(RVA = "0x441F90", Offset = "0x440B90", Length = "0x5E")]
    protected DcFlags GetDamageFlags() => new DcFlags();

    [Token(Token = "0x6001E13")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    protected EnemySpecialAttackPrefab()
    {
    }
  }
}
