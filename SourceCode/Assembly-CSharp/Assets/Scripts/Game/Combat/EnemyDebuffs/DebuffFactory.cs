// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemyDebuffs.DebuffFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;

namespace Assets.Scripts.Game.Combat.EnemyDebuffs
{
  [Token(Token = "0x2000437")]
  public static class DebuffFactory
  {
    [Token(Token = "0x6001E1E")]
    [Address(RVA = "0x43E210", Offset = "0x43CE10", Length = "0x360")]
    public static EnemyDebuff CreateDebuff(
      EDebuff eDebuff,
      Enemy enemy,
      DamageContainer dc,
      float duration,
      int stacks = 1)
    {
      return (EnemyDebuff) null;
    }
  }
}
