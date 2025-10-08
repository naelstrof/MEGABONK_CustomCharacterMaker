// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.MapGeneration.ProceduralTiles.GaussianHeightBias
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.MapGeneration.ProceduralTiles
{
  [Token(Token = "0x2000351")]
  public class GaussianHeightBias : IHeightBiasStrategy
  {
    [Token(Token = "0x600179A")]
    [Address(RVA = "0x3CC9F0", Offset = "0x3CB5F0", Length = "0xFF")]
    public float CalculateBias(int x, int y, int size, float outerBiasStrength, float strictness) => 0.0f;

    [Token(Token = "0x600179B")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public GaussianHeightBias()
    {
    }
  }
}
