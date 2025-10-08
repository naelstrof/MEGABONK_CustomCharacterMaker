// Decompiled with JetBrains decompiler
// Type: MyButtonCharacter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000178")]
public class MyButtonCharacter : MyButton
{
  [Token(Token = "0x4000AD0")]
  [FieldOffset(Offset = "0x58")]
  public GameObject hoverOverlay;
  [Token(Token = "0x4000AD1")]
  [FieldOffset(Offset = "0x60")]
  public GameObject unavailableOverlay;
  [Token(Token = "0x4000AD2")]
  [FieldOffset(Offset = "0x68")]
  public TextMeshProUGUI t_name;
  [Token(Token = "0x4000AD3")]
  [FieldOffset(Offset = "0x70")]
  public RawImage i_icon;
  [Token(Token = "0x4000AD4")]
  [FieldOffset(Offset = "0x78")]
  public GameObject requiresPurchaseOverlay;
  [Token(Token = "0x4000AD5")]
  [FieldOffset(Offset = "0x80")]
  public TextMeshProUGUI t_price;
  [Token(Token = "0x4000AD6")]
  [FieldOffset(Offset = "0x88")]
  public GameObject star;
  [Token(Token = "0x4000AD7")]
  [FieldOffset(Offset = "0x90")]
  public CharacterData characterData;
  [Token(Token = "0x4000AD8")]
  [FieldOffset(Offset = "0x98")]
  public Material lockedMaterial;
  [Token(Token = "0x4000AD9")]
  public static Action<MyButtonCharacter> A_Confirm;
  [Token(Token = "0x4000ADA")]
  public static Action<MyButtonCharacter> A_Select;
  [Token(Token = "0x4000ADB")]
  [FieldOffset(Offset = "0xA0")]
  public bool canUseCharacter;
  [Token(Token = "0x4000ADC")]
  [FieldOffset(Offset = "0xA8")]
  private CharacterData data;
  [Token(Token = "0x4000ADD")]
  [FieldOffset(Offset = "0xB0")]
  public string cantUseCharacterReason;

  [Token(Token = "0x6000974")]
  [Address(RVA = "0x4D78C0", Offset = "0x4D64C0", Length = "0x121")]
  private new void Awake()
  {
  }

  [Token(Token = "0x6000975")]
  [Address(RVA = "0x4D7B20", Offset = "0x4D6720", Length = "0xA5")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000976")]
  [Address(RVA = "0x4D79F0", Offset = "0x4D65F0", Length = "0x121")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000977")]
  [Address(RVA = "0x4D7BD0", Offset = "0x4D67D0", Length = "0xF")]
  private void OnItemPurchased(UnlockableBase unlockable)
  {
  }

  [Token(Token = "0x6000978")]
  [Address(RVA = "0x4D7BE0", Offset = "0x4D67E0", Length = "0x4EF")]
  public void SetCharacter(CharacterData data)
  {
  }

  [Token(Token = "0x6000979")]
  [Address(RVA = "0x4D7BD0", Offset = "0x4D67D0", Length = "0xF")]
  public void Refresh()
  {
  }

  [Token(Token = "0x600097A")]
  [Address(RVA = "0x4D80D0", Offset = "0x4D6CD0", Length = "0x72")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x600097B")]
  [Address(RVA = "0x4D8150", Offset = "0x4D6D50", Length = "0x24")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x600097C")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x600097D")]
  [Address(RVA = "0x4D8180", Offset = "0x4D6D80", Length = "0x1B0")]
  private new void Update()
  {
  }

  [Token(Token = "0x600097E")]
  [Address(RVA = "0x4D7090", Offset = "0x4D5C90", Length = "0xE")]
  public MyButtonCharacter()
  {
  }
}
