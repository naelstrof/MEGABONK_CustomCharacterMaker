// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemyDebuffs.DebuffEcho
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;

namespace Assets.Scripts.Game.Combat.EnemyDebuffs
{
  [Token(Token = "0x200043B")]
  public class DebuffEcho : EnemyDebuff
  {
    [Token(Token = "0x6001E2E")]
    [Address(RVA = "0x43E090", Offset = "0x43CC90", Length = "0xE")]
    public DebuffEcho(Enemy enemy, DamageContainer dc, float duration, int stacks)
      : base((Enemy) null, (DamageContainer) null, 0.0f, 0)
    {
    }

    [Token(Token = "0x6001E2F")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void MyTick()
    {
    }

    [Token(Token = "0x6001E30")]
    [Address(RVA = "0x358360", Offset = "0x356F60", Length = "0x9")]
    protected override float GetStartTicks() => 0.0f;

    [Token(Token = "0x6001E31")]
    [Address(RVA = "0x43E0A0", Offset = "0x43CCA0", Length = "0x6")]
    public override EDebuff GetDebuffType() => new EDebuff();

    [Token(Token = "0x6001E32")]
    [Address(RVA = "0x43E0B0", Offset = "0x43CCB0", Length = "0x15B")]
    public override void OnRemove(bool fromDeath)
    {
    }

    [Token(Token = "0x6001E33")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void OnAdded()
    {
    }

    [Token(Token = "0x6001E34")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void OnRefresh()
    {
    }

    [Token(Token = "0x6001E35")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void AddStacks(int numStacks)
    {
    }
  }
}
