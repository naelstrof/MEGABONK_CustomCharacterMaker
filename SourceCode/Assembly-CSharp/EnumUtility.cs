// Decompiled with JetBrains decompiler
// Type: EnumUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System;

[Token(Token = "0x2000210")]
public static class EnumUtility
{
  [Token(Token = "0x6000D75")]
  [Address(RVA = "0x521460", Offset = "0x520060", Length = "0x70")]
  public static string EnumToReadable(string s) => (string) null;

  [Token(Token = "0x6000D76")]
  [Address(RVA = "0x5214D0", Offset = "0x5200D0", Length = "0x7")]
  public static string EnumToReadable(EStat eStat) => (string) null;

  [Token(Token = "0x6000D77")]
  [Address(RVA = "0x6C4240", Offset = "0x6C2E40", Length = "0xA7")]
  public static bool HasFlagsAny<T>(this T value, T flags) where T : Enum => false;

  [Token(Token = "0x6000D78")]
  [Address(RVA = "0x6C4060", Offset = "0x6C2C60", Length = "0xAA")]
  public static bool HasFlagsAll<T>(this T value, T flags) where T : Enum => false;
}
