// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations.EnemySpecialAttackFollowing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations
{
  [Token(Token = "0x2000430")]
  public class EnemySpecialAttackFollowing : EnemySpecialAttackPrefab
  {
    [Token(Token = "0x4001B55")]
    [FieldOffset(Offset = "0x50")]
    public bool grounded;
    [Token(Token = "0x4001B56")]
    [FieldOffset(Offset = "0x51")]
    public bool predictive;
    [Token(Token = "0x4001B57")]
    [FieldOffset(Offset = "0x54")]
    public float delayBetweenHits;
    [Token(Token = "0x4001B58")]
    [FieldOffset(Offset = "0x58")]
    public int numHits;
    [Token(Token = "0x4001B59")]
    [FieldOffset(Offset = "0x5C")]
    private int numSpawned;

    [Token(Token = "0x6001DFA")]
    [Address(RVA = "0x440E00", Offset = "0x43FA00", Length = "0x135")]
    protected override void Init()
    {
    }

    [Token(Token = "0x6001DFB")]
    [Address(RVA = "0x440D90", Offset = "0x43F990", Length = "0x67")]
    private IEnumerator DoAttack() => (IEnumerator) null;

    [Token(Token = "0x6001DFC")]
    [Address(RVA = "0x440F40", Offset = "0x43FB40", Length = "0x42A")]
    private void SpawnHitEffect(Vector3 pos)
    {
    }

    [Token(Token = "0x6001DFD")]
    [Address(RVA = "0x441370", Offset = "0x43FF70", Length = "0x19")]
    public EnemySpecialAttackFollowing()
    {
    }
  }
}
