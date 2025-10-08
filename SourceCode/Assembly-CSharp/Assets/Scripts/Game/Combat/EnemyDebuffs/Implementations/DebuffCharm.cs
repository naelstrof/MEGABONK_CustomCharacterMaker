// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations.DebuffCharm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;

namespace Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations
{
  [Token(Token = "0x200043D")]
  public class DebuffCharm : EnemyDebuff
  {
    [Token(Token = "0x6001E41")]
    [Address(RVA = "0x43E090", Offset = "0x43CC90", Length = "0xE")]
    public DebuffCharm(Enemy enemy, DamageContainer dc, float duration, int stacks)
      : base((Enemy) null, (DamageContainer) null, 0.0f, 0)
    {
    }

    [Token(Token = "0x6001E42")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void MyTick()
    {
    }

    [Token(Token = "0x6001E43")]
    [Address(RVA = "0x358360", Offset = "0x356F60", Length = "0x9")]
    protected override float GetStartTicks() => 0.0f;

    [Token(Token = "0x6001E44")]
    [Address(RVA = "0x43E000", Offset = "0x43CC00", Length = "0x6")]
    public override EDebuff GetDebuffType() => new EDebuff();

    [Token(Token = "0x6001E45")]
    [Address(RVA = "0x43E010", Offset = "0x43CC10", Length = "0x7E")]
    public override void OnRemove(bool fromDeath)
    {
    }

    [Token(Token = "0x6001E46")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void OnAdded()
    {
    }

    [Token(Token = "0x6001E47")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void OnRefresh()
    {
    }

    [Token(Token = "0x6001E48")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void AddStacks(int numStacks)
    {
    }
  }
}
