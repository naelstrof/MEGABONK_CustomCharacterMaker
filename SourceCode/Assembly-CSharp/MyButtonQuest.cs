// Decompiled with JetBrains decompiler
// Type: MyButtonQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200017C")]
public class MyButtonQuest : MyButton
{
  [Token(Token = "0x4000AF1")]
  [FieldOffset(Offset = "0x58")]
  public TextMeshProUGUI t_description;
  [Token(Token = "0x4000AF2")]
  [FieldOffset(Offset = "0x60")]
  public TextMeshProUGUI t_reward;
  [Token(Token = "0x4000AF3")]
  [FieldOffset(Offset = "0x68")]
  public TextMeshProUGUI t_progress;
  [Token(Token = "0x4000AF4")]
  [FieldOffset(Offset = "0x70")]
  public TextMeshProUGUI t_claimAmount;
  [Token(Token = "0x4000AF5")]
  [FieldOffset(Offset = "0x78")]
  public RawImage i_icon;
  [Token(Token = "0x4000AF6")]
  [FieldOffset(Offset = "0x80")]
  public RawImage i_progressBar;
  [Token(Token = "0x4000AF7")]
  [FieldOffset(Offset = "0x88")]
  public RawImage i_outline;
  [Token(Token = "0x4000AF8")]
  [FieldOffset(Offset = "0x90")]
  public RawImage i_background;
  [Token(Token = "0x4000AF9")]
  [FieldOffset(Offset = "0x98")]
  public MaskableGraphic i_colorBg;
  [Token(Token = "0x4000AFA")]
  [FieldOffset(Offset = "0xA0")]
  public MaskableGraphic i_colorOutline;
  [Token(Token = "0x4000AFB")]
  [FieldOffset(Offset = "0xA8")]
  public MaskableGraphic i_completeCheck;
  [Token(Token = "0x4000AFC")]
  [FieldOffset(Offset = "0xB0")]
  public GameObject claimOverlay;
  [Token(Token = "0x4000AFD")]
  [FieldOffset(Offset = "0xB8")]
  public GameObject incompleteOverlay;
  [Token(Token = "0x4000AFE")]
  [FieldOffset(Offset = "0xC0")]
  public GameObject rewardContainer;
  [Token(Token = "0x4000AFF")]
  [FieldOffset(Offset = "0xC8")]
  public GameObject hoveringOverlay;
  [Token(Token = "0x4000B01")]
  [FieldOffset(Offset = "0xD8")]
  public Color bgColorDefault;
  [Token(Token = "0x4000B02")]
  [FieldOffset(Offset = "0xE8")]
  public Color bgColorCompleted;
  [Token(Token = "0x4000B03")]
  public static Action<MyButtonQuest> A_Select;
  [Token(Token = "0x4000B04")]
  public static Action<MyButtonQuest> A_Hover;

  [field: Token(Token = "0x4000B00")]
  [field: FieldOffset(Offset = "0xD0")]
  [Token(Token = "0x17000059")]
  public MyAchievement achievement { [Token(Token = "0x6000992"), Address(RVA = "0x37A520", Offset = "0x379120", Length = "0x8")] get; [Token(Token = "0x6000993"), Address(RVA = "0x4D9850", Offset = "0x4D8450", Length = "0x13")] private set; }

  [Token(Token = "0x6000994")]
  [Address(RVA = "0x4D8F90", Offset = "0x4D7B90", Length = "0x7A3")]
  public void Set(MyAchievement achievement)
  {
  }

  [Token(Token = "0x6000995")]
  [Address(RVA = "0x4D9740", Offset = "0x4D8340", Length = "0x75")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x6000996")]
  [Address(RVA = "0x4D97C0", Offset = "0x4D83C0", Length = "0x2E")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x6000997")]
  [Address(RVA = "0x4D8EE0", Offset = "0x4D7AE0", Length = "0xAB")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x6000998")]
  [Address(RVA = "0x4D97F0", Offset = "0x4D83F0", Length = "0x51")]
  public void TryClaimButton()
  {
  }

  [Token(Token = "0x6000999")]
  [Address(RVA = "0x4D8DA0", Offset = "0x4D79A0", Length = "0x135")]
  private void Claim()
  {
  }

  [Token(Token = "0x600099A")]
  [Address(RVA = "0x4D7090", Offset = "0x4D5C90", Length = "0xE")]
  public MyButtonQuest()
  {
  }
}
