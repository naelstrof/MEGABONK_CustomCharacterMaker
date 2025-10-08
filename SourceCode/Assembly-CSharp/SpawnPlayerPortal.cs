// Decompiled with JetBrains decompiler
// Type: SpawnPlayerPortal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections;
using UnityEngine;

[Token(Token = "0x2000048")]
public class SpawnPlayerPortal : MonoBehaviour
{
  [Token(Token = "0x400023F")]
  [FieldOffset(Offset = "0x20")]
  public AudioSource audioOpen;
  [Token(Token = "0x4000240")]
  [FieldOffset(Offset = "0x28")]
  public AudioSource audioLoop;
  [Token(Token = "0x4000241")]
  [FieldOffset(Offset = "0x30")]
  public AudioSource audioClose;
  [Token(Token = "0x4000242")]
  [FieldOffset(Offset = "0x38")]
  public AudioSource audioPassing;
  [Token(Token = "0x4000243")]
  [FieldOffset(Offset = "0x40")]
  public GameObject blockObjectSpawns;
  [Token(Token = "0x4000244")]
  [FieldOffset(Offset = "0x48")]
  public Transform portalRender;
  [Token(Token = "0x4000245")]
  [FieldOffset(Offset = "0x50")]
  private Vector3 portalScale;
  [Token(Token = "0x4000246")]
  [FieldOffset(Offset = "0x60")]
  public ParticleSystem passingFx;
  [Token(Token = "0x4000247")]
  public static Action A_PortalOpen;
  [Token(Token = "0x4000248")]
  public static Action A_PortalClosed;
  [Token(Token = "0x4000249")]
  [FieldOffset(Offset = "0x68")]
  private bool movePlayer;
  [Token(Token = "0x400024A")]
  [FieldOffset(Offset = "0x6C")]
  private float moveTime;
  [Token(Token = "0x400024B")]
  [FieldOffset(Offset = "0x70")]
  private float moveTimer;
  [Token(Token = "0x400024C")]
  [FieldOffset(Offset = "0x74")]
  private Vector3 playerStartPosition;
  [Token(Token = "0x400024D")]
  [FieldOffset(Offset = "0x80")]
  private Vector3 desiredPosition;
  [Token(Token = "0x400024E")]
  [FieldOffset(Offset = "0x8C")]
  private float openTime;
  [Token(Token = "0x400024F")]
  [FieldOffset(Offset = "0x90")]
  private float scaleTimer;
  [Token(Token = "0x4000250")]
  [FieldOffset(Offset = "0x94")]
  private bool open;

  [Token(Token = "0x60001E7")]
  [Address(RVA = "0x367830", Offset = "0x366430", Length = "0x71")]
  public void StartPortal()
  {
  }

  [Token(Token = "0x60001E8")]
  [Address(RVA = "0x3675E0", Offset = "0x3661E0", Length = "0x67")]
  private IEnumerator DoPortal() => (IEnumerator) null;

  [Token(Token = "0x60001E9")]
  [Address(RVA = "0x367810", Offset = "0x366410", Length = "0x1A")]
  private void PassShake()
  {
  }

  [Token(Token = "0x60001EA")]
  [Address(RVA = "0x367650", Offset = "0x366250", Length = "0x1B0")]
  private void MovePlayer()
  {
  }

  [Token(Token = "0x60001EB")]
  [Address(RVA = "0x3678B0", Offset = "0x3664B0", Length = "0x3A2")]
  private void Update()
  {
  }

  [Token(Token = "0x60001EC")]
  [Address(RVA = "0x339A90", Offset = "0x338690", Length = "0x1D")]
  private void ClosePortal()
  {
  }

  [Token(Token = "0x60001ED")]
  [Address(RVA = "0x367C60", Offset = "0x366860", Length = "0x18")]
  public SpawnPlayerPortal()
  {
  }
}
