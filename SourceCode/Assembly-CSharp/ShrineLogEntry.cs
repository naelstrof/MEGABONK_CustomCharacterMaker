// Decompiled with JetBrains decompiler
// Type: ShrineLogEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000161")]
public class ShrineLogEntry : MonoBehaviour
{
  [Token(Token = "0x4000A59")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI text;
  [Token(Token = "0x4000A5A")]
  [FieldOffset(Offset = "0x28")]
  public TextSizer textSizer;

  [Token(Token = "0x60008EB")]
  [Address(RVA = "0x4DD230", Offset = "0x4DBE30", Length = "0x69")]
  public void Set(string s)
  {
  }

  [Token(Token = "0x60008EC")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ShrineLogEntry()
  {
  }
}
