// Decompiled with JetBrains decompiler
// Type: MapStatsInfoUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.MapsAndStages;
using Assets.Scripts.Game.Other;
using Cpp2ILInjected;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001B8")]
public class MapStatsInfoUi : MonoBehaviour
{
  [Token(Token = "0x4000C84")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_mapName;
  [Token(Token = "0x4000C85")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_mapRuns;
  [Token(Token = "0x4000C86")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_tier;
  [Token(Token = "0x4000C87")]
  [FieldOffset(Offset = "0x38")]
  public TextMeshProUGUI t_highscore;
  [Token(Token = "0x4000C88")]
  [FieldOffset(Offset = "0x40")]
  public TextMeshProUGUI t_fastestTime;
  [Token(Token = "0x4000C89")]
  [FieldOffset(Offset = "0x48")]
  public RawImage characterIconPrefab;
  [Token(Token = "0x4000C8A")]
  [FieldOffset(Offset = "0x50")]
  public RawImage mapIcon;
  [Token(Token = "0x4000C8B")]
  [FieldOffset(Offset = "0x58")]
  private List<RawImage> characterIcons;
  [Token(Token = "0x4000C8C")]
  [FieldOffset(Offset = "0x60")]
  private EMap currentMap;
  [Token(Token = "0x4000C8D")]
  [FieldOffset(Offset = "0x64")]
  private int currentTier;

  [Token(Token = "0x6000B1F")]
  [Address(RVA = "0x4F8BB0", Offset = "0x4F77B0", Length = "0x121")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000B20")]
  [Address(RVA = "0x4F8CE0", Offset = "0x4F78E0", Length = "0x121")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000B21")]
  [Address(RVA = "0x4F8E10", Offset = "0x4F7A10", Length = "0x8")]
  private void OnRunConfigChanged(RunConfig runConfig)
  {
  }

  [Token(Token = "0x6000B22")]
  [Address(RVA = "0x4F8E20", Offset = "0x4F7A20", Length = "0x8DF")]
  public void SetConfig(RunConfig runConfig)
  {
  }

  [Token(Token = "0x6000B23")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MapStatsInfoUi()
  {
  }
}
