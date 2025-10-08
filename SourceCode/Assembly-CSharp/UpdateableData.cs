// Decompiled with JetBrains decompiler
// Type: UpdateableData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

[Token(Token = "0x20000E7")]
public class UpdateableData : ScriptableObject
{
  [Token(Token = "0x4000790")]
  [FieldOffset(Offset = "0x20")]
  public bool autoUpdate;

  [Token(Token = "0x14000003")]
  public event Action OnValuesUpdate
  {
    [Token(Token = "0x6000657"), Address(RVA = "0x4B1640", Offset = "0x4B0240", Length = "0x9E")] add
    {
    }
    [Token(Token = "0x6000658"), Address(RVA = "0x4B16E0", Offset = "0x4B02E0", Length = "0x9E")] remove
    {
    }
  }

  [Token(Token = "0x6000659")]
  [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
  public UpdateableData()
  {
  }
}
