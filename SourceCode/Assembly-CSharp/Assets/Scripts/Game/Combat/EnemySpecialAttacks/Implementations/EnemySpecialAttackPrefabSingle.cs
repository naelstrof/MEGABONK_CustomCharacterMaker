// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations.EnemySpecialAttackPrefabSingle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations
{
  [Token(Token = "0x2000435")]
  public class EnemySpecialAttackPrefabSingle : EnemySpecialAttackPrefab
  {
    [Token(Token = "0x4001B6B")]
    [FieldOffset(Offset = "0x50")]
    public bool grounded;
    [Token(Token = "0x4001B6C")]
    [FieldOffset(Offset = "0x51")]
    public bool predictive;

    [Token(Token = "0x6001E1A")]
    [Address(RVA = "0x441390", Offset = "0x43FF90", Length = "0x402")]
    protected override void Init()
    {
    }

    [Token(Token = "0x6001E1B")]
    [Address(RVA = "0x4417A0", Offset = "0x4403A0", Length = "0x4DC")]
    private void SpawnHitEffect()
    {
    }

    [Token(Token = "0x6001E1C")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public EnemySpecialAttackPrefabSingle()
    {
    }
  }
}
