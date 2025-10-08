// Decompiled with JetBrains decompiler
// Type: SimpleEncryptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

[Token(Token = "0x2000215")]
public static class SimpleEncryptor
{
  [Token(Token = "0x4000E7E")]
  private static readonly byte[] Key;
  [Token(Token = "0x4000E7F")]
  private static readonly byte[] IV;

  [Token(Token = "0x6000D85")]
  [Address(RVA = "0x52D9B0", Offset = "0x52C5B0", Length = "0x4FE")]
  public static string Encrypt(string plainText) => (string) null;

  [Token(Token = "0x6000D86")]
  [Address(RVA = "0x52D510", Offset = "0x52C110", Length = "0x48F")]
  public static string Decrypt(string encryptedText) => (string) null;

  [Token(Token = "0x6000D87")]
  [Address(RVA = "0x52DEB0", Offset = "0x52CAB0", Length = "0xEA")]
  static SimpleEncryptor()
  {
  }
}
