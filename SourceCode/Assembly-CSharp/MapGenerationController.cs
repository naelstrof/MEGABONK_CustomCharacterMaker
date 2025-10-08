// Decompiled with JetBrains decompiler
// Type: MapGenerationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections;
using UnityEngine;

[Token(Token = "0x2000078")]
public class MapGenerationController : MonoBehaviour
{
  [Token(Token = "0x40003A7")]
  [FieldOffset(Offset = "0x20")]
  public MapData testMapData;
  [Token(Token = "0x40003A8")]
  [FieldOffset(Offset = "0x28")]
  public StageData testStageData;
  [Token(Token = "0x40003A9")]
  [FieldOffset(Offset = "0x30")]
  public ProceduralTileGeneration proceduralTileGeneration;
  [Token(Token = "0x40003AA")]
  [FieldOffset(Offset = "0x38")]
  public RandomObjectPlacer randomObjectPlacer;
  [Token(Token = "0x40003AB")]
  [FieldOffset(Offset = "0x40")]
  public GenerateTileObjects RandomTileObjects;
  [Token(Token = "0x40003AC")]
  [FieldOffset(Offset = "0x48")]
  public MinimapMesh minimapMesh;
  [Token(Token = "0x40003AD")]
  [FieldOffset(Offset = "0x50")]
  public GameObject colliderBox;
  [Token(Token = "0x40003AE")]
  [FieldOffset(Offset = "0x58")]
  public GameObject spawnPortal;
  [Token(Token = "0x40003AF")]
  [FieldOffset(Offset = "0x60")]
  public GameObject bossPortal;
  [Token(Token = "0x40003B0")]
  [FieldOffset(Offset = "0x68")]
  public GameObject spawnPlatform;
  [Token(Token = "0x40003B1")]
  [FieldOffset(Offset = "0x70")]
  public GameObject bossPortalFinal;
  [Token(Token = "0x40003B2")]
  [FieldOffset(Offset = "0x78")]
  public GameManager gameManager;
  [Token(Token = "0x40003B3")]
  [FieldOffset(Offset = "0x80")]
  public SpawnInteractables interactablesSpawner;
  [Token(Token = "0x40003B4")]
  [FieldOffset(Offset = "0x88")]
  public GrassChunkManager grassRenderer;
  [Token(Token = "0x40003B5")]
  [FieldOffset(Offset = "0x90")]
  public MapEdges mapEdges;
  [Token(Token = "0x40003B6")]
  [FieldOffset(Offset = "0x98")]
  public MeshRenderer proceduralMeshRenderer;
  [Token(Token = "0x40003B7")]
  [FieldOffset(Offset = "0xA0")]
  public Water water;
  [Token(Token = "0x40003B8")]
  [FieldOffset(Offset = "0xA8")]
  public GameObject proceduralMapWorldEdges;
  [Token(Token = "0x40003B9")]
  [FieldOffset(Offset = "0xB0")]
  public MapGenerator proceduralMapMeshGenerator;
  [Token(Token = "0x40003BA")]
  public static Action A_GenerationComplete;
  [Token(Token = "0x40003BB")]
  public static bool isGenerating;

  [Token(Token = "0x60002FF")]
  [Address(RVA = "0x469390", Offset = "0x467F90", Length = "0x12C")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000300")]
  [Address(RVA = "0x4694C0", Offset = "0x4680C0", Length = "0x67")]
  private IEnumerator GenerateMap() => (IEnumerator) null;

  [Token(Token = "0x6000301")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MapGenerationController()
  {
  }
}
