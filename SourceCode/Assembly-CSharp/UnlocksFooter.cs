// Decompiled with JetBrains decompiler
// Type: UnlocksFooter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001E8")]
public class UnlocksFooter : MonoBehaviour
{
  [Token(Token = "0x4000DAF")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_unlockName;
  [Token(Token = "0x4000DB0")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_unlockDescription;
  [Token(Token = "0x4000DB1")]
  [FieldOffset(Offset = "0x30")]
  public UnlockContainer unlockContainer;
  [Token(Token = "0x4000DB2")]
  [FieldOffset(Offset = "0x38")]
  public MyButton buyButton;
  [Token(Token = "0x4000DB3")]
  [FieldOffset(Offset = "0x40")]
  public RequirementPrefab[] reqContainers;
  [Token(Token = "0x4000DB4")]
  [FieldOffset(Offset = "0x48")]
  public RequirementsContainer requirementsContainer;
  [Token(Token = "0x4000DB5")]
  [FieldOffset(Offset = "0x50")]
  public GameObject buyContainer;
  [Token(Token = "0x4000DB6")]
  [FieldOffset(Offset = "0x58")]
  public TextMeshProUGUI t_buyPrice;
  [Token(Token = "0x4000DB7")]
  [FieldOffset(Offset = "0x60")]
  public TextMeshProUGUI t_suggestedBy;
  [Token(Token = "0x4000DB8")]
  public static Action<UnlockableBase> A_Purchased;
  [Token(Token = "0x4000DB9")]
  [FieldOffset(Offset = "0x68")]
  private UnlockContainer lastSelected;
  [Token(Token = "0x4000DBA")]
  [FieldOffset(Offset = "0x70")]
  public Window parentWindow;

  [Token(Token = "0x6000CA9")]
  [Address(RVA = "0x51A150", Offset = "0x518D50", Length = "0x2FC")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000CAA")]
  [Address(RVA = "0x51A450", Offset = "0x519050", Length = "0x21B")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000CAB")]
  [Address(RVA = "0x51AE40", Offset = "0x519A40", Length = "0xE3")]
  private void SetEmpty()
  {
  }

  [Token(Token = "0x6000CAC")]
  [Address(RVA = "0x51A6F0", Offset = "0x5192F0", Length = "0xAB")]
  private void OnUnlockSelected(UnlockContainer container)
  {
  }

  [Token(Token = "0x6000CAD")]
  [Address(RVA = "0x51A7A0", Offset = "0x5193A0", Length = "0x69F")]
  private void Refresh(UnlockContainer container)
  {
  }

  [Token(Token = "0x6000CAE")]
  [Address(RVA = "0x51A670", Offset = "0x519270", Length = "0x7B")]
  private void OnUnlockClicked(UnlockContainer container)
  {
  }

  [Token(Token = "0x6000CAF")]
  [Address(RVA = "0x51AF30", Offset = "0x519B30", Length = "0x4B6")]
  public void TryBuyUnlockable()
  {
  }

  [Token(Token = "0x6000CB0")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public UnlocksFooter()
  {
  }
}
