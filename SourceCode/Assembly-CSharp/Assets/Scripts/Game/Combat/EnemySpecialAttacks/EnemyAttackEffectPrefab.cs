// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemySpecialAttacks.EnemyAttackEffectPrefab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Game.Combat.EnemySpecialAttacks
{
  [Token(Token = "0x200042A")]
  public class EnemyAttackEffectPrefab : MonoBehaviour
  {
    [Token(Token = "0x4001B32")]
    [FieldOffset(Offset = "0x20")]
    public EEnemyAttack eAttack;
    [Token(Token = "0x4001B33")]
    [FieldOffset(Offset = "0x24")]
    public float aliveTime;
    [Token(Token = "0x4001B34")]
    [FieldOffset(Offset = "0x28")]
    private float returnTime;

    [Token(Token = "0x6001DE7")]
    [Address(RVA = "0x43FFD0", Offset = "0x43EBD0", Length = "0x60")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6001DE8")]
    [Address(RVA = "0x440030", Offset = "0x43EC30", Length = "0xAC")]
    private void Update()
    {
    }

    [Token(Token = "0x6001DE9")]
    [Address(RVA = "0x4400E0", Offset = "0x43ECE0", Length = "0xE")]
    public EnemyAttackEffectPrefab()
    {
    }
  }
}
