// Decompiled with JetBrains decompiler
// Type: EncounterUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.UI.InGame.Rewards;
using Assets.Scripts.UI.Menu.Windows;
using Cpp2ILInjected;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000168")]
public class EncounterUi : BaseEncounterWindow
{
  [Token(Token = "0x4000A80")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_name;
  [Token(Token = "0x4000A81")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_description;
  [Token(Token = "0x4000A82")]
  [FieldOffset(Offset = "0x30")]
  public GameObject b_generic;
  [Token(Token = "0x4000A83")]
  [FieldOffset(Offset = "0x38")]
  private List<EncounterButton> genericButtons;
  [Token(Token = "0x4000A84")]
  [FieldOffset(Offset = "0x40")]
  private List<EncounterButton> rarityButtons;
  [Token(Token = "0x4000A85")]
  [FieldOffset(Offset = "0x48")]
  public GameObject particles;
  [Token(Token = "0x4000A86")]
  [FieldOffset(Offset = "0x50")]
  public TabsExplicitNavigation tabsExplicitNavigation;
  [Token(Token = "0x4000A87")]
  [FieldOffset(Offset = "0x58")]
  private EncounterOffer[] offers;
  [Token(Token = "0x4000A88")]
  [FieldOffset(Offset = "0x60")]
  private float openedAtTime;
  [Token(Token = "0x4000A89")]
  [FieldOffset(Offset = "0x64")]
  private int rebuildAfterFrames;
  [Token(Token = "0x4000A8A")]
  [FieldOffset(Offset = "0x68")]
  private bool needRebuild;

  [Token(Token = "0x6000918")]
  [Address(RVA = "0x4D3400", Offset = "0x4D2000", Length = "0x401")]
  public override void Open(EEncounter encounterType)
  {
  }

  [Token(Token = "0x6000919")]
  [Address(RVA = "0x4D3260", Offset = "0x4D1E60", Length = "0xD5")]
  private void Update()
  {
  }

  [Token(Token = "0x600091A")]
  [Address(RVA = "0x4D3260", Offset = "0x4D1E60", Length = "0xD5")]
  private void KeyboardInput()
  {
  }

  [Token(Token = "0x600091B")]
  [Address(RVA = "0x4D3340", Offset = "0x4D1F40", Length = "0x6C")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x600091C")]
  [Address(RVA = "0x4D3060", Offset = "0x4D1C60", Length = "0x1F9")]
  private void HideButtons()
  {
  }

  [Token(Token = "0x600091D")]
  [Address(RVA = "0x4D33B0", Offset = "0x4D1FB0", Length = "0x4E")]
  public override void OnClose()
  {
  }

  [Token(Token = "0x600091E")]
  [Address(RVA = "0x4D2FD0", Offset = "0x4D1BD0", Length = "0x8B")]
  public override void ChooseOffer(int index)
  {
  }

  [Token(Token = "0x600091F")]
  [Address(RVA = "0x4D3810", Offset = "0x4D2410", Length = "0xAC")]
  public EncounterUi()
  {
  }
}
