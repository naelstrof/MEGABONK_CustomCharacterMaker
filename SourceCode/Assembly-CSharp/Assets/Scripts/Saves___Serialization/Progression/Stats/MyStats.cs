// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.Stats.MyStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Assets.Scripts.Saves___Serialization.Progression.Stats
{
  [Token(Token = "0x200032E")]
  public static class MyStats
  {
    [Token(Token = "0x40015A2")]
    private static bool hasUnsavedChanges;
    [Token(Token = "0x40015A3")]
    public static Action<string, MyStat> A_StatUpdated;
    [Token(Token = "0x40015A4")]
    private static float nextSaveTimeReady;
    [Token(Token = "0x40015A5")]
    private static float saveCooldown;

    [Token(Token = "0x6001684")]
    [Address(RVA = "0x3B08B0", Offset = "0x3AF4B0", Length = "0x3B7")]
    public static void Init()
    {
    }

    [Token(Token = "0x6001685")]
    [Address(RVA = "0x3B0350", Offset = "0x3AEF50", Length = "0x32E")]
    public static void Cleanup()
    {
    }

    [Token(Token = "0x6001686")]
    [Address(RVA = "0x3B02C0", Offset = "0x3AEEC0", Length = "0x86")]
    public static void AddValue(EMyStat statName, float value)
    {
    }

    [Token(Token = "0x6001687")]
    [Address(RVA = "0x3B0030", Offset = "0x3AEC30", Length = "0x289")]
    public static void AddValue(string statName, float value)
    {
    }

    [Token(Token = "0x6001688")]
    [Address(RVA = "0x3B11A0", Offset = "0x3AFDA0", Length = "0x428")]
    private static void SetValue(string statName, float value)
    {
    }

    [Token(Token = "0x6001689")]
    [Address(RVA = "0x3B0E50", Offset = "0x3AFA50", Length = "0x34A")]
    public static void SetValueForce(string statName, float value)
    {
    }

    [Token(Token = "0x600168A")]
    [Address(RVA = "0x3B07F0", Offset = "0x3AF3F0", Length = "0xB9")]
    public static bool HasStat(string statName) => false;

    [Token(Token = "0x600168B")]
    [Address(RVA = "0x3B0680", Offset = "0x3AF280", Length = "0x16B")]
    public static float GetStat(string statName) => 0.0f;

    [Token(Token = "0x600168C")]
    [Address(RVA = "0x3B0DB0", Offset = "0x3AF9B0", Length = "0x4E")]
    private static void OnProgressionLoaded()
    {
    }

    [Token(Token = "0x600168D")]
    [Address(RVA = "0x3B0E00", Offset = "0x3AFA00", Length = "0x4E")]
    private static void OnProgressionSaved()
    {
    }

    [Token(Token = "0x600168E")]
    [Address(RVA = "0x3B0C70", Offset = "0x3AF870", Length = "0x139")]
    private static void OnPause(bool paused)
    {
    }

    [Token(Token = "0x600168F")]
    [Address(RVA = "0x3B15D0", Offset = "0x3B01D0", Length = "0x3A")]
    static MyStats()
    {
    }
  }
}
