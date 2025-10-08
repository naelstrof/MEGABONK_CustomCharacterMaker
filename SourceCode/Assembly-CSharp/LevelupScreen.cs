// Decompiled with JetBrains decompiler
// Type: LevelupScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.UI.InGame.Rewards;
using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000157")]
public class LevelupScreen : BaseEncounterWindow
{
  [Token(Token = "0x4000A04")]
  public static bool isLevelingUp;
  [Token(Token = "0x4000A05")]
  [FieldOffset(Offset = "0x20")]
  public GameObject window;
  [Token(Token = "0x4000A06")]
  [FieldOffset(Offset = "0x28")]
  public GameObject effects;
  [Token(Token = "0x4000A07")]
  [FieldOffset(Offset = "0x30")]
  public AudioSource audioLevel;
  [Token(Token = "0x4000A08")]
  [FieldOffset(Offset = "0x38")]
  public AudioSource audioShadyGuy;
  [Token(Token = "0x4000A09")]
  [FieldOffset(Offset = "0x40")]
  public GameObject button;
  [Token(Token = "0x4000A0A")]
  [FieldOffset(Offset = "0x48")]
  public UpgradePicker upgradePicker;
  [Token(Token = "0x4000A0B")]
  [FieldOffset(Offset = "0x50")]
  public UpgradeInventoryUI upgradeInventoryUi;
  [Token(Token = "0x4000A0C")]
  [FieldOffset(Offset = "0x58")]
  public TextMeshProUGUI t_title;
  [Token(Token = "0x4000A0D")]
  [FieldOffset(Offset = "0x60")]
  public TextMeshProUGUI t_description;
  [Token(Token = "0x4000A0E")]
  [FieldOffset(Offset = "0x68")]
  public MyButtonOffersUtility b_skip;
  [Token(Token = "0x4000A0F")]
  [FieldOffset(Offset = "0x70")]
  public MyButtonOffersUtility b_refresh;
  [Token(Token = "0x4000A10")]
  [FieldOffset(Offset = "0x78")]
  public MyButtonOffersUtility b_banish;
  [Token(Token = "0x4000A11")]
  [FieldOffset(Offset = "0x80")]
  public MyButtonNormal b_leave;
  [Token(Token = "0x4000A12")]
  public static Action A_LevelupEnabled;
  [Token(Token = "0x4000A13")]
  public static Action A_LevelUpClose;
  [Token(Token = "0x4000A14")]
  [FieldOffset(Offset = "0x88")]
  private int level;
  [Token(Token = "0x4000A15")]
  [FieldOffset(Offset = "0x8C")]
  private int currentLevel;
  [Token(Token = "0x4000A16")]
  [FieldOffset(Offset = "0x90")]
  public Window windowScript;
  [Token(Token = "0x4000A17")]
  private static bool hasBanishes;
  [Token(Token = "0x4000A18")]
  private static bool hasRefreshes;
  [Token(Token = "0x4000A19")]
  private static bool hasSkips;
  [Token(Token = "0x4000A1A")]
  [FieldOffset(Offset = "0x98")]
  private bool hasInitedThisStage;
  [Token(Token = "0x4000A1B")]
  [FieldOffset(Offset = "0x9C")]
  private EEncounter encounterType;
  [Token(Token = "0x4000A1C")]
  [FieldOffset(Offset = "0xA0")]
  public float refreshTime;

  [Token(Token = "0x600089A")]
  [Address(RVA = "0x4D6B90", Offset = "0x4D5790", Length = "0x155")]
  private void TryInit()
  {
  }

  [Token(Token = "0x600089B")]
  [Address(RVA = "0x4D6160", Offset = "0x4D4D60", Length = "0x73F")]
  public void ShowLevelupScreen()
  {
  }

  [Token(Token = "0x600089C")]
  [Address(RVA = "0x4D6CF0", Offset = "0x4D58F0", Length = "0x6E")]
  private void Update()
  {
  }

  [Token(Token = "0x600089D")]
  [Address(RVA = "0x4D53B0", Offset = "0x4D3FB0", Length = "0x65")]
  public void CloseLevelupScreen()
  {
  }

  [Token(Token = "0x600089E")]
  [Address(RVA = "0x4D5A90", Offset = "0x4D4690", Length = "0xD")]
  public override void Open(EEncounter encounterType)
  {
  }

  [Token(Token = "0x600089F")]
  [Address(RVA = "0x4D59C0", Offset = "0x4D45C0", Length = "0xC0")]
  public override void OnClose()
  {
  }

  [Token(Token = "0x60008A0")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public override void ChooseOffer(int index)
  {
  }

  [Token(Token = "0x60008A1")]
  [Address(RVA = "0x4D53B0", Offset = "0x4D3FB0", Length = "0x65")]
  public void Leave()
  {
  }

  [Token(Token = "0x60008A2")]
  [Address(RVA = "0x4D68A0", Offset = "0x4D54A0", Length = "0x1CD")]
  public void Skip()
  {
  }

  [Token(Token = "0x60008A3")]
  [Address(RVA = "0x4D5F70", Offset = "0x4D4B70", Length = "0x1E8")]
  public void Refresh()
  {
  }

  [Token(Token = "0x60008A4")]
  [Address(RVA = "0x4D6A70", Offset = "0x4D5670", Length = "0x119")]
  public void StartBanish()
  {
  }

  [Token(Token = "0x60008A5")]
  [Address(RVA = "0x4D5240", Offset = "0x4D3E40", Length = "0x16B")]
  public void Banish()
  {
  }

  [Token(Token = "0x60008A6")]
  [Address(RVA = "0x4D5950", Offset = "0x4D4550", Length = "0x68")]
  private int GetSkips() => 0;

  [Token(Token = "0x60008A7")]
  [Address(RVA = "0x4D56B0", Offset = "0x4D42B0", Length = "0x68")]
  private int GetRefreshes() => 0;

  [Token(Token = "0x60008A8")]
  [Address(RVA = "0x4D5530", Offset = "0x4D4130", Length = "0x68")]
  public int GetBanishes() => 0;

  [Token(Token = "0x60008A9")]
  [Address(RVA = "0x4D58E0", Offset = "0x4D44E0", Length = "0x6B")]
  private int GetSkipsUsed() => 0;

  [Token(Token = "0x60008AA")]
  [Address(RVA = "0x4D5640", Offset = "0x4D4240", Length = "0x6B")]
  private int GetRefreshesUsed() => 0;

  [Token(Token = "0x60008AB")]
  [Address(RVA = "0x4D54C0", Offset = "0x4D40C0", Length = "0x6B")]
  public int GetBanishesUsed() => 0;

  [Token(Token = "0x60008AC")]
  [Address(RVA = "0x4D5420", Offset = "0x4D4020", Length = "0x91")]
  public void DecrementBanishes()
  {
  }

  [Token(Token = "0x60008AD")]
  [Address(RVA = "0x4D5AA0", Offset = "0x4D46A0", Length = "0x4C1")]
  private void RefreshUtilityButtons()
  {
  }

  [Token(Token = "0x60008AE")]
  [Address(RVA = "0x4D57A0", Offset = "0x4D43A0", Length = "0x13F")]
  public int GetShopToolPrice(int numUses) => 0;

  [Token(Token = "0x60008AF")]
  [Address(RVA = "0x4D55A0", Offset = "0x4D41A0", Length = "0x98")]
  private string GetMoaiText(int level) => (string) null;

  [Token(Token = "0x60008B0")]
  [Address(RVA = "0x4D5720", Offset = "0x4D4320", Length = "0x78")]
  private string GetShadyGuyText() => (string) null;

  [Token(Token = "0x60008B1")]
  [Address(RVA = "0x357E60", Offset = "0x356A60", Length = "0x7")]
  public LevelupScreen()
  {
  }
}
