// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.SaveFiles.Configs.ConfigSettingsTypes.CFVisualsSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Settings___Saves.SaveFiles;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Saves___Serialization.SaveFiles.Configs.ConfigSettingsTypes
{
  [Token(Token = "0x2000323")]
  public class CFVisualsSettings : CFSettings
  {
    [Token(Token = "0x4001554")]
    [FieldOffset(Offset = "0x10")]
    public int damage_numbers;
    [Token(Token = "0x4001555")]
    [FieldOffset(Offset = "0x14")]
    public int damage_flash;
    [Token(Token = "0x4001556")]
    [FieldOffset(Offset = "0x18")]
    public int low_hp_effects;

    [Token(Token = "0x6001654")]
    [Address(RVA = "0x3A3A30", Offset = "0x3A2630", Length = "0x13C")]
    public List<SettingHeader> GetHeaders() => (List<SettingHeader>) null;

    [Token(Token = "0x6001655")]
    [Address(RVA = "0x3A3B70", Offset = "0x3A2770", Length = "0x1C")]
    public CFVisualsSettings()
    {
    }
  }
}
