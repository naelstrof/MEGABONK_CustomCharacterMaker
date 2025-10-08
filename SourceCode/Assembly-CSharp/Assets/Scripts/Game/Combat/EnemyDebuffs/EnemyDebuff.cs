// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemyDebuffs.EnemyDebuff
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;

namespace Assets.Scripts.Game.Combat.EnemyDebuffs
{
  [Token(Token = "0x200043A")]
  public abstract class EnemyDebuff
  {
    [Token(Token = "0x4001B7C")]
    [FieldOffset(Offset = "0x10")]
    protected int ticksLeft;
    [Token(Token = "0x4001B7D")]
    [FieldOffset(Offset = "0x18")]
    protected Enemy enemy;

    [Token(Token = "0x6001E21")]
    [Address(RVA = "0x4403A0", Offset = "0x43EFA0", Length = "0xA0")]
    public EnemyDebuff(Enemy enemy, DamageContainer dc, float duration, int stacks = 1)
    {
    }

    [Token(Token = "0x6001E22")]
    [Address(RVA = "0x440370", Offset = "0x43EF70", Length = "0x22")]
    public virtual void Tick()
    {
    }

    [Token(Token = "0x6001E23")]
    [Address(RVA = "0x3E9A20", Offset = "0x3E8620", Length = "0x8")]
    public bool IsDone() => false;

    [Token(Token = "0x6001E24")]
    [Address(RVA = "0x440300", Offset = "0x43EF00", Length = "0x66")]
    public void Refresh(float duration, int stacks)
    {
    }

    [Token(Token = "0x6001E25")]
    [Address(RVA = "0x440260", Offset = "0x43EE60", Length = "0x7F")]
    private int GetTicks(float duration) => 0;

    [Token(Token = "0x6001E26")]
    [Address(RVA = "0x4402E0", Offset = "0x43EEE0", Length = "0x1A")]
    private void RefreshTimeout(float duration)
    {
    }

    [Token(Token = "0x6001E27")]
    public abstract void AddStacks(int numStacks);

    [Token(Token = "0x6001E28")]
    public abstract void MyTick();

    [Token(Token = "0x6001E29")]
    protected abstract float GetStartTicks();

    [Token(Token = "0x6001E2A")]
    public abstract EDebuff GetDebuffType();

    [Token(Token = "0x6001E2B")]
    public abstract void OnRemove(bool fromDeath);

    [Token(Token = "0x6001E2C")]
    public abstract void OnAdded();

    [Token(Token = "0x6001E2D")]
    public abstract void OnRefresh();
  }
}
