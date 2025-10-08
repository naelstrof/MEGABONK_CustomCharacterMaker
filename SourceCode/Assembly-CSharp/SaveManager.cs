// Decompiled with JetBrains decompiler
// Type: SaveManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.SaveFiles;
using Assets.Scripts.Settings___Saves.SaveFiles.ConfigSaves;
using Cpp2ILInjected;
using System;
using UnityEngine;

[Token(Token = "0x2000115")]
public class SaveManager : MonoBehaviour
{
  [Token(Token = "0x400083F")]
  private static bool USE_ENCRYPTION;
  [Token(Token = "0x4000840")]
  private static int settingsVersion;
  [Token(Token = "0x4000841")]
  private static ulong steamIdSave;
  [Token(Token = "0x4000842")]
  private const string configName = "config.json";
  [Token(Token = "0x4000843")]
  private const string statsName = "stats.json";
  [Token(Token = "0x4000844")]
  private const string progressionName = "progression.json";
  [Token(Token = "0x4000845")]
  public const string controllersName = "controller_config.json";
  [Token(Token = "0x4000846")]
  [FieldOffset(Offset = "0x20")]
  public ConfigSaveFile config;
  [Token(Token = "0x4000847")]
  [FieldOffset(Offset = "0x28")]
  public StatsSaveFile stats;
  [Token(Token = "0x4000848")]
  [FieldOffset(Offset = "0x30")]
  public ProgressionSaveFile progression;
  [Token(Token = "0x400084A")]
  public static Action A_SavesLoaded;
  [Token(Token = "0x400084B")]
  public static Action A_ProgressionSaved;
  [Token(Token = "0x400084C")]
  private static string cloudDirectory;
  [Token(Token = "0x400084D")]
  private static string localDirectory;
  [Token(Token = "0x400084E")]
  private const string lastSteamIdKey = "saves_last_steamid";
  [Token(Token = "0x400084F")]
  public static bool loaded;
  [Token(Token = "0x4000850")]
  [FieldOffset(Offset = "0x38")]
  private bool usingNoSave;

  [field: Token(Token = "0x4000849")]
  [Token(Token = "0x1700003E")]
  public static SaveManager Instance { [Token(Token = "0x60006DA"), Address(RVA = "0x4C4460", Offset = "0x4C3060", Length = "0x4F")] get; [Token(Token = "0x60006DB"), Address(RVA = "0x4C44B0", Offset = "0x4C30B0", Length = "0x6E")] private set; }

  [Token(Token = "0x60006DC")]
  [Address(RVA = "0x4C23E0", Offset = "0x4C0FE0", Length = "0x162")]
  private void Awake()
  {
  }

  [Token(Token = "0x60006DD")]
  [Address(RVA = "0x4C3BD0", Offset = "0x4C27D0", Length = "0xF2")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60006DE")]
  [Address(RVA = "0x4C3DE0", Offset = "0x4C29E0", Length = "0xCD")]
  public void SaveConfig()
  {
  }

  [Token(Token = "0x60006DF")]
  [Address(RVA = "0x4C4140", Offset = "0x4C2D40", Length = "0xC7")]
  public void SaveStats()
  {
  }

  [Token(Token = "0x60006E0")]
  [Address(RVA = "0x4C4020", Offset = "0x4C2C20", Length = "0x115")]
  public void SaveProgression()
  {
  }

  [Token(Token = "0x60006E1")]
  [Address(RVA = "0x4C4210", Offset = "0x4C2E10", Length = "0x15D")]
  private void SaveTemp(string serializedJson, string filePath, bool encrypt)
  {
  }

  [Token(Token = "0x60006E2")]
  [Address(RVA = "0x4C27C0", Offset = "0x4C13C0", Length = "0x85")]
  private static string GetDataPath() => (string) null;

  [Token(Token = "0x60006E3")]
  [Address(RVA = "0x4C2550", Offset = "0x4C1150", Length = "0x90")]
  private static string GetCloudFolder() => (string) null;

  [Token(Token = "0x60006E4")]
  [Address(RVA = "0x4C2850", Offset = "0x4C1450", Length = "0x90")]
  private static string GetLocalFolder() => (string) null;

  [Token(Token = "0x60006E5")]
  [Address(RVA = "0x4C25E0", Offset = "0x4C11E0", Length = "0x85")]
  private string GetConfigPath() => (string) null;

  [Token(Token = "0x60006E6")]
  [Address(RVA = "0x4C2990", Offset = "0x4C1590", Length = "0xAD")]
  private string GetStatsPath() => (string) null;

  [Token(Token = "0x60006E7")]
  [Address(RVA = "0x4C28E0", Offset = "0x4C14E0", Length = "0xAD")]
  private string GetProgressionPath() => (string) null;

  [Token(Token = "0x60006E8")]
  [Address(RVA = "0x4C2710", Offset = "0x4C1310", Length = "0xAD")]
  public static string GetControllersPath() => (string) null;

  [Token(Token = "0x60006E9")]
  [Address(RVA = "0x4C2670", Offset = "0x4C1270", Length = "0x9A")]
  public static string GetControllersDir() => (string) null;

  [Token(Token = "0x60006EA")]
  [Address(RVA = "0x4C2E90", Offset = "0x4C1A90", Length = "0x16D")]
  public void Load(bool loadBackup)
  {
  }

  [Token(Token = "0x60006EB")]
  [Address(RVA = "0x4C2D30", Offset = "0x4C1930", Length = "0x15C")]
  public void LoadNoSave()
  {
  }

  [Token(Token = "0x60006EC")]
  [Address(RVA = "0x4C3000", Offset = "0x4C1C00", Length = "0xB48")]
  public bool Load(ulong steamId, bool loadBackup, out string failReason, out string failPath)
  {
    failReason = (string) null;
    failPath = (string) null;
    return false;
  }

  [Token(Token = "0x60006ED")]
  [Address(RVA = "0x4C3B50", Offset = "0x4C2750", Length = "0x71")]
  public void NewSaveConfig()
  {
  }

  [Token(Token = "0x60006EE")]
  [Address(RVA = "0x4C3CD0", Offset = "0x4C28D0", Length = "0x10F")]
  public void ResetAll()
  {
  }

  [Token(Token = "0x60006EF")]
  [Address(RVA = "0x4C3EB0", Offset = "0x4C2AB0", Length = "0x168")]
  public void SaveControllers()
  {
  }

  [Token(Token = "0x60006F0")]
  [Address(RVA = "0x4C2A40", Offset = "0x4C1640", Length = "0x2E3")]
  public void LoadControllers()
  {
  }

  [Token(Token = "0x60006F1")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public SaveManager()
  {
  }

  [Token(Token = "0x60006F2")]
  [Address(RVA = "0x4C4370", Offset = "0x4C2F70", Length = "0xE6")]
  static SaveManager()
  {
  }
}
