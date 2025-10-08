// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Settings___Saves.SaveFiles.CFSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Settings___Saves.SaveFiles
{
  [Token(Token = "0x2000318")]
  public interface CFSettings
  {
    [Token(Token = "0x6001628")]
    List<SettingHeader> GetHeaders();
  }
}
