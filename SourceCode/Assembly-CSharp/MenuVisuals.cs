// Decompiled with JetBrains decompiler
// Type: MenuVisuals
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.MapsAndStages;
using Assets.Scripts.Game.Other;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000DB")]
public class MenuVisuals : MonoBehaviour
{
  [Token(Token = "0x4000741")]
  [FieldOffset(Offset = "0x20")]
  public Terrain terrain;
  [Token(Token = "0x4000742")]
  [FieldOffset(Offset = "0x28")]
  public GrassChunkManager grassRenderer;
  [Token(Token = "0x4000743")]
  [FieldOffset(Offset = "0x30")]
  public StageData defaultStageVisuals;
  [Token(Token = "0x4000744")]
  [FieldOffset(Offset = "0x38")]
  private StageData currentStageData;
  [Token(Token = "0x4000745")]
  [FieldOffset(Offset = "0x40")]
  public Transform camera;
  [Token(Token = "0x4000746")]
  [FieldOffset(Offset = "0x48")]
  public GameObject particles;
  [Token(Token = "0x4000747")]
  [FieldOffset(Offset = "0x50")]
  public GameObject forestBg;
  [Token(Token = "0x4000748")]
  [FieldOffset(Offset = "0x58")]
  public GameObject desertBg;

  [Token(Token = "0x6000624")]
  [Address(RVA = "0x49F750", Offset = "0x49E350", Length = "0x121")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000625")]
  [Address(RVA = "0x49F880", Offset = "0x49E480", Length = "0x121")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000626")]
  [Address(RVA = "0x49F9B0", Offset = "0x49E5B0", Length = "0xA0")]
  private void OnRunConfigChanged(RunConfig runConfig)
  {
  }

  [Token(Token = "0x6000627")]
  [Address(RVA = "0x49FD30", Offset = "0x49E930", Length = "0x10")]
  private void Start()
  {
  }

  [Token(Token = "0x6000628")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void Update()
  {
  }

  [Token(Token = "0x6000629")]
  [Address(RVA = "0x49FA60", Offset = "0x49E660", Length = "0x2C4")]
  public void Set(StageData stageData, EMap map)
  {
  }

  [Token(Token = "0x600062A")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MenuVisuals()
  {
  }
}
