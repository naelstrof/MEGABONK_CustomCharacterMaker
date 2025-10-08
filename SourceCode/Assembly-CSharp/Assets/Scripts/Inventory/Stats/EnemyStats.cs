// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory.Stats.EnemyStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory.Stats
{
  [Token(Token = "0x200035A")]
  public static class EnemyStats
  {
    [Token(Token = "0x40016E3")]
    private static float maxSpeedMultiplier;

    [Token(Token = "0x60017DB")]
    [Address(RVA = "0x3CC3E0", Offset = "0x3CAFE0", Length = "0x276")]
    public static float GetHp(Enemy enemy) => 0.0f;

    [Token(Token = "0x60017DC")]
    [Address(RVA = "0x3CC760", Offset = "0x3CB360", Length = "0x18E")]
    public static float GetSpeed(EnemyData enemyData) => 0.0f;

    [Token(Token = "0x60017DD")]
    [Address(RVA = "0x3CC220", Offset = "0x3CAE20", Length = "0x17B")]
    public static float GetDamage(Enemy enemy) => 0.0f;

    [Token(Token = "0x60017DE")]
    [Address(RVA = "0x3CC3A0", Offset = "0x3CAFA0", Length = "0x36")]
    public static float GetEliteChance(EnemyData enemyData) => 0.0f;

    [Token(Token = "0x60017DF")]
    [Address(RVA = "0x3CC660", Offset = "0x3CB260", Length = "0xF7")]
    public static float GetKnockbackResistance(Enemy enemy) => 0.0f;

    [Token(Token = "0x60017E0")]
    [Address(RVA = "0x3CC8F0", Offset = "0x3CB4F0", Length = "0x39")]
    static EnemyStats()
    {
    }
  }
}
