// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Utility.MyLogger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Utility
{
  [Token(Token = "0x20002E3")]
  public static class MyLogger
  {
    [Token(Token = "0x6001531")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public static void Log(string s, GameObject context = null)
    {
    }

    [Token(Token = "0x6001532")]
    [Address(RVA = "0x3AFF80", Offset = "0x3AEB80", Length = "0xAD")]
    public static void LogInBuild(string s, GameObject context = null)
    {
    }

    [Token(Token = "0x6001533")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public static void LogError(string s, GameObject context = null)
    {
    }

    [Token(Token = "0x6001534")]
    [Address(RVA = "0x3AFED0", Offset = "0x3AEAD0", Length = "0xAD")]
    public static void LogErrorInBuild(string s, GameObject context = null)
    {
    }
  }
}
