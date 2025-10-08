// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemySpecialAttacks.EnemyAttackPrefabAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Game.Combat.EnemySpecialAttacks
{
  [Token(Token = "0x200042B")]
  public class EnemyAttackPrefabAnimation : MonoBehaviour
  {
    [Token(Token = "0x4001B35")]
    [FieldOffset(Offset = "0x20")]
    public AnimationCurve animationCurveScale;
    [Token(Token = "0x4001B36")]
    [FieldOffset(Offset = "0x28")]
    public float animationDuration;
    [Token(Token = "0x4001B37")]
    [FieldOffset(Offset = "0x2C")]
    private Vector3 defaultSize;
    [Token(Token = "0x4001B38")]
    [FieldOffset(Offset = "0x38")]
    private float animationTime;

    [Token(Token = "0x6001DEA")]
    [Address(RVA = "0x4400F0", Offset = "0x43ECF0", Length = "0x3F")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001DEB")]
    [Address(RVA = "0x440130", Offset = "0x43ED30", Length = "0x118")]
    private void Update()
    {
    }

    [Token(Token = "0x6001DEC")]
    [Address(RVA = "0x440250", Offset = "0x43EE50", Length = "0xE")]
    public EnemyAttackPrefabAnimation()
    {
    }
  }
}
