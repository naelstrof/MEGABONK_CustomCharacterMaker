// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations.DebuffStun
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;

namespace Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations
{
  [Token(Token = "0x2000441")]
  public class DebuffStun : EnemyDebuff
  {
    [Token(Token = "0x6001E65")]
    [Address(RVA = "0x43E090", Offset = "0x43CC90", Length = "0xE")]
    public DebuffStun(Enemy enemy, DamageContainer dc, float duration, int stacks)
      : base((Enemy) null, (DamageContainer) null, 0.0f, 0)
    {
    }

    [Token(Token = "0x6001E66")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void MyTick()
    {
    }

    [Token(Token = "0x6001E67")]
    [Address(RVA = "0x43DA90", Offset = "0x43C690", Length = "0x9")]
    protected override float GetStartTicks() => 0.0f;

    [Token(Token = "0x6001E68")]
    [Address(RVA = "0x433230", Offset = "0x431E30", Length = "0x6")]
    public override EDebuff GetDebuffType() => new EDebuff();

    [Token(Token = "0x6001E69")]
    [Address(RVA = "0x43E890", Offset = "0x43D490", Length = "0x26")]
    public override void OnAdded()
    {
    }

    [Token(Token = "0x6001E6A")]
    [Address(RVA = "0x43E890", Offset = "0x43D490", Length = "0x26")]
    public override void OnRemove(bool fromDeath)
    {
    }

    [Token(Token = "0x6001E6B")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void OnRefresh()
    {
    }

    [Token(Token = "0x6001E6C")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void AddStacks(int numStacks)
    {
    }
  }
}
