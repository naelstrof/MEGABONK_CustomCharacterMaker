// Decompiled with JetBrains decompiler
// Type: LeaderboardUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Steamworks;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001A6")]
public class LeaderboardUi : MonoBehaviour
{
  [Token(Token = "0x4000BEF")]
  [FieldOffset(Offset = "0x20")]
  public GameObject buffering;
  [Token(Token = "0x4000BF0")]
  [FieldOffset(Offset = "0x28")]
  private string leaderboardName;
  [Token(Token = "0x4000BF1")]
  [FieldOffset(Offset = "0x30")]
  public Transform entriesParent;
  [Token(Token = "0x4000BF2")]
  [FieldOffset(Offset = "0x38")]
  private LeaderboardEntryUi[] leaderboardEntries;
  [Token(Token = "0x4000BF3")]
  [FieldOffset(Offset = "0x40")]
  public ButtonNavigationSelectionOnly leaderboardTypeButtons;
  [Token(Token = "0x4000BF4")]
  private static int lastSelectedTypeIndex;
  [Token(Token = "0x4000BF5")]
  [FieldOffset(Offset = "0x48")]
  public TextMeshProUGUI t_reset;
  [Token(Token = "0x4000BF6")]
  [FieldOffset(Offset = "0x50")]
  private ELeaderboardDataRequest leaderboardType;

  [Token(Token = "0x6000AA7")]
  [Address(RVA = "0x4F30C0", Offset = "0x4F1CC0", Length = "0x574")]
  private void Start()
  {
  }

  [Token(Token = "0x6000AA8")]
  [Address(RVA = "0x4F23B0", Offset = "0x4F0FB0", Length = "0x30E")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000AA9")]
  [Address(RVA = "0x4F2860", Offset = "0x4F1460", Length = "0x859")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000AAA")]
  [Address(RVA = "0x4F2700", Offset = "0x4F1300", Length = "0x15A")]
  private void OnLeaderboardTypeSelected(int index)
  {
  }

  [Token(Token = "0x6000AAB")]
  [Address(RVA = "0x4F26C0", Offset = "0x4F12C0", Length = "0x34")]
  private void OnLeaderboardScoreDownloaded(string lbName)
  {
  }

  [Token(Token = "0x6000AAC")]
  [Address(RVA = "0x4F26C0", Offset = "0x4F12C0", Length = "0x34")]
  private void OnLeaderboardScoreDownloadedLocal(string lbName)
  {
  }

  [Token(Token = "0x6000AAD")]
  [Address(RVA = "0x4F3640", Offset = "0x4F2240", Length = "0x6A")]
  public LeaderboardUi()
  {
  }
}
