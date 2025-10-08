// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.GlyphTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;

namespace Rewired.Glyphs
{
  [Token(Token = "0x2000285")]
  public static class GlyphTools
  {
    [Token(Token = "0x60012DA")]
    [Address(RVA = "0x36F7B0", Offset = "0x36E3B0", Length = "0x673")]
    public static bool TryGetActionElementMaps(
      int playerId,
      int actionId,
      AxisRange actionRange,
      ControllerElementGlyphSelectorOptions options,
      List<ActionElementMap> workingActionElementMaps,
      out ActionElementMap aemResult1,
      out ActionElementMap aemResult2)
    {
      aemResult1 = (ActionElementMap) null;
      aemResult2 = (ActionElementMap) null;
      return false;
    }

    [Token(Token = "0x60012DB")]
    [Address(RVA = "0x36FE30", Offset = "0x36EA30", Length = "0x24D")]
    public static bool TryGetActionElementMaps(
      InputAction action,
      AxisRange actionRange,
      List<ActionElementMap> tempAems,
      out ActionElementMap aemResult1,
      out ActionElementMap aemResult2)
    {
      aemResult1 = (ActionElementMap) null;
      aemResult2 = (ActionElementMap) null;
      return false;
    }

    [Token(Token = "0x60012DC")]
    [Address(RVA = "0x36F1D0", Offset = "0x36DDD0", Length = "0xA5")]
    public static ActionElementMap FindFirstFullAxisBinding(List<ActionElementMap> actionElementMaps) => (ActionElementMap) null;

    [Token(Token = "0x60012DD")]
    [Address(RVA = "0x36F050", Offset = "0x36DC50", Length = "0x17B")]
    public static ActionElementMap FindFirstBinding(
      List<ActionElementMap> actionElementMaps,
      AxisRange actionRange)
    {
      return (ActionElementMap) null;
    }

    [Token(Token = "0x60012DE")]
    [Address(RVA = "0x36F280", Offset = "0x36DE80", Length = "0x125")]
    public static bool FindFirstSplitAxisBindingPair(
      List<ActionElementMap> actionElementMaps,
      out ActionElementMap negativeAem,
      out ActionElementMap positiveAem)
    {
      negativeAem = (ActionElementMap) null;
      positiveAem = (ActionElementMap) null;
      return false;
    }

    [Token(Token = "0x60012DF")]
    [Address(RVA = "0x36F600", Offset = "0x36E200", Length = "0x6C")]
    public static bool IsMousePrioritizedOverKeyboard(ControllerElementGlyphSelectorOptions options) => false;

    [Token(Token = "0x60012E0")]
    [Address(RVA = "0x36F530", Offset = "0x36E130", Length = "0xC3")]
    private static int GetElementMapsWithAction(
      Player player,
      ControllerType controllerType,
      int controllerId,
      int actionId,
      bool skipDisabledMaps,
      List<ActionElementMap> results)
    {
      return 0;
    }

    [Token(Token = "0x60012E1")]
    [Address(RVA = "0x36F470", Offset = "0x36E070", Length = "0xB6")]
    private static int GetElementMapsWithAction(
      Player player,
      ControllerType controllerType,
      int actionId,
      bool skipDisabledMaps,
      List<ActionElementMap> results)
    {
      return 0;
    }

    [Token(Token = "0x60012E2")]
    [Address(RVA = "0x36F3B0", Offset = "0x36DFB0", Length = "0xB0")]
    private static int GetElementMapsWithAction(
      Player player,
      int actionId,
      bool skipDisabledMaps,
      List<ActionElementMap> results)
    {
      return 0;
    }

    [Token(Token = "0x60012E3")]
    [Address(RVA = "0x36F670", Offset = "0x36E270", Length = "0x13E")]
    private static int RemoveInvalidElementMaps(
      Player player,
      List<ActionElementMap> results,
      int startIndex)
    {
      return 0;
    }
  }
}
