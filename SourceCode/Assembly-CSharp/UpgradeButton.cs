// Decompiled with JetBrains decompiler
// Type: UpgradeButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data;
using Assets.Scripts.Inventory__Items__Pickups;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200015A")]
public class UpgradeButton : MyButton
{
  [Token(Token = "0x4000A20")]
  [FieldOffset(Offset = "0x58")]
  public RawImage icon;
  [Token(Token = "0x4000A21")]
  [FieldOffset(Offset = "0x60")]
  public TextMeshProUGUI t_name;
  [Token(Token = "0x4000A22")]
  [FieldOffset(Offset = "0x68")]
  public TextMeshProUGUI t_description;
  [Token(Token = "0x4000A23")]
  [FieldOffset(Offset = "0x70")]
  public TextMeshProUGUI t_level;
  [Token(Token = "0x4000A24")]
  [FieldOffset(Offset = "0x78")]
  public TextMeshProUGUI t_rarity;
  [Token(Token = "0x4000A25")]
  [FieldOffset(Offset = "0x80")]
  public RawImage iconBorder;
  [Token(Token = "0x4000A26")]
  [FieldOffset(Offset = "0x88")]
  public RawImage iconBackground;
  [Token(Token = "0x4000A27")]
  [FieldOffset(Offset = "0x90")]
  public Image background;
  [Token(Token = "0x4000A28")]
  [FieldOffset(Offset = "0x98")]
  public Image backgroundOverlay;
  [Token(Token = "0x4000A29")]
  [FieldOffset(Offset = "0xA0")]
  public GameObject banishOverlay;
  [Token(Token = "0x4000A2A")]
  [FieldOffset(Offset = "0xA8")]
  private IUpgradable upgradable;
  [Token(Token = "0x4000A2B")]
  [FieldOffset(Offset = "0xB0")]
  private List<StatModifier> upgradeOffer;
  [Token(Token = "0x4000A2C")]
  [FieldOffset(Offset = "0xB8")]
  public UpgradePicker upgradePicker;
  [Token(Token = "0x4000A2D")]
  [FieldOffset(Offset = "0xC0")]
  public TomeSynergiesUi tomeSynergiesUi;
  [Token(Token = "0x4000A2E")]
  [FieldOffset(Offset = "0xC8")]
  private bool isItem;
  [Token(Token = "0x4000A2F")]
  [FieldOffset(Offset = "0xD0")]
  private ItemData itemData;
  [Token(Token = "0x4000A30")]
  [FieldOffset(Offset = "0xD8")]
  private ERarity rarity;
  [Token(Token = "0x4000A31")]
  [FieldOffset(Offset = "0xDC")]
  private int price;
  [Token(Token = "0x4000A32")]
  [FieldOffset(Offset = "0xE0")]
  private bool canAfford;
  [Token(Token = "0x4000A33")]
  [FieldOffset(Offset = "0xE8")]
  public GameObject overlayCantAfford;

  [Token(Token = "0x60008B7")]
  [Address(RVA = "0x4E4CC0", Offset = "0x4E38C0", Length = "0x56B")]
  public void SetUpgrade(IUpgradable upgradable)
  {
  }

  [Token(Token = "0x60008B8")]
  [Address(RVA = "0x4E49B0", Offset = "0x4E35B0", Length = "0x300")]
  public void SetItem(ItemData itemData)
  {
  }

  [Token(Token = "0x60008B9")]
  [Address(RVA = "0x4E4880", Offset = "0x4E3480", Length = "0x129")]
  public void SetItemPriced(ItemData itemData, int price)
  {
  }

  [Token(Token = "0x60008BA")]
  [Address(RVA = "0x4E4450", Offset = "0x4E3050", Length = "0x50")]
  private void EnableButton()
  {
  }

  [Token(Token = "0x60008BB")]
  [Address(RVA = "0x4E44B0", Offset = "0x4E30B0", Length = "0x3C1")]
  public void SelectUpgrade()
  {
  }

  [Token(Token = "0x60008BC")]
  [Address(RVA = "0x4E5230", Offset = "0x4E3E30", Length = "0x51")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x60008BD")]
  [Address(RVA = "0x4E5290", Offset = "0x4E3E90", Length = "0x43")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x60008BE")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x60008BF")]
  [Address(RVA = "0x4D7090", Offset = "0x4D5C90", Length = "0xE")]
  public UpgradeButton()
  {
  }
}
