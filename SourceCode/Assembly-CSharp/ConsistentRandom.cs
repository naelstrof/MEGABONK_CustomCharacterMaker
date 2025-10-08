// Decompiled with JetBrains decompiler
// Type: ConsistentRandom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

[Token(Token = "0x20000DD")]
public class ConsistentRandom : Random
{
  [Token(Token = "0x400075C")]
  private const int MBIG = 2147483647;
  [Token(Token = "0x400075D")]
  private const int MSEED = 161803398;
  [Token(Token = "0x400075E")]
  private const int MZ = 0;
  [Token(Token = "0x400075F")]
  [FieldOffset(Offset = "0x20")]
  private int inext;
  [Token(Token = "0x4000760")]
  [FieldOffset(Offset = "0x24")]
  private int inextp;
  [Token(Token = "0x4000761")]
  [FieldOffset(Offset = "0x28")]
  private int[] SeedArray;

  [Token(Token = "0x6000636")]
  [Address(RVA = "0x492110", Offset = "0x490D10", Length = "0x22")]
  public ConsistentRandom()
  {
  }

  [Token(Token = "0x6000637")]
  [Address(RVA = "0x492140", Offset = "0x490D40", Length = "0x22F")]
  public ConsistentRandom(int seed)
  {
  }

  [Token(Token = "0x6000638")]
  [Address(RVA = "0x4920F0", Offset = "0x490CF0", Length = "0x20")]
  protected override double Sample() => 0.0;

  [Token(Token = "0x6000639")]
  [Address(RVA = "0x491E10", Offset = "0x490A10", Length = "0x87")]
  private int InternalSample() => 0;

  [Token(Token = "0x600063A")]
  [Address(RVA = "0x4920E0", Offset = "0x490CE0", Length = "0x7")]
  public override int Next() => 0;

  [Token(Token = "0x600063B")]
  [Address(RVA = "0x491DB0", Offset = "0x4909B0", Length = "0x57")]
  private double GetSampleForLargeRange() => 0.0;

  [Token(Token = "0x600063C")]
  [Address(RVA = "0x491FD0", Offset = "0x490BD0", Length = "0x108")]
  public override int Next(int minValue, int maxValue) => 0;

  [Token(Token = "0x600063D")]
  [Address(RVA = "0x491EA0", Offset = "0x490AA0", Length = "0x121")]
  public override void NextBytes(byte[] buffer)
  {
  }
}
