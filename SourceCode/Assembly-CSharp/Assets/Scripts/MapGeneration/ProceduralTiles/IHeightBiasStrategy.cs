// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.MapGeneration.ProceduralTiles.IHeightBiasStrategy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.MapGeneration.ProceduralTiles
{
  [Token(Token = "0x2000350")]
  public interface IHeightBiasStrategy
  {
    [Token(Token = "0x6001799")]
    float CalculateBias(int x, int y, int size, float outerBiasStrength, float strictness);
  }
}
