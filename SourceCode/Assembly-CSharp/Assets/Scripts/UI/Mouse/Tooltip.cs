// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.Mouse.Tooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Mouse
{
  [Token(Token = "0x20002ED")]
  public static class Tooltip
  {
    [Token(Token = "0x4001416")]
    private const string tooltipColor = "#ffe88a";
    [Token(Token = "0x4001417")]
    private const string tooltipColorOther = "#42b9f5";

    [Token(Token = "0x6001549")]
    [Address(RVA = "0x3C0C10", Offset = "0x3BF810", Length = "0x1A3")]
    public static string GetTooltipString(EStat stat, string color = "#ffe88a") => (string) null;

    [Token(Token = "0x600154A")]
    [Address(RVA = "0x3C0A80", Offset = "0x3BF680", Length = "0x18C")]
    public static string GetTooltipString(string s, string forceColor = "") => (string) null;

    [Token(Token = "0x600154B")]
    [Address(RVA = "0x3C0970", Offset = "0x3BF570", Length = "0x101")]
    public static string GetIdInfo(string keyword) => (string) null;
  }
}
