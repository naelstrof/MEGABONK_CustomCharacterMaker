// Decompiled with JetBrains decompiler
// Type: TomeSynergiesUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.Tomes;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000159")]
public class TomeSynergiesUi : MonoBehaviour
{
  [Token(Token = "0x4000A1E")]
  [FieldOffset(Offset = "0x20")]
  public RawImage iconPrefab;
  [Token(Token = "0x4000A1F")]
  [FieldOffset(Offset = "0x28")]
  private List<RawImage> iconPrefabs;

  [Token(Token = "0x60008B5")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public void Set(ETome eTome)
  {
  }

  [Token(Token = "0x60008B6")]
  [Address(RVA = "0x4E2A90", Offset = "0x4E1690", Length = "0x77")]
  public TomeSynergiesUi()
  {
  }
}
