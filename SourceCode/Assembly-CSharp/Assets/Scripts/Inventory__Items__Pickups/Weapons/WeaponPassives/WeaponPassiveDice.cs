// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Weapons.WeaponPassives.WeaponPassiveDice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Weapons.WeaponPassives
{
  [Token(Token = "0x200036F")]
  public class WeaponPassiveDice : WeaponPassive
  {
    [Token(Token = "0x400175E")]
    [FieldOffset(Offset = "0x20")]
    private int stacks;
    [Token(Token = "0x400175F")]
    [FieldOffset(Offset = "0x24")]
    private float critPer6;
    [Token(Token = "0x4001760")]
    [FieldOffset(Offset = "0x28")]
    private string movingStatName;
    [Token(Token = "0x4001761")]
    private static float maxRollsUpgradesPerMinute;
    [Token(Token = "0x4001762")]
    [FieldOffset(Offset = "0x30")]
    private float rollCooldown;
    [Token(Token = "0x4001763")]
    [FieldOffset(Offset = "0x34")]
    private float nextRollTime;
    [Token(Token = "0x4001764")]
    [FieldOffset(Offset = "0x38")]
    private float accumulatedCritChance;

    [Token(Token = "0x6001899")]
    [Address(RVA = "0x3FD230", Offset = "0x3FBE30", Length = "0x119")]
    public override void Init()
    {
    }

    [Token(Token = "0x600189A")]
    [Address(RVA = "0x3FD110", Offset = "0x3FBD10", Length = "0x119")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x600189B")]
    [Address(RVA = "0x3FD350", Offset = "0x3FBF50", Length = "0x1EA")]
    private void OnStackAdded()
    {
    }

    [Token(Token = "0x600189C")]
    [Address(RVA = "0x3FD580", Offset = "0x3FC180", Length = "0xA9")]
    public WeaponPassiveDice(WeaponBase weaponBase)
      : base((WeaponBase) null)
    {
    }

    [Token(Token = "0x600189D")]
    [Address(RVA = "0x3FD540", Offset = "0x3FC140", Length = "0x39")]
    static WeaponPassiveDice()
    {
    }
  }
}
