// Decompiled with JetBrains decompiler
// Type: NoiseData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu]
[Token(Token = "0x20000E0")]
public class NoiseData : UpdateableData
{
  [Token(Token = "0x400076A")]
  [FieldOffset(Offset = "0x28")]
  public float noiseScale;
  [Range(1f, 20f)]
  [Token(Token = "0x400076B")]
  [FieldOffset(Offset = "0x2C")]
  public int octaves;
  [Range(0.0f, 1f)]
  [Token(Token = "0x400076C")]
  [FieldOffset(Offset = "0x30")]
  public float persistance;
  [Token(Token = "0x400076D")]
  [FieldOffset(Offset = "0x34")]
  public float lacunarity;
  [Token(Token = "0x400076E")]
  [FieldOffset(Offset = "0x38")]
  public float blend;
  [Token(Token = "0x400076F")]
  [FieldOffset(Offset = "0x3C")]
  public float blendStrength;
  [Token(Token = "0x4000770")]
  [FieldOffset(Offset = "0x40")]
  public int seed;
  [Token(Token = "0x4000771")]
  [FieldOffset(Offset = "0x44")]
  public Vector2 offset;

  [Token(Token = "0x6000643")]
  [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
  public NoiseData()
  {
  }
}
