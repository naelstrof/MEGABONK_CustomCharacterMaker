// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.EnemyDebuffs.EDebuff
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Assets.Scripts.Game.Combat.EnemyDebuffs
{
  [Flags]
  [Token(Token = "0x2000439")]
  public enum EDebuff
  {
    [Token(Token = "0x4001B74")] Poison = 1,
    [Token(Token = "0x4001B75")] Freeze = 2,
    [Token(Token = "0x4001B76")] Burn = 4,
    [Token(Token = "0x4001B77")] Stun = 8,
    [Token(Token = "0x4001B78")] Echo = 16, // 0x00000010
    [Token(Token = "0x4001B79")] Charm = 32, // 0x00000020
    [Token(Token = "0x4001B7A")] Bloodmark = 64, // 0x00000040
    [Token(Token = "0x4001B7B")] DebuffsWithCap = Charm | Stun | Freeze, // 0x0000002A
  }
}
