// Decompiled with JetBrains decompiler
// Type: QuestsWindowNew
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.Progression;
using Cpp2ILInjected;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

[Token(Token = "0x20001BD")]
public class QuestsWindowNew : Window
{
  [Token(Token = "0x4000CA2")]
  [FieldOffset(Offset = "0x50")]
  public Button backBtn;
  [Token(Token = "0x4000CA3")]
  [FieldOffset(Offset = "0x58")]
  public GameObject questPrefab;
  [Token(Token = "0x4000CA4")]
  [FieldOffset(Offset = "0x60")]
  public GameObject tabPrefab;
  [Token(Token = "0x4000CA5")]
  [FieldOffset(Offset = "0x68")]
  public ButtonNavigationSelectionOnly tabNavigation;
  [Token(Token = "0x4000CA6")]
  [FieldOffset(Offset = "0x70")]
  public TabVerticalNavigation tabVertNavigation;
  [Token(Token = "0x4000CA7")]
  [FieldOffset(Offset = "0x78")]
  public LocalizedString localizedGeneral;
  [Token(Token = "0x4000CA8")]
  [FieldOffset(Offset = "0x80")]
  public LocalizedString localizedCharacters;
  [Token(Token = "0x4000CA9")]
  [FieldOffset(Offset = "0x88")]
  public LocalizedString localizedWeapons;
  [Token(Token = "0x4000CAA")]
  [FieldOffset(Offset = "0x90")]
  public LocalizedString localizedChallenges;
  [Token(Token = "0x4000CAB")]
  [FieldOffset(Offset = "0x98")]
  public LocalizedString localizedItems;
  [Token(Token = "0x4000CAC")]
  [FieldOffset(Offset = "0xA0")]
  public LocalizedString localizedTomes;
  [Token(Token = "0x4000CAD")]
  [FieldOffset(Offset = "0xA8")]
  public LocalizedString localizedSkins;
  [Token(Token = "0x4000CAE")]
  [FieldOffset(Offset = "0xB0")]
  private List<MyButtonQuest> questButtons;
  [Token(Token = "0x4000CAF")]
  [FieldOffset(Offset = "0xB8")]
  private EAchievementType achievementTab;
  [Token(Token = "0x4000CB0")]
  [FieldOffset(Offset = "0xC0")]
  public RawImage progressBar;
  [Token(Token = "0x4000CB1")]
  [FieldOffset(Offset = "0xC8")]
  public TextMeshProUGUI t_totalProgress;
  [Token(Token = "0x4000CB2")]
  [FieldOffset(Offset = "0xD0")]
  public MyButtonToggle toggleHideCompleted;
  [Token(Token = "0x4000CB3")]
  [FieldOffset(Offset = "0xD8")]
  private List<EAchievementType> tabsEnums;

  [Token(Token = "0x6000B3D")]
  [Address(RVA = "0x50DE30", Offset = "0x50CA30", Length = "0x1F")]
  private new void Awake()
  {
  }

  [Token(Token = "0x6000B3E")]
  [Address(RVA = "0x50F210", Offset = "0x50DE10", Length = "0x484")]
  private new void Start()
  {
  }

  [Token(Token = "0x6000B3F")]
  [Address(RVA = "0x50E9E0", Offset = "0x50D5E0", Length = "0x1D9")]
  private new void OnEnable()
  {
  }

  [Token(Token = "0x6000B40")]
  [Address(RVA = "0x50E6F0", Offset = "0x50D2F0", Length = "0x2E1")]
  private new void OnDestroy()
  {
  }

  [Token(Token = "0x6000B41")]
  [Address(RVA = "0x50EC70", Offset = "0x50D870", Length = "0xB8")]
  private void OnToggle(bool on)
  {
  }

  [Token(Token = "0x6000B42")]
  [Address(RVA = "0x50ED30", Offset = "0x50D930", Length = "0x4D5")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000B43")]
  [Address(RVA = "0x50DE50", Offset = "0x50CA50", Length = "0x7B4")]
  private void CreateTabs()
  {
  }

  [Token(Token = "0x6000B44")]
  [Address(RVA = "0x50EBC0", Offset = "0x50D7C0", Length = "0xAD")]
  private void OnTabSelected(int index)
  {
  }

  [Token(Token = "0x6000B45")]
  [Address(RVA = "0x386DE0", Offset = "0x3859E0", Length = "0xD")]
  private void OnQuestButtonHover(MyButtonQuest btn)
  {
  }

  [Token(Token = "0x6000B46")]
  [Address(RVA = "0x50E610", Offset = "0x50D210", Length = "0x48")]
  private int GetAchievementTypeIndex(int index) => 0;

  [Token(Token = "0x6000B47")]
  [Address(RVA = "0x50E680", Offset = "0x50D280", Length = "0x54")]
  private LocalizedString GetTabLocalizedString(EAchievementType achType) => (LocalizedString) null;

  [Token(Token = "0x6000B48")]
  [Address(RVA = "0x4EBA20", Offset = "0x4EA620", Length = "0x7")]
  public QuestsWindowNew()
  {
  }
}
