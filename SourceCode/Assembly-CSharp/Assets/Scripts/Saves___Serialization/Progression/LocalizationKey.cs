// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.LocalizationKey
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine.Localization;

namespace Assets.Scripts.Saves___Serialization.Progression
{
  [Token(Token = "0x2000325")]
  [Serializable]
  public class LocalizationKey
  {
    [Token(Token = "0x400155A")]
    [FieldOffset(Offset = "0x10")]
    public string key;
    [Token(Token = "0x400155B")]
    [FieldOffset(Offset = "0x18")]
    public LocalizedString localizedValue;

    [Token(Token = "0x600165A")]
    [Address(RVA = "0x3AC580", Offset = "0x3AB180", Length = "0x4E")]
    public LocalizationKey(string key, LocalizedString localizedValue)
    {
    }
  }
}
