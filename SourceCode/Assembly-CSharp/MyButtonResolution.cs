// Decompiled with JetBrains decompiler
// Type: MyButtonResolution
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x200017D")]
public class MyButtonResolution : MyButton
{
  [Token(Token = "0x4000B05")]
  [FieldOffset(Offset = "0x58")]
  public TextMeshProUGUI t_resolution;
  [Token(Token = "0x4000B06")]
  [FieldOffset(Offset = "0x60")]
  public GameObject selected;
  [Token(Token = "0x4000B07")]
  [FieldOffset(Offset = "0x68")]
  private int value;

  [Token(Token = "0x600099B")]
  [Address(RVA = "0x4D9870", Offset = "0x4D8470", Length = "0x14A")]
  private new void Awake()
  {
  }

  [Token(Token = "0x600099C")]
  [Address(RVA = "0x4D9B90", Offset = "0x4D8790", Length = "0x140")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600099D")]
  [Address(RVA = "0x4D9D70", Offset = "0x4D8970", Length = "0xE1")]
  public void SetResolution(Resolution resolution, bool isSelected, int value)
  {
  }

  [Token(Token = "0x600099E")]
  [Address(RVA = "0x4D99C0", Offset = "0x4D85C0", Length = "0x194")]
  public void ClickButton()
  {
  }

  [Token(Token = "0x600099F")]
  [Address(RVA = "0x4D9D40", Offset = "0x4D8940", Length = "0x2F")]
  public void Select()
  {
  }

  [Token(Token = "0x60009A0")]
  [Address(RVA = "0x4D9B60", Offset = "0x4D8760", Length = "0x2F")]
  public void Deselect()
  {
  }

  [Token(Token = "0x60009A1")]
  [Address(RVA = "0x4D9CE0", Offset = "0x4D88E0", Length = "0x5C")]
  private void OnResolutionChanged(int resIndex)
  {
  }

  [Token(Token = "0x60009A2")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x60009A3")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x60009A4")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x60009A5")]
  [Address(RVA = "0x4D7090", Offset = "0x4D5C90", Length = "0xE")]
  public MyButtonResolution()
  {
  }
}
