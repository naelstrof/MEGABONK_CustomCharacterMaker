// Decompiled with JetBrains decompiler
// Type: ProceduralTileGeneration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.MapGeneration.ProceduralTiles;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000F5")]
public class ProceduralTileGeneration : MonoBehaviour
{
  [Token(Token = "0x40007BA")]
  [FieldOffset(Offset = "0x20")]
  public int debugSeed;
  [Token(Token = "0x40007BB")]
  [FieldOffset(Offset = "0x28")]
  public GameObject stairsMesh;
  [Token(Token = "0x40007BC")]
  [FieldOffset(Offset = "0x30")]
  public GameObject flatTile;
  [Token(Token = "0x40007BD")]
  [FieldOffset(Offset = "0x38")]
  public GameObject slopeTile;
  [Token(Token = "0x40007BE")]
  [FieldOffset(Offset = "0x40")]
  public GameObject ceilingTile;
  [Token(Token = "0x40007BF")]
  [FieldOffset(Offset = "0x48")]
  public GameObject wallFlat;
  [Token(Token = "0x40007C0")]
  [FieldOffset(Offset = "0x50")]
  public GameObject wallLeftUp;
  [Token(Token = "0x40007C1")]
  [FieldOffset(Offset = "0x58")]
  public GameObject wallLeftDown;
  [Token(Token = "0x40007C2")]
  [FieldOffset(Offset = "0x60")]
  public GameObject wallLeftCross;
  [Token(Token = "0x40007C3")]
  [FieldOffset(Offset = "0x68")]
  public List<GameObject> tiles;
  [Token(Token = "0x40007C4")]
  [FieldOffset(Offset = "0x70")]
  public List<GameObject> flatTiles;
  [Token(Token = "0x40007C5")]
  [FieldOffset(Offset = "0x78")]
  public List<GameObject> fillTiles;
  [Token(Token = "0x40007C6")]
  [FieldOffset(Offset = "0x80")]
  public GameObject collider;
  [Token(Token = "0x40007C7")]
  [FieldOffset(Offset = "0x88")]
  private StageData currentStage;
  [Token(Token = "0x40007C8")]
  [FieldOffset(Offset = "0x90")]
  private MapParameters currentMapParameters;
  [Token(Token = "0x40007C9")]
  [FieldOffset(Offset = "0x98")]
  public StageData testStage;
  [Token(Token = "0x40007CA")]
  [FieldOffset(Offset = "0xA0")]
  public MapParameters testMapParameters;
  [Token(Token = "0x40007CB")]
  [FieldOffset(Offset = "0xA8")]
  public GameObject newRoot;
  [Token(Token = "0x40007CC")]
  [FieldOffset(Offset = "0xB0")]
  public GameObject tilesParent;
  [Token(Token = "0x40007CD")]
  [FieldOffset(Offset = "0xB8")]
  public ProceduralTile[][] proceduralTiles;

  [Token(Token = "0x600068C")]
  [Address(RVA = "0x4A37E0", Offset = "0x4A23E0", Length = "0x7A4")]
  public Vector3 Generate(
    out Vector3 firstTileDirection,
    StageData stageData,
    MapParameters mapParameters,
    bool useDebugSeed = false)
  {
    firstTileDirection = new Vector3();
    return new Vector3();
  }

  [Token(Token = "0x600068D")]
  [Address(RVA = "0x4A5010", Offset = "0x4A3C10", Length = "0xAE")]
  public Vector3 TilePositionToWorldPosition(Vector2Int pos) => new Vector3();

  [Token(Token = "0x600068E")]
  [Address(RVA = "0x4A31C0", Offset = "0x4A1DC0", Length = "0x236")]
  public void FillHoles()
  {
  }

  [Token(Token = "0x600068F")]
  [Address(RVA = "0x4A2810", Offset = "0x4A1410", Length = "0x9A6")]
  private void FillHole(Vector2Int pos1, Vector2Int pos2)
  {
  }

  [Token(Token = "0x6000690")]
  [Address(RVA = "0x4A35B0", Offset = "0x4A21B0", Length = "0x225")]
  private void FillWallSlopeToFlat(
    int heightDifference,
    Vector2Int position,
    int height,
    Vector2Int globalDir,
    bool isFirstPieceSloped,
    bool useEdgeTextures = false)
  {
  }

  [Token(Token = "0x6000691")]
  [Address(RVA = "0x4A3400", Offset = "0x4A2000", Length = "0x1AC")]
  private void FillWallSlopToSlop(
    int heightDifference,
    Vector2Int position,
    int height,
    Vector2Int globalDir)
  {
  }

  [Token(Token = "0x6000692")]
  [Address(RVA = "0x4A48A0", Offset = "0x4A34A0", Length = "0x6E2")]
  public GameObject InstantiateTile(
    Vector2Int pos,
    int height,
    GameObject tilePrefab,
    Vector3 direction)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x6000693")]
  [Address(RVA = "0x4A4F90", Offset = "0x4A3B90", Length = "0x7B")]
  public GameObject InstantiateTile(Vector2Int pos, int height, int yDir, Vector2Int direction) => (GameObject) null;

  [Token(Token = "0x6000694")]
  [Address(RVA = "0x4A4560", Offset = "0x4A3160", Length = "0x33B")]
  private void InstantiateFillTile(
    Vector2Int pos,
    int height,
    GameObject tilePrefab,
    Vector2Int direction,
    Vector2Int globalDirection,
    EFillType fillType,
    bool flip = false,
    bool useEdgeTexture = false)
  {
  }

  [Token(Token = "0x6000695")]
  [Address(RVA = "0x4A27C0", Offset = "0x4A13C0", Length = "0x4C")]
  private void FillEdges()
  {
  }

  [Token(Token = "0x6000696")]
  [Address(RVA = "0x4A1C70", Offset = "0x4A0870", Length = "0x3C0")]
  private void FillEdgesIsland()
  {
  }

  [Token(Token = "0x6000697")]
  [Address(RVA = "0x4A2250", Offset = "0x4A0E50", Length = "0x568")]
  private void FillEdgesWalls()
  {
  }

  [Token(Token = "0x6000698")]
  [Address(RVA = "0x4A2040", Offset = "0x4A0C40", Length = "0x206")]
  private void FillEdgesTrees()
  {
  }

  [Token(Token = "0x6000699")]
  [Address(RVA = "0x4A1860", Offset = "0x4A0460", Length = "0x404")]
  private void FillEdge(
    Vector2Int pos1,
    int desiredHeightOffset,
    bool isFacingOut,
    Vector2Int dir,
    bool useEdgeTextures = false)
  {
  }

  [Token(Token = "0x600069A")]
  [Address(RVA = "0x4A3F90", Offset = "0x4A2B90", Length = "0x84")]
  private Vector3 GetMapToZeroPositionOffset() => new Vector3();

  [Token(Token = "0x600069B")]
  [Address(RVA = "0x4A42B0", Offset = "0x4A2EB0", Length = "0x2AF")]
  public Vector3 GetWorldSize() => new Vector3();

  [Token(Token = "0x600069C")]
  [Address(RVA = "0x4A4020", Offset = "0x4A2C20", Length = "0x288")]
  public Vector3 GetWorldCenter() => new Vector3();

  [Token(Token = "0x600069D")]
  [Address(RVA = "0x4A1740", Offset = "0x4A0340", Length = "0x119")]
  private void ClearTiles()
  {
  }

  [Token(Token = "0x600069E")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ProceduralTileGeneration()
  {
  }
}
