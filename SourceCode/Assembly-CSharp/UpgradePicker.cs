// Decompiled with JetBrains decompiler
// Type: UpgradePicker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data;
using Assets.Scripts.Inventory__Items__Pickups;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.UI.InGame.Rewards;
using Assets.Scripts.UI.Menu.Windows;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x200015C")]
public class UpgradePicker : MonoBehaviour
{
  [Token(Token = "0x4000A3B")]
  [FieldOffset(Offset = "0x20")]
  public UpgradeButton[] buttons;
  [Token(Token = "0x4000A3C")]
  [FieldOffset(Offset = "0x28")]
  public LevelupScreen levelupScreen;
  [Token(Token = "0x4000A3D")]
  [FieldOffset(Offset = "0x30")]
  private int numUpgrades;
  [Token(Token = "0x4000A3E")]
  [FieldOffset(Offset = "0x38")]
  public TabsExplicitNavigation tabsExplicitNavigation;
  [Token(Token = "0x4000A3F")]
  [FieldOffset(Offset = "0x40")]
  private EEncounter encounterType;
  [Token(Token = "0x4000A40")]
  [FieldOffset(Offset = "0x48")]
  public GameObject window;
  [Token(Token = "0x4000A41")]
  [FieldOffset(Offset = "0x50")]
  private float openedAtTime;
  [Token(Token = "0x4000A42")]
  public static Action A_ShadyGuyDone;
  [Token(Token = "0x4000A43")]
  [FieldOffset(Offset = "0x54")]
  private int moaiLuckMode;
  [Token(Token = "0x4000A44")]
  [FieldOffset(Offset = "0x58")]
  public GameObject banisModeOverlay;
  [Token(Token = "0x4000A46")]
  [FieldOffset(Offset = "0x64")]
  public float banishCooldownOverAtTime;

  [Token(Token = "0x60008C3")]
  [Address(RVA = "0x4E63A0", Offset = "0x4E4FA0", Length = "0x575")]
  public void ShuffleUpgrades(EEncounter encounterType)
  {
  }

  [Token(Token = "0x60008C4")]
  [Address(RVA = "0x43A200", Offset = "0x438E00", Length = "0x4")]
  public void SetMoaiLuck(int luckMode)
  {
  }

  [Token(Token = "0x60008C5")]
  [Address(RVA = "0x4E5C60", Offset = "0x4E4860", Length = "0x1D1")]
  private void KeyboardInput()
  {
  }

  [Token(Token = "0x60008C6")]
  [Address(RVA = "0x4E6020", Offset = "0x4E4C20", Length = "0x379")]
  public void SelectUpgrade(
    IUpgradable upgradable,
    List<StatModifier> upgradeOffer,
    UpgradeButton btn,
    ERarity rarity)
  {
  }

  [Token(Token = "0x60008C7")]
  [Address(RVA = "0x4E5E40", Offset = "0x4E4A40", Length = "0x1D2")]
  public void SelectItem(ItemData itemData)
  {
  }

  [Token(Token = "0x60008C8")]
  [Address(RVA = "0x4E5C50", Offset = "0x4E4850", Length = "0x4")]
  public int GetNumUpgrades() => 0;

  [field: Token(Token = "0x4000A45")]
  [field: FieldOffset(Offset = "0x60")]
  [Token(Token = "0x17000052")]
  public bool banishMode { [Token(Token = "0x60008C9"), Address(RVA = "0x371820", Offset = "0x370420", Length = "0x5")] get; [Token(Token = "0x60008CA"), Address(RVA = "0x371830", Offset = "0x370430", Length = "0x4")] private set; }

  [Token(Token = "0x60008CB")]
  [Address(RVA = "0x4E6920", Offset = "0x4E5520", Length = "0x2B")]
  public void StartBanishMode()
  {
  }

  [Token(Token = "0x60008CC")]
  [Address(RVA = "0x4E5C30", Offset = "0x4E4830", Length = "0x1D")]
  private void Banish()
  {
  }

  [Token(Token = "0x60008CD")]
  [Address(RVA = "0x4E6950", Offset = "0x4E5550", Length = "0x8E")]
  public void StopBanishMode()
  {
  }

  [Token(Token = "0x60008CE")]
  [Address(RVA = "0x4E69E0", Offset = "0x4E55E0", Length = "0x6F")]
  private void Update()
  {
  }

  [Token(Token = "0x60008CF")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public UpgradePicker()
  {
  }
}
