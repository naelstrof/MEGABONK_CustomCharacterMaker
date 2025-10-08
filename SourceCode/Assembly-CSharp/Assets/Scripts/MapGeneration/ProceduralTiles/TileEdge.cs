// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.MapGeneration.ProceduralTiles.TileEdge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

namespace Assets.Scripts.MapGeneration.ProceduralTiles
{
  [Token(Token = "0x2000354")]
  [Serializable]
  public class TileEdge
  {
    [Token(Token = "0x40016B9")]
    [FieldOffset(Offset = "0x10")]
    public Vector2Int direction;
    [Token(Token = "0x40016BA")]
    [FieldOffset(Offset = "0x18")]
    public int offsetHeight;
    [Token(Token = "0x40016BB")]
    [FieldOffset(Offset = "0x1C")]
    public ETileEdgeType type;

    [Token(Token = "0x60017A2")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public TileEdge()
    {
    }
  }
}
