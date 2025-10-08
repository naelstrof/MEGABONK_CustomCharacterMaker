// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.MapGeneration.ProceduralTiles.LinearHeightBias
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.MapGeneration.ProceduralTiles
{
  [Token(Token = "0x2000352")]
  public class LinearHeightBias : IHeightBiasStrategy
  {
    [Token(Token = "0x600179C")]
    [Address(RVA = "0x3CCC00", Offset = "0x3CB800", Length = "0xE8")]
    public float CalculateBias(int x, int y, int size, float outerBiasStrength, float strictness) => 0.0f;

    [Token(Token = "0x600179D")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public LinearHeightBias()
    {
    }
  }
}
