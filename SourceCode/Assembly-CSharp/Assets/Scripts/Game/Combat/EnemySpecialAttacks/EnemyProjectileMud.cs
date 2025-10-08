// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemySpecialAttacks.EnemyProjectileMud
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Game.Combat.EnemySpecialAttacks
{
  [Token(Token = "0x200042C")]
  public class EnemyProjectileMud : EnemySpecialAttackPrefab
  {
    [Token(Token = "0x4001B39")]
    [FieldOffset(Offset = "0x50")]
    public GameObject hitEffect;
    [Token(Token = "0x4001B3A")]
    [FieldOffset(Offset = "0x58")]
    public ParticleSystem mudParticles;
    [Token(Token = "0x4001B3B")]
    [FieldOffset(Offset = "0x60")]
    public Transform slamParticles;
    [Token(Token = "0x4001B3C")]
    [FieldOffset(Offset = "0x68")]
    public Transform preParticles;
    [Token(Token = "0x4001B3D")]
    [FieldOffset(Offset = "0x70")]
    public bool grounded;
    [Token(Token = "0x4001B3E")]
    [FieldOffset(Offset = "0x71")]
    public bool predictive;

    [Token(Token = "0x6001DED")]
    [Address(RVA = "0x440440", Offset = "0x43F040", Length = "0x5CF")]
    protected override void Init()
    {
    }

    [Token(Token = "0x6001DEE")]
    [Address(RVA = "0x440A10", Offset = "0x43F610", Length = "0x37E")]
    private void SpawnHitEffect()
    {
    }

    [Token(Token = "0x6001DEF")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public EnemyProjectileMud()
    {
    }
  }
}
