// Decompiled with JetBrains decompiler
// Type: TransitionUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[Token(Token = "0x20001F8")]
public class TransitionUI : MonoBehaviour
{
  [Token(Token = "0x4000E01")]
  [FieldOffset(Offset = "0x20")]
  public RawImage overlay;
  [Token(Token = "0x4000E02")]
  [FieldOffset(Offset = "0x28")]
  private float transitionTime;
  [Token(Token = "0x4000E03")]
  public static TransitionUI Instance;
  [Token(Token = "0x4000E04")]
  [FieldOffset(Offset = "0x2C")]
  public bool isTransitioning;
  [Token(Token = "0x4000E05")]
  public static Action A_transitionEnd;
  [Token(Token = "0x4000E06")]
  public static Action A_transitionStart;
  [Token(Token = "0x4000E07")]
  [FieldOffset(Offset = "0x30")]
  private float fadeInTime;

  [Token(Token = "0x6000D00")]
  [Address(RVA = "0x532A70", Offset = "0x531670", Length = "0x185")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000D01")]
  [Address(RVA = "0x532F00", Offset = "0x531B00", Length = "0xEA")]
  private void Start()
  {
  }

  [Token(Token = "0x6000D02")]
  [Address(RVA = "0x532D10", Offset = "0x531910", Length = "0xEB")]
  public void LoadMenu()
  {
  }

  [Token(Token = "0x6000D03")]
  [Address(RVA = "0x532E00", Offset = "0x531A00", Length = "0xCB")]
  public void StartLoadingMap(string mapName)
  {
  }

  [Token(Token = "0x6000D04")]
  [Address(RVA = "0x532ED0", Offset = "0x531AD0", Length = "0x24")]
  public void StartTransition(Action action)
  {
  }

  [Token(Token = "0x6000D05")]
  [Address(RVA = "0x532C00", Offset = "0x531800", Length = "0x84")]
  private IEnumerator DoTransition(Action action) => (IEnumerator) null;

  [Token(Token = "0x6000D06")]
  [Address(RVA = "0x532C90", Offset = "0x531890", Length = "0x67")]
  private IEnumerator EndTransition() => (IEnumerator) null;

  [Token(Token = "0x6000D07")]
  [Address(RVA = "0x532FF0", Offset = "0x531BF0", Length = "0x5")]
  public void StopTransition()
  {
  }

  [Token(Token = "0x6000D08")]
  [Address(RVA = "0x532D00", Offset = "0x531900", Length = "0x5")]
  public bool IsTransitioning() => false;

  [Token(Token = "0x6000D09")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void OnNewSceneLoaded(Scene arg0, LoadSceneMode arg1)
  {
  }

  [Token(Token = "0x6000D0A")]
  [Address(RVA = "0x393420", Offset = "0x392020", Length = "0x6")]
  public float GetTransitionTime() => 0.0f;

  [Token(Token = "0x6000D0B")]
  [Address(RVA = "0x533000", Offset = "0x531C00", Length = "0x15")]
  public TransitionUI()
  {
  }
}
