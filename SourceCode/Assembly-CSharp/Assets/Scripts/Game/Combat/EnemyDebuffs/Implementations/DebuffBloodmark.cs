// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations.DebuffBloodmark
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;

namespace Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations
{
  [Token(Token = "0x200043C")]
  public class DebuffBloodmark : EnemyDebuff
  {
    [Token(Token = "0x4001B7E")]
    public const float defaultDuration = 4f;
    [Token(Token = "0x4001B7F")]
    [FieldOffset(Offset = "0x20")]
    private int stacks;
    [Token(Token = "0x4001B80")]
    public static string damageSource;
    [Token(Token = "0x4001B81")]
    [FieldOffset(Offset = "0x28")]
    private DamageContainer dc;
    [Token(Token = "0x4001B82")]
    [FieldOffset(Offset = "0x30")]
    private float baseDamageMultiplier;
    [Token(Token = "0x4001B83")]
    [FieldOffset(Offset = "0x34")]
    private float damage;
    [Token(Token = "0x4001B84")]
    [FieldOffset(Offset = "0x38")]
    private bool isDone;
    [Token(Token = "0x4001B85")]
    [FieldOffset(Offset = "0x39")]
    private bool isSubscribed;

    [Token(Token = "0x6001E36")]
    [Address(RVA = "0x43DEE0", Offset = "0x43CAE0", Length = "0x11F")]
    public DebuffBloodmark(Enemy enemy, DamageContainer dc, float duration, int stacks)
      : base((Enemy) null, (DamageContainer) null, 0.0f, 0)
    {
    }

    [Token(Token = "0x6001E37")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void MyTick()
    {
    }

    [Token(Token = "0x6001E38")]
    [Address(RVA = "0x43DA90", Offset = "0x43C690", Length = "0x9")]
    protected override float GetStartTicks() => 0.0f;

    [Token(Token = "0x6001E39")]
    [Address(RVA = "0x415A60", Offset = "0x414660", Length = "0x6")]
    public float GetDamage() => 0.0f;

    [Token(Token = "0x6001E3A")]
    [Address(RVA = "0x43D950", Offset = "0x43C550", Length = "0x125")]
    public override void AddStacks(int numStacks)
    {
    }

    [Token(Token = "0x6001E3B")]
    [Address(RVA = "0x43DA80", Offset = "0x43C680", Length = "0x6")]
    public override EDebuff GetDebuffType() => new EDebuff();

    [Token(Token = "0x6001E3C")]
    [Address(RVA = "0x43DCA0", Offset = "0x43C8A0", Length = "0x1A6")]
    public override void OnRemove(bool fromDeath)
    {
    }

    [Token(Token = "0x6001E3D")]
    [Address(RVA = "0x43DAA0", Offset = "0x43C6A0", Length = "0x118")]
    public override void OnAdded()
    {
    }

    [Token(Token = "0x6001E3E")]
    [Address(RVA = "0x43DBC0", Offset = "0x43C7C0", Length = "0xCB")]
    private void OnEnemyDamaged(Enemy e, DamageContainer dc)
    {
    }

    [Token(Token = "0x6001E3F")]
    [Address(RVA = "0x43DC90", Offset = "0x43C890", Length = "0xE")]
    public override void OnRefresh()
    {
    }

    [Token(Token = "0x6001E40")]
    [Address(RVA = "0x43DE50", Offset = "0x43CA50", Length = "0x81")]
    static DebuffBloodmark()
    {
    }
  }
}
