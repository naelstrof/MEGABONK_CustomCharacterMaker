// Decompiled with JetBrains decompiler
// Type: MapEdges
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000075")]
public class MapEdges : MonoBehaviour
{
  [Token(Token = "0x4000398")]
  [FieldOffset(Offset = "0x20")]
  public MeshRenderer edgeBot;
  [Token(Token = "0x4000399")]
  [FieldOffset(Offset = "0x28")]
  public MeshRenderer edgeTop;

  [Token(Token = "0x60002F4")]
  [Address(RVA = "0x468EF0", Offset = "0x467AF0", Length = "0x397")]
  public void Set(Vector3 worldCenter, Vector3 worldSize, StageData stageData)
  {
  }

  [Token(Token = "0x60002F5")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MapEdges()
  {
  }
}
