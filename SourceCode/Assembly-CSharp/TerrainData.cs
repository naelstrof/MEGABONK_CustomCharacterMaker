// Decompiled with JetBrains decompiler
// Type: TerrainData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu]
[Token(Token = "0x20000E1")]
public class TerrainData : UpdateableData
{
  [Token(Token = "0x4000772")]
  [FieldOffset(Offset = "0x28")]
  public float uniformScale;
  [Token(Token = "0x4000773")]
  [FieldOffset(Offset = "0x2C")]
  public bool useFalloff;
  [Token(Token = "0x4000774")]
  [FieldOffset(Offset = "0x30")]
  public float heightMultiplier;
  [Token(Token = "0x4000775")]
  [FieldOffset(Offset = "0x38")]
  public AnimationCurve heightCurve;

  [Token(Token = "0x17000036")]
  public float minHeight
  {
    [Token(Token = "0x6000644"), Address(RVA = "0x4AE9C0", Offset = "0x4AD5C0", Length = "0x48")] get => 0.0f;
  }

  [Token(Token = "0x17000037")]
  public float maxHeight
  {
    [Token(Token = "0x6000645"), Address(RVA = "0x4AE970", Offset = "0x4AD570", Length = "0x4D")] get => 0.0f;
  }

  [Token(Token = "0x6000646")]
  [Address(RVA = "0x4A03D0", Offset = "0x49EFD0", Length = "0xE")]
  public TerrainData()
  {
  }
}
