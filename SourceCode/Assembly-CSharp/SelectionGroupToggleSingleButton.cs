// Decompiled with JetBrains decompiler
// Type: SelectionGroupToggleSingleButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001C5")]
public class SelectionGroupToggleSingleButton : MyButton
{
  [Token(Token = "0x4000CD7")]
  [FieldOffset(Offset = "0x58")]
  public GameObject[] enableOnSelect;
  [Token(Token = "0x4000CD8")]
  [FieldOffset(Offset = "0x60")]
  public GameObject unselectableOverlay;

  [field: Token(Token = "0x4000CD9")]
  [field: FieldOffset(Offset = "0x68")]
  [Token(Token = "0x1700006A")]
  public bool canSelect { [Token(Token = "0x6000B7B"), Address(RVA = "0x50B480", Offset = "0x50A080", Length = "0x5")] get; [Token(Token = "0x6000B7C"), Address(RVA = "0x50B490", Offset = "0x50A090", Length = "0x4")] set; }

  [field: Token(Token = "0x4000CDA")]
  [field: FieldOffset(Offset = "0x69")]
  [Token(Token = "0x1700006B")]
  public bool isSelected { [Token(Token = "0x6000B7D"), Address(RVA = "0x513540", Offset = "0x512140", Length = "0x5")] get; [Token(Token = "0x6000B7E"), Address(RVA = "0x513550", Offset = "0x512150", Length = "0x4")] private set; }

  [Token(Token = "0x6000B7F")]
  [Address(RVA = "0x5134E0", Offset = "0x5120E0", Length = "0x5D")]
  public void Select()
  {
  }

  [Token(Token = "0x6000B80")]
  [Address(RVA = "0x513480", Offset = "0x512080", Length = "0x5D")]
  public void Deselect()
  {
  }

  [Token(Token = "0x6000B81")]
  [Address(RVA = "0x4D7070", Offset = "0x4D5C70", Length = "0x5")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x6000B82")]
  [Address(RVA = "0x4D7080", Offset = "0x4D5C80", Length = "0x5")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x6000B83")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x6000B84")]
  [Address(RVA = "0x5133F0", Offset = "0x511FF0", Length = "0x8A")]
  public void CanSelect(bool b)
  {
  }

  [Token(Token = "0x6000B85")]
  [Address(RVA = "0x512FD0", Offset = "0x511BD0", Length = "0xD")]
  public SelectionGroupToggleSingleButton()
  {
  }
}
