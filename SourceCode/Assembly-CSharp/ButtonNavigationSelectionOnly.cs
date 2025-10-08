// Decompiled with JetBrains decompiler
// Type: ButtonNavigationSelectionOnly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001C9")]
public class ButtonNavigationSelectionOnly : MonoBehaviour
{
  [Token(Token = "0x4000CF3")]
  [FieldOffset(Offset = "0x20")]
  private MyButtonTabs[] buttons;
  [Token(Token = "0x4000CF4")]
  [FieldOffset(Offset = "0x28")]
  public int current;
  [Token(Token = "0x4000CF5")]
  [FieldOffset(Offset = "0x2C")]
  public float cooldown;
  [Token(Token = "0x4000CF6")]
  [FieldOffset(Offset = "0x30")]
  private float lastPressedTime;
  [Token(Token = "0x4000CF7")]
  [FieldOffset(Offset = "0x38")]
  public Action<int> A_ButtonSelected;
  [Token(Token = "0x4000CF8")]
  [FieldOffset(Offset = "0x40")]
  public int startButton;

  [Token(Token = "0x6000BA1")]
  [Address(RVA = "0x501FA0", Offset = "0x500BA0", Length = "0x33")]
  private void Start()
  {
  }

  [Token(Token = "0x6000BA2")]
  [Address(RVA = "0x501E00", Offset = "0x500A00", Length = "0x192")]
  private void Init()
  {
  }

  [Token(Token = "0x6000BA3")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void ReInit()
  {
  }

  [Token(Token = "0x6000BA4")]
  [Address(RVA = "0x501C90", Offset = "0x500890", Length = "0xDE")]
  public void ButtonPressed(int index, bool force = false)
  {
  }

  [Token(Token = "0x6000BA5")]
  [Address(RVA = "0x501D70", Offset = "0x500970", Length = "0x22")]
  private bool CanPress() => false;

  [Token(Token = "0x6000BA6")]
  [Address(RVA = "0x501DC0", Offset = "0x5009C0", Length = "0x36")]
  public Button GetSelectedButton() => (Button) null;

  [Token(Token = "0x6000BA7")]
  [Address(RVA = "0x501DA0", Offset = "0x5009A0", Length = "0x1A")]
  public int GetNumButtons() => 0;

  [Token(Token = "0x6000BA8")]
  [Address(RVA = "0x501FE0", Offset = "0x500BE0", Length = "0xE")]
  public ButtonNavigationSelectionOnly()
  {
  }
}
