// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Tools.Potato
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups;
using Cpp2ILInjected;

namespace Assets.Scripts.Tools
{
  [Token(Token = "0x2000308")]
  public static class Potato
  {
    [Token(Token = "0x4001494")]
    private static float lastCollisionTime;
    [Token(Token = "0x4001495")]
    private static float noCollisionTimeThreshold;
    [Token(Token = "0x4001496")]
    public static EPotatoFlags flags;
    [Token(Token = "0x4001497")]
    public static float totalDamageDone;
    [Token(Token = "0x4001498")]
    public static float dmgMin1;
    [Token(Token = "0x4001499")]
    public static float dmgMin2;
    [Token(Token = "0x400149A")]
    public static float dmgMin5;
    [Token(Token = "0x400149B")]
    public static float dmgMin10;
    [Token(Token = "0x400149C")]
    private static float dmgMin1Max;
    [Token(Token = "0x400149D")]
    private static float dmgMin2Max;
    [Token(Token = "0x400149E")]
    private static float dmgMin5Max;
    [Token(Token = "0x400149F")]
    private static int totalKills;
    [Token(Token = "0x40014A0")]
    public static int killsMinute1;
    [Token(Token = "0x40014A1")]
    public static int killsMinute2;
    [Token(Token = "0x40014A2")]
    public static int killsMinute5;
    [Token(Token = "0x40014A3")]
    public static int killsMinute10;
    [Token(Token = "0x40014A4")]
    private static int maxKillsMinute1;
    [Token(Token = "0x40014A5")]
    private static int maxKillsMinute2;
    [Token(Token = "0x40014A6")]
    private static int maxKillsMinute5;
    [Token(Token = "0x40014A7")]
    private static int maxKillsMinute10;
    [Token(Token = "0x40014A8")]
    public static int enemyCollisionCalls;
    [Token(Token = "0x40014A9")]
    public static int playerDamageCalls;
    [Token(Token = "0x40014AA")]
    public static int damageBlocksCount;
    [Token(Token = "0x40014AB")]
    public static int damageTakenCount;
    [Token(Token = "0x40014AC")]
    public static int totalDamageTaken;
    [Token(Token = "0x40014AD")]
    private static int lastKillCount;
    [Token(Token = "0x40014AE")]
    private static int lastGoldCount;
    [Token(Token = "0x40014AF")]
    private static bool isRunning;
    [Token(Token = "0x40014B0")]
    private static float nextCheckTime;

    [Token(Token = "0x60015C4")]
    [Address(RVA = "0x3B3E20", Offset = "0x3B2A20", Length = "0x8B3")]
    public static void Init()
    {
    }

    [Token(Token = "0x60015C5")]
    [Address(RVA = "0x3B3560", Offset = "0x3B2160", Length = "0x8B3")]
    public static void Cleanup()
    {
    }

    [Token(Token = "0x60015C6")]
    [Address(RVA = "0x3B4EA0", Offset = "0x3B3AA0", Length = "0x1A4")]
    private static void OnRunStarted()
    {
    }

    [Token(Token = "0x60015C7")]
    [Address(RVA = "0x3B4E50", Offset = "0x3B3A50", Length = "0x4F")]
    private static void OnRunOver()
    {
    }

    [Token(Token = "0x60015C8")]
    [Address(RVA = "0x3B4E00", Offset = "0x3B3A00", Length = "0x4F")]
    private static void OnRunEnded()
    {
    }

    [Token(Token = "0x60015C9")]
    [Address(RVA = "0x3B4D50", Offset = "0x3B3950", Length = "0xA2")]
    private static void OnPlayerCollided()
    {
    }

    [Token(Token = "0x60015CA")]
    [Address(RVA = "0x3B5050", Offset = "0x3B3C50", Length = "0x57E")]
    public static void Update()
    {
    }

    [Token(Token = "0x60015CB")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    private static void TestInput()
    {
    }

    [Token(Token = "0x60015CC")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    private static void CheckCollision()
    {
    }

    [Token(Token = "0x60015CD")]
    [Address(RVA = "0x3B5CC0", Offset = "0x3B48C0", Length = "0x160")]
    private static void VerifyKillCount()
    {
    }

    [Token(Token = "0x60015CE")]
    [Address(RVA = "0x3B55D0", Offset = "0x3B41D0", Length = "0x194")]
    private static void VerifyGold()
    {
    }

    [Token(Token = "0x60015CF")]
    [Address(RVA = "0x3B5770", Offset = "0x3B4370", Length = "0x15B")]
    private static void VerifyHp()
    {
    }

    [Token(Token = "0x60015D0")]
    [Address(RVA = "0x3B4930", Offset = "0x3B3530", Length = "0x395")]
    private static void OnEnemyDamaged(Enemy enemy, DamageContainer dc)
    {
    }

    [Token(Token = "0x60015D1")]
    [Address(RVA = "0x3B58D0", Offset = "0x3B44D0", Length = "0x3E4")]
    private static void VerifyKillCountPerMinute()
    {
    }

    [Token(Token = "0x60015D2")]
    [Address(RVA = "0x3B4CD0", Offset = "0x3B38D0", Length = "0x7F")]
    private static void OnHpTamper()
    {
    }

    [Token(Token = "0x60015D3")]
    [Address(RVA = "0x3B48D0", Offset = "0x3B34D0", Length = "0x53")]
    private static void OnEnemyCollision()
    {
    }

    [Token(Token = "0x60015D4")]
    [Address(RVA = "0x3B47A0", Offset = "0x3B33A0", Length = "0x53")]
    private static void OnDamageCalled()
    {
    }

    [Token(Token = "0x60015D5")]
    [Address(RVA = "0x3B4800", Offset = "0x3B3400", Length = "0x53")]
    private static void OnDamageStopped()
    {
    }

    [Token(Token = "0x60015D6")]
    [Address(RVA = "0x3B4860", Offset = "0x3B3460", Length = "0x67")]
    private static void OnDamageTaken(PlayerHealth arg1, DamageContainer arg2, bool arg3)
    {
    }

    [Token(Token = "0x60015D7")]
    [Address(RVA = "0x3B46E0", Offset = "0x3B32E0", Length = "0xBB")]
    private static void MarkPotato(EPotatoFlags flag, string message)
    {
    }

    [Token(Token = "0x60015D8")]
    [Address(RVA = "0x3B5E20", Offset = "0x3B4A20", Length = "0xE1")]
    static Potato()
    {
    }
  }
}
