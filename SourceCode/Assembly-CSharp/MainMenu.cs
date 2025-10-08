// Decompiled with JetBrains decompiler
// Type: MainMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20001AD")]
public class MainMenu : MonoBehaviour
{
  [Token(Token = "0x4000C2A")]
  public static Action A_MenuOpened;
  [Token(Token = "0x4000C2B")]
  [FieldOffset(Offset = "0x20")]
  public MenuCamera menuCamera;
  [Token(Token = "0x4000C2C")]
  [FieldOffset(Offset = "0x28")]
  public GameObject btnUnlocks;
  [Token(Token = "0x4000C2D")]
  [FieldOffset(Offset = "0x30")]
  public GameObject btnQuests;
  [Token(Token = "0x4000C2E")]
  [FieldOffset(Offset = "0x38")]
  public GameObject btnShop;
  [Token(Token = "0x4000C2F")]
  [FieldOffset(Offset = "0x40")]
  public GameObject leaderboards;
  [Token(Token = "0x4000C30")]
  [FieldOffset(Offset = "0x48")]
  public GameObject quickQuests;
  [Token(Token = "0x4000C31")]
  [FieldOffset(Offset = "0x50")]
  public MyButton btnPlay;
  [Token(Token = "0x4000C32")]
  [FieldOffset(Offset = "0x58")]
  private bool isAnimating;
  [Token(Token = "0x4000C33")]
  [FieldOffset(Offset = "0x60")]
  public GameObject blockRaycastOverlay;
  [Token(Token = "0x4000C34")]
  [FieldOffset(Offset = "0x68")]
  public GameObject newButtonParticles;
  [Token(Token = "0x4000C35")]
  [FieldOffset(Offset = "0x70")]
  public MapSelectionUi mapSelectionUi;
  [Token(Token = "0x4000C36")]
  [FieldOffset(Offset = "0x78")]
  public GameObject tabMenu;
  [Token(Token = "0x4000C37")]
  [FieldOffset(Offset = "0x80")]
  public GameObject tabCharacters;
  [Token(Token = "0x4000C38")]
  [FieldOffset(Offset = "0x88")]
  public GameObject tabMaps;
  [Token(Token = "0x4000C39")]
  [FieldOffset(Offset = "0x90")]
  public GameObject tabShop;
  [Token(Token = "0x4000C3A")]
  [FieldOffset(Offset = "0x98")]
  public GameObject tabUnlocks;
  [Token(Token = "0x4000C3B")]
  [FieldOffset(Offset = "0xA0")]
  public GameObject tabLogs;
  [Token(Token = "0x4000C3C")]
  [FieldOffset(Offset = "0xA8")]
  public GameObject settings;
  [Token(Token = "0x4000C3D")]
  [FieldOffset(Offset = "0xB0")]
  public GameObject credits;
  [Token(Token = "0x4000C3E")]
  [FieldOffset(Offset = "0xB8")]
  public GameObject quests;
  [Token(Token = "0x4000C3F")]
  [FieldOffset(Offset = "0xC0")]
  public GameObject leaderboardsFull;
  [Token(Token = "0x4000C40")]
  [FieldOffset(Offset = "0xC8")]
  private GameObject currentTab;

  [Token(Token = "0x6000ACD")]
  [Address(RVA = "0x4F4DC0", Offset = "0x4F39C0", Length = "0x177")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000ACE")]
  [Address(RVA = "0x4F5580", Offset = "0x4F4180", Length = "0x138")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000ACF")]
  [Address(RVA = "0x4F60B0", Offset = "0x4F4CB0", Length = "0x164")]
  private void Start()
  {
  }

  [Token(Token = "0x6000AD0")]
  [Address(RVA = "0x4F56C0", Offset = "0x4F42C0", Length = "0x985")]
  private void RefreshButtons()
  {
  }

  [Token(Token = "0x6000AD1")]
  [Address(RVA = "0x4F4D30", Offset = "0x4F3930", Length = "0x84")]
  private IEnumerator AnimateNewButtons(List<GameObject> objects) => (IEnumerator) null;

  [Token(Token = "0x6000AD2")]
  [Address(RVA = "0x4F5340", Offset = "0x4F3F40", Length = "0x78")]
  public void GoToMenu()
  {
  }

  [Token(Token = "0x6000AD3")]
  [Address(RVA = "0x4F5100", Offset = "0x4F3D00", Length = "0x71")]
  public void GoToCharacterSelection()
  {
  }

  [Token(Token = "0x6000AD4")]
  [Address(RVA = "0x4F52D0", Offset = "0x4F3ED0", Length = "0x61")]
  public void GoToMapSelection()
  {
  }

  [Token(Token = "0x6000AD5")]
  [Address(RVA = "0x4F54A0", Offset = "0x4F40A0", Length = "0x61")]
  public void GoToShop()
  {
  }

  [Token(Token = "0x6000AD6")]
  [Address(RVA = "0x4F5180", Offset = "0x4F3D80", Length = "0x61")]
  public void GoToCredits()
  {
  }

  [Token(Token = "0x6000AD7")]
  [Address(RVA = "0x4F5510", Offset = "0x4F4110", Length = "0x61")]
  public void GoToUnlocks()
  {
  }

  [Token(Token = "0x6000AD8")]
  [Address(RVA = "0x4F53C0", Offset = "0x4F3FC0", Length = "0x61")]
  public void GoToQuests()
  {
  }

  [Token(Token = "0x6000AD9")]
  [Address(RVA = "0x4F5260", Offset = "0x4F3E60", Length = "0x61")]
  public void GoToLogs()
  {
  }

  [Token(Token = "0x6000ADA")]
  [Address(RVA = "0x4F5430", Offset = "0x4F4030", Length = "0x61")]
  public void GoToSettings()
  {
  }

  [Token(Token = "0x6000ADB")]
  [Address(RVA = "0x4F51F0", Offset = "0x4F3DF0", Length = "0x61")]
  public void GoToLeaderboards()
  {
  }

  [Token(Token = "0x6000ADC")]
  [Address(RVA = "0x4F6050", Offset = "0x4F4C50", Length = "0x5D")]
  public void SetWindow(GameObject tabWindow)
  {
  }

  [Token(Token = "0x6000ADD")]
  [Address(RVA = "0x4F4F40", Offset = "0x4F3B40", Length = "0x1BF")]
  public void ExitGame()
  {
  }

  [Token(Token = "0x6000ADE")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MainMenu()
  {
  }
}
