// Decompiled with JetBrains decompiler
// Type: Explosion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using MilkShake;
using UnityEngine;

[Token(Token = "0x20000A6")]
public class Explosion : MonoBehaviour
{
  [Token(Token = "0x4000524")]
  [FieldOffset(Offset = "0x20")]
  private Material material;
  [Token(Token = "0x4000525")]
  [FieldOffset(Offset = "0x28")]
  public ShakePreset shakePreset;
  [Token(Token = "0x4000526")]
  [FieldOffset(Offset = "0x30")]
  public GameObject explosionFx;
  [Token(Token = "0x4000527")]
  [FieldOffset(Offset = "0x38")]
  private float time;
  [Token(Token = "0x4000528")]
  [FieldOffset(Offset = "0x3C")]
  private Vector3 desiredSize;
  [Token(Token = "0x4000529")]
  [FieldOffset(Offset = "0x48")]
  private float myTime;

  [Token(Token = "0x6000425")]
  [Address(RVA = "0x475AD0", Offset = "0x4746D0", Length = "0xB9")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000426")]
  [Address(RVA = "0x475E80", Offset = "0x474A80", Length = "0x85")]
  private void Start()
  {
  }

  [Token(Token = "0x6000427")]
  [Address(RVA = "0x475E30", Offset = "0x474A30", Length = "0x4D")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000428")]
  [Address(RVA = "0x475B90", Offset = "0x474790", Length = "0x299")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000429")]
  [Address(RVA = "0x475F10", Offset = "0x474B10", Length = "0xE")]
  public Explosion()
  {
  }
}
