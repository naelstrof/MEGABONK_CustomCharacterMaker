// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Actors.DcFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Assets.Scripts.Actors
{
  [Flags]
  [Token(Token = "0x2000450")]
  public enum DcFlags
  {
    [Token(Token = "0x4001BF3")] None = 0,
    [Token(Token = "0x4001BF4")] BypassEvade = 1,
    [Token(Token = "0x4001BF5")] BossDamage = 2,
    [Token(Token = "0x4001BF6")] BypassAegis = 4,
    [Token(Token = "0x4001BF7")] FinalBossDamage = 8,
    [Token(Token = "0x4001BF8")] BypassAll = BypassAegis | BypassEvade, // 0x00000005
  }
}
