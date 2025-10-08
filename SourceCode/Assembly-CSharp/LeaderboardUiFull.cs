// Decompiled with JetBrains decompiler
// Type: LeaderboardUiFull
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Menu.Shop.Leaderboards;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001A1")]
public class LeaderboardUiFull : MonoBehaviour
{
  [Token(Token = "0x4000BD3")]
  [FieldOffset(Offset = "0x20")]
  public GameObject buffering;
  [Token(Token = "0x4000BD4")]
  [FieldOffset(Offset = "0x28")]
  private string leaderboardName;
  [Token(Token = "0x4000BD5")]
  [FieldOffset(Offset = "0x30")]
  public Transform entriesParent;
  [Token(Token = "0x4000BD6")]
  [FieldOffset(Offset = "0x38")]
  private LeaderboardEntryUi[] leaderboardEntries;
  [Token(Token = "0x4000BD7")]
  [FieldOffset(Offset = "0x40")]
  public ButtonNavigationSelectionOnly tabCategory;
  [Token(Token = "0x4000BD8")]
  [FieldOffset(Offset = "0x48")]
  public ButtonNavigationSelectionOnly tabGroup;
  [Token(Token = "0x4000BD9")]
  private static int lastSelectedTypeIndex;
  [Token(Token = "0x4000BDA")]
  [FieldOffset(Offset = "0x50")]
  public TextMeshProUGUI t_reset;

  [Token(Token = "0x6000A86")]
  [Address(RVA = "0x4F1D70", Offset = "0x4F0970", Length = "0x5C8")]
  private void Start()
  {
  }

  [Token(Token = "0x6000A87")]
  [Address(RVA = "0x4F0ED0", Offset = "0x4EFAD0", Length = "0x3C9")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000A88")]
  [Address(RVA = "0x4F1400", Offset = "0x4F0000", Length = "0x962")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000A89")]
  [Address(RVA = "0x4F0E90", Offset = "0x4EFA90", Length = "0x26")]
  private ELeaderboardCategory GetCategory() => new ELeaderboardCategory();

  [Token(Token = "0x6000A8A")]
  [Address(RVA = "0x4F12E0", Offset = "0x4EFEE0", Length = "0x111")]
  private void RefreshFilter()
  {
  }

  [Token(Token = "0x6000A8B")]
  [Address(RVA = "0x4F0EC0", Offset = "0x4EFAC0", Length = "0x7")]
  private void OnGroupSelected(int index)
  {
  }

  [Token(Token = "0x6000A8C")]
  [Address(RVA = "0x4F0EC0", Offset = "0x4EFAC0", Length = "0x7")]
  private void OnCategorySelected(int index)
  {
  }

  [Token(Token = "0x6000A8D")]
  [Address(RVA = "0x4F12A0", Offset = "0x4EFEA0", Length = "0x34")]
  private void OnLeaderboardScoreDownloaded(string lbName)
  {
  }

  [Token(Token = "0x6000A8E")]
  [Address(RVA = "0x4F12A0", Offset = "0x4EFEA0", Length = "0x34")]
  private void OnLeaderboardScoreDownloadedLocal(string lbName)
  {
  }

  [Token(Token = "0x6000A8F")]
  [Address(RVA = "0x4F2340", Offset = "0x4F0F40", Length = "0x6A")]
  public LeaderboardUiFull()
  {
  }
}
