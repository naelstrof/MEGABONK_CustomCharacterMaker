// Decompiled with JetBrains decompiler
// Type: ChestWindowUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Interactables;
using Assets.Scripts.UI.InGame.Rewards;
using Cpp2ILInjected;
using System;
using System.Collections;
using TMPro;

[Token(Token = "0x2000164")]
public class ChestWindowUi : BaseEncounterWindow
{
  [Token(Token = "0x4000A5F")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_itemName;
  [Token(Token = "0x4000A60")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_itemDesc;
  [Token(Token = "0x4000A61")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_itemRarity;
  [Token(Token = "0x4000A62")]
  [FieldOffset(Offset = "0x38")]
  public ChestOpening chestOpening;
  [Token(Token = "0x4000A63")]
  [FieldOffset(Offset = "0x40")]
  public LevelupScreen levelupScreen;
  [Token(Token = "0x4000A64")]
  [FieldOffset(Offset = "0x48")]
  public MyButtonOffersUtility b_banish;
  [Token(Token = "0x4000A65")]
  [FieldOffset(Offset = "0x50")]
  public MyButton b_open;
  [Token(Token = "0x4000A66")]
  [FieldOffset(Offset = "0x58")]
  public MyButton b_leave;
  [Token(Token = "0x4000A67")]
  [FieldOffset(Offset = "0x60")]
  public MyButton b_take;
  [Token(Token = "0x4000A68")]
  [FieldOffset(Offset = "0x68")]
  public ItemData itemData;
  [Token(Token = "0x4000A69")]
  [FieldOffset(Offset = "0x70")]
  public Window window;
  [Token(Token = "0x4000A6A")]
  public static Action A_Open;
  [Token(Token = "0x4000A6B")]
  public static Action A_Close;
  [Token(Token = "0x4000A6C")]
  [FieldOffset(Offset = "0x78")]
  private EChest chestType;

  [Token(Token = "0x60008F5")]
  [Address(RVA = "0x4CE190", Offset = "0x4CCD90", Length = "0x121")]
  private void Awake()
  {
  }

  [Token(Token = "0x60008F6")]
  [Address(RVA = "0x4CE7E0", Offset = "0x4CD3E0", Length = "0x121")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60008F7")]
  [Address(RVA = "0x4CEA90", Offset = "0x4CD690", Length = "0x22E")]
  public override void Open(EEncounter encounterType)
  {
  }

  [Token(Token = "0x60008F8")]
  [Address(RVA = "0x4CEF30", Offset = "0x4CDB30", Length = "0x2F")]
  private void ShowOpenButton()
  {
  }

  [Token(Token = "0x60008F9")]
  [Address(RVA = "0x4CE760", Offset = "0x4CD360", Length = "0x74")]
  public override void OnClose()
  {
  }

  [Token(Token = "0x60008FA")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public override void ChooseOffer(int index)
  {
  }

  [Token(Token = "0x60008FB")]
  [Address(RVA = "0x4CECC0", Offset = "0x4CD8C0", Length = "0x265")]
  private void OpeningFinished(ItemData unused)
  {
  }

  [Token(Token = "0x60008FC")]
  [Address(RVA = "0x4CE120", Offset = "0x4CCD20", Length = "0x67")]
  private IEnumerator AnimateText() => (IEnumerator) null;

  [Token(Token = "0x60008FD")]
  [Address(RVA = "0x4CE0A0", Offset = "0x4CCCA0", Length = "0x79")]
  private IEnumerator AnimateSingleTextObject(TextMeshProUGUI text, float fadeTime) => (IEnumerator) null;

  [Token(Token = "0x60008FE")]
  [Address(RVA = "0x4CE910", Offset = "0x4CD510", Length = "0x172")]
  public void OpenButton()
  {
  }

  [Token(Token = "0x60008FF")]
  [Address(RVA = "0x4CEF60", Offset = "0x4CDB60", Length = "0xB9")]
  public void TakeButton()
  {
  }

  [Token(Token = "0x6000900")]
  [Address(RVA = "0x4CE520", Offset = "0x4CD120", Length = "0x23D")]
  public void DiscardButton()
  {
  }

  [Token(Token = "0x6000901")]
  [Address(RVA = "0x4CE2C0", Offset = "0x4CCEC0", Length = "0x251")]
  public void BanishButton()
  {
  }

  [Token(Token = "0x6000902")]
  [Address(RVA = "0x357E60", Offset = "0x356A60", Length = "0x7")]
  public ChestWindowUi()
  {
  }
}
