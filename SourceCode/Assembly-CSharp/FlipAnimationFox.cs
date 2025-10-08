// Decompiled with JetBrains decompiler
// Type: FlipAnimationFox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000045")]
public class FlipAnimationFox : MonoBehaviour
{
  [Token(Token = "0x400020D")]
  [FieldOffset(Offset = "0x20")]
  public Animator animator;
  [Token(Token = "0x400020E")]
  [FieldOffset(Offset = "0x28")]
  private bool isJumping;
  [Token(Token = "0x400020F")]
  [FieldOffset(Offset = "0x30")]
  public Transform flipTransform;
  [Token(Token = "0x4000210")]
  [FieldOffset(Offset = "0x38")]
  private float lastAnimationTime;
  [Token(Token = "0x4000211")]
  [FieldOffset(Offset = "0x3C")]
  private int jumpCount;
  [Token(Token = "0x4000212")]
  [FieldOffset(Offset = "0x40")]
  public GameObject[] defaultHandhelds;
  [Token(Token = "0x4000213")]
  [FieldOffset(Offset = "0x48")]
  public GameObject[] flippedHandhelds;

  [Token(Token = "0x60001D6")]
  [Address(RVA = "0x35C190", Offset = "0x35AD90", Length = "0xF9")]
  private void Update()
  {
  }

  [Token(Token = "0x60001D7")]
  [Address(RVA = "0x35C0A0", Offset = "0x35ACA0", Length = "0xEC")]
  private void OnJumpAnimationStart()
  {
  }

  [Token(Token = "0x60001D8")]
  [Address(RVA = "0x35C020", Offset = "0x35AC20", Length = "0x7E")]
  private void OnJumpAnimationFinishOrInterrupted()
  {
  }

  [Token(Token = "0x60001D9")]
  [Address(RVA = "0x35BF60", Offset = "0x35AB60", Length = "0xBF")]
  private void FlipHandhelds(bool flip)
  {
  }

  [Token(Token = "0x60001DA")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public FlipAnimationFox()
  {
  }
}
