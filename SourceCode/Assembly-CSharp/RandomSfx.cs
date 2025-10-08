// Decompiled with JetBrains decompiler
// Type: RandomSfx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200002D")]
public class RandomSfx : MonoBehaviour
{
  [Token(Token = "0x400017F")]
  [FieldOffset(Offset = "0x20")]
  public AudioClip[] sounds;
  [Range(0.0f, 3f)]
  [Token(Token = "0x4000180")]
  [FieldOffset(Offset = "0x28")]
  public float maxPitch;
  [Range(0.0f, 3f)]
  [Token(Token = "0x4000181")]
  [FieldOffset(Offset = "0x2C")]
  public float minPitch;
  [Token(Token = "0x4000182")]
  [FieldOffset(Offset = "0x30")]
  public float randomVolume;
  [Token(Token = "0x4000183")]
  [FieldOffset(Offset = "0x38")]
  public AudioSource s;
  [Token(Token = "0x4000184")]
  [FieldOffset(Offset = "0x40")]
  public bool playOnAwake;
  [Token(Token = "0x4000185")]
  [FieldOffset(Offset = "0x44")]
  private float defaultVolume;

  [Token(Token = "0x600015E")]
  [Address(RVA = "0x364F70", Offset = "0x363B70", Length = "0x37")]
  private void Awake()
  {
  }

  [Token(Token = "0x600015F")]
  [Address(RVA = "0x364FB0", Offset = "0x363BB0", Length = "0xE6")]
  private void Init()
  {
  }

  [Token(Token = "0x6000160")]
  [Address(RVA = "0x365130", Offset = "0x363D30", Length = "0x154")]
  public void Play(float delay = 0.0f, float volumeMultiplier = 1f)
  {
  }

  [Token(Token = "0x6000161")]
  [Address(RVA = "0x365290", Offset = "0x363E90", Length = "0x1D")]
  public void Stop()
  {
  }

  [Token(Token = "0x6000162")]
  [Address(RVA = "0x3650A0", Offset = "0x363CA0", Length = "0x89")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x6000163")]
  [Address(RVA = "0x3652B0", Offset = "0x363EB0", Length = "0x27")]
  public RandomSfx()
  {
  }
}
