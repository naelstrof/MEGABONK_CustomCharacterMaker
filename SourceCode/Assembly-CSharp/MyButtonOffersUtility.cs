// Decompiled with JetBrains decompiler
// Type: MyButtonOffersUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200017B")]
public class MyButtonOffersUtility : MyButton
{
  [Token(Token = "0x4000AE8")]
  [FieldOffset(Offset = "0x58")]
  public TextMeshProUGUI t_amount;
  [Token(Token = "0x4000AE9")]
  [FieldOffset(Offset = "0x60")]
  public TextMeshProUGUI t_price;
  [Token(Token = "0x4000AEA")]
  [FieldOffset(Offset = "0x68")]
  public GameObject disbaledOverlay;
  [Token(Token = "0x4000AEB")]
  [FieldOffset(Offset = "0x70")]
  public MaskableGraphic background;
  [Token(Token = "0x4000AEC")]
  [FieldOffset(Offset = "0x78")]
  public Color defaultColor;
  [Token(Token = "0x4000AED")]
  [FieldOffset(Offset = "0x88")]
  public Color hoverColor;
  [Token(Token = "0x4000AEE")]
  [FieldOffset(Offset = "0x98")]
  private bool colorInited;
  [Token(Token = "0x4000AEF")]
  [FieldOffset(Offset = "0x99")]
  private bool cantAfford;
  [Token(Token = "0x4000AF0")]
  [FieldOffset(Offset = "0x9C")]
  private float refreshedAtTime;

  [Token(Token = "0x600098A")]
  [Address(RVA = "0x4D8BC0", Offset = "0x4D77C0", Length = "0x113")]
  private void SetColor(Color c)
  {
  }

  [Token(Token = "0x600098B")]
  [Address(RVA = "0x4D87C0", Offset = "0x4D73C0", Length = "0x42")]
  public void Enable()
  {
  }

  [Token(Token = "0x600098C")]
  [Address(RVA = "0x4D8770", Offset = "0x4D7370", Length = "0x42")]
  public void Disable()
  {
  }

  [Token(Token = "0x600098D")]
  [Address(RVA = "0x4D8CE0", Offset = "0x4D78E0", Length = "0x5B")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x600098E")]
  [Address(RVA = "0x4D8D40", Offset = "0x4D7940", Length = "0x55")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x600098F")]
  [Address(RVA = "0x4D8810", Offset = "0x4D7410", Length = "0x1B5")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x6000990")]
  [Address(RVA = "0x4D89D0", Offset = "0x4D75D0", Length = "0x1E0")]
  public void SetAmount(int n, int price)
  {
  }

  [Token(Token = "0x6000991")]
  [Address(RVA = "0x4D7090", Offset = "0x4D5C90", Length = "0xE")]
  public MyButtonOffersUtility()
  {
  }
}
