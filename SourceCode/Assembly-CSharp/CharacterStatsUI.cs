// Decompiled with JetBrains decompiler
// Type: CharacterStatsUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x2000189")]
public class CharacterStatsUI : MonoBehaviour
{
  [Token(Token = "0x4000B4B")]
  [FieldOffset(Offset = "0x20")]
  public List<StatContainer> statContainers;

  [Token(Token = "0x60009E7")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public void SetCharacter(CharacterData data)
  {
  }

  [Token(Token = "0x60009E8")]
  [Address(RVA = "0x4EBE80", Offset = "0x4EAA80", Length = "0xB4")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x60009E9")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public CharacterStatsUI()
  {
  }
}
