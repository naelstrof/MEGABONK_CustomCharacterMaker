// Decompiled with JetBrains decompiler
// Type: UpdatableData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

[Token(Token = "0x20000E6")]
public class UpdatableData : ScriptableObject
{
  [Token(Token = "0x400078E")]
  [FieldOffset(Offset = "0x20")]
  public bool autoUpdate;

  [Token(Token = "0x14000002")]
  public event Action OnValuesUpdated
  {
    [Token(Token = "0x6000654"), Address(RVA = "0x4B1500", Offset = "0x4B0100", Length = "0x9E")] add
    {
    }
    [Token(Token = "0x6000655"), Address(RVA = "0x4B15A0", Offset = "0x4B01A0", Length = "0x9E")] remove
    {
    }
  }

  [Token(Token = "0x6000656")]
  [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
  public UpdatableData()
  {
  }
}
