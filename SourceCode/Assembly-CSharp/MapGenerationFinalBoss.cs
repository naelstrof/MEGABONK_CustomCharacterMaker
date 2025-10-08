// Decompiled with JetBrains decompiler
// Type: MapGenerationFinalBoss
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using UnityEngine;

[Token(Token = "0x2000072")]
public class MapGenerationFinalBoss : MonoBehaviour
{
  [Token(Token = "0x4000385")]
  [FieldOffset(Offset = "0x20")]
  public MapData testMapData;
  [Token(Token = "0x4000386")]
  [FieldOffset(Offset = "0x28")]
  public StageData testStageData;
  [Token(Token = "0x4000387")]
  [FieldOffset(Offset = "0x30")]
  public GameManager gameManager;
  [Token(Token = "0x4000388")]
  [FieldOffset(Offset = "0x38")]
  public Transform spawnTransform;
  [Token(Token = "0x4000389")]
  [FieldOffset(Offset = "0x40")]
  public GrassChunkManager grassRenderer;
  [Token(Token = "0x400038A")]
  [FieldOffset(Offset = "0x48")]
  public GameObject colliderBox;
  [Token(Token = "0x400038B")]
  [FieldOffset(Offset = "0x50")]
  public MinimapMesh minimapMesh;
  [Token(Token = "0x400038C")]
  [FieldOffset(Offset = "0x58")]
  public GameObject spawnPortal;
  [Token(Token = "0x400038D")]
  [FieldOffset(Offset = "0x60")]
  public MeshRenderer worldMeshRenderer;
  [Token(Token = "0x400038E")]
  [FieldOffset(Offset = "0x68")]
  public MeshFilter worldMeshFilter;
  [Token(Token = "0x400038F")]
  [FieldOffset(Offset = "0x70")]
  public MeshRenderer[] renderersForMaterial;
  [Token(Token = "0x4000390")]
  [FieldOffset(Offset = "0x78")]
  private Vector3 spawnPosition;
  [Token(Token = "0x4000391")]
  [FieldOffset(Offset = "0x84")]
  private Vector3 spawnDirection;

  [Token(Token = "0x60002E8")]
  [Address(RVA = "0x469530", Offset = "0x468130", Length = "0x71")]
  private void Awake()
  {
  }

  [Token(Token = "0x60002E9")]
  [Address(RVA = "0x4695B0", Offset = "0x4681B0", Length = "0x67")]
  private IEnumerator GenerateMap() => (IEnumerator) null;

  [Token(Token = "0x60002EA")]
  [Address(RVA = "0x469620", Offset = "0x468220", Length = "0x13D")]
  public GameObject Spawn() => (GameObject) null;

  [Token(Token = "0x60002EB")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MapGenerationFinalBoss()
  {
  }
}
