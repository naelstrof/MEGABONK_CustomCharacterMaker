// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Settings___Saves.SaveFiles.ConfigSaves.ConfigSaveFile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.SaveFiles.Configs;
using Assets.Scripts.Saves___Serialization.SaveFiles.Configs.ConfigSettingsTypes;
using Assets.Scripts.Settings___Saves.SaveFiles.ConfigSettingsTypes;
using Cpp2ILInjected;
using System;

namespace Assets.Scripts.Settings___Saves.SaveFiles.ConfigSaves
{
  [Token(Token = "0x200031E")]
  [Serializable]
  public class ConfigSaveFile
  {
    [Token(Token = "0x400152F")]
    [FieldOffset(Offset = "0x10")]
    public int settingsVersion;
    [Token(Token = "0x4001530")]
    [FieldOffset(Offset = "0x14")]
    public bool hasSelectedLanguage;
    [Token(Token = "0x4001531")]
    [FieldOffset(Offset = "0x18")]
    public CFGameSettings cfGameSettings;
    [Token(Token = "0x4001532")]
    [FieldOffset(Offset = "0x20")]
    public CFVideoSettings cfVideoSettings;
    [Token(Token = "0x4001533")]
    [FieldOffset(Offset = "0x28")]
    public CFAudioSettings cfAudioSettings;
    [Token(Token = "0x4001534")]
    [FieldOffset(Offset = "0x30")]
    public CFControlSettings cfControlSettings;
    [Token(Token = "0x4001535")]
    [FieldOffset(Offset = "0x38")]
    public CFVisualsSettings cfVisualsSettings;
    [Token(Token = "0x4001536")]
    [FieldOffset(Offset = "0x40")]
    public ConfigSettingsExtra otherSettings;
    [Token(Token = "0x4001537")]
    [FieldOffset(Offset = "0x48")]
    public Preferences preferences;

    [Token(Token = "0x600163E")]
    [Address(RVA = "0x3A4370", Offset = "0x3A2F70", Length = "0x1D")]
    public void Init()
    {
    }

    [Token(Token = "0x600163F")]
    [Address(RVA = "0x3A4390", Offset = "0x3A2F90", Length = "0x547")]
    public ConfigSaveFile()
    {
    }
  }
}
