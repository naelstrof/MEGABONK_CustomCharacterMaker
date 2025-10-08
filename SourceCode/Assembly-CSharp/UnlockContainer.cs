// Decompiled with JetBrains decompiler
// Type: UnlockContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x20001E7")]
public class UnlockContainer : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
  [Token(Token = "0x4000D9B")]
  [FieldOffset(Offset = "0x20")]
  public UnlockableBase unlockable;
  [Token(Token = "0x4000D9C")]
  [FieldOffset(Offset = "0x28")]
  public RawImage icon;
  [Token(Token = "0x4000D9D")]
  [FieldOffset(Offset = "0x30")]
  public RawImage fullReleaseOnly;
  [Token(Token = "0x4000D9E")]
  [FieldOffset(Offset = "0x38")]
  public RawImage backgroundLocked;
  [Token(Token = "0x4000D9F")]
  [FieldOffset(Offset = "0x40")]
  public RawImage backgroundUnlocked;
  [Token(Token = "0x4000DA0")]
  [FieldOffset(Offset = "0x48")]
  public Texture t_unknown;
  [Token(Token = "0x4000DA1")]
  [FieldOffset(Offset = "0x50")]
  public string requirementsString;
  [Token(Token = "0x4000DA2")]
  [FieldOffset(Offset = "0x58")]
  public bool isUnlocked;
  [Token(Token = "0x4000DA3")]
  [FieldOffset(Offset = "0x59")]
  public bool fullGameOnly;
  [Token(Token = "0x4000DA4")]
  [FieldOffset(Offset = "0x5A")]
  public bool isPurchased;
  [Token(Token = "0x4000DA5")]
  [FieldOffset(Offset = "0x60")]
  public GameObject notPurchasedOverlay;
  [Token(Token = "0x4000DA6")]
  [FieldOffset(Offset = "0x68")]
  public TextMeshProUGUI t_price;
  [Token(Token = "0x4000DA7")]
  [FieldOffset(Offset = "0x70")]
  public GameObject alert;
  [Token(Token = "0x4000DA8")]
  [FieldOffset(Offset = "0x78")]
  public GameObject activationToggle;
  [Token(Token = "0x4000DA9")]
  [FieldOffset(Offset = "0x80")]
  public GameObject activationToggleCheckmark;
  [Token(Token = "0x4000DAA")]
  [FieldOffset(Offset = "0x88")]
  public GameObject unactivatedOverlay;
  [Token(Token = "0x4000DAB")]
  public static Action<UnlockContainer> A_Selected;
  [Token(Token = "0x4000DAC")]
  public static Action<UnlockContainer> A_Clicked;
  [Token(Token = "0x4000DAD")]
  [FieldOffset(Offset = "0x90")]
  public Color defaultBackgroundColor;
  [Token(Token = "0x4000DAE")]
  public static Action A_RemovedAlert;

  [Token(Token = "0x6000C9D")]
  [Address(RVA = "0x518FB0", Offset = "0x517BB0", Length = "0x121")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000C9E")]
  [Address(RVA = "0x519250", Offset = "0x517E50", Length = "0x121")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000C9F")]
  [Address(RVA = "0x519380", Offset = "0x517F80", Length = "0x6D")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000CA0")]
  [Address(RVA = "0x519940", Offset = "0x518540", Length = "0x5A9")]
  public void Set(UnlockableBase unlockable)
  {
  }

  [Token(Token = "0x6000CA1")]
  [Address(RVA = "0x519850", Offset = "0x518450", Length = "0x39")]
  public void SetEmpty()
  {
  }

  [Token(Token = "0x6000CA2")]
  [Address(RVA = "0x519890", Offset = "0x518490", Length = "0xA0")]
  public void SetUnlocked(bool isUnlocked)
  {
  }

  [Token(Token = "0x6000CA3")]
  [Address(RVA = "0x519700", Offset = "0x518300", Length = "0x14C")]
  public void SetAchievement(MyAchievement ach)
  {
  }

  [Token(Token = "0x6000CA4")]
  [Address(RVA = "0x5190E0", Offset = "0x517CE0", Length = "0x16D")]
  private Color GetBackgroundColor(UnlockableBase unlockable) => new Color();

  [Token(Token = "0x6000CA5")]
  [Address(RVA = "0x519470", Offset = "0x518070", Length = "0x28C")]
  public void OnSelect(BaseEventData eventData)
  {
  }

  [Token(Token = "0x6000CA6")]
  [Address(RVA = "0x519EF0", Offset = "0x518AF0", Length = "0x252")]
  public void ToggleActivation()
  {
  }

  [Token(Token = "0x6000CA7")]
  [Address(RVA = "0x5193F0", Offset = "0x517FF0", Length = "0x7A")]
  private void OnPurchased(UnlockableBase unlockable)
  {
  }

  [Token(Token = "0x6000CA8")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public UnlockContainer()
  {
  }
}
