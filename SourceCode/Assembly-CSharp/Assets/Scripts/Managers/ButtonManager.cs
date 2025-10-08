// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Managers.ButtonManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Assets.Scripts.Managers
{
  [Token(Token = "0x2000355")]
  public class ButtonManager
  {
    [Token(Token = "0x40016BC")]
    private static MyButton selectedButton2;
    [Token(Token = "0x40016BD")]
    public static Action<MyButton> A_ButtonHover;
    [Token(Token = "0x40016BE")]
    public static bool enabled;

    [Token(Token = "0x60017A3")]
    [Address(RVA = "0x3C85D0", Offset = "0x3C71D0", Length = "0x51")]
    public static void Refresh()
    {
    }

    [Token(Token = "0x60017A4")]
    [Address(RVA = "0x3C8630", Offset = "0x3C7230", Length = "0xEC")]
    public static void SetFirstButton(MyButton button)
    {
    }

    [Token(Token = "0x60017A5")]
    [Address(RVA = "0x3C8340", Offset = "0x3C6F40", Length = "0x237")]
    public static void ForceHoverButton(MyButton btn)
    {
    }

    [Token(Token = "0x60017A6")]
    [Address(RVA = "0x3C87D0", Offset = "0x3C73D0", Length = "0x152")]
    public static void StartedHoveringButton(MyButton button)
    {
    }

    [Token(Token = "0x60017A7")]
    [Address(RVA = "0x3C8720", Offset = "0x3C7320", Length = "0xA5")]
    public static void SetNull()
    {
    }

    [Token(Token = "0x60017A8")]
    [Address(RVA = "0x3C8580", Offset = "0x3C7180", Length = "0x4E")]
    public static MyButton GetCurrentButton() => (MyButton) null;

    [Token(Token = "0x60017A9")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public ButtonManager()
    {
    }

    [Token(Token = "0x60017AA")]
    [Address(RVA = "0x3C8930", Offset = "0x3C7530", Length = "0x37")]
    static ButtonManager()
    {
    }
  }
}
