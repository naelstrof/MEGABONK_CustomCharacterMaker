// Decompiled with JetBrains decompiler
// Type: Settings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Settings___Saves.SaveFiles;
using Assets.Scripts.UI.Menu.Windows;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20001D5")]
public class Settings : MonoBehaviour
{
  [Token(Token = "0x4000D31")]
  [FieldOffset(Offset = "0x20")]
  public GameObject enumPrefab;
  [Token(Token = "0x4000D32")]
  [FieldOffset(Offset = "0x28")]
  public GameObject sliderPrefab;
  [Token(Token = "0x4000D33")]
  [FieldOffset(Offset = "0x30")]
  public GameObject resolutionPrefab;
  [Token(Token = "0x4000D34")]
  [FieldOffset(Offset = "0x38")]
  public GameObject controlPrefab;
  [Token(Token = "0x4000D35")]
  [FieldOffset(Offset = "0x40")]
  public GameObject controlPrefabNew;
  [Token(Token = "0x4000D36")]
  [FieldOffset(Offset = "0x48")]
  public GameObject controllerDisplayPrefab;
  [Token(Token = "0x4000D37")]
  [FieldOffset(Offset = "0x50")]
  public GameObject headerPrefab;
  [Token(Token = "0x4000D38")]
  [FieldOffset(Offset = "0x58")]
  public GameObject languagePrefab;
  [Token(Token = "0x4000D39")]
  [FieldOffset(Offset = "0x60")]
  public Transform videoContent;
  [Token(Token = "0x4000D3A")]
  [FieldOffset(Offset = "0x68")]
  public Transform gameContent;
  [Token(Token = "0x4000D3B")]
  [FieldOffset(Offset = "0x70")]
  public Transform audioContent;
  [Token(Token = "0x4000D3C")]
  [FieldOffset(Offset = "0x78")]
  public Transform controlContent;
  [Token(Token = "0x4000D3D")]
  [FieldOffset(Offset = "0x80")]
  public Transform visualsContent;
  [Token(Token = "0x4000D3E")]
  [FieldOffset(Offset = "0x88")]
  public List<BetterSetting> settings;
  [Token(Token = "0x4000D3F")]
  [FieldOffset(Offset = "0x90")]
  public GameObject resolutionWindow;
  [Token(Token = "0x4000D40")]
  [FieldOffset(Offset = "0x98")]
  public Window settingsWindow;
  [Token(Token = "0x4000D41")]
  [FieldOffset(Offset = "0xA0")]
  public GameObject btn_resetSettings;
  [Token(Token = "0x4000D42")]
  [FieldOffset(Offset = "0xA8")]
  public GameObject b_resetControls;
  [Token(Token = "0x4000D43")]
  [FieldOffset(Offset = "0xB0")]
  public TabsExplicitNavigation gameContentNav;
  [Token(Token = "0x4000D44")]
  [FieldOffset(Offset = "0xB8")]
  public TabsExplicitNavigation settingsNav;
  [Token(Token = "0x4000D45")]
  public static Action A_ResetRewiredControls;
  [Token(Token = "0x4000D46")]
  public static Settings Instance;

  [Token(Token = "0x6000C0E")]
  [Address(RVA = "0x5143F0", Offset = "0x512FF0", Length = "0x2F5")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000C0F")]
  [Address(RVA = "0x5157B0", Offset = "0x5143B0", Length = "0x9A")]
  private void Start()
  {
  }

  [Token(Token = "0x6000C10")]
  [Address(RVA = "0x514F80", Offset = "0x513B80", Length = "0x1D8")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000C11")]
  [Address(RVA = "0x514D40", Offset = "0x513940", Length = "0x23E")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000C12")]
  [Address(RVA = "0x515990", Offset = "0x514590", Length = "0x49B")]
  private void UpdateSettings()
  {
  }

  [Token(Token = "0x6000C13")]
  [Address(RVA = "0x5146F0", Offset = "0x5132F0", Length = "0x578")]
  private void CreateGenericSettings(
    Action<string, object, CFSettings> saveAction,
    Transform contentParent,
    CFSettings cfSettings)
  {
  }

  [Token(Token = "0x6000C14")]
  [Address(RVA = "0x514C70", Offset = "0x513870", Length = "0xB4")]
  private GameObject GetSettingPrefab(SettingType settingType) => (GameObject) null;

  [Token(Token = "0x6000C15")]
  [Address(RVA = "0x515850", Offset = "0x514450", Length = "0x133")]
  public void TryResetSaveFile()
  {
  }

  [Token(Token = "0x6000C16")]
  [Address(RVA = "0x515310", Offset = "0x513F10", Length = "0x37B")]
  public void ResetControls()
  {
  }

  [Token(Token = "0x6000C17")]
  [Address(RVA = "0x515690", Offset = "0x514290", Length = "0x11C")]
  private void ResetSaveFile()
  {
  }

  [Token(Token = "0x6000C18")]
  [Address(RVA = "0x5151D0", Offset = "0x513DD0", Length = "0x13C")]
  public void RefreshSettings()
  {
  }

  [Token(Token = "0x6000C19")]
  [Address(RVA = "0x515160", Offset = "0x513D60", Length = "0x52")]
  private void OnResButtonClicked()
  {
  }

  [Token(Token = "0x6000C1A")]
  [Address(RVA = "0x5151C0", Offset = "0x513DC0", Length = "0x7")]
  private void OnResChanged(int resIndex)
  {
  }

  [Token(Token = "0x6000C1B")]
  [Address(RVA = "0x515E30", Offset = "0x514A30", Length = "0x7D")]
  public Settings()
  {
  }
}
