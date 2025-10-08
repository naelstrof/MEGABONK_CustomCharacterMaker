// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Settings___Saves.SaveFiles.ConfigSettingsTypes.CFAudioSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Settings___Saves.SaveFiles.ConfigSettingsTypes
{
  [Token(Token = "0x200031D")]
  public class CFAudioSettings : CFSettings
  {
    [Token(Token = "0x4001529")]
    [FieldOffset(Offset = "0x10")]
    public float master_volume;
    [Token(Token = "0x400152A")]
    [FieldOffset(Offset = "0x14")]
    public float music;
    [Token(Token = "0x400152B")]
    [FieldOffset(Offset = "0x18")]
    public float game_sfx;
    [Token(Token = "0x400152C")]
    [FieldOffset(Offset = "0x1C")]
    public float ambience;
    [Token(Token = "0x400152D")]
    [FieldOffset(Offset = "0x20")]
    public float ui;
    [Token(Token = "0x400152E")]
    [FieldOffset(Offset = "0x24")]
    public float xp_and_gold;

    [Token(Token = "0x600163C")]
    [Address(RVA = "0x3A2E00", Offset = "0x3A1A00", Length = "0x13C")]
    public List<SettingHeader> GetHeaders() => (List<SettingHeader>) null;

    [Token(Token = "0x600163D")]
    [Address(RVA = "0x3A2F40", Offset = "0x3A1B40", Length = "0x31")]
    public CFAudioSettings()
    {
    }
  }
}
