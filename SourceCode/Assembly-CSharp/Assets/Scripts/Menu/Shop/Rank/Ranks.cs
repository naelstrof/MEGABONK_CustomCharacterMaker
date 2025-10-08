// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Menu.Shop.Rank.Ranks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Menu.Shop.Rank
{
  [Token(Token = "0x20002EA")]
  public static class Ranks
  {
    [Token(Token = "0x4001410")]
    public const int maxRank = 240;
    [Token(Token = "0x4001411")]
    public const int numRankTiers = 6;
    [Token(Token = "0x4001412")]
    public const int numRanksPerTier = 40;

    [Token(Token = "0x6001547")]
    [Address(RVA = "0x3B78D0", Offset = "0x3B64D0", Length = "0x1A2")]
    public static void GetRankTextures(
      int rank,
      out Texture frame,
      out Texture rankIcon,
      out Color rankColor,
      out Color frameColor)
    {
      frame = (Texture) null;
      rankIcon = (Texture) null;
      rankColor = new Color();
      frameColor = new Color();
    }
  }
}
