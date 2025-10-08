// Decompiled with JetBrains decompiler
// Type: ChallengesUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001B0")]
public class ChallengesUi : Window
{
  [Token(Token = "0x4000C4B")]
  [FieldOffset(Offset = "0x50")]
  public GameObject challengeButtonPrefab;
  [Token(Token = "0x4000C4C")]
  [FieldOffset(Offset = "0x58")]
  public SelectionGroupToggleSingle challengesSelectionGroup;
  [Token(Token = "0x4000C4D")]
  [FieldOffset(Offset = "0x60")]
  private List<SelectionGroupToggleSingleButtonChallenge> challengeButtons;
  [Token(Token = "0x4000C4E")]
  [FieldOffset(Offset = "0x68")]
  public MapSelectionUi mapSelectionUi;
  [Token(Token = "0x4000C4F")]
  [FieldOffset(Offset = "0x70")]
  public MyButton btn_confirm;
  [Token(Token = "0x4000C50")]
  [FieldOffset(Offset = "0x78")]
  private SelectionGroupToggleSingleButton hoverBtn;
  [Token(Token = "0x4000C51")]
  [FieldOffset(Offset = "0x80")]
  private Color completedColor;
  [Token(Token = "0x4000C52")]
  [FieldOffset(Offset = "0x90")]
  private Color notCompletedColor;
  [Token(Token = "0x4000C53")]
  [FieldOffset(Offset = "0xA0")]
  public TextMeshProUGUI t_name;
  [Token(Token = "0x4000C54")]
  [FieldOffset(Offset = "0xA8")]
  public TextMeshProUGUI t_stats;
  [Token(Token = "0x4000C55")]
  [FieldOffset(Offset = "0xB0")]
  public TextMeshProUGUI t_description;
  [Token(Token = "0x4000C56")]
  [FieldOffset(Offset = "0xB8")]
  public TextMeshProUGUI t_silver;
  [Token(Token = "0x4000C57")]
  [FieldOffset(Offset = "0xC0")]
  public TextMeshProUGUI t_completed;
  [Token(Token = "0x4000C58")]
  [FieldOffset(Offset = "0xC8")]
  public TextMeshProUGUI t_author;
  [Token(Token = "0x4000C59")]
  [FieldOffset(Offset = "0xD0")]
  public TextMeshProUGUI t_header;
  [Token(Token = "0x4000C5A")]
  [FieldOffset(Offset = "0xD8")]
  public TextMeshProUGUI t_winCondition;
  [Token(Token = "0x4000C5B")]
  [FieldOffset(Offset = "0xE0")]
  public TextMeshProUGUI t_reward;
  [Token(Token = "0x4000C5C")]
  [FieldOffset(Offset = "0xE8")]
  public TextMeshProUGUI t_leaderboards;

  [Token(Token = "0x6000AE9")]
  [Address(RVA = "0x4E6A50", Offset = "0x4E5650", Length = "0x210")]
  private new void Awake()
  {
  }

  [Token(Token = "0x6000AEA")]
  [Address(RVA = "0x4E8930", Offset = "0x4E7530", Length = "0x21F")]
  private new void Start()
  {
  }

  [Token(Token = "0x6000AEB")]
  [Address(RVA = "0x4E7620", Offset = "0x4E6220", Length = "0x210")]
  private new void OnDestroy()
  {
  }

  [Token(Token = "0x6000AEC")]
  [Address(RVA = "0x4E6CF0", Offset = "0x4E58F0", Length = "0x791")]
  private void OnChallengeHovered(SelectionGroupToggleSingleButtonChallenge btn)
  {
  }

  [Token(Token = "0x6000AED")]
  [Address(RVA = "0x4E8B50", Offset = "0x4E7750", Length = "0x83E")]
  private void UpdateStatsText(ChallengeData challengeData)
  {
  }

  [Token(Token = "0x6000AEE")]
  [Address(RVA = "0x4E6C70", Offset = "0x4E5870", Length = "0x55")]
  private bool IsNegativeModifier(StatModifier statModifier) => false;

  [Token(Token = "0x6000AEF")]
  [Address(RVA = "0x4E6CD0", Offset = "0x4E58D0", Length = "0x12")]
  private bool IsOppositeStat(EStat stat) => false;

  [Token(Token = "0x6000AF0")]
  [Address(RVA = "0x4E8440", Offset = "0x4E7040", Length = "0x1D2")]
  private void SetEmpty()
  {
  }

  [Token(Token = "0x6000AF1")]
  [Address(RVA = "0x4E8620", Offset = "0x4E7220", Length = "0x2C7")]
  private void SetHidden(ChallengeData challengeData)
  {
  }

  [Token(Token = "0x6000AF2")]
  [Address(RVA = "0x4E7840", Offset = "0x4E6440", Length = "0x1F")]
  private new void OnEnable()
  {
  }

  [Token(Token = "0x6000AF3")]
  [Address(RVA = "0x4E7860", Offset = "0x4E6460", Length = "0xBDE")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000AF4")]
  [Address(RVA = "0x4E88F0", Offset = "0x4E74F0", Length = "0x36")]
  public void SetNone()
  {
  }

  [Token(Token = "0x6000AF5")]
  [Address(RVA = "0x4E7490", Offset = "0x4E6090", Length = "0x189")]
  private void OnChallengeSelected(SelectionGroupToggleSingleButton btn)
  {
  }

  [Token(Token = "0x6000AF6")]
  [Address(RVA = "0x4E9390", Offset = "0x4E7F90", Length = "0x9D")]
  public ChallengesUi()
  {
  }
}
