// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations.DebuffPoison
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;

namespace Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations
{
  [Token(Token = "0x2000440")]
  public class DebuffPoison : EnemyDebuff
  {
    [Token(Token = "0x4001B89")]
    public static int numPoisonedEnemies;
    [Token(Token = "0x4001B8A")]
    [FieldOffset(Offset = "0x20")]
    private int stacks;
    [Token(Token = "0x4001B8B")]
    public static string poisonDamageSource;

    [Token(Token = "0x6001E5B")]
    [Address(RVA = "0x43E090", Offset = "0x43CC90", Length = "0xE")]
    public DebuffPoison(Enemy enemy, DamageContainer dc, float duration, int stacks)
      : base((Enemy) null, (DamageContainer) null, 0.0f, 0)
    {
    }

    [Token(Token = "0x6001E5C")]
    [Address(RVA = "0x43E910", Offset = "0x43D510", Length = "0x52")]
    public float GetDamageForHpBar() => 0.0f;

    [Token(Token = "0x6001E5D")]
    [Address(RVA = "0x43E980", Offset = "0x43D580", Length = "0x148")]
    public override void MyTick()
    {
    }

    [Token(Token = "0x6001E5E")]
    [Address(RVA = "0x43E970", Offset = "0x43D570", Length = "0x9")]
    protected override float GetStartTicks() => 0.0f;

    [Token(Token = "0x6001E5F")]
    [Address(RVA = "0x430D40", Offset = "0x42F940", Length = "0x6")]
    public override EDebuff GetDebuffType() => new EDebuff();

    [Token(Token = "0x6001E60")]
    [Address(RVA = "0x43EB30", Offset = "0x43D730", Length = "0x51")]
    public override void OnRemove(bool fromDeath)
    {
    }

    [Token(Token = "0x6001E61")]
    [Address(RVA = "0x43EAD0", Offset = "0x43D6D0", Length = "0x51")]
    public override void OnAdded()
    {
    }

    [Token(Token = "0x6001E62")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void OnRefresh()
    {
    }

    [Token(Token = "0x6001E63")]
    [Address(RVA = "0x43E900", Offset = "0x43D500", Length = "0x4")]
    public override void AddStacks(int numStacks)
    {
    }

    [Token(Token = "0x6001E64")]
    [Address(RVA = "0x43EB90", Offset = "0x43D790", Length = "0x86")]
    static DebuffPoison()
    {
    }
  }
}
