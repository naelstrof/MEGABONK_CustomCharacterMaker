// Decompiled with JetBrains decompiler
// Type: MapSelectionUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Other;
using Cpp2ILInjected;
using System;
using UnityEngine;

[Token(Token = "0x20001B3")]
public class MapSelectionUi : Window
{
  [Token(Token = "0x4000C64")]
  [FieldOffset(Offset = "0x50")]
  public SelectionGroupToggleSingle mapSelectionGroup;
  [Token(Token = "0x4000C65")]
  [FieldOffset(Offset = "0x58")]
  public SelectionGroupToggleSingle tierSelectionGroup;
  [Token(Token = "0x4000C66")]
  [FieldOffset(Offset = "0x60")]
  public ChallengesUi challengesUi;
  [Token(Token = "0x4000C67")]
  [FieldOffset(Offset = "0x68")]
  private bool firstSelection;
  [Token(Token = "0x4000C68")]
  [FieldOffset(Offset = "0x70")]
  private SelectionGroupToggleSingleButton selectedBtn;
  [Token(Token = "0x4000C69")]
  [FieldOffset(Offset = "0x78")]
  private SelectionGroupToggleSingleButton mapBtn;
  [Token(Token = "0x4000C6A")]
  [FieldOffset(Offset = "0x80")]
  public MapStatsWindow mapStatsWindow;
  [Token(Token = "0x4000C6B")]
  [FieldOffset(Offset = "0x88")]
  public MapSelectionWindow mapButtonsWindow;
  [Token(Token = "0x4000C6C")]
  [FieldOffset(Offset = "0x90")]
  public RunConfig runConfig;
  [Token(Token = "0x4000C6D")]
  [FieldOffset(Offset = "0x98")]
  public MyButton btnConfirm;
  [Token(Token = "0x4000C6E")]
  [FieldOffset(Offset = "0xA0")]
  public GameObject jukebox;
  [Token(Token = "0x4000C6F")]
  public static Action<RunConfig> A_RunConfigChanged;
  [Token(Token = "0x4000C70")]
  public static Action<SelectionGroupToggleSingleButton, MapData> A_MapSelected;
  [Token(Token = "0x4000C71")]
  [FieldOffset(Offset = "0xA8")]
  private bool isSelectingMap;
  [Token(Token = "0x4000C72")]
  [FieldOffset(Offset = "0xA9")]
  private bool newMapSelected;
  [Token(Token = "0x4000C73")]
  public static bool isTestFight;
  [Token(Token = "0x4000C74")]
  public static Action A_MapSelectionEnabled;

  [Token(Token = "0x6000AFE")]
  [Address(RVA = "0x4F7660", Offset = "0x4F6260", Length = "0x1D1")]
  private new void Awake()
  {
  }

  [Token(Token = "0x6000AFF")]
  [Address(RVA = "0x4F7AC0", Offset = "0x4F66C0", Length = "0x1D1")]
  private new void OnDestroy()
  {
  }

  [Token(Token = "0x6000B00")]
  [Address(RVA = "0x4F7840", Offset = "0x4F6440", Length = "0x278")]
  public void Init()
  {
  }

  [Token(Token = "0x6000B01")]
  [Address(RVA = "0x4F7DE0", Offset = "0x4F69E0", Length = "0x391")]
  private void OnMapSelected(SelectionGroupToggleSingleButton btn)
  {
  }

  [Token(Token = "0x6000B02")]
  [Address(RVA = "0x4F8180", Offset = "0x4F6D80", Length = "0x291")]
  private void OnTierSelected(SelectionGroupToggleSingleButton btn)
  {
  }

  [Token(Token = "0x6000B03")]
  [Address(RVA = "0x4F8420", Offset = "0x4F7020", Length = "0x80")]
  public void SetChallenge(ChallengeData challengeData)
  {
  }

  [Token(Token = "0x6000B04")]
  [Address(RVA = "0x4F8560", Offset = "0x4F7160", Length = "0x4A")]
  public void StartMap()
  {
  }

  [Token(Token = "0x6000B05")]
  [Address(RVA = "0x4F84B0", Offset = "0x4F70B0", Length = "0xA8")]
  public void StartBossFightTest()
  {
  }

  [Token(Token = "0x6000B06")]
  [Address(RVA = "0x4F7CA0", Offset = "0x4F68A0", Length = "0x3C")]
  private new void OnDisable()
  {
  }

  [Token(Token = "0x6000B07")]
  [Address(RVA = "0x4F7CE0", Offset = "0x4F68E0", Length = "0xFE")]
  private new void OnEnable()
  {
  }

  [Token(Token = "0x6000B08")]
  [Address(RVA = "0x4F85B0", Offset = "0x4F71B0", Length = "0x79")]
  public MapSelectionUi()
  {
  }
}
