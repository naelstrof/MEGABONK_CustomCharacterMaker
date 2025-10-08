// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.DamageUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Game.Combat
{
  [Token(Token = "0x2000425")]
  public class DamageUtility
  {
    [Token(Token = "0x4001B10")]
    public const string enemyDamageSource = "Enemy";

    [Token(Token = "0x6001DDD")]
    [Address(RVA = "0x43D550", Offset = "0x43C150", Length = "0x272")]
    public static DamageContainer GetPlayerDamage(Enemy enemy, Vector3 direction, DcFlags flags) => (DamageContainer) null;

    [Token(Token = "0x6001DDE")]
    [Address(RVA = "0x43D7D0", Offset = "0x43C3D0", Length = "0x17A")]
    public static DamageContainer GetPlayerDamage(
      float damage,
      float knockback,
      Vector3 direction,
      Enemy enemy,
      string damageSource,
      DcFlags flags)
    {
      return (DamageContainer) null;
    }

    [Token(Token = "0x6001DDF")]
    [Address(RVA = "0x43D360", Offset = "0x43BF60", Length = "0x90")]
    public static bool CheckEvade(Enemy enemy) => false;

    [Token(Token = "0x6001DE0")]
    [Address(RVA = "0x43D400", Offset = "0x43C000", Length = "0x144")]
    public static bool GetCritDamageMultiplier(float critChance, out float multiplier)
    {
      multiplier = new float();
      return false;
    }

    [Token(Token = "0x6001DE1")]
    [Address(RVA = "0x43D2B0", Offset = "0x43BEB0", Length = "0xA4")]
    public static void ApplyExecute(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001DE2")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public DamageUtility()
    {
    }
  }
}
