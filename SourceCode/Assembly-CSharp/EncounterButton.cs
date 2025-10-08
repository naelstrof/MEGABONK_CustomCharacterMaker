// Decompiled with JetBrains decompiler
// Type: EncounterButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.UI.InGame.Rewards;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000167")]
public class EncounterButton : MyButton
{
  [Token(Token = "0x4000A75")]
  [FieldOffset(Offset = "0x58")]
  public GameObject rarityContainer;
  [Token(Token = "0x4000A76")]
  [FieldOffset(Offset = "0x60")]
  public Image background;
  [Token(Token = "0x4000A77")]
  [FieldOffset(Offset = "0x68")]
  public Image selectedOverlay;
  [Token(Token = "0x4000A78")]
  [FieldOffset(Offset = "0x70")]
  public RawImage iconBorder;
  [Token(Token = "0x4000A79")]
  [FieldOffset(Offset = "0x78")]
  public RawImage iconBackground;
  [Token(Token = "0x4000A7A")]
  [FieldOffset(Offset = "0x80")]
  public TextMeshProUGUI t_description;
  [Token(Token = "0x4000A7B")]
  [FieldOffset(Offset = "0x88")]
  public TextMeshProUGUI t_rarity;
  [Token(Token = "0x4000A7C")]
  [FieldOffset(Offset = "0x90")]
  public int index;
  [Token(Token = "0x4000A7D")]
  [FieldOffset(Offset = "0x98")]
  private EncounterUi encounterUi;
  [Token(Token = "0x4000A7E")]
  [FieldOffset(Offset = "0xA0")]
  private bool canAccept;
  [Token(Token = "0x4000A7F")]
  [FieldOffset(Offset = "0xA8")]
  private string cantAcceptReason;

  [Token(Token = "0x600090F")]
  [Address(RVA = "0x4D2920", Offset = "0x4D1520", Length = "0x34")]
  public void Init(EncounterUi encounterUi, int index)
  {
  }

  [Token(Token = "0x6000910")]
  [Address(RVA = "0x4D2CA0", Offset = "0x4D18A0", Length = "0x22C")]
  public void SetOffer(EncounterOffer offer, bool showRarity)
  {
  }

  [Token(Token = "0x6000911")]
  [Address(RVA = "0x4D2F30", Offset = "0x4D1B30", Length = "0x7E")]
  private void TimeoutButton(float time)
  {
  }

  [Token(Token = "0x6000912")]
  [Address(RVA = "0x4D28C0", Offset = "0x4D14C0", Length = "0x50")]
  private void EnableButton()
  {
  }

  [Token(Token = "0x6000913")]
  [Address(RVA = "0x4D2AD0", Offset = "0x4D16D0", Length = "0x1C4")]
  public void SetDeclineOffer(int numOffers)
  {
  }

  [Token(Token = "0x6000914")]
  [Address(RVA = "0x4D2ED0", Offset = "0x4D1AD0", Length = "0x24")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x6000915")]
  [Address(RVA = "0x4D2F00", Offset = "0x4D1B00", Length = "0x24")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x6000916")]
  [Address(RVA = "0x4D2960", Offset = "0x4D1560", Length = "0x167")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x6000917")]
  [Address(RVA = "0x4D2FB0", Offset = "0x4D1BB0", Length = "0x15")]
  public EncounterButton()
  {
  }
}
