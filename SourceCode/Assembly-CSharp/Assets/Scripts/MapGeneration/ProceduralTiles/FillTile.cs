// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.MapGeneration.ProceduralTiles.FillTile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.MapGeneration.ProceduralTiles
{
  [Token(Token = "0x2000344")]
  public class FillTile : MonoBehaviour
  {
    [Token(Token = "0x400168D")]
    [FieldOffset(Offset = "0x20")]
    public MeshRenderer renderer;
    [Token(Token = "0x400168E")]
    [FieldOffset(Offset = "0x28")]
    public EFillType fillType;
    [Token(Token = "0x400168F")]
    [FieldOffset(Offset = "0x2C")]
    public bool cross;
    [Token(Token = "0x4001690")]
    [FieldOffset(Offset = "0x2D")]
    public bool useEdge;

    [Token(Token = "0x600177B")]
    [Address(RVA = "0x3CC990", Offset = "0x3CB590", Length = "0x57")]
    public void SetFillType(EFillType type, StageData stageData, bool useEdgeTextures = false)
    {
    }

    [Token(Token = "0x600177C")]
    [Address(RVA = "0x3CC930", Offset = "0x3CB530", Length = "0x5D")]
    private void OnValidate()
    {
    }

    [Token(Token = "0x600177D")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public FillTile()
    {
    }
  }
}
