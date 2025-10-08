// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.CombatScaling
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Game.Combat
{
  [Token(Token = "0x2000424")]
  public static class CombatScaling
  {
    [Token(Token = "0x4001B09")]
    private static float speedMultiplicationPerMinute;
    [Token(Token = "0x4001B0A")]
    private static float hpMultiplicationPerMinute;
    [Token(Token = "0x4001B0B")]
    private static float damageMultiplicationPerMinute;
    [Token(Token = "0x4001B0C")]
    private static float knockbackResistancePerMinute;
    [Token(Token = "0x4001B0D")]
    private static float stageSpeedMultiplier;
    [Token(Token = "0x4001B0E")]
    private static float stageDamageMultiplier;
    [Token(Token = "0x4001B0F")]
    private static float stageKnockbackResMultiplier;

    [Token(Token = "0x6001DCF")]
    [Address(RVA = "0x43C660", Offset = "0x43B260", Length = "0x58")]
    private static float GetMinutes() => 0.0f;

    [Token(Token = "0x6001DD0")]
    [Address(RVA = "0x43CA60", Offset = "0x43B660", Length = "0x3B")]
    public static float GetStageMultiplier() => 0.0f;

    [Token(Token = "0x6001DD1")]
    [Address(RVA = "0x43CAA0", Offset = "0x43B6A0", Length = "0xAB")]
    public static float GetStageSpeedMultiplier() => 0.0f;

    [Token(Token = "0x6001DD2")]
    [Address(RVA = "0x43C970", Offset = "0x43B570", Length = "0xEB")]
    public static float GetStageHpMultiplier() => 0.0f;

    [Token(Token = "0x6001DD3")]
    [Address(RVA = "0x43C8C0", Offset = "0x43B4C0", Length = "0xAB")]
    public static float GetStageDamageMultiplier() => 0.0f;

    [Token(Token = "0x6001DD4")]
    [Address(RVA = "0x43C6C0", Offset = "0x43B2C0", Length = "0x1F5")]
    public static float GetSpeedMultiplierAddition(
      out float baseAddition,
      out float swarmAddition,
      out float stageAddition)
    {
      baseAddition = new float();
      swarmAddition = new float();
      stageAddition = new float();
      return 0.0f;
    }

    [Token(Token = "0x6001DD5")]
    [Address(RVA = "0x43C2E0", Offset = "0x43AEE0", Length = "0x22C")]
    public static float GetHpMultiplierAddition(
      out float baseAddition,
      out float swarmAddition,
      out float stageAddition)
    {
      baseAddition = new float();
      swarmAddition = new float();
      stageAddition = new float();
      return 0.0f;
    }

    [Token(Token = "0x6001DD6")]
    [Address(RVA = "0x43BF90", Offset = "0x43AB90", Length = "0x1F9")]
    public static float GetDamageMultiplierAddition(
      out float baseAddition,
      out float swarmAddition,
      out float stageAddition)
    {
      baseAddition = new float();
      swarmAddition = new float();
      stageAddition = new float();
      return 0.0f;
    }

    [Token(Token = "0x6001DD7")]
    [Address(RVA = "0x43C510", Offset = "0x43B110", Length = "0x14C")]
    public static float GetKnockbackResistanceMultiplierAddition(
      out float baseAddition,
      out float swarmAddition,
      out float stageAddition)
    {
      baseAddition = new float();
      swarmAddition = new float();
      stageAddition = new float();
      return 0.0f;
    }

    [Token(Token = "0x6001DD8")]
    [Address(RVA = "0x43C270", Offset = "0x43AE70", Length = "0x6D")]
    public static float GetFinalSwarmMultiplier() => 0.0f;

    [Token(Token = "0x6001DD9")]
    [Address(RVA = "0x43C200", Offset = "0x43AE00", Length = "0x6D")]
    public static float GetFinalSwarmHpMultiplier() => 0.0f;

    [Token(Token = "0x6001DDA")]
    [Address(RVA = "0x43C190", Offset = "0x43AD90", Length = "0x6D")]
    public static float GetFinalSwarmDamageMultiplier() => 0.0f;

    [Token(Token = "0x6001DDB")]
    [Address(RVA = "0x43CB50", Offset = "0x43B750", Length = "0x69")]
    public static float GetSwarmSpeedMultiplier() => 0.0f;

    [Token(Token = "0x6001DDC")]
    [Address(RVA = "0x43CBC0", Offset = "0x43B7C0", Length = "0xB7")]
    static CombatScaling()
    {
    }
  }
}
