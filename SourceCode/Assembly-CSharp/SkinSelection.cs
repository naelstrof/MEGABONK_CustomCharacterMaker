// Decompiled with JetBrains decompiler
// Type: SkinSelection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200018E")]
public class SkinSelection : MonoBehaviour
{
  [Token(Token = "0x4000B66")]
  [FieldOffset(Offset = "0x20")]
  public GameObject skinContainerPrefab;
  [Token(Token = "0x4000B67")]
  [FieldOffset(Offset = "0x28")]
  private List<SkinContainer> containers;
  [Token(Token = "0x4000B68")]
  [FieldOffset(Offset = "0x30")]
  public MyButton b_confirm;
  [Token(Token = "0x4000B69")]
  [FieldOffset(Offset = "0x38")]
  private List<SkinData> skins;
  [Token(Token = "0x4000B6A")]
  [FieldOffset(Offset = "0x40")]
  private int currentlySelected;
  [Token(Token = "0x4000B6B")]
  [FieldOffset(Offset = "0x48")]
  private SkinContainer previousSelected;
  [Token(Token = "0x4000B6C")]
  public static Action<SkinContainer> A_ForceSkinDisplay;
  [Token(Token = "0x4000B6D")]
  [FieldOffset(Offset = "0x50")]
  private SkinContainer lastSelectedSkinContainer;

  [Token(Token = "0x6000A13")]
  [Address(RVA = "0x4FBBD0", Offset = "0x4FA7D0", Length = "0x2FF")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000A14")]
  [Address(RVA = "0x4FC2F0", Offset = "0x4FAEF0", Length = "0x2FF")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000A15")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void Start()
  {
  }

  [Token(Token = "0x6000A16")]
  [Address(RVA = "0x4FC700", Offset = "0x4FB300", Length = "0x10E")]
  private void OnSkinHover(SkinContainer skinContainer)
  {
  }

  [Token(Token = "0x6000A17")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void OnSkinHoverMouse(SkinContainer skinContainer)
  {
  }

  [Token(Token = "0x6000A18")]
  [Address(RVA = "0x4FC5F0", Offset = "0x4FB1F0", Length = "0x10E")]
  private void OnSkinHoverMouseExit(SkinContainer skinContainer)
  {
  }

  [Token(Token = "0x6000A19")]
  [Address(RVA = "0x4FCFA0", Offset = "0x4FBBA0", Length = "0x265")]
  private void SetCurrentlySelected(int index, ECharacter character)
  {
  }

  [Token(Token = "0x6000A1A")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public void DisableNavigation()
  {
  }

  [Token(Token = "0x6000A1B")]
  [Address(RVA = "0x4FBED0", Offset = "0x4FAAD0", Length = "0x20C")]
  public void CreateNavigation(Button backButton)
  {
  }

  [Token(Token = "0x6000A1C")]
  [Address(RVA = "0x4FC0E0", Offset = "0x4FACE0", Length = "0x20C")]
  public void EnableNavigation(Button backButton)
  {
  }

  [Token(Token = "0x6000A1D")]
  [Address(RVA = "0x4FCE90", Offset = "0x4FBA90", Length = "0x10A")]
  private void SetConfirmButtonNav()
  {
  }

  [Token(Token = "0x6000A1E")]
  [Address(RVA = "0x4FC810", Offset = "0x4FB410", Length = "0x675")]
  public void SetCharacter(MyButtonCharacter charButton)
  {
  }

  [Token(Token = "0x6000A1F")]
  [Address(RVA = "0x4FD210", Offset = "0x4FBE10", Length = "0x10F")]
  public void SetNotUnlocked()
  {
  }

  [Token(Token = "0x6000A20")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public SkinSelection()
  {
  }
}
