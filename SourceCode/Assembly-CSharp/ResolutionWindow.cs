// Decompiled with JetBrains decompiler
// Type: ResolutionWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20001ED")]
public class ResolutionWindow : Window
{
  [Token(Token = "0x4000DCD")]
  [FieldOffset(Offset = "0x50")]
  public GameObject resolutionButtonPrefab;
  [Token(Token = "0x4000DCE")]
  [FieldOffset(Offset = "0x58")]
  private List<MyButtonResolution> resolutionButtons;

  [Token(Token = "0x6000CC8")]
  [Address(RVA = "0x52BD50", Offset = "0x52A950", Length = "0x9B")]
  private new void OnEnable()
  {
  }

  [Token(Token = "0x6000CC9")]
  [Address(RVA = "0x52BDF0", Offset = "0x52A9F0", Length = "0x41F")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000CCA")]
  [Address(RVA = "0x52C210", Offset = "0x52AE10", Length = "0x77")]
  public ResolutionWindow()
  {
  }
}
