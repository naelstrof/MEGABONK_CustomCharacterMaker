// Decompiled with JetBrains decompiler
// Type: TextureGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000EF")]
public static class TextureGenerator
{
  [Token(Token = "0x6000670")]
  [Address(RVA = "0x4AF750", Offset = "0x4AE350", Length = "0xBE")]
  public static Texture2D textureFromColorMap(Color[] colorMap, int width, int height) => (Texture2D) null;

  [Token(Token = "0x6000671")]
  [Address(RVA = "0x4AF5A0", Offset = "0x4AE1A0", Length = "0x1A2")]
  public static Texture2D TextureFromHeightMap(float[,] heightMap) => (Texture2D) null;

  [Token(Token = "0x6000672")]
  [Address(RVA = "0x4AF2E0", Offset = "0x4ADEE0", Length = "0x20B")]
  public static Texture2D ColorTextureFromHeightMap(float[,] heightMap, TextureData textureData) => (Texture2D) null;

  [Token(Token = "0x6000673")]
  [Address(RVA = "0x4AF4F0", Offset = "0x4AE0F0", Length = "0xAA")]
  public static Color GetColor(float height, TextureData textureData) => new Color();
}
