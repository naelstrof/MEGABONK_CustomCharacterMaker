// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemySpecialAttacks.SpecialAttackController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Combat.EnemySpecialAttacks
{
  [Token(Token = "0x200042E")]
  public class SpecialAttackController
  {
    [Token(Token = "0x4001B4A")]
    private static bool enabled;
    [Token(Token = "0x4001B4B")]
    [FieldOffset(Offset = "0x10")]
    private HashSet<EnemySpecialAttack> attacks;
    [Token(Token = "0x4001B4C")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<EnemySpecialAttack, float> cooldowns;
    [Token(Token = "0x4001B4D")]
    [FieldOffset(Offset = "0x20")]
    private float updateRate;
    [Token(Token = "0x4001B4E")]
    [FieldOffset(Offset = "0x24")]
    private float nextCheckTime;
    [Token(Token = "0x4001B4F")]
    [FieldOffset(Offset = "0x28")]
    private Enemy enemy;
    [Token(Token = "0x4001B50")]
    [FieldOffset(Offset = "0x30")]
    private bool isAttacking;
    [Token(Token = "0x4001B51")]
    [FieldOffset(Offset = "0x34")]
    private float attackOverAtTime;
    [Token(Token = "0x4001B52")]
    [FieldOffset(Offset = "0x38")]
    private EnemySpecialAttack currentAttack;

    [Token(Token = "0x6001DF2")]
    [Address(RVA = "0x4530C0", Offset = "0x451CC0", Length = "0x28E")]
    public SpecialAttackController(Enemy enemy)
    {
    }

    [Token(Token = "0x6001DF3")]
    [Address(RVA = "0x452940", Offset = "0x451540", Length = "0x4F5")]
    public void Tick()
    {
    }

    [Token(Token = "0x6001DF4")]
    [Address(RVA = "0x452E40", Offset = "0x451A40", Length = "0x230")]
    private void UseSpecialAttack(EnemySpecialAttack attack)
    {
    }

    [Token(Token = "0x6001DF5")]
    [Address(RVA = "0x4528A0", Offset = "0x4514A0", Length = "0x95")]
    private void FinishAttack()
    {
    }

    [Token(Token = "0x6001DF6")]
    [Address(RVA = "0x453080", Offset = "0x451C80", Length = "0x36")]
    static SpecialAttackController()
    {
    }
  }
}
