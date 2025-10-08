// Decompiled with JetBrains decompiler
// Type: MapStatsWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Other;
using Cpp2ILInjected;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001B9")]
public class MapStatsWindow : MonoBehaviour
{
  [Token(Token = "0x4000C8E")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_mapSpecs;
  [Token(Token = "0x4000C8F")]
  [FieldOffset(Offset = "0x28")]
  public SelectionGroupToggleSingle tierSelection;
  [Token(Token = "0x4000C90")]
  [FieldOffset(Offset = "0x30")]
  public SelectionGroupToggleSingle challengeSelection;
  [Token(Token = "0x4000C91")]
  [FieldOffset(Offset = "0x38")]
  public SelectionGroupToggleSingleButtonTier[] tierButtons;
  [Token(Token = "0x4000C92")]
  [FieldOffset(Offset = "0x40")]
  public MapSelectionUi mapSelectionUi;
  [Token(Token = "0x4000C93")]
  [FieldOffset(Offset = "0x48")]
  public MyButton btnChallenges;
  [Token(Token = "0x4000C94")]
  [FieldOffset(Offset = "0x50")]
  public GameObject newChallengesIndicator;
  [Token(Token = "0x4000C95")]
  [FieldOffset(Offset = "0x58")]
  private Dictionary<int, float> tierSilverMultipliers;

  [Token(Token = "0x6000B24")]
  [Address(RVA = "0x50BAA0", Offset = "0x50A6A0", Length = "0x7")]
  private void Start()
  {
  }

  [Token(Token = "0x6000B25")]
  [Address(RVA = "0x50B4A0", Offset = "0x50A0A0", Length = "0x2FB")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000B26")]
  [Address(RVA = "0x50B7A0", Offset = "0x50A3A0", Length = "0x2FB")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000B27")]
  [Address(RVA = "0x50BAA0", Offset = "0x50A6A0", Length = "0x7")]
  private void OnInfoChanged(SelectionGroupToggleSingleButton btn)
  {
  }

  [Token(Token = "0x6000B28")]
  [Address(RVA = "0x50BAA0", Offset = "0x50A6A0", Length = "0x7")]
  private void OnRunConfigChanged(RunConfig runConfig)
  {
  }

  [Token(Token = "0x6000B29")]
  [Address(RVA = "0x50BAB0", Offset = "0x50A6B0", Length = "0x351")]
  private void OnMapSelected(SelectionGroupToggleSingleButton mapButton, MapData mapData)
  {
  }

  [Token(Token = "0x6000B2A")]
  [Address(RVA = "0x50BE10", Offset = "0x50AA10", Length = "0x213")]
  public void RefreshTiers()
  {
  }

  [Token(Token = "0x6000B2B")]
  [Address(RVA = "0x50C030", Offset = "0x50AC30", Length = "0x6E7")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000B2C")]
  [Address(RVA = "0x50C720", Offset = "0x50B320", Length = "0xDE")]
  public MapStatsWindow()
  {
  }
}
