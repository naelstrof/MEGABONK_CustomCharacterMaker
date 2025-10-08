// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Settings___Saves.SaveFiles.ConfigSettingsUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Reflection;
using UnityEngine;

namespace Assets.Scripts.Settings___Saves.SaveFiles
{
  [Token(Token = "0x200031A")]
  public static class ConfigSettingsUtility
  {
    [Token(Token = "0x600162B")]
    [Address(RVA = "0x3A60C0", Offset = "0x3A4CC0", Length = "0x27F")]
    public static SettingType GetSettingType(FieldInfo field) => new SettingType();

    [Token(Token = "0x600162C")]
    [Address(RVA = "0x3A49A0", Offset = "0x3A35A0", Length = "0xD0")]
    public static string CheckSettingName(string settingName) => (string) null;

    [Token(Token = "0x600162D")]
    [Address(RVA = "0x3A5630", Offset = "0x3A4230", Length = "0x8E9")]
    public static string GetSettingDescription(string settingName) => (string) null;

    [Token(Token = "0x600162E")]
    [Address(RVA = "0x3A6340", Offset = "0x3A4F40", Length = "0x602")]
    public static string[] GetSettingValues(string settingName) => (string[]) null;

    [Token(Token = "0x600162F")]
    [Address(RVA = "0x3A6DC0", Offset = "0x3A59C0", Length = "0xD2")]
    public static bool GetSliderWholeNumbers(string settingName) => false;

    [Token(Token = "0x6001630")]
    [Address(RVA = "0x3A69D0", Offset = "0x3A55D0", Length = "0x3E9")]
    public static void GetSliderRange(string settingName, out float min, out float max)
    {
      min = new float();
      max = new float();
    }

    [Token(Token = "0x6001631")]
    [Address(RVA = "0x3A5470", Offset = "0x3A4070", Length = "0x1BC")]
    private static string[] GetResolutionNames() => (string[]) null;

    [Token(Token = "0x6001632")]
    [Address(RVA = "0x3A4DD0", Offset = "0x3A39D0", Length = "0x16B")]
    private static string[] GetLanguageNames() => (string[]) null;

    [Token(Token = "0x6001633")]
    [Address(RVA = "0x3A5190", Offset = "0x3A3D90", Length = "0x2DA")]
    public static Resolution[] GetMyResolutions() => (Resolution[]) null;

    [Token(Token = "0x6001634")]
    [Address(RVA = "0x3A4A80", Offset = "0x3A3680", Length = "0x344")]
    public static string[] GetControllers() => (string[]) null;

    [Token(Token = "0x6001635")]
    [Address(RVA = "0x3A4930", Offset = "0x3A3530", Length = "0x69")]
    public static bool AreResolutionSame(Resolution r1, Resolution r2) => false;

    [Token(Token = "0x6001636")]
    [Address(RVA = "0x3A4F40", Offset = "0x3A3B40", Length = "0x243")]
    private static string[] GetMonitorNames() => (string[]) null;

    [Token(Token = "0x6001637")]
    [Address(RVA = "0x3A7200", Offset = "0x3A5E00", Length = "0xCD")]
    public static string SettingNameToReadable(string s) => (string) null;

    [Token(Token = "0x6001638")]
    [Address(RVA = "0x3A6EA0", Offset = "0x3A5AA0", Length = "0x353")]
    public static string SettingNameToReadable(string s, CFSettings cfSettings) => (string) null;

    [Token(Token = "0x6001639")]
    [Address(RVA = "0x3A5F20", Offset = "0x3A4B20", Length = "0x19A")]
    public static string GetSettingEnumLocalized(string settingEnumValue) => (string) null;

    [Token(Token = "0x600163A")]
    [Address(RVA = "0x3A6950", Offset = "0x3A5550", Length = "0x79")]
    public static float GetSliderIncrement(string settingName) => 0.0f;
  }
}
