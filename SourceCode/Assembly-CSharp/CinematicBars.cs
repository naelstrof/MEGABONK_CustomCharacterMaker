// Decompiled with JetBrains decompiler
// Type: CinematicBars
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000145")]
public class CinematicBars : MonoBehaviour
{
  [Token(Token = "0x400097B")]
  [FieldOffset(Offset = "0x20")]
  public RectTransform topBar;
  [Token(Token = "0x400097C")]
  [FieldOffset(Offset = "0x28")]
  public RectTransform bottomBar;
  [Token(Token = "0x400097D")]
  [FieldOffset(Offset = "0x30")]
  public CanvasGroup canvasGroup;
  [Token(Token = "0x400097E")]
  [FieldOffset(Offset = "0x38")]
  private float barHeight;
  [Token(Token = "0x400097F")]
  [FieldOffset(Offset = "0x3C")]
  private float moveTime;
  [Token(Token = "0x4000980")]
  [FieldOffset(Offset = "0x40")]
  private float moveTimer;
  [Token(Token = "0x4000981")]
  [FieldOffset(Offset = "0x44")]
  private bool isShowing;

  [Token(Token = "0x6000829")]
  [Address(RVA = "0x4B36B0", Offset = "0x4B22B0", Length = "0x3C")]
  private void Awake()
  {
  }

  [Token(Token = "0x600082A")]
  [Address(RVA = "0x4B3760", Offset = "0x4B2360", Length = "0xA0")]
  public void InstaShow()
  {
  }

  [Token(Token = "0x600082B")]
  [Address(RVA = "0x4B3840", Offset = "0x4B2440", Length = "0xCF")]
  public void Show()
  {
  }

  [Token(Token = "0x600082C")]
  [Address(RVA = "0x4B36F0", Offset = "0x4B22F0", Length = "0x68")]
  public void Hide()
  {
  }

  [Token(Token = "0x600082D")]
  [Address(RVA = "0x4B3810", Offset = "0x4B2410", Length = "0x2C")]
  public bool IsShowing() => false;

  [Token(Token = "0x600082E")]
  [Address(RVA = "0x4B3910", Offset = "0x4B2510", Length = "0x203")]
  private void Update()
  {
  }

  [Token(Token = "0x600082F")]
  [Address(RVA = "0x4B3B20", Offset = "0x4B2720", Length = "0xE")]
  public CinematicBars()
  {
  }
}
