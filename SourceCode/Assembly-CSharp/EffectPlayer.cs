// Decompiled with JetBrains decompiler
// Type: EffectPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000101")]
public class EffectPlayer : MonoBehaviour
{
  [Token(Token = "0x40007ED")]
  [FieldOffset(Offset = "0x20")]
  public float psMinInterval;
  [Token(Token = "0x40007EE")]
  [FieldOffset(Offset = "0x28")]
  public ParticleSystem ps;
  [Token(Token = "0x40007EF")]
  [FieldOffset(Offset = "0x30")]
  public AudioSpamFilter audioSpamFilter;
  [Token(Token = "0x40007F0")]
  [FieldOffset(Offset = "0x38")]
  public RandomSfx randomSfx;
  [Token(Token = "0x40007F1")]
  [FieldOffset(Offset = "0x40")]
  private float nextPlayTime;
  [Token(Token = "0x40007F2")]
  [FieldOffset(Offset = "0x44")]
  public bool playOnEnable;

  [Token(Token = "0x60006BD")]
  [Address(RVA = "0x4B57E0", Offset = "0x4B43E0", Length = "0x14B")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60006BE")]
  [Address(RVA = "0x4B5A70", Offset = "0x4B4670", Length = "0x141")]
  public void Play()
  {
  }

  [Token(Token = "0x60006BF")]
  [Address(RVA = "0x4B5930", Offset = "0x4B4530", Length = "0x133")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x60006C0")]
  [Address(RVA = "0x4B5BC0", Offset = "0x4B47C0", Length = "0xE")]
  public EffectPlayer()
  {
  }
}
