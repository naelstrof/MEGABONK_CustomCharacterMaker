// Decompiled with JetBrains decompiler
// Type: FadeWorldUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000207")]
public class FadeWorldUi : MonoBehaviour
{
  [Token(Token = "0x4000E3F")]
  [FieldOffset(Offset = "0x20")]
  public MaskableGraphic damageText;
  [Token(Token = "0x4000E40")]
  [FieldOffset(Offset = "0x28")]
  public MaskableGraphic otherText;
  [Token(Token = "0x4000E41")]
  [FieldOffset(Offset = "0x30")]
  private Vector3 randomDir;
  [Token(Token = "0x4000E42")]
  [FieldOffset(Offset = "0x40")]
  public CanvasGroup cGroup;
  [Token(Token = "0x4000E43")]
  [FieldOffset(Offset = "0x48")]
  private Vector3 defaultScale;
  [Token(Token = "0x4000E44")]
  [FieldOffset(Offset = "0x54")]
  private float fadeTime;
  [Token(Token = "0x4000E45")]
  [FieldOffset(Offset = "0x58")]
  private float startFadeoutTime;
  [Token(Token = "0x4000E46")]
  [FieldOffset(Offset = "0x5C")]
  private bool started;
  [Token(Token = "0x4000E47")]
  [FieldOffset(Offset = "0x60")]
  private IEnumerator shakeRoutine;
  [Token(Token = "0x4000E48")]
  [FieldOffset(Offset = "0x68")]
  private float moveMultiplier;
  [Token(Token = "0x4000E49")]
  [FieldOffset(Offset = "0x6C")]
  private float speed;
  [Token(Token = "0x4000E4A")]
  [FieldOffset(Offset = "0x70")]
  private Vector3 moveDir;
  [Token(Token = "0x4000E4B")]
  [FieldOffset(Offset = "0x7C")]
  private float desiredScale;

  [Token(Token = "0x6000D4A")]
  [Address(RVA = "0x522220", Offset = "0x520E20", Length = "0x66")]
  private void StartFadeOut()
  {
  }

  [Token(Token = "0x6000D4B")]
  [Address(RVA = "0x522290", Offset = "0x520E90", Length = "0x392")]
  public void Start()
  {
  }

  [Token(Token = "0x6000D4C")]
  [Address(RVA = "0x522630", Offset = "0x521230", Length = "0x2C6")]
  private void Update()
  {
  }

  [Token(Token = "0x6000D4D")]
  [Address(RVA = "0x5221C0", Offset = "0x520DC0", Length = "0x56")]
  private void DestroySelf()
  {
  }

  [Token(Token = "0x6000D4E")]
  [Address(RVA = "0x522900", Offset = "0x521500", Length = "0x2A")]
  public FadeWorldUi()
  {
  }
}
