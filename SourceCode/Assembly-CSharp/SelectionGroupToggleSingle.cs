// Decompiled with JetBrains decompiler
// Type: SelectionGroupToggleSingle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20001C3")]
public class SelectionGroupToggleSingle : MonoBehaviour
{
  [Token(Token = "0x4000CCC")]
  [FieldOffset(Offset = "0x20")]
  public Action<SelectionGroupToggleSingleButton> A_ButtonSelected;
  [Token(Token = "0x4000CCD")]
  [FieldOffset(Offset = "0x28")]
  public int startIndex;
  [Token(Token = "0x4000CCE")]
  [FieldOffset(Offset = "0x2C")]
  public bool canSelectMultiple;
  [Token(Token = "0x4000CCF")]
  [FieldOffset(Offset = "0x2D")]
  public bool canSelectNothing;
  [Token(Token = "0x4000CD0")]
  [FieldOffset(Offset = "0x2E")]
  public bool selectDefaultOnAwake;
  [Token(Token = "0x4000CD1")]
  [FieldOffset(Offset = "0x30")]
  private SelectionGroupToggleSingleButton lastButton;
  [Token(Token = "0x4000CD2")]
  [FieldOffset(Offset = "0x38")]
  private List<SelectionGroupToggleSingleButton> buttons;
  [Token(Token = "0x4000CD4")]
  [FieldOffset(Offset = "0x48")]
  private HashSet<SelectionGroupToggleSingleButton> registeredButtons;

  [field: Token(Token = "0x4000CD3")]
  [field: FieldOffset(Offset = "0x40")]
  [Token(Token = "0x17000069")]
  public List<SelectionGroupToggleSingleButton> selectedButtons { [Token(Token = "0x6000B6C"), Address(RVA = "0x514080", Offset = "0x512C80", Length = "0x5")] get; [Token(Token = "0x6000B6D"), Address(RVA = "0x514090", Offset = "0x512C90", Length = "0xD")] private set; }

  [Token(Token = "0x6000B6E")]
  [Address(RVA = "0x513560", Offset = "0x512160", Length = "0xE8")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000B6F")]
  [Address(RVA = "0x513CC0", Offset = "0x5128C0", Length = "0x7")]
  private void OnTransformChildrenChanged()
  {
  }

  [Token(Token = "0x6000B70")]
  [Address(RVA = "0x513730", Offset = "0x512330", Length = "0x300")]
  public void FindButtons()
  {
  }

  [Token(Token = "0x6000B71")]
  [Address(RVA = "0x513CD0", Offset = "0x5128D0", Length = "0x117")]
  private void SelectButton(SelectionGroupToggleSingleButton btn)
  {
  }

  [Token(Token = "0x6000B72")]
  [Address(RVA = "0x513650", Offset = "0x512250", Length = "0xDF")]
  private void DeselectButton(SelectionGroupToggleSingleButton btn)
  {
  }

  [Token(Token = "0x6000B73")]
  [Address(RVA = "0x513DF0", Offset = "0x5129F0", Length = "0x1B6")]
  public void SetNone()
  {
  }

  [Token(Token = "0x6000B74")]
  [Address(RVA = "0x513C00", Offset = "0x512800", Length = "0xBE")]
  private void OnButtonSelect(SelectionGroupToggleSingleButton newBtn)
  {
  }

  [Token(Token = "0x6000B75")]
  [Address(RVA = "0x513AA0", Offset = "0x5126A0", Length = "0x76")]
  public SelectionGroupToggleSingleButton GetButton(int index) => (SelectionGroupToggleSingleButton) null;

  [Token(Token = "0x6000B76")]
  [Address(RVA = "0x513A40", Offset = "0x512640", Length = "0x5F")]
  public void ForceSelect(int index)
  {
  }

  [Token(Token = "0x6000B77")]
  [Address(RVA = "0x513B20", Offset = "0x512720", Length = "0xD1")]
  public int GetSelectedIndex() => 0;

  [Token(Token = "0x6000B78")]
  [Address(RVA = "0x513FB0", Offset = "0x512BB0", Length = "0xC1")]
  public SelectionGroupToggleSingle()
  {
  }
}
