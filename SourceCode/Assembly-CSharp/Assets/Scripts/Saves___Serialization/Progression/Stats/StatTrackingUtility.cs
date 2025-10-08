// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.Stats.StatTrackingUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Saves___Serialization.Progression.Stats
{
  [Token(Token = "0x2000330")]
  public class StatTrackingUtility
  {
    [Token(Token = "0x40015AA")]
    private static HashSet<EEnemy> skeletonEnemies;
    [Token(Token = "0x40015AB")]
    private static HashSet<EEnemy> wispEnemies;
    [Token(Token = "0x40015AC")]
    private static HashSet<EEnemy> goblinEnemies;
    [Token(Token = "0x40015AD")]
    private static Dictionary<ECharacter, string> keysKillsCharacters;
    [Token(Token = "0x40015AE")]
    private static Dictionary<EEnemy, string> keysKillsEnemies;
    [Token(Token = "0x40015AF")]
    private static Dictionary<string, string> keysKillsSources;

    [Token(Token = "0x600169B")]
    [Address(RVA = "0x3DCAA0", Offset = "0x3DB6A0", Length = "0x86")]
    public static bool IsSkeleton(Enemy enemy) => false;

    [Token(Token = "0x600169C")]
    [Address(RVA = "0x3DCB30", Offset = "0x3DB730", Length = "0x87")]
    public static bool IsWisp(Enemy enemy) => false;

    [Token(Token = "0x600169D")]
    [Address(RVA = "0x3DCA10", Offset = "0x3DB610", Length = "0x87")]
    public static bool IsGoblin(Enemy enemy) => false;

    [Token(Token = "0x600169E")]
    [Address(RVA = "0x3DC3A0", Offset = "0x3DAFA0", Length = "0x218")]
    public static string GetKeyKillsCharacter(ECharacter character) => (string) null;

    [Token(Token = "0x600169F")]
    [Address(RVA = "0x3DC5C0", Offset = "0x3DB1C0", Length = "0x26A")]
    public static string GetKeyKillsEnemy(Enemy enemy) => (string) null;

    [Token(Token = "0x60016A0")]
    [Address(RVA = "0x3DC830", Offset = "0x3DB430", Length = "0x1DA")]
    public static string GetKeyKillsSource(DamageContainer dc) => (string) null;

    [Token(Token = "0x60016A1")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public StatTrackingUtility()
    {
    }

    [Token(Token = "0x60016A2")]
    [Address(RVA = "0x3DCBC0", Offset = "0x3DB7C0", Length = "0x32F")]
    static StatTrackingUtility()
    {
    }
  }
}
