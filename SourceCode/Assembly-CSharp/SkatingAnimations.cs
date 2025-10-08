// Decompiled with JetBrains decompiler
// Type: SkatingAnimations
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x2000047")]
public class SkatingAnimations : MonoBehaviour
{
  [Token(Token = "0x400022E")]
  [FieldOffset(Offset = "0x20")]
  public Animator animator;
  [Token(Token = "0x400022F")]
  [FieldOffset(Offset = "0x28")]
  private PlayerMovement playerMovement;
  [Token(Token = "0x4000230")]
  [FieldOffset(Offset = "0x30")]
  public AudioSource skateSfx;
  [Token(Token = "0x4000231")]
  [FieldOffset(Offset = "0x38")]
  private string lastAnimationName;
  [Token(Token = "0x4000232")]
  [FieldOffset(Offset = "0x40")]
  private float maxVolume;
  [Token(Token = "0x4000233")]
  [FieldOffset(Offset = "0x44")]
  private float skateVolumeBoost;
  [Token(Token = "0x4000234")]
  [FieldOffset(Offset = "0x48")]
  private float idleThreshold;
  [Token(Token = "0x4000235")]
  [FieldOffset(Offset = "0x50")]
  private Queue<float> speedChangeQueue;
  [Token(Token = "0x4000236")]
  [FieldOffset(Offset = "0x58")]
  private Queue<float> rotationChangeQueue;
  [Token(Token = "0x4000237")]
  [FieldOffset(Offset = "0x60")]
  private float previousSpeed;
  [Token(Token = "0x4000238")]
  [FieldOffset(Offset = "0x64")]
  private Vector3 previousForward;
  [Token(Token = "0x4000239")]
  [FieldOffset(Offset = "0x70")]
  private int averageFrameCount;
  [Token(Token = "0x400023A")]
  [FieldOffset(Offset = "0x74")]
  private float speedChangeThreshold;
  [Token(Token = "0x400023B")]
  [FieldOffset(Offset = "0x78")]
  private float rotationChangeThreshold;
  [Token(Token = "0x400023C")]
  [FieldOffset(Offset = "0x7C")]
  private float nextKickTime;
  [Token(Token = "0x400023D")]
  [FieldOffset(Offset = "0x80")]
  private float minKickInterval;
  [Token(Token = "0x400023E")]
  [FieldOffset(Offset = "0x84")]
  private float maxKickInterval;

  [Token(Token = "0x60001E2")]
  [Address(RVA = "0x366860", Offset = "0x365460", Length = "0x6C")]
  private void Awake()
  {
  }

  [Token(Token = "0x60001E3")]
  [Address(RVA = "0x367220", Offset = "0x365E20", Length = "0x2C5")]
  private void Update()
  {
  }

  [Token(Token = "0x60001E4")]
  [Address(RVA = "0x367210", Offset = "0x365E10", Length = "0x8")]
  public void Kick()
  {
  }

  [Token(Token = "0x60001E5")]
  [Address(RVA = "0x3668D0", Offset = "0x3654D0", Length = "0x933")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x60001E6")]
  [Address(RVA = "0x3674F0", Offset = "0x3660F0", Length = "0xE3")]
  public SkatingAnimations()
  {
  }
}
