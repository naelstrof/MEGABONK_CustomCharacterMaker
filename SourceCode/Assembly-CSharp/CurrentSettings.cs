// Decompiled with JetBrains decompiler
// Type: CurrentSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Settings___Saves.SaveFiles;
using Cpp2ILInjected;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

[Token(Token = "0x20001CC")]
public class CurrentSettings : MonoBehaviour
{
  [Token(Token = "0x4000CFB")]
  [FieldOffset(Offset = "0x20")]
  public AudioMixer audioMixer;
  [Token(Token = "0x4000CFC")]
  public static CurrentSettings Instance;
  [Token(Token = "0x4000CFD")]
  public static Action<EControllerType> A_ControllerTypeChanged;
  [Token(Token = "0x4000CFE")]
  public static Action<string, object, object> A_SettingUpdated;
  [Token(Token = "0x4000CFF")]
  public static Action<int> A_ResolutionChanged;
  [Token(Token = "0x4000D00")]
  [FieldOffset(Offset = "0x28")]
  private Resolution resolutionBeforeMonitorChange;
  [Token(Token = "0x4000D01")]
  private static bool firstResolutionChange;

  [Token(Token = "0x6000BB2")]
  [Address(RVA = "0x502320", Offset = "0x500F20", Length = "0x238")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000BB3")]
  [Address(RVA = "0x503AA0", Offset = "0x5026A0", Length = "0x3F")]
  private void Start()
  {
  }

  [Token(Token = "0x6000BB4")]
  [Address(RVA = "0x5027B0", Offset = "0x5013B0", Length = "0x138")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000BB5")]
  [Address(RVA = "0x503DF0", Offset = "0x5029F0", Length = "0xBF5")]
  public void UpdateSave()
  {
  }

  [Token(Token = "0x6000BB6")]
  [Address(RVA = "0x502560", Offset = "0x501160", Length = "0xD1")]
  public void BetterUpdateCfSettings(string settingName, object value, CFSettings cfSettings)
  {
  }

  [Token(Token = "0x6000BB7")]
  [Address(RVA = "0x5028F0", Offset = "0x5014F0", Length = "0xB39")]
  private void OnSettingUpdated(string name, object value, object oldValue)
  {
  }

  [Token(Token = "0x6000BB8")]
  [Address(RVA = "0x503B30", Offset = "0x502730", Length = "0x24")]
  private void UpdateInputDelay(int i)
  {
  }

  [Token(Token = "0x6000BB9")]
  [Address(RVA = "0x503B60", Offset = "0x502760", Length = "0x11E")]
  private void UpdateLanguage(int i)
  {
  }

  [Token(Token = "0x6000BBA")]
  [Address(RVA = "0x503D60", Offset = "0x502960", Length = "0x90")]
  private void UpdateResolution(int index, int oldValue)
  {
  }

  [Token(Token = "0x6000BBB")]
  [Address(RVA = "0x503D30", Offset = "0x502930", Length = "0x24")]
  private void UpdateMonitor(int index, int oldValue)
  {
  }

  [Token(Token = "0x6000BBC")]
  [Address(RVA = "0x502640", Offset = "0x501240", Length = "0x86")]
  private IEnumerator DoUpdateResolution(int index, int oldValue) => (IEnumerator) null;

  [Token(Token = "0x6000BBD")]
  [Address(RVA = "0x501FF0", Offset = "0x500BF0", Length = "0xEF")]
  private void AcceptResolution(int newValue)
  {
  }

  [Token(Token = "0x6000BBE")]
  [Address(RVA = "0x5036D0", Offset = "0x5022D0", Length = "0x10B")]
  private void RevertResolution(int oldValue)
  {
  }

  [Token(Token = "0x6000BBF")]
  [Address(RVA = "0x5026D0", Offset = "0x5012D0", Length = "0x86")]
  private IEnumerator DoUpdateTargetMonitor(int index, int oldValue) => (IEnumerator) null;

  [Token(Token = "0x6000BC0")]
  [Address(RVA = "0x5020E0", Offset = "0x500CE0", Length = "0x23A")]
  private void AcceptTargetMonitor(int newValue)
  {
  }

  [Token(Token = "0x6000BC1")]
  [Address(RVA = "0x5037E0", Offset = "0x5023E0", Length = "0x152")]
  private void RevertTargetMonitor(int oldValue)
  {
  }

  [Token(Token = "0x6000BC2")]
  [Address(RVA = "0x503940", Offset = "0x502540", Length = "0x114")]
  private void SetResolution(int index)
  {
  }

  [Token(Token = "0x6000BC3")]
  [Address(RVA = "0x502760", Offset = "0x501360", Length = "0x4B")]
  private IEnumerator MoveToPrimaryDisplay() => (IEnumerator) null;

  [Token(Token = "0x6000BC4")]
  [Address(RVA = "0x503B20", Offset = "0x502720", Length = "0x9")]
  private void UpdateFullscreenMode(int i)
  {
  }

  [Token(Token = "0x6000BC5")]
  [Address(RVA = "0x504A60", Offset = "0x503660", Length = "0x9")]
  private void UpdateVSync(int i)
  {
  }

  [Token(Token = "0x6000BC6")]
  [Address(RVA = "0x503C80", Offset = "0x502880", Length = "0x47")]
  private void UpdateMaxFps(int i)
  {
  }

  [Token(Token = "0x6000BC7")]
  [Address(RVA = "0x5049F0", Offset = "0x5035F0", Length = "0x20")]
  private void UpdateShadowQuality(int i)
  {
  }

  [Token(Token = "0x6000BC8")]
  [Address(RVA = "0x504A10", Offset = "0x503610", Length = "0x2A")]
  private void UpdateShadowResolution(int i)
  {
  }

  [Token(Token = "0x6000BC9")]
  [Address(RVA = "0x504A50", Offset = "0x503650", Length = "0xE")]
  private void UpdateTextureQuality(int i)
  {
  }

  [Token(Token = "0x6000BCA")]
  [Address(RVA = "0x503AE0", Offset = "0x5026E0", Length = "0x38")]
  private void UpdateAntiAliasing(int i)
  {
  }

  [Token(Token = "0x6000BCB")]
  [Address(RVA = "0x504A40", Offset = "0x503640", Length = "0xD")]
  private void UpdateSoftParticles(int b)
  {
  }

  [Token(Token = "0x6000BCC")]
  [Address(RVA = "0x503CD0", Offset = "0x5028D0", Length = "0x5D")]
  public void UpdateMixerVolume(float f, string groupVolumeName)
  {
  }

  [Token(Token = "0x6000BCD")]
  [Address(RVA = "0x503A60", Offset = "0x502660", Length = "0x33")]
  private float SliderToDb(float sliderValue) => 0.0f;

  [Token(Token = "0x6000BCE")]
  [Address(RVA = "0x503430", Offset = "0x502030", Length = "0x293")]
  private void RefreshAudioMixer()
  {
  }

  [Token(Token = "0x6000BCF")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public CurrentSettings()
  {
  }

  [Token(Token = "0x6000BD0")]
  [Address(RVA = "0x504A70", Offset = "0x503670", Length = "0x37")]
  static CurrentSettings()
  {
  }
}
