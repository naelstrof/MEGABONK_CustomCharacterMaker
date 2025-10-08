// Decompiled with JetBrains decompiler
// Type: AlwaysUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200011A")]
public class AlwaysUi : MonoBehaviour
{
  [Token(Token = "0x4000867")]
  [FieldOffset(Offset = "0x20")]
  public UiTextPopup UiTextPopup;
  [Token(Token = "0x4000868")]
  [FieldOffset(Offset = "0x28")]
  public SelectionArrow selectionArrow;
  [Token(Token = "0x4000869")]
  [FieldOffset(Offset = "0x30")]
  public GameObject resolutionWindow;
  [Token(Token = "0x400086A")]
  [FieldOffset(Offset = "0x38")]
  public GameObject languageWindow;
  [Token(Token = "0x400086B")]
  [FieldOffset(Offset = "0x40")]
  public DynamicWindows dynamicWindows;
  [Token(Token = "0x400086C")]
  [FieldOffset(Offset = "0x48")]
  public ConfigWarning configWarning;
  [Token(Token = "0x400086D")]
  [FieldOffset(Offset = "0x50")]
  public TooltipNew tooltipNew;
  [Token(Token = "0x400086E")]
  public static AlwaysUi Instance;

  [Token(Token = "0x600070C")]
  [Address(RVA = "0x4B2B90", Offset = "0x4B1790", Length = "0xD3")]
  private void Awake()
  {
  }

  [Token(Token = "0x600070D")]
  [Address(RVA = "0x4B2C70", Offset = "0x4B1870", Length = "0x20")]
  public void OpenLanguageWindow()
  {
  }

  [Token(Token = "0x600070E")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void OnGUI()
  {
  }

  [Token(Token = "0x600070F")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void OnApplicationFocus(bool hasFocus)
  {
  }

  [Token(Token = "0x6000710")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void OnApplicationPause()
  {
  }

  [Token(Token = "0x6000711")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public AlwaysUi()
  {
  }
}
