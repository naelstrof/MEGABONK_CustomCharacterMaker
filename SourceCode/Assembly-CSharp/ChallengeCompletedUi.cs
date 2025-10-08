// Decompiled with JetBrains decompiler
// Type: ChallengeCompletedUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000143")]
public class ChallengeCompletedUi : MonoBehaviour
{
  [Token(Token = "0x4000966")]
  [FieldOffset(Offset = "0x20")]
  public AudioSource sfx;
  [Token(Token = "0x4000967")]
  [FieldOffset(Offset = "0x28")]
  public GameObject content;
  [Token(Token = "0x4000968")]
  [FieldOffset(Offset = "0x30")]
  public GameObject text;
  [Token(Token = "0x4000969")]
  [FieldOffset(Offset = "0x38")]
  public GameObject challengeBox;
  [Token(Token = "0x400096A")]
  [FieldOffset(Offset = "0x40")]
  public TextMeshProUGUI t_header;
  [Token(Token = "0x400096B")]
  [FieldOffset(Offset = "0x48")]
  public TextMeshProUGUI t_description;
  [Token(Token = "0x400096C")]
  [FieldOffset(Offset = "0x50")]
  public TextSizer textSizer;
  [Token(Token = "0x400096D")]
  [FieldOffset(Offset = "0x58")]
  public CanvasGroup canvasGroup;
  [Token(Token = "0x400096E")]
  [FieldOffset(Offset = "0x60")]
  public GameObject particles;
  [Token(Token = "0x400096F")]
  [FieldOffset(Offset = "0x68")]
  public RawImage shadow;
  [Token(Token = "0x4000970")]
  [FieldOffset(Offset = "0x70")]
  private float fadeInTime;
  [Token(Token = "0x4000971")]
  [FieldOffset(Offset = "0x74")]
  private float fadeOutTime;
  [Token(Token = "0x4000972")]
  [FieldOffset(Offset = "0x78")]
  private float cardDesiredScale;
  [Token(Token = "0x4000973")]
  [FieldOffset(Offset = "0x7C")]
  private float textDesiredScale;
  [Token(Token = "0x4000974")]
  [FieldOffset(Offset = "0x80")]
  private float desiredAlpha;
  [Token(Token = "0x4000975")]
  [FieldOffset(Offset = "0x84")]
  private float animatorTime;
  [Token(Token = "0x4000976")]
  [FieldOffset(Offset = "0x88")]
  private float animatorSpeed;
  [Token(Token = "0x4000977")]
  [FieldOffset(Offset = "0x90")]
  public Image background;

  [Token(Token = "0x600081B")]
  [Address(RVA = "0x4B32A0", Offset = "0x4B1EA0", Length = "0x140")]
  private void Awake()
  {
  }

  [Token(Token = "0x600081C")]
  [Address(RVA = "0x4B34B0", Offset = "0x4B20B0", Length = "0x140")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600081D")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void Test()
  {
  }

  [Token(Token = "0x600081E")]
  [Address(RVA = "0x4B33F0", Offset = "0x4B1FF0", Length = "0xB8")]
  private void OnAchievementUnlocked(ChallengeData challenge)
  {
  }

  [Token(Token = "0x600081F")]
  [Address(RVA = "0x4B3670", Offset = "0x4B2270", Length = "0x7")]
  private void Update()
  {
  }

  [Token(Token = "0x6000820")]
  [Address(RVA = "0x4B2EA0", Offset = "0x4B1AA0", Length = "0x3FF")]
  private void Animate()
  {
  }

  [Token(Token = "0x6000821")]
  [Address(RVA = "0x4B3600", Offset = "0x4B2200", Length = "0x67")]
  private IEnumerator StartAnimate() => (IEnumerator) null;

  [Token(Token = "0x6000822")]
  [Address(RVA = "0x4B3680", Offset = "0x4B2280", Length = "0x29")]
  public ChallengeCompletedUi()
  {
  }
}
