// Decompiled with JetBrains decompiler
// Type: MapTitle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Other;
using Cpp2ILInjected;
using System.Collections;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000135")]
public class MapTitle : MonoBehaviour
{
  [Token(Token = "0x400090B")]
  [FieldOffset(Offset = "0x20")]
  private float delay;
  [Token(Token = "0x400090C")]
  [FieldOffset(Offset = "0x24")]
  private float visibleTime;
  [Token(Token = "0x400090D")]
  [FieldOffset(Offset = "0x28")]
  private float fadeTime;
  [Token(Token = "0x400090E")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_title;
  [Token(Token = "0x400090F")]
  [FieldOffset(Offset = "0x38")]
  public TextMeshProUGUI t_description;
  [Token(Token = "0x4000910")]
  [FieldOffset(Offset = "0x40")]
  public TextMeshProUGUI t_tier;
  [Token(Token = "0x4000911")]
  [FieldOffset(Offset = "0x48")]
  public CanvasGroup titleCanvasGroup;
  [Token(Token = "0x4000912")]
  [FieldOffset(Offset = "0x50")]
  private float alphaTimer;
  [Token(Token = "0x4000913")]
  [FieldOffset(Offset = "0x58")]
  public StageData testStage;
  [Token(Token = "0x4000914")]
  [FieldOffset(Offset = "0x60")]
  private bool started;
  [Token(Token = "0x4000915")]
  [FieldOffset(Offset = "0x68")]
  private RunConfig runConfig;
  [Token(Token = "0x4000916")]
  [FieldOffset(Offset = "0x70")]
  private float totalTimer;
  [Token(Token = "0x4000917")]
  [FieldOffset(Offset = "0x74")]
  private bool hasPlayedSfx;
  [Token(Token = "0x4000918")]
  [FieldOffset(Offset = "0x75")]
  private bool isFading;
  [Token(Token = "0x4000919")]
  [FieldOffset(Offset = "0x76")]
  private bool isTyping;
  [Token(Token = "0x400091A")]
  [FieldOffset(Offset = "0x78")]
  public AudioSource textSfx;
  [Token(Token = "0x400091B")]
  [FieldOffset(Offset = "0x80")]
  public RandomSfx letterSfx;
  [Token(Token = "0x400091C")]
  [FieldOffset(Offset = "0x88")]
  private bool done;

  [Token(Token = "0x60007BB")]
  [Address(RVA = "0x4BCE10", Offset = "0x4BBA10", Length = "0x38A")]
  public void StartAnimation()
  {
  }

  [Token(Token = "0x60007BC")]
  [Address(RVA = "0x4BD210", Offset = "0x4BBE10", Length = "0x3FF")]
  private void Update()
  {
  }

  [Token(Token = "0x60007BD")]
  [Address(RVA = "0x4BD1A0", Offset = "0x4BBDA0", Length = "0x67")]
  private IEnumerator TypeDescription() => (IEnumerator) null;

  [Token(Token = "0x60007BE")]
  [Address(RVA = "0x4BCC10", Offset = "0x4BB810", Length = "0x1F3")]
  private string GetTitle() => (string) null;

  [Token(Token = "0x60007BF")]
  [Address(RVA = "0x4BCB70", Offset = "0x4BB770", Length = "0x9F")]
  private string GetDescription() => (string) null;

  [Token(Token = "0x60007C0")]
  [Address(RVA = "0x4BD610", Offset = "0x4BC210", Length = "0x1C")]
  public MapTitle()
  {
  }
}
