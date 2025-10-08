// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemyDebuffs.AddDebuffContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Cpp2ILInjected;

namespace Assets.Scripts.Game.Combat.EnemyDebuffs
{
  [Token(Token = "0x2000436")]
  public struct AddDebuffContainer
  {
    [Token(Token = "0x4001B6D")]
    [FieldOffset(Offset = "0x0")]
    public EDebuff eDebuff;
    [Token(Token = "0x4001B6E")]
    [FieldOffset(Offset = "0x8")]
    public DamageContainer dc;
    [Token(Token = "0x4001B6F")]
    [FieldOffset(Offset = "0x10")]
    public float duration;
    [Token(Token = "0x4001B70")]
    [FieldOffset(Offset = "0x14")]
    public int stacks;

    [Token(Token = "0x6001E1D")]
    [Address(RVA = "0x43A3C0", Offset = "0x438FC0", Length = "0x3A")]
    public AddDebuffContainer(EDebuff eDebuff, DamageContainer dc, float duration, int stacks = 1)
    {
      this.eDebuff = new EDebuff();
      this.dc = (DamageContainer) null;
      this.duration = 0.0f;
      this.stacks = 0;
    }
  }
}
