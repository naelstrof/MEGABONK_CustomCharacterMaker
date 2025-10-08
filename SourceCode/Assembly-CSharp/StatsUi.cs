// Decompiled with JetBrains decompiler
// Type: StatsUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x200016F")]
public class StatsUi : MonoBehaviour
{
  [Token(Token = "0x4000A9B")]
  [FieldOffset(Offset = "0x20")]
  public Transform rootTransformToRefresh;
  [Token(Token = "0x4000A9C")]
  [FieldOffset(Offset = "0x28")]
  public GameObject entryPrefab;
  [Token(Token = "0x4000A9D")]
  [FieldOffset(Offset = "0x30")]
  public GameObject spacerPrefab;
  [Token(Token = "0x4000A9E")]
  [FieldOffset(Offset = "0x38")]
  private List<StatEntry> entries;
  [Token(Token = "0x4000A9F")]
  [FieldOffset(Offset = "0x40")]
  private int[] spacers;
  [Token(Token = "0x4000AA0")]
  [FieldOffset(Offset = "0x48")]
  private List<EStat> statsToShow;

  [Token(Token = "0x600093D")]
  [Address(RVA = "0x4DEF80", Offset = "0x4DDB80", Length = "0x132")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x600093E")]
  [Address(RVA = "0x4DF0C0", Offset = "0x4DDCC0", Length = "0x358")]
  private void TryInit()
  {
  }

  [Token(Token = "0x600093F")]
  [Address(RVA = "0x4DEF80", Offset = "0x4DDB80", Length = "0x132")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000940")]
  [Address(RVA = "0x4DEDD0", Offset = "0x4DD9D0", Length = "0x67")]
  private IEnumerator DelayedRebuild() => (IEnumerator) null;

  [Token(Token = "0x6000941")]
  [Address(RVA = "0x4DEE40", Offset = "0x4DDA40", Length = "0x60")]
  public static string FormatStat(EStat stat, float value) => (string) null;

  [Token(Token = "0x6000942")]
  [Address(RVA = "0x4DF420", Offset = "0x4DE020", Length = "0xB24")]
  public StatsUi()
  {
  }
}
