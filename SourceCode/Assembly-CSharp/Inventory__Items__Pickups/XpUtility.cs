// Decompiled with JetBrains decompiler
// Type: Inventory__Items__Pickups.XpUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Inventory__Items__Pickups
{
  [Token(Token = "0x20002C5")]
  public class XpUtility
  {
    [Token(Token = "0x40012CA")]
    public static float eliteEnemyXpMultiplier;
    [Token(Token = "0x40012CB")]
    private static int baseXp;
    [Token(Token = "0x40012CC")]
    private static float increaseRate;
    [Token(Token = "0x40012CD")]
    private static float exponent;
    [Token(Token = "0x40012CE")]
    public const int maxLevel = 9999;
    [Token(Token = "0x40012CF")]
    public static int[] xpForLevelsTable;

    [Token(Token = "0x60014B5")]
    [Address(RVA = "0x39F720", Offset = "0x39E320", Length = "0x183")]
    public static void Init()
    {
    }

    [Token(Token = "0x60014B6")]
    [Address(RVA = "0x39F9A0", Offset = "0x39E5A0", Length = "0x9E")]
    public static int XpToLevel(int xp) => 0;

    [Token(Token = "0x60014B7")]
    [Address(RVA = "0x39FAB0", Offset = "0x39E6B0", Length = "0xEC")]
    public static int XpToNextLevel(int currentXp) => 0;

    [Token(Token = "0x60014B8")]
    [Address(RVA = "0x39F940", Offset = "0x39E540", Length = "0x55")]
    public static int XpOnCurrentLevel(int currentXp) => 0;

    [Token(Token = "0x60014B9")]
    [Address(RVA = "0x39FA40", Offset = "0x39E640", Length = "0x6C")]
    public static int XpToNextLevelTotal(int currentXp) => 0;

    [Token(Token = "0x60014BA")]
    [Address(RVA = "0x39F610", Offset = "0x39E210", Length = "0x10B")]
    public static float CurrentLevelProgress(int currentXp) => 0.0f;

    [Token(Token = "0x60014BB")]
    [Address(RVA = "0x39F8B0", Offset = "0x39E4B0", Length = "0x8D")]
    public static int LevelToXp(int lvl) => 0;

    [Token(Token = "0x60014BC")]
    [Address(RVA = "0x39FBA0", Offset = "0x39E7A0", Length = "0x50")]
    public static int XpTotalCurrentLevel(int xp) => 0;

    [Token(Token = "0x60014BD")]
    [Address(RVA = "0x39FBF0", Offset = "0x39E7F0", Length = "0x51")]
    public static int XpTotalNextLevel(int xp) => 0;

    [Token(Token = "0x60014BE")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public XpUtility()
    {
    }

    [Token(Token = "0x60014BF")]
    [Address(RVA = "0x39FC50", Offset = "0x39E850", Length = "0x78")]
    static XpUtility()
    {
    }
  }
}
