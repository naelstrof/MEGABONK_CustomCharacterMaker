// Decompiled with JetBrains decompiler
// Type: GenerateTileObjects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x2000074")]
public class GenerateTileObjects : MonoBehaviour
{
  [Token(Token = "0x4000395")]
  [FieldOffset(Offset = "0x20")]
  public GameObject tileObjectsParent;
  [Token(Token = "0x4000396")]
  [FieldOffset(Offset = "0x28")]
  public GameObject bossSpawner;
  [Token(Token = "0x4000397")]
  [FieldOffset(Offset = "0x30")]
  public GameObject bossSpawnerFinal;

  [Token(Token = "0x60002F2")]
  [Address(RVA = "0x466F60", Offset = "0x465B60", Length = "0x846")]
  public void Generate(List<GameObject> allFlatTiles, StageData stageData)
  {
  }

  [Token(Token = "0x60002F3")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public GenerateTileObjects()
  {
  }
}
