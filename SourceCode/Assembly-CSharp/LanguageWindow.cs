// Decompiled with JetBrains decompiler
// Type: LanguageWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20001EC")]
public class LanguageWindow : Window
{
  [Token(Token = "0x4000DCA")]
  [FieldOffset(Offset = "0x50")]
  public GameObject languageButtonPrefab;
  [Token(Token = "0x4000DCB")]
  [FieldOffset(Offset = "0x58")]
  public SelectionGroupToggleSingle selectionGroup;
  [Token(Token = "0x4000DCC")]
  [FieldOffset(Offset = "0x60")]
  private List<SelectionGroupToggleSingleButton> buttons;

  [Token(Token = "0x6000CC1")]
  [Address(RVA = "0x528130", Offset = "0x526D30", Length = "0x235")]
  private new void Awake()
  {
  }

  [Token(Token = "0x6000CC2")]
  [Address(RVA = "0x528EB0", Offset = "0x527AB0", Length = "0x16B")]
  private new void Start()
  {
  }

  [Token(Token = "0x6000CC3")]
  [Address(RVA = "0x528370", Offset = "0x526F70", Length = "0x235")]
  private new void OnDestroy()
  {
  }

  [Token(Token = "0x6000CC4")]
  [Address(RVA = "0x5285B0", Offset = "0x5271B0", Length = "0x53")]
  private new void OnEnable()
  {
  }

  [Token(Token = "0x6000CC5")]
  [Address(RVA = "0x5287E0", Offset = "0x5273E0", Length = "0x6C1")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000CC6")]
  [Address(RVA = "0x528610", Offset = "0x527210", Length = "0x1CF")]
  private void OnLanguageSelected(SelectionGroupToggleSingleButton btn)
  {
  }

  [Token(Token = "0x6000CC7")]
  [Address(RVA = "0x4EBA20", Offset = "0x4EA620", Length = "0x7")]
  public LanguageWindow()
  {
  }
}
