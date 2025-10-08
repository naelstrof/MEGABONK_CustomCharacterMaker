// Decompiled with JetBrains decompiler
// Type: Tile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;

[Token(Token = "0x20000F3")]
public class Tile
{
  [field: Token(Token = "0x40007B1")]
  [field: FieldOffset(Offset = "0x10")]
  [Token(Token = "0x17000039")]
  public int X { [Token(Token = "0x600067E"), Address(RVA = "0x36AC50", Offset = "0x369850", Length = "0x4")] get; }

  [field: Token(Token = "0x40007B2")]
  [field: FieldOffset(Offset = "0x14")]
  [Token(Token = "0x1700003A")]
  public int Y { [Token(Token = "0x600067F"), Address(RVA = "0x4AF8D0", Offset = "0x4AE4D0", Length = "0x4")] get; }

  [field: Token(Token = "0x40007B3")]
  [field: FieldOffset(Offset = "0x18")]
  [Token(Token = "0x1700003B")]
  public bool IsAvailable { [Token(Token = "0x6000680"), Address(RVA = "0x4AF8B0", Offset = "0x4AE4B0", Length = "0x5")] get; [Token(Token = "0x6000681"), Address(RVA = "0x4AF8E0", Offset = "0x4AE4E0", Length = "0x4")] set; }

  [field: Token(Token = "0x40007B4")]
  [field: FieldOffset(Offset = "0x19")]
  [Token(Token = "0x1700003C")]
  public bool IsVisited { [Token(Token = "0x6000682"), Address(RVA = "0x4AF8C0", Offset = "0x4AE4C0", Length = "0x5")] get; [Token(Token = "0x6000683"), Address(RVA = "0x4AF8F0", Offset = "0x4AE4F0", Length = "0x4")] set; }

  [field: Token(Token = "0x40007B5")]
  [field: FieldOffset(Offset = "0x20")]
  [Token(Token = "0x1700003D")]
  public List<Tile> Neighbors { [Token(Token = "0x6000684"), Address(RVA = "0x36C790", Offset = "0x36B390", Length = "0x5")] get; }

  [Token(Token = "0x6000685")]
  [Address(RVA = "0x4AF810", Offset = "0x4AE410", Length = "0x92")]
  public Tile(int x, int y)
  {
  }
}
