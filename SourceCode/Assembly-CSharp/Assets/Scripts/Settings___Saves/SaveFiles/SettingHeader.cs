// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Settings___Saves.SaveFiles.SettingHeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Settings___Saves.SaveFiles
{
  [Token(Token = "0x200031B")]
  public class SettingHeader
  {
    [Token(Token = "0x400151F")]
    [FieldOffset(Offset = "0x10")]
    public int index;
    [Token(Token = "0x4001520")]
    [FieldOffset(Offset = "0x18")]
    public string header;

    [Token(Token = "0x600163B")]
    [Address(RVA = "0x3B82A0", Offset = "0x3B6EA0", Length = "0x40")]
    public SettingHeader(int index, string header)
    {
    }
  }
}
