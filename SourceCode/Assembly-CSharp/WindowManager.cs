// Decompiled with JetBrains decompiler
// Type: WindowManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;

[Token(Token = "0x2000203")]
public static class WindowManager
{
  [Token(Token = "0x4000E28")]
  public static List<Window> openWindows;
  [Token(Token = "0x4000E29")]
  public static Window activeWindow;
  [Token(Token = "0x4000E2A")]
  public static Action<Window> A_WindowOpened;

  [Token(Token = "0x6000D36")]
  [Address(RVA = "0x53EBA0", Offset = "0x53D7A0", Length = "0x149")]
  public static void Update()
  {
  }

  [Token(Token = "0x6000D37")]
  [Address(RVA = "0x53E570", Offset = "0x53D170", Length = "0x2CE")]
  public static void CloseAll()
  {
  }

  [Token(Token = "0x6000D38")]
  [Address(RVA = "0x53EF20", Offset = "0x53DB20", Length = "0x1D8")]
  public static void WindowOpened(Window newWindow)
  {
  }

  [Token(Token = "0x6000D39")]
  [Address(RVA = "0x53ECF0", Offset = "0x53D8F0", Length = "0x226")]
  public static void WindowClosed(Window closedWindow)
  {
  }

  [Token(Token = "0x6000D3A")]
  [Address(RVA = "0x53EAF0", Offset = "0x53D6F0", Length = "0xAB")]
  public static void RefreshCursor()
  {
  }

  [Token(Token = "0x6000D3B")]
  [Address(RVA = "0x53E840", Offset = "0x53D440", Length = "0x6B")]
  public static bool HasOpenWindow() => false;

  [Token(Token = "0x6000D3C")]
  [Address(RVA = "0x53E8B0", Offset = "0x53D4B0", Length = "0x23E")]
  public static void OnGUI()
  {
  }

  [Token(Token = "0x6000D3D")]
  [Address(RVA = "0x53F100", Offset = "0x53DD00", Length = "0x84")]
  static WindowManager()
  {
  }
}
