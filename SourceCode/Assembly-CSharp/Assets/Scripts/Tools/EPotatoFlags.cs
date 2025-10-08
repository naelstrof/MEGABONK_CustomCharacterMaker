// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Tools.EPotatoFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Assets.Scripts.Tools
{
  [Flags]
  [Token(Token = "0x2000307")]
  public enum EPotatoFlags
  {
    [Token(Token = "0x400148C")] None = 0,
    [Token(Token = "0x400148D")] Collision = 1,
    [Token(Token = "0x400148E")] Kills = 2,
    [Token(Token = "0x400148F")] Gold = 4,
    [Token(Token = "0x4001490")] Hp = 8,
    [Token(Token = "0x4001491")] Damage = 16, // 0x00000010
    [Token(Token = "0x4001492")] KillsPerMinute = 32, // 0x00000020
    [Token(Token = "0x4001493")] HpTamper = 64, // 0x00000040
  }
}
