// Decompiled with JetBrains decompiler
// Type: TextureData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

[CreateAssetMenu]
[Token(Token = "0x20000E2")]
public class TextureData : UpdatableData
{
  [Token(Token = "0x4000776")]
  private const int textureSize = 512;
  [Token(Token = "0x4000777")]
  private const TextureFormat textureFormat = TextureFormat.RGB565;
  [Token(Token = "0x4000778")]
  [FieldOffset(Offset = "0x28")]
  public TextureData.Layer[] layers;
  [Token(Token = "0x4000779")]
  [FieldOffset(Offset = "0x30")]
  private float savedMinHeight;
  [Token(Token = "0x400077A")]
  [FieldOffset(Offset = "0x34")]
  private float savedMaxHeight;

  [Token(Token = "0x6000647")]
  [Address(RVA = "0x4AEA10", Offset = "0x4AD610", Length = "0x78C")]
  public void ApplyToMaterial(Material material)
  {
  }

  [Token(Token = "0x6000648")]
  [Address(RVA = "0x4AF2D0", Offset = "0x4ADED0", Length = "0xB")]
  public void UpdateMeshHeights(float minHeight, float maxHeight)
  {
  }

  [Token(Token = "0x6000649")]
  [Address(RVA = "0x4AF1A0", Offset = "0x4ADDA0", Length = "0x120")]
  private Texture2DArray GenerateTextureArray(Texture2D[] textures) => (Texture2DArray) null;

  [Token(Token = "0x600064A")]
  [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
  public TextureData()
  {
  }

  [Token(Token = "0x20000E3")]
  [Serializable]
  public class Layer
  {
    [Token(Token = "0x400077B")]
    [FieldOffset(Offset = "0x10")]
    public Texture2D texture;
    [Token(Token = "0x400077C")]
    [FieldOffset(Offset = "0x18")]
    public Color tint;
    [Range(0.0f, 1f)]
    [Token(Token = "0x400077D")]
    [FieldOffset(Offset = "0x28")]
    public float tintStrength;
    [Range(0.0f, 1f)]
    [Token(Token = "0x400077E")]
    [FieldOffset(Offset = "0x2C")]
    public float startHeight;
    [Range(0.0f, 1f)]
    [Token(Token = "0x400077F")]
    [FieldOffset(Offset = "0x30")]
    public float blendStrength;
    [Token(Token = "0x4000780")]
    [FieldOffset(Offset = "0x34")]
    public float textureScale;
    [Token(Token = "0x4000781")]
    [FieldOffset(Offset = "0x38")]
    public TextureData.TerrainType type;

    [Token(Token = "0x600064B")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public Layer()
    {
    }
  }

  [Token(Token = "0x20000E4")]
  public enum TerrainType
  {
    [Token(Token = "0x4000783")] Water,
    [Token(Token = "0x4000784")] Sand,
    [Token(Token = "0x4000785")] Grass,
  }
}
