// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations.DebuffFire
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;

namespace Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations
{
  [Token(Token = "0x200043E")]
  public class DebuffFire : EnemyDebuff
  {
    [Token(Token = "0x4001B86")]
    [FieldOffset(Offset = "0x20")]
    private string damageSource;
    [Token(Token = "0x4001B87")]
    [FieldOffset(Offset = "0x28")]
    private bool canDamage;

    [Token(Token = "0x6001E49")]
    [Address(RVA = "0x43E7E0", Offset = "0x43D3E0", Length = "0xAF")]
    public DebuffFire(Enemy enemy, DamageContainer dc, float duration, int stacks)
      : base((Enemy) null, (DamageContainer) null, 0.0f, 0)
    {
    }

    [Token(Token = "0x6001E4A")]
    [Address(RVA = "0x43E630", Offset = "0x43D230", Length = "0x1AB")]
    public override void MyTick()
    {
    }

    [Token(Token = "0x6001E4B")]
    [Address(RVA = "0x43E580", Offset = "0x43D180", Length = "0x9D")]
    private float GetDamage() => 0.0f;

    [Token(Token = "0x6001E4C")]
    [Address(RVA = "0x43E620", Offset = "0x43D220", Length = "0x9")]
    protected override float GetStartTicks() => 0.0f;

    [Token(Token = "0x6001E4D")]
    [Address(RVA = "0x3E74A0", Offset = "0x3E60A0", Length = "0x6")]
    public override EDebuff GetDebuffType() => new EDebuff();

    [Token(Token = "0x6001E4E")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void OnRemove(bool fromDeath)
    {
    }

    [Token(Token = "0x6001E4F")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void OnAdded()
    {
    }

    [Token(Token = "0x6001E50")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void OnRefresh()
    {
    }

    [Token(Token = "0x6001E51")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void AddStacks(int numStacks)
    {
    }
  }
}
