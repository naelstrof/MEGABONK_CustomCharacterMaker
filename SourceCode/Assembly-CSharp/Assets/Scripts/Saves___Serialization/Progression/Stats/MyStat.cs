// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.Stats.MyStat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Assets.Scripts.Saves___Serialization.Progression.Stats
{
  [Token(Token = "0x200032D")]
  [Serializable]
  public class MyStat
  {
    [Token(Token = "0x40015A0")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x40015A1")]
    [FieldOffset(Offset = "0x18")]
    public float value;

    [Token(Token = "0x6001683")]
    [Address(RVA = "0x3A7D50", Offset = "0x3A6950", Length = "0x44")]
    public MyStat(string name, float value)
    {
    }
  }
}
