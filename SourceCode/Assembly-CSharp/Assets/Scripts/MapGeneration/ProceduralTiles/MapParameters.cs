// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.MapGeneration.ProceduralTiles.MapParameters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.MapGeneration.ProceduralTiles
{
  [CreateAssetMenu(menuName = "Me/Mapping/MapParameters")]
  [Token(Token = "0x2000346")]
  public class MapParameters : ScriptableObject
  {
    [Token(Token = "0x4001696")]
    [FieldOffset(Offset = "0x18")]
    public float volatility;
    [Token(Token = "0x4001697")]
    [FieldOffset(Offset = "0x1C")]
    public float centerHeightTarget;
    [Token(Token = "0x4001698")]
    [FieldOffset(Offset = "0x20")]
    public float slopeStrength;
    [Token(Token = "0x4001699")]
    [FieldOffset(Offset = "0x24")]
    public float yOffset;
    [Token(Token = "0x400169A")]
    [FieldOffset(Offset = "0x28")]
    public float flatMapBias;
    [Token(Token = "0x400169B")]
    [FieldOffset(Offset = "0x2C")]
    public int size;
    [Token(Token = "0x400169C")]
    [FieldOffset(Offset = "0x30")]
    public int scale;
    [Token(Token = "0x400169D")]
    [FieldOffset(Offset = "0x34")]
    public int tileWidth;
    [Token(Token = "0x400169E")]
    [FieldOffset(Offset = "0x38")]
    public int tileHeight;
    [Token(Token = "0x400169F")]
    [FieldOffset(Offset = "0x3C")]
    public EBiasStrategy biasStrategy;
    [Token(Token = "0x40016A0")]
    [FieldOffset(Offset = "0x40")]
    public EHeightGenerationStrategy heightGenerationStrategy;
    [Header("Calculated Values")]
    [Token(Token = "0x40016A1")]
    [FieldOffset(Offset = "0x44")]
    public int scaledTileWidth;
    [Token(Token = "0x40016A2")]
    [FieldOffset(Offset = "0x48")]
    public int scaledTileHeight;
    [Token(Token = "0x40016A3")]
    [FieldOffset(Offset = "0x50")]
    public StageData testStageData;

    [Token(Token = "0x600177E")]
    [Address(RVA = "0x3CDDE0", Offset = "0x3CC9E0", Length = "0x15")]
    private void OnValidate()
    {
    }

    [Token(Token = "0x600177F")]
    [Address(RVA = "0x3CDE00", Offset = "0x3CCA00", Length = "0x38")]
    public MapParameters()
    {
    }
  }
}
