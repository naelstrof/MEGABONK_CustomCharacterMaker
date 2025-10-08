// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.SaveFiles.Configs.ConfigSettingsExtra
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Saves___Serialization.SaveFiles.Configs
{
  [Token(Token = "0x2000321")]
  public class ConfigSettingsExtra
  {
    [Token(Token = "0x400154A")]
    [FieldOffset(Offset = "0x10")]
    public bool hideCompletedQuests;
    [Token(Token = "0x400154B")]
    [FieldOffset(Offset = "0x11")]
    public bool hasAcceptedPhotoSensitivity;
    [Token(Token = "0x400154C")]
    [FieldOffset(Offset = "0x18")]
    public string lastSteamLanguage;

    [Token(Token = "0x6001651")]
    [Address(RVA = "0x3A48E0", Offset = "0x3A34E0", Length = "0x4F")]
    public ConfigSettingsExtra()
    {
    }
  }
}
