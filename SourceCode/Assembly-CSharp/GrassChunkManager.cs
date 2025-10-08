// Decompiled with JetBrains decompiler
// Type: GrassChunkManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x2000006")]
public class GrassChunkManager : MonoBehaviour
{
  [Token(Token = "0x4000008")]
  [FieldOffset(Offset = "0x20")]
  public Mesh grassMesh;
  [Token(Token = "0x4000009")]
  [FieldOffset(Offset = "0x28")]
  public Material grassMaterial;
  [Token(Token = "0x400000A")]
  [FieldOffset(Offset = "0x30")]
  public int grassPerChunk;
  [Token(Token = "0x400000B")]
  [FieldOffset(Offset = "0x34")]
  public int chunkSize;
  [Token(Token = "0x400000C")]
  [FieldOffset(Offset = "0x38")]
  public int renderDistance;
  [Token(Token = "0x400000D")]
  [FieldOffset(Offset = "0x3C")]
  public float yThreshold;
  [Token(Token = "0x400000E")]
  [FieldOffset(Offset = "0x40")]
  public LayerMask layerMask;
  [Token(Token = "0x400000F")]
  [FieldOffset(Offset = "0x44")]
  public bool testWithoutPlayer;
  [Token(Token = "0x4000010")]
  [FieldOffset(Offset = "0x48")]
  private int currentGrassPerChunk;
  [Token(Token = "0x4000011")]
  [FieldOffset(Offset = "0x4C")]
  private Vector2Int currentChunk;
  [Token(Token = "0x4000012")]
  [FieldOffset(Offset = "0x58")]
  private Dictionary<Vector2Int, List<GrassChunkManager.GrassInstance>> precomputedGrassPositions;
  [Token(Token = "0x4000013")]
  [FieldOffset(Offset = "0x60")]
  private List<GrassChunkManager.GrassData> allGrassDataList;
  [Token(Token = "0x4000014")]
  [FieldOffset(Offset = "0x68")]
  private ComputeBuffer allGrassBuffer;
  [Token(Token = "0x4000015")]
  [FieldOffset(Offset = "0x70")]
  private ComputeBuffer argsBuffer;
  [Token(Token = "0x4000016")]
  [FieldOffset(Offset = "0x78")]
  private readonly uint[] args;

  [Token(Token = "0x6000008")]
  [Address(RVA = "0x33F900", Offset = "0x33E500", Length = "0x2B")]
  public void Set(Material material, int grassPerChunk)
  {
  }

  [Token(Token = "0x6000009")]
  [Address(RVA = "0x33E340", Offset = "0x33CF40", Length = "0x1AC")]
  private void Awake()
  {
  }

  [Token(Token = "0x600000A")]
  [Address(RVA = "0x33F930", Offset = "0x33E530", Length = "0x113")]
  private void Start()
  {
  }

  [Token(Token = "0x600000B")]
  [Address(RVA = "0x33FF30", Offset = "0x33EB30", Length = "0x41E")]
  private void Update()
  {
  }

  [Token(Token = "0x600000C")]
  [Address(RVA = "0x33E910", Offset = "0x33D510", Length = "0x10B")]
  private Vector2Int GetPlayerChunk() => new Vector2Int();

  [Token(Token = "0x600000D")]
  [Address(RVA = "0x33FA50", Offset = "0x33E650", Length = "0x431")]
  private void UpdateChunks()
  {
  }

  [Token(Token = "0x600000E")]
  [Address(RVA = "0x33E4F0", Offset = "0x33D0F0", Length = "0x41C")]
  private void GenerateGrassForChunk(Vector2Int chunkCoord)
  {
  }

  [Token(Token = "0x600000F")]
  [Address(RVA = "0x33F140", Offset = "0x33DD40", Length = "0x58F")]
  private void RebuildGrassBuffer()
  {
  }

  [Token(Token = "0x6000010")]
  [Address(RVA = "0x33F6D0", Offset = "0x33E2D0", Length = "0x226")]
  private void RenderGrass()
  {
  }

  [Token(Token = "0x6000011")]
  [Address(RVA = "0x33EA20", Offset = "0x33D620", Length = "0x202")]
  private bool GetTerrainHeight(float x, float z, out float height)
  {
    height = new float();
    return false;
  }

  [Token(Token = "0x6000012")]
  [Address(RVA = "0x33FE90", Offset = "0x33EA90", Length = "0x98")]
  private void UpdateGrassQuality(int quality)
  {
  }

  [Token(Token = "0x6000013")]
  [Address(RVA = "0x33F0A0", Offset = "0x33DCA0", Length = "0x93")]
  private void OnSettingUpdated(string setting, object oldValue, object newValue)
  {
  }

  [Token(Token = "0x6000014")]
  [Address(RVA = "0x33EC30", Offset = "0x33D830", Length = "0x165")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000015")]
  [Address(RVA = "0x33EDA0", Offset = "0x33D9A0", Length = "0x2F5")]
  private void OnDrawGizmos()
  {
  }

  [Token(Token = "0x6000016")]
  [Address(RVA = "0x340350", Offset = "0x33EF50", Length = "0x106")]
  public GrassChunkManager()
  {
  }

  [Token(Token = "0x2000007")]
  private struct GrassInstance
  {
    [Token(Token = "0x4000017")]
    [FieldOffset(Offset = "0x0")]
    public Vector3 position;
    [Token(Token = "0x4000018")]
    [FieldOffset(Offset = "0xC")]
    public float rotationY;
  }

  [Token(Token = "0x2000008")]
  private struct GrassData
  {
    [Token(Token = "0x4000019")]
    [FieldOffset(Offset = "0x0")]
    public Matrix4x4 transform;
  }
}
