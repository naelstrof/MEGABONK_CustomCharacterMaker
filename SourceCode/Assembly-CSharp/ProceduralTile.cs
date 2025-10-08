// Decompiled with JetBrains decompiler
// Type: ProceduralTile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.MapGeneration.ProceduralTiles;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000F4")]
[Serializable]
public class ProceduralTile : MonoBehaviour
{
  [Token(Token = "0x40007B6")]
  [FieldOffset(Offset = "0x20")]
  public List<TileEdge> edges;
  [Token(Token = "0x40007B7")]
  [FieldOffset(Offset = "0x28")]
  public Renderer renderer;
  [Token(Token = "0x40007B8")]
  [FieldOffset(Offset = "0x30")]
  private Vector2Int[] globalDirections;
  [Token(Token = "0x40007B9")]
  [FieldOffset(Offset = "0x38")]
  public int posY;

  [Token(Token = "0x6000686")]
  [Address(RVA = "0x4A50C0", Offset = "0x4A3CC0", Length = "0x1DE")]
  public TileEdge GetEdge(Vector2Int globalDirection) => (TileEdge) null;

  [Token(Token = "0x6000687")]
  [Address(RVA = "0x4A5350", Offset = "0x4A3F50", Length = "0x7D")]
  public void SetGlobalRotation(Vector2Int direction)
  {
  }

  [Token(Token = "0x6000688")]
  [Address(RVA = "0x4A52B0", Offset = "0x4A3EB0", Length = "0x9A")]
  public Vector2Int GlobalToLocalDirection(Vector2Int dir) => new Vector2Int();

  [Token(Token = "0x6000689")]
  [Address(RVA = "0x4A53D0", Offset = "0x4A3FD0", Length = "0x39")]
  public void SetPosY(int y, StageData stageData, bool isFlat)
  {
  }

  [Token(Token = "0x600068A")]
  [Address(RVA = "0x4A52A0", Offset = "0x4A3EA0", Length = "0x4")]
  public int GetY() => 0;

  [Token(Token = "0x600068B")]
  [Address(RVA = "0x4A5410", Offset = "0x4A4010", Length = "0xD4")]
  public ProceduralTile()
  {
  }
}
