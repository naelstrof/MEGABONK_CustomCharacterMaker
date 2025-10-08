// Decompiled with JetBrains decompiler
// Type: MapGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000EA")]
public class MapGenerator : MonoBehaviour
{
  [Token(Token = "0x4000795")]
  [FieldOffset(Offset = "0x20")]
  public MapGenerator.DrawMode drawMode;
  [Token(Token = "0x4000796")]
  [FieldOffset(Offset = "0x28")]
  public TerrainData terrainData;
  [Token(Token = "0x4000797")]
  [FieldOffset(Offset = "0x30")]
  public NoiseData noiseData;
  [Token(Token = "0x4000798")]
  [FieldOffset(Offset = "0x38")]
  public TextureData textureData;
  [Range(0.0f, 6f)]
  [Token(Token = "0x4000799")]
  [FieldOffset(Offset = "0x40")]
  public int levelOfDetail;
  [Token(Token = "0x400079A")]
  private static int seed;
  [Token(Token = "0x400079B")]
  [FieldOffset(Offset = "0x44")]
  public bool autoUpdate;
  [Token(Token = "0x400079C")]
  [FieldOffset(Offset = "0x48")]
  private float[,] falloffMap;
  [Token(Token = "0x400079E")]
  public static int mapChunkSize;
  [Token(Token = "0x400079F")]
  public static int worldScale;
  [Token(Token = "0x40007A0")]
  [FieldOffset(Offset = "0x58")]
  public GameObject mesh;
  [Token(Token = "0x40007A1")]
  public static MapGenerator Instance;
  [Token(Token = "0x40007A2")]
  public static float[,] staticNoiseMap;
  [Token(Token = "0x40007A3")]
  [FieldOffset(Offset = "0x60")]
  public float[,] heightMap;

  [field: Token(Token = "0x400079D")]
  [field: FieldOffset(Offset = "0x50")]
  [Token(Token = "0x17000038")]
  public MapDisplay display { [Token(Token = "0x600065F"), Address(RVA = "0x36CC90", Offset = "0x36B890", Length = "0x5")] get; [Token(Token = "0x6000660"), Address(RVA = "0x36CCC0", Offset = "0x36B8C0", Length = "0xD")] private set; }

  [Token(Token = "0x6000661")]
  [Address(RVA = "0x49E4C0", Offset = "0x49D0C0", Length = "0x13F")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000662")]
  [Address(RVA = "0x49F1C0", Offset = "0x49DDC0", Length = "0x224")]
  private void OnValuesUpdated()
  {
  }

  [Token(Token = "0x6000663")]
  [Address(RVA = "0x49EA30", Offset = "0x49D630", Length = "0xE9")]
  public void GenerateMap(MapData mapData, StageData stageData, int seed = 105)
  {
  }

  [Token(Token = "0x6000664")]
  [Address(RVA = "0x49E750", Offset = "0x49D350", Length = "0x2DD")]
  public void GenerateMap(int seed = 105)
  {
  }

  [Token(Token = "0x6000665")]
  [Address(RVA = "0x49EDA0", Offset = "0x49D9A0", Length = "0x26B")]
  public float[,] GeneratePerlinNoiseMap(NoiseData noiseData, int seed, bool useFalloffMap) => (float[,]) null;

  [Token(Token = "0x6000666")]
  [Address(RVA = "0x49EB20", Offset = "0x49D720", Length = "0x27B")]
  public float[,] GeneratePerlinNoiseMap(int seed) => (float[,]) null;

  [Token(Token = "0x6000667")]
  [Address(RVA = "0x49E600", Offset = "0x49D200", Length = "0x142")]
  public void DrawMapInEditor()
  {
  }

  [Token(Token = "0x6000668")]
  [Address(RVA = "0x49F010", Offset = "0x49DC10", Length = "0x1A3")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x6000669")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MapGenerator()
  {
  }

  [Token(Token = "0x600066A")]
  [Address(RVA = "0x49F3F0", Offset = "0x49DFF0", Length = "0x63")]
  static MapGenerator()
  {
  }

  [Token(Token = "0x20000EB")]
  public enum DrawMode
  {
    [Token(Token = "0x40007A5")] NoiseMap,
    [Token(Token = "0x40007A6")] Mesh,
    [Token(Token = "0x40007A7")] FalloffMap,
    [Token(Token = "0x40007A8")] ColorMap,
  }
}
