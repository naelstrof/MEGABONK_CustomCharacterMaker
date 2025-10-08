// Decompiled with JetBrains decompiler
// Type: UnlocksUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20001E9")]
public class UnlocksUi : MonoBehaviour
{
  [Token(Token = "0x4000DBB")]
  [FieldOffset(Offset = "0x20")]
  private List<UnlockContainer> unlockContainers;
  [Token(Token = "0x4000DBC")]
  [FieldOffset(Offset = "0x28")]
  public GameObject unlockContainerPrefab;
  [Token(Token = "0x4000DBD")]
  [FieldOffset(Offset = "0x30")]
  public Transform contentParent;
  [Token(Token = "0x4000DBE")]
  [FieldOffset(Offset = "0x38")]
  public ButtonNavigationSelectionOnly tabButtons;
  [Token(Token = "0x4000DBF")]
  [FieldOffset(Offset = "0x40")]
  public TabGridNavigation tabGridNavigation;
  [Token(Token = "0x4000DC0")]
  [FieldOffset(Offset = "0x48")]
  public GameObject exclChar;
  [Token(Token = "0x4000DC1")]
  [FieldOffset(Offset = "0x50")]
  public GameObject exclWeapon;
  [Token(Token = "0x4000DC2")]
  [FieldOffset(Offset = "0x58")]
  public GameObject exclTome;
  [Token(Token = "0x4000DC3")]
  [FieldOffset(Offset = "0x60")]
  public GameObject exclItem;
  [Token(Token = "0x4000DC4")]
  [FieldOffset(Offset = "0x68")]
  public GameObject[] exclamationMarks;

  [Token(Token = "0x6000CB1")]
  [Address(RVA = "0x51B3F0", Offset = "0x519FF0", Length = "0x28A")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000CB2")]
  [Address(RVA = "0x51B850", Offset = "0x51A450", Length = "0x202")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000CB3")]
  [Address(RVA = "0x51BA60", Offset = "0x51A660", Length = "0x7")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000CB4")]
  [Address(RVA = "0x51B680", Offset = "0x51A280", Length = "0x1C9")]
  public void FocusCharacterPurchase(CharacterData character)
  {
  }

  [Token(Token = "0x6000CB5")]
  [Address(RVA = "0x51C090", Offset = "0x51AC90", Length = "0x4B7")]
  private void UpdateExclamationMarks()
  {
  }

  [Token(Token = "0x6000CB6")]
  [Address(RVA = "0x51BA70", Offset = "0x51A670", Length = "0x22B")]
  private void OnTabSelected(int index)
  {
  }

  [Token(Token = "0x6000CB7")]
  [Address(RVA = "0x51BCA0", Offset = "0x51A8A0", Length = "0x3E9")]
  private void Refresh(List<UnlockableBase> unlockables, string unlockType)
  {
  }

  [Token(Token = "0x6000CB8")]
  [Address(RVA = "0x51C550", Offset = "0x51B150", Length = "0x77")]
  public UnlocksUi()
  {
  }
}
