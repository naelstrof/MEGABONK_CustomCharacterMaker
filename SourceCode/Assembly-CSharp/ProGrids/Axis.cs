// Decompiled with JetBrains decompiler
// Type: ProGrids.Axis
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace ProGrids
{
  [Token(Token = "0x20002AA")]
  public enum Axis
  {
    [Token(Token = "0x4001279")] None = 0,
    [Token(Token = "0x400127A")] X = 1,
    [Token(Token = "0x400127B")] Y = 2,
    [Token(Token = "0x400127C")] Z = 4,
    [Token(Token = "0x400127D")] NegX = 8,
    [Token(Token = "0x400127E")] NegY = 22, // 0x00000016
    [Token(Token = "0x400127F")] NegZ = 50, // 0x00000032
  }
}
