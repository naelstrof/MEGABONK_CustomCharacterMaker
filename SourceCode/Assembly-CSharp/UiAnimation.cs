// Decompiled with JetBrains decompiler
// Type: UiAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.UI.Animation;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000125")]
public class UiAnimation : MonoBehaviour
{
  [Token(Token = "0x40008A9")]
  [FieldOffset(Offset = "0x20")]
  public MaskableGraphic element;
  [Token(Token = "0x40008AA")]
  [FieldOffset(Offset = "0x28")]
  private MaskableGraphic[] subElements;
  [Token(Token = "0x40008AB")]
  [FieldOffset(Offset = "0x30")]
  private bool checkedChildren;
  [Token(Token = "0x40008AC")]
  [FieldOffset(Offset = "0x34")]
  private float scaleTarget;
  [Token(Token = "0x40008AD")]
  [FieldOffset(Offset = "0x38")]
  private float scaleTimer;
  [Token(Token = "0x40008AE")]
  [FieldOffset(Offset = "0x3C")]
  private float scaleTimespan;
  [Token(Token = "0x40008AF")]
  [FieldOffset(Offset = "0x40")]
  private float fromScale;
  [Token(Token = "0x40008B0")]
  [FieldOffset(Offset = "0x44")]
  private EEasing scaleEasing;

  [Token(Token = "0x600074E")]
  [Address(RVA = "0x4CA0C0", Offset = "0x4C8CC0", Length = "0x49")]
  private void Awake()
  {
  }

  [Token(Token = "0x600074F")]
  [Address(RVA = "0x4CA110", Offset = "0x4C8D10", Length = "0x59")]
  private void CheckSubElements()
  {
  }

  [Token(Token = "0x6000750")]
  [Address(RVA = "0x4CA170", Offset = "0x4C8D70", Length = "0x205")]
  public void CrossFadeAndScaleIn(float time, EEasing easing = EEasing.Linear)
  {
  }

  [Token(Token = "0x6000751")]
  [Address(RVA = "0x4CA470", Offset = "0x4C9070", Length = "0xA6")]
  public void ScaleIn(float time, EEasing easing = EEasing.Linear)
  {
  }

  [Token(Token = "0x6000752")]
  [Address(RVA = "0x4CA380", Offset = "0x4C8F80", Length = "0xCB")]
  public void CrossFade(float alpha, float time)
  {
  }

  [Token(Token = "0x6000753")]
  [Address(RVA = "0x4CA520", Offset = "0x4C9120", Length = "0x180")]
  public void Scale(float scale, float time, EEasing easing = EEasing.Linear)
  {
  }

  [Token(Token = "0x6000754")]
  [Address(RVA = "0x4CA6B0", Offset = "0x4C92B0", Length = "0x242")]
  private void Update()
  {
  }

  [Token(Token = "0x6000755")]
  [Address(RVA = "0x4CA450", Offset = "0x4C9050", Length = "0x1E")]
  private float GetEaseValue(float value, EEasing easing) => 0.0f;

  [Token(Token = "0x6000756")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public UiAnimation()
  {
  }
}
