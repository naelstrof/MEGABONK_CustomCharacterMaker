// Decompiled with JetBrains decompiler
// Type: AttackMuzzle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000B3")]
public class AttackMuzzle : MonoBehaviour
{
  [Token(Token = "0x400059E")]
  [FieldOffset(Offset = "0x20")]
  public RandomSfx randomSfx;
  [Token(Token = "0x400059F")]
  [FieldOffset(Offset = "0x28")]
  public ParticleSystem ps;
  [Token(Token = "0x40005A0")]
  [FieldOffset(Offset = "0x30")]
  private float cliplength;
  [Token(Token = "0x40005A1")]
  [FieldOffset(Offset = "0x34")]
  private float volumeMultiplier;
  [Token(Token = "0x40005A2")]
  [FieldOffset(Offset = "0x38")]
  public float minVolumeMultiplier;
  [Token(Token = "0x40005A3")]
  [FieldOffset(Offset = "0x3C")]
  public float maxInterval;
  [Token(Token = "0x40005A4")]
  [FieldOffset(Offset = "0x40")]
  public float minAudioCooldown;
  [Token(Token = "0x40005A5")]
  [FieldOffset(Offset = "0x44")]
  private float lastPlayedTime;

  [Token(Token = "0x6000484")]
  [Address(RVA = "0x475420", Offset = "0x474020", Length = "0xF3")]
  public void Set(int quantity, float burstInterval)
  {
  }

  [Token(Token = "0x6000485")]
  [Address(RVA = "0x475320", Offset = "0x473F20", Length = "0xF1")]
  public void Play()
  {
  }

  [Token(Token = "0x6000486")]
  [Address(RVA = "0x4752A0", Offset = "0x473EA0", Length = "0x74")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x6000487")]
  [Address(RVA = "0x475520", Offset = "0x474120", Length = "0x23")]
  public AttackMuzzle()
  {
  }
}
