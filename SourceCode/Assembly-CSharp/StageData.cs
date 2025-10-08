// Decompiled with JetBrains decompiler
// Type: StageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.MapGeneration;
using Assets.Scripts.Game.Spawning.New.Timelines;
using Assets.Scripts.MapGeneration.ProceduralTiles;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(menuName = "Me/Mapping/StageData")]
[Token(Token = "0x200021B")]
public class StageData : ScriptableObject
{
  [Header("Meta")]
  [Token(Token = "0x4000ECD")]
  [FieldOffset(Offset = "0x18")]
  public LocalizedString localizedName;
  [Header("Meta")]
  [Token(Token = "0x4000ECE")]
  [FieldOffset(Offset = "0x20")]
  public LocalizedString localizedDescription;
  [SerializeField]
  [Token(Token = "0x4000ECF")]
  [FieldOffset(Offset = "0x28")]
  private string stageName;
  [SerializeField]
  [Token(Token = "0x4000ED0")]
  [FieldOffset(Offset = "0x30")]
  private string stageDescription;
  [Header("Visuals")]
  [Token(Token = "0x4000ED1")]
  [FieldOffset(Offset = "0x38")]
  public MapEdgeFillType mapEdgeFillType;
  [Token(Token = "0x4000ED2")]
  [FieldOffset(Offset = "0x40")]
  public Material waterMaterial;
  [Token(Token = "0x4000ED3")]
  [FieldOffset(Offset = "0x48")]
  public GameObject waterSplashFx;
  [Header("Grass")]
  [Token(Token = "0x4000ED4")]
  [FieldOffset(Offset = "0x50")]
  public Material grassMaterial;
  [Token(Token = "0x4000ED5")]
  [FieldOffset(Offset = "0x58")]
  public int grassPerChunk;
  [Header("TileTextures")]
  [Token(Token = "0x4000ED6")]
  [FieldOffset(Offset = "0x60")]
  public Material[] flatMaterials;
  [Token(Token = "0x4000ED7")]
  [FieldOffset(Offset = "0x68")]
  public Material m_fillMiddle;
  [Token(Token = "0x4000ED8")]
  [FieldOffset(Offset = "0x70")]
  public Material m_fillTop;
  [Token(Token = "0x4000ED9")]
  [FieldOffset(Offset = "0x78")]
  public Material m_fillMiddleEdge;
  [Token(Token = "0x4000EDA")]
  [FieldOffset(Offset = "0x80")]
  public Material m_fillTopEdge;
  [Token(Token = "0x4000EDB")]
  [FieldOffset(Offset = "0x88")]
  public Material m_stairs;
  [Token(Token = "0x4000EDC")]
  [FieldOffset(Offset = "0x90")]
  public Material triplanarMaterial;
  [Token(Token = "0x4000EDD")]
  [FieldOffset(Offset = "0x98")]
  public GameObject particles;
  [Header("Fog And Sky")]
  [Token(Token = "0x4000EDE")]
  [FieldOffset(Offset = "0xA0")]
  public Material skybox;
  [Token(Token = "0x4000EDF")]
  [FieldOffset(Offset = "0xA8")]
  public float fogIntensity;
  [Token(Token = "0x4000EE0")]
  [FieldOffset(Offset = "0xAC")]
  public Color fogColor;
  [Header("Lighting")]
  [Token(Token = "0x4000EE1")]
  [FieldOffset(Offset = "0xBC")]
  public Color ambienceColor;
  [Token(Token = "0x4000EE2")]
  [FieldOffset(Offset = "0xCC")]
  public Color lightColor;
  [Token(Token = "0x4000EE3")]
  [FieldOffset(Offset = "0xDC")]
  public float lightIntensity;
  [Header("Gameplay")]
  [Token(Token = "0x4000EE4")]
  [FieldOffset(Offset = "0xE0")]
  public StageTimeline stageTimeline;
  [Token(Token = "0x4000EE5")]
  [FieldOffset(Offset = "0xE8")]
  public bool isWaterDamage;
  [Header("Map Generation")]
  [Token(Token = "0x4000EE6")]
  [FieldOffset(Offset = "0xF0")]
  public MapParameters mapParameters;
  [Token(Token = "0x4000EE7")]
  [FieldOffset(Offset = "0xF8")]
  public RandomMapObject[] randomMapObjects;
  [Token(Token = "0x4000EE8")]
  [FieldOffset(Offset = "0x100")]
  public StageTilePrefabs stageTilePrefabs;
  [Header("Procedural Mesh Data")]
  [Token(Token = "0x4000EE9")]
  [FieldOffset(Offset = "0x108")]
  public TerrainData proceduralTerrainData;
  [Token(Token = "0x4000EEA")]
  [FieldOffset(Offset = "0x110")]
  public NoiseData proceduralNoiseData;
  [Token(Token = "0x4000EEB")]
  [FieldOffset(Offset = "0x118")]
  public float proceduralMapScale;
  [Token(Token = "0x4000EEC")]
  [FieldOffset(Offset = "0x11C")]
  public float farClipPlane;
  [Header("Challenges")]
  [Token(Token = "0x4000EED")]
  [FieldOffset(Offset = "0x120")]
  public ChallengeData[] challenges;

  [Token(Token = "0x6000DAC")]
  [Address(RVA = "0x51EBA0", Offset = "0x51D7A0", Length = "0x1D")]
  public string GetName() => (string) null;

  [Token(Token = "0x6000DAD")]
  [Address(RVA = "0x52EE70", Offset = "0x52DA70", Length = "0x1D")]
  public string GetDescription() => (string) null;

  [Token(Token = "0x6000DAE")]
  [Address(RVA = "0x52EE90", Offset = "0x52DA90", Length = "0x2B")]
  public Material GetSideMaterial(EFillType eFillType, bool useEdgeTextures = false) => (Material) null;

  [Token(Token = "0x6000DAF")]
  [Address(RVA = "0x52EEC0", Offset = "0x52DAC0", Length = "0x39")]
  public Material GetTopMaterial() => (Material) null;

  [Token(Token = "0x6000DB0")]
  [Address(RVA = "0x52ED60", Offset = "0x52D960", Length = "0x109")]
  public void ApplyFogAndSky()
  {
  }

  [Token(Token = "0x6000DB1")]
  [Address(RVA = "0x52EF00", Offset = "0x52DB00", Length = "0xA4")]
  public GameObject SpawnParticles() => (GameObject) null;

  [Token(Token = "0x6000DB2")]
  [Address(RVA = "0x52EFB0", Offset = "0x52DBB0", Length = "0xA6")]
  public StageData()
  {
  }
}
