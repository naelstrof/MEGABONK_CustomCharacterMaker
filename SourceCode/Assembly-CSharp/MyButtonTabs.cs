// Decompiled with JetBrains decompiler
// Type: MyButtonTabs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000182")]
public class MyButtonTabs : MyButton
{
  [Token(Token = "0x4000B1A")]
  [FieldOffset(Offset = "0x58")]
  public MaskableGraphic background;
  [Token(Token = "0x4000B1B")]
  [FieldOffset(Offset = "0x60")]
  public MaskableGraphic text;
  [Token(Token = "0x4000B1C")]
  [FieldOffset(Offset = "0x68")]
  public GameObject associatedContent;
  [Token(Token = "0x4000B1D")]
  [FieldOffset(Offset = "0x70")]
  public Color selectedColor;
  [Token(Token = "0x4000B1E")]
  [FieldOffset(Offset = "0x80")]
  public Color defaultColor;
  [Token(Token = "0x4000B1F")]
  [FieldOffset(Offset = "0x90")]
  private bool selected;

  [Token(Token = "0x60009B9")]
  [Address(RVA = "0x4DADE0", Offset = "0x4D99E0", Length = "0xE3")]
  private void Start()
  {
  }

  [Token(Token = "0x60009BA")]
  [Address(RVA = "0x4DAC50", Offset = "0x4D9850", Length = "0xA4")]
  public void Select()
  {
  }

  [Token(Token = "0x60009BB")]
  [Address(RVA = "0x4DAB60", Offset = "0x4D9760", Length = "0xEB")]
  public void Deselect(MyButtonTabs newButton)
  {
  }

  [Token(Token = "0x60009BC")]
  [Address(RVA = "0x4DAD00", Offset = "0x4D9900", Length = "0xDA")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x60009BD")]
  [Address(RVA = "0x4DAED0", Offset = "0x4D9AD0", Length = "0x4B")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x60009BE")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x60009BF")]
  [Address(RVA = "0x4D7090", Offset = "0x4D5C90", Length = "0xE")]
  public MyButtonTabs()
  {
  }
}
