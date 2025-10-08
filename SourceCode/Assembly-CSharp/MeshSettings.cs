// Decompiled with JetBrains decompiler
// Type: MeshSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu]
[Token(Token = "0x20000DF")]
public class MeshSettings : UpdatableData
{
  [Token(Token = "0x4000762")]
  public const int numSupportedLODs = 5;
  [Token(Token = "0x4000763")]
  public const int numSupportedChunkSizes = 9;
  [Token(Token = "0x4000764")]
  public const int numSupportedFlatshadedChunkSizes = 3;
  [Token(Token = "0x4000765")]
  public static readonly int[] supportedChunkSizes;
  [Token(Token = "0x4000766")]
  [FieldOffset(Offset = "0x28")]
  public float meshScale;
  [Token(Token = "0x4000767")]
  [FieldOffset(Offset = "0x2C")]
  public bool useFlatShading;
  [Range(0.0f, 8f)]
  [Token(Token = "0x4000768")]
  [FieldOffset(Offset = "0x30")]
  public int chunkSizeIndex;
  [Range(0.0f, 2f)]
  [Token(Token = "0x4000769")]
  [FieldOffset(Offset = "0x34")]
  public int flatshadedChunkSizeIndex;

  [Token(Token = "0x17000034")]
  public int numVertsPerLine
  {
    [Token(Token = "0x600063F"), Address(RVA = "0x4A0470", Offset = "0x49F070", Length = "0x80")] get => 0;
  }

  [Token(Token = "0x17000035")]
  public float meshWorldSize
  {
    [Token(Token = "0x6000640"), Address(RVA = "0x4A03E0", Offset = "0x49EFE0", Length = "0x8C")] get => 0.0f;
  }

  [Token(Token = "0x6000641")]
  [Address(RVA = "0x4A03D0", Offset = "0x49EFD0", Length = "0xE")]
  public MeshSettings()
  {
  }

  [Token(Token = "0x6000642")]
  [Address(RVA = "0x4A0340", Offset = "0x49EF40", Length = "0x8C")]
  static MeshSettings()
  {
  }
}
