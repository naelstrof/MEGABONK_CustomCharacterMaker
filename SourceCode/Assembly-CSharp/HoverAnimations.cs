// Decompiled with JetBrains decompiler
// Type: HoverAnimations
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000046")]
public class HoverAnimations : MonoBehaviour
{
  [Token(Token = "0x4000214")]
  [FieldOffset(Offset = "0x20")]
  public Transform player;
  [Token(Token = "0x4000215")]
  [FieldOffset(Offset = "0x28")]
  public AudioSource audioHoverLoop;
  [Token(Token = "0x4000216")]
  [FieldOffset(Offset = "0x30")]
  public AudioSource audioSpin;
  [Token(Token = "0x4000217")]
  [FieldOffset(Offset = "0x38")]
  public Animator animator;
  [Token(Token = "0x4000218")]
  [FieldOffset(Offset = "0x40")]
  private Vector3 defaultPos;
  [Token(Token = "0x4000219")]
  [FieldOffset(Offset = "0x4C")]
  private Vector3 defaultRotation;
  [Token(Token = "0x400021A")]
  [FieldOffset(Offset = "0x58")]
  private float currentPitch;
  [Token(Token = "0x400021B")]
  [FieldOffset(Offset = "0x5C")]
  private float nextLandingReadyTime;
  [Token(Token = "0x400021C")]
  [FieldOffset(Offset = "0x60")]
  private float landingInterval;
  [Token(Token = "0x400021D")]
  [FieldOffset(Offset = "0x64")]
  private float minLandingSpeed;
  [Token(Token = "0x400021E")]
  [FieldOffset(Offset = "0x68")]
  private float maxLandingSpeed;
  [Token(Token = "0x400021F")]
  [FieldOffset(Offset = "0x6C")]
  public float sinSpeed;
  [Token(Token = "0x4000220")]
  [FieldOffset(Offset = "0x70")]
  public float height;
  [Token(Token = "0x4000221")]
  [FieldOffset(Offset = "0x74")]
  private float currentLandingOffset;
  [Token(Token = "0x4000222")]
  [FieldOffset(Offset = "0x78")]
  private float landingOffset;
  [Token(Token = "0x4000223")]
  [FieldOffset(Offset = "0x7C")]
  private float minLandingOffset;
  [Token(Token = "0x4000224")]
  [FieldOffset(Offset = "0x80")]
  private float maxLandingOffset;
  [Token(Token = "0x4000225")]
  [FieldOffset(Offset = "0x84")]
  public float landingResetSpeed;
  [Token(Token = "0x4000226")]
  [FieldOffset(Offset = "0x88")]
  public float landingSpeed;
  [Token(Token = "0x4000227")]
  [FieldOffset(Offset = "0x8C")]
  private float lastVelY;
  [Token(Token = "0x4000228")]
  [FieldOffset(Offset = "0x90")]
  private float currentLean;
  [Token(Token = "0x4000229")]
  [FieldOffset(Offset = "0x94")]
  private float targetLean;
  [Token(Token = "0x400022A")]
  [FieldOffset(Offset = "0x98")]
  public float maxLeanAngle;
  [Token(Token = "0x400022B")]
  [FieldOffset(Offset = "0x9C")]
  public float leanSpeed;
  [Token(Token = "0x400022C")]
  [FieldOffset(Offset = "0xA0")]
  public float maxSpeedForLean;
  [Token(Token = "0x400022D")]
  [FieldOffset(Offset = "0xA4")]
  private float newLean;

  [Token(Token = "0x60001DB")]
  [Address(RVA = "0x35CCB0", Offset = "0x35B8B0", Length = "0xD1")]
  private void Start()
  {
  }

  [Token(Token = "0x60001DC")]
  [Address(RVA = "0x35CD90", Offset = "0x35B990", Length = "0x3DB")]
  private void Update()
  {
  }

  [Token(Token = "0x60001DD")]
  [Address(RVA = "0x35CB90", Offset = "0x35B790", Length = "0x11C")]
  private void OnLanded(float speed)
  {
  }

  [Token(Token = "0x60001DE")]
  [Address(RVA = "0x35C620", Offset = "0x35B220", Length = "0x284")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x60001DF")]
  [Address(RVA = "0x35C8B0", Offset = "0x35B4B0", Length = "0x2D9")]
  private void LeanRotation()
  {
  }

  [Token(Token = "0x60001E0")]
  [Address(RVA = "0x35C3B0", Offset = "0x35AFB0", Length = "0x267")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x60001E1")]
  [Address(RVA = "0x35D170", Offset = "0x35BD70", Length = "0x6D")]
  public HoverAnimations()
  {
  }
}
