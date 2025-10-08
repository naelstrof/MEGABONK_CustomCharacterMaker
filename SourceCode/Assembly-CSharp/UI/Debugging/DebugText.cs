// Decompiled with JetBrains decompiler
// Type: UI.Debugging.DebugText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace UI.Debugging
{
  [Token(Token = "0x20002C3")]
  public class DebugText : MonoBehaviour
  {
    [Token(Token = "0x40012C5")]
    public static Dictionary<string, string> debugEntries;
    [Token(Token = "0x40012C6")]
    public static Dictionary<string, int> debugPriority;
    [Token(Token = "0x40012C7")]
    private static List<string> sortedKeys;

    [Token(Token = "0x60014AD")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x60014AE")]
    [Address(RVA = "0x389DA0", Offset = "0x3889A0", Length = "0x362")]
    public static void DebugValue(string key, string value, int priority = 0)
    {
    }

    [Token(Token = "0x60014AF")]
    [Address(RVA = "0x38A110", Offset = "0x388D10", Length = "0x1D5")]
    private static void SortKeysByPriority()
    {
    }

    [Token(Token = "0x60014B0")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public DebugText()
    {
    }

    [Token(Token = "0x60014B1")]
    [Address(RVA = "0x38A2F0", Offset = "0x388EF0", Length = "0x148")]
    static DebugText()
    {
    }
  }
}
