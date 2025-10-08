// Decompiled with JetBrains decompiler
// Type: RunConfigUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000160")]
public class RunConfigUi : MonoBehaviour
{
  [Token(Token = "0x4000A51")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_mapName;
  [Token(Token = "0x4000A52")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_mapTier;
  [Token(Token = "0x4000A53")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_silverMultiplier;
  [Token(Token = "0x4000A54")]
  [FieldOffset(Offset = "0x38")]
  public TextMeshProUGUI t_challengeName;
  [Token(Token = "0x4000A55")]
  [FieldOffset(Offset = "0x40")]
  public TextMeshProUGUI t_challengeDescription;
  [Token(Token = "0x4000A56")]
  [FieldOffset(Offset = "0x48")]
  public Image mapOutline;
  [Token(Token = "0x4000A57")]
  [FieldOffset(Offset = "0x50")]
  public GameObject challenge;
  [Token(Token = "0x4000A58")]
  [FieldOffset(Offset = "0x58")]
  public GameObject challengeFailedOverlay;

  [Token(Token = "0x60008E7")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60008E8")]
  [Address(RVA = "0x4DCE30", Offset = "0x4DBA30", Length = "0x3F6")]
  private void Start()
  {
  }

  [Token(Token = "0x60008E9")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void Refresh()
  {
  }

  [Token(Token = "0x60008EA")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public RunConfigUi()
  {
  }
}
