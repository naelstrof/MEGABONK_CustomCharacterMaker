// Decompiled with JetBrains decompiler
// Type: MyButtonMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000179")]
public class MyButtonMap : MyButton
{
  [Token(Token = "0x4000ADE")]
  [FieldOffset(Offset = "0x58")]
  public GameObject hoverOverlay;
  [Token(Token = "0x4000ADF")]
  [FieldOffset(Offset = "0x60")]
  public TextMeshProUGUI t_name;
  [Token(Token = "0x4000AE0")]
  [FieldOffset(Offset = "0x68")]
  public RawImage i_icon;
  [Token(Token = "0x4000AE1")]
  [FieldOffset(Offset = "0x70")]
  public MapData mapData;
  [Token(Token = "0x4000AE2")]
  public static Action<MyButtonMap> A_Confirm;
  [Token(Token = "0x4000AE3")]
  public static Action<MyButtonMap> A_Select;

  [Token(Token = "0x600097F")]
  [Address(RVA = "0x4D8340", Offset = "0x4D6F40", Length = "0x13F")]
  public void SetMap(MapData data)
  {
  }

  [Token(Token = "0x6000980")]
  [Address(RVA = "0x4D8480", Offset = "0x4D7080", Length = "0x72")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x6000981")]
  [Address(RVA = "0x4D8150", Offset = "0x4D6D50", Length = "0x24")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x6000982")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x6000983")]
  [Address(RVA = "0x4D8500", Offset = "0x4D7100", Length = "0x83")]
  private new void Update()
  {
  }

  [Token(Token = "0x6000984")]
  [Address(RVA = "0x4D7090", Offset = "0x4D5C90", Length = "0xE")]
  public MyButtonMap()
  {
  }
}
