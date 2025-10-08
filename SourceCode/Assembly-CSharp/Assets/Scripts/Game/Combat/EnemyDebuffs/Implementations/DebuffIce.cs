// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations.DebuffIce
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;

namespace Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations
{
  [Token(Token = "0x200043F")]
  public class DebuffIce : EnemyDebuff
  {
    [Token(Token = "0x4001B88")]
    public static float slowMultiplier;

    [Token(Token = "0x6001E52")]
    [Address(RVA = "0x43E090", Offset = "0x43CC90", Length = "0xE")]
    public DebuffIce(Enemy enemy, DamageContainer dc, float duration, int stacks)
      : base((Enemy) null, (DamageContainer) null, 0.0f, 0)
    {
    }

    [Token(Token = "0x6001E53")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void MyTick()
    {
    }

    [Token(Token = "0x6001E54")]
    [Address(RVA = "0x43E620", Offset = "0x43D220", Length = "0x9")]
    protected override float GetStartTicks() => 0.0f;

    [Token(Token = "0x6001E55")]
    [Address(RVA = "0x4319A0", Offset = "0x4305A0", Length = "0x6")]
    public override EDebuff GetDebuffType() => new EDebuff();

    [Token(Token = "0x6001E56")]
    [Address(RVA = "0x43E890", Offset = "0x43D490", Length = "0x26")]
    public override void OnAdded()
    {
    }

    [Token(Token = "0x6001E57")]
    [Address(RVA = "0x43E890", Offset = "0x43D490", Length = "0x26")]
    public override void OnRemove(bool fromDeath)
    {
    }

    [Token(Token = "0x6001E58")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void OnRefresh()
    {
    }

    [Token(Token = "0x6001E59")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void AddStacks(int numStacks)
    {
    }

    [Token(Token = "0x6001E5A")]
    [Address(RVA = "0x43E8C0", Offset = "0x43D4C0", Length = "0x39")]
    static DebuffIce()
    {
    }
  }
}
