// Decompiled with JetBrains decompiler
// Type: Utility.MyRandom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Utility
{
  [Token(Token = "0x20002C0")]
  public class MyRandom
  {
    [Token(Token = "0x40012C1")]
    public static Random random;

    [Token(Token = "0x60014A3")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public MyRandom()
    {
    }

    [Token(Token = "0x60014A4")]
    [Address(RVA = "0x390770", Offset = "0x38F370", Length = "0x73")]
    static MyRandom()
    {
    }
  }
}
