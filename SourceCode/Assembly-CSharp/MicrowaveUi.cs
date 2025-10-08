// Decompiled with JetBrains decompiler
// Type: MicrowaveUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Items;
using Assets.Scripts.UI.InGame.Rewards;
using Cpp2ILInjected;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Token(Token = "0x200016A")]
public class MicrowaveUi : BaseEncounterWindow
{
  [Token(Token = "0x4000A8E")]
  [FieldOffset(Offset = "0x20")]
  public GameObject itemPrefab;
  [Token(Token = "0x4000A8F")]
  [FieldOffset(Offset = "0x28")]
  private List<MicrowaveItemButton> itemPrefabs;
  [Token(Token = "0x4000A90")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_price;

  [Token(Token = "0x6000926")]
  [Address(RVA = "0x4D70F0", Offset = "0x4D5CF0", Length = "0x67D")]
  public override void Open(EEncounter encounterType)
  {
  }

  [Token(Token = "0x6000927")]
  [Address(RVA = "0x4D7810", Offset = "0x4D6410", Length = "0xA6")]
  private void Update()
  {
  }

  [Token(Token = "0x6000928")]
  [Address(RVA = "0x4D7770", Offset = "0x4D6370", Length = "0x90")]
  public void SelectUpgrade(EItem eItem)
  {
  }

  [Token(Token = "0x6000929")]
  [Address(RVA = "0x4D70A0", Offset = "0x4D5CA0", Length = "0x4F")]
  public void CloseScreen()
  {
  }

  [Token(Token = "0x600092A")]
  [Address(RVA = "0x3563C0", Offset = "0x354FC0", Length = "0x26")]
  public override void OnClose()
  {
  }

  [Token(Token = "0x600092B")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public override void ChooseOffer(int index)
  {
  }

  [Token(Token = "0x600092C")]
  [Address(RVA = "0x357E60", Offset = "0x356A60", Length = "0x7")]
  public MicrowaveUi()
  {
  }
}
