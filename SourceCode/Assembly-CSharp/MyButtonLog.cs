// Decompiled with JetBrains decompiler
// Type: MyButtonLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001AC")]
public class MyButtonLog : MyButton
{
  [Token(Token = "0x4000C21")]
  [FieldOffset(Offset = "0x58")]
  public TextMeshProUGUI t_enemyName;
  [Token(Token = "0x4000C22")]
  [FieldOffset(Offset = "0x60")]
  public EEnemy eEnemy;
  [Token(Token = "0x4000C23")]
  public static Action<EEnemy> A_EnemySelected;
  [Token(Token = "0x4000C24")]
  public static Action A_ClaimedReward;
  [Token(Token = "0x4000C25")]
  [FieldOffset(Offset = "0x68")]
  public GameObject claimAlert;
  [Token(Token = "0x4000C26")]
  [FieldOffset(Offset = "0x70")]
  public GameObject greenLoggedIcon;
  [Token(Token = "0x4000C27")]
  [FieldOffset(Offset = "0x78")]
  public MaskableGraphic background;
  [Token(Token = "0x4000C28")]
  [FieldOffset(Offset = "0x80")]
  public Color defaultColor;
  [Token(Token = "0x4000C29")]
  [FieldOffset(Offset = "0x90")]
  public Color hoverColor;

  [Token(Token = "0x6000AC7")]
  [Address(RVA = "0x4FA140", Offset = "0x4F8D40", Length = "0x82")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x6000AC8")]
  [Address(RVA = "0x4FA1D0", Offset = "0x4F8DD0", Length = "0x42")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x6000AC9")]
  [Address(RVA = "0x4F9FB0", Offset = "0x4F8BB0", Length = "0x18A")]
  public void SetEnemy(EEnemy enemy, int enemyIndex)
  {
  }

  [Token(Token = "0x6000ACA")]
  [Address(RVA = "0x4F9DB0", Offset = "0x4F89B0", Length = "0x1E2")]
  public void Claim()
  {
  }

  [Token(Token = "0x6000ACB")]
  [Address(RVA = "0x4F9FA0", Offset = "0x4F8BA0", Length = "0x7")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x6000ACC")]
  [Address(RVA = "0x4F0AE0", Offset = "0x4EF6E0", Length = "0x7")]
  public MyButtonLog()
  {
  }
}
