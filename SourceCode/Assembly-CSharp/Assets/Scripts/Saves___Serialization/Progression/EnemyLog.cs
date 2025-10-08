// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.EnemyLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Assets.Scripts.Saves___Serialization.Progression
{
  [Token(Token = "0x2000326")]
  [Serializable]
  public class EnemyLog
  {
    [Token(Token = "0x400155C")]
    [FieldOffset(Offset = "0x10")]
    public int kills;
    [Token(Token = "0x400155D")]
    [FieldOffset(Offset = "0x14")]
    public int currentChallengeTier;

    [Token(Token = "0x600165B")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public EnemyLog()
    {
    }
  }
}
