// Decompiled with JetBrains decompiler
// Type: LeaderboardEntryUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Menu.Shop.Leaderboards;
using Assets.Scripts.Steam;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001A4")]
public class LeaderboardEntryUi : MyButton
{
  [Token(Token = "0x4000BE3")]
  [FieldOffset(Offset = "0x58")]
  public RawImage playerIcon;
  [Token(Token = "0x4000BE4")]
  [FieldOffset(Offset = "0x60")]
  public RawImage characterIcon;
  [Token(Token = "0x4000BE5")]
  [FieldOffset(Offset = "0x68")]
  public TextMeshProUGUI playerName;
  [Token(Token = "0x4000BE6")]
  [FieldOffset(Offset = "0x70")]
  public TextMeshProUGUI rank;
  [Token(Token = "0x4000BE7")]
  [FieldOffset(Offset = "0x78")]
  public TextMeshProUGUI score;
  [Token(Token = "0x4000BE8")]
  [FieldOffset(Offset = "0x80")]
  public RawImage localHighlight;
  [Token(Token = "0x4000BE9")]
  [FieldOffset(Offset = "0x88")]
  public MaskableGraphic outlineColor;
  [Token(Token = "0x4000BEA")]
  [FieldOffset(Offset = "0x90")]
  public Color colorDefault;
  [Token(Token = "0x4000BEB")]
  [FieldOffset(Offset = "0xA0")]
  public Color colorGold;
  [Token(Token = "0x4000BEC")]
  [FieldOffset(Offset = "0xB0")]
  public GameObject hoverOverlay;
  [Token(Token = "0x4000BED")]
  [FieldOffset(Offset = "0xB8")]
  private LeaderboardEntry entry;

  [Token(Token = "0x6000A9A")]
  [Address(RVA = "0x4F02A0", Offset = "0x4EEEA0", Length = "0x140")]
  private new void Awake()
  {
  }

  [Token(Token = "0x6000A9B")]
  [Address(RVA = "0x4F0A80", Offset = "0x4EF680", Length = "0x2E")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x6000A9C")]
  [Address(RVA = "0x4F0AB0", Offset = "0x4EF6B0", Length = "0x2E")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x6000A9D")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x6000A9E")]
  [Address(RVA = "0x4F0440", Offset = "0x4EF040", Length = "0x140")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000A9F")]
  [Address(RVA = "0x4F05F0", Offset = "0x4EF1F0", Length = "0x487")]
  public void Set(LeaderboardEntry entry, int rankIndex, ELeaderboardCategory category = ELeaderboardCategory.Kills)
  {
  }

  [Token(Token = "0x6000AA0")]
  [Address(RVA = "0x3563C0", Offset = "0x354FC0", Length = "0x26")]
  public void Clear()
  {
  }

  [Token(Token = "0x6000AA1")]
  [Address(RVA = "0x4F0590", Offset = "0x4EF190", Length = "0x5D")]
  private void OnPlayerInformationArrived(ulong steamid)
  {
  }

  [Token(Token = "0x6000AA2")]
  [Address(RVA = "0x4F03F0", Offset = "0x4EEFF0", Length = "0x41")]
  private void LoadAvatar()
  {
  }

  [Token(Token = "0x6000AA3")]
  [Address(RVA = "0x4F0AE0", Offset = "0x4EF6E0", Length = "0x7")]
  public LeaderboardEntryUi()
  {
  }
}
