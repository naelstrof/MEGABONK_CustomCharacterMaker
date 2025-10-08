// Decompiled with JetBrains decompiler
// Type: ExplorerUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000211")]
public class ExplorerUtility : MonoBehaviour
{
  [Token(Token = "0x6000D79")]
  [Address(RVA = "0x521800", Offset = "0x520400", Length = "0x135")]
  public static void OpenInFileExplorer(string filePath)
  {
  }

  [Token(Token = "0x6000D7A")]
  [Address(RVA = "0x5214E0", Offset = "0x5200E0", Length = "0xAE")]
  private static string NormalizeFilePath(string filePath) => (string) null;

  [Token(Token = "0x6000D7B")]
  [Address(RVA = "0x521590", Offset = "0x520190", Length = "0x26E")]
  public static void OpenFileInExplorerNew(string filePath)
  {
  }

  [Token(Token = "0x6000D7C")]
  [Address(RVA = "0x375D80", Offset = "0x374980", Length = "0x3")]
  public static bool IsWindows() => false;

  [Token(Token = "0x6000D7D")]
  [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
  public static bool IsOSX() => false;

  [Token(Token = "0x6000D7E")]
  [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
  public static bool IsLinux() => false;

  [Token(Token = "0x6000D7F")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ExplorerUtility()
  {
  }
}
