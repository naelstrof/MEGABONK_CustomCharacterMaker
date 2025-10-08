// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Weapons.WeaponPassives.WeaponPassiveBloodMagic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Weapons.WeaponPassives
{
  [Token(Token = "0x200036E")]
  public class WeaponPassiveBloodMagic : WeaponPassive
  {
    [Token(Token = "0x4001758")]
    [FieldOffset(Offset = "0x20")]
    private int stacks;
    [Token(Token = "0x4001759")]
    [FieldOffset(Offset = "0x24")]
    private float stackChance;
    [Token(Token = "0x400175A")]
    private static string bloodMagicDamageSource;
    [Token(Token = "0x400175B")]
    private static float maxRollsUpgradesPerMinute;
    [Token(Token = "0x400175C")]
    [FieldOffset(Offset = "0x28")]
    private float rollCooldown;
    [Token(Token = "0x400175D")]
    [FieldOffset(Offset = "0x2C")]
    private float nextReadyTime;

    [Token(Token = "0x6001894")]
    [Address(RVA = "0x3FCBB0", Offset = "0x3FB7B0", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001895")]
    [Address(RVA = "0x3FCA60", Offset = "0x3FB660", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001896")]
    [Address(RVA = "0x3FCD00", Offset = "0x3FB900", Length = "0x2D3")]
    private void OnEnemyDied(Enemy enemy, DamageContainer dc)
    {
    }

    [Token(Token = "0x6001897")]
    [Address(RVA = "0x3FD080", Offset = "0x3FBC80", Length = "0x83")]
    public WeaponPassiveBloodMagic(WeaponBase weaponBase)
      : base((WeaponBase) null)
    {
    }

    [Token(Token = "0x6001898")]
    [Address(RVA = "0x3FCFE0", Offset = "0x3FBBE0", Length = "0x96")]
    static WeaponPassiveBloodMagic()
    {
    }
  }
}
