// Decompiled with JetBrains decompiler
// Type: LanguageStartup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using UnityEngine;

[Token(Token = "0x200019E")]
public class LanguageStartup : MonoBehaviour
{
  [Token(Token = "0x6000A74")]
  [Address(RVA = "0x4EEB10", Offset = "0x4ED710", Length = "0x2BD")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000A75")]
  [Address(RVA = "0x4EF7D0", Offset = "0x4EE3D0", Length = "0x138")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000A76")]
  [Address(RVA = "0x4EF910", Offset = "0x4EE510", Length = "0x16A")]
  private void OnSavesLoaded()
  {
  }

  [Token(Token = "0x6000A77")]
  [Address(RVA = "0x4EFA80", Offset = "0x4EE680", Length = "0x4B")]
  private IEnumerator SetLanguageCoroutine() => (IEnumerator) null;

  [Token(Token = "0x6000A78")]
  [Address(RVA = "0x4EEDD0", Offset = "0x4ED9D0", Length = "0x24F")]
  private static void CheckSteamLanguage()
  {
  }

  [Token(Token = "0x6000A79")]
  [Address(RVA = "0x4EFE30", Offset = "0x4EEA30", Length = "0x314")]
  public static void SetSystemLanguage()
  {
  }

  [Token(Token = "0x6000A7A")]
  [Address(RVA = "0x4EFAD0", Offset = "0x4EE6D0", Length = "0x359")]
  private static void SetLocale(string loc)
  {
  }

  [Token(Token = "0x6000A7B")]
  [Address(RVA = "0x4EF020", Offset = "0x4EDC20", Length = "0x562")]
  private static string MapSteamLangToLocale(string steamLang) => (string) null;

  [Token(Token = "0x6000A7C")]
  [Address(RVA = "0x4EF590", Offset = "0x4EE190", Length = "0x1E0")]
  private static string MapSystemLangToLocale(SystemLanguage lang) => (string) null;

  [Token(Token = "0x6000A7D")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public LanguageStartup()
  {
  }
}
