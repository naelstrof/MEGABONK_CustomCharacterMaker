// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilitySpeedDemon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x2000402")]
  public class PassiveAbilitySpeedDemon : PassiveAbility
  {
    [Token(Token = "0x4001A67")]
    [FieldOffset(Offset = "0x18")]
    private float increaseInterval;
    [Token(Token = "0x4001A68")]
    [FieldOffset(Offset = "0x1C")]
    private float increasePerInterval;
    [Token(Token = "0x4001A69")]
    [FieldOffset(Offset = "0x20")]
    private float speedIncrease;
    [Token(Token = "0x4001A6A")]
    [FieldOffset(Offset = "0x24")]
    private float nextInterval;
    [Token(Token = "0x4001A6B")]
    [FieldOffset(Offset = "0x28")]
    private float cap;
    [Token(Token = "0x4001A6C")]
    [FieldOffset(Offset = "0x2C")]
    private float maxDamageAddPerLevel;
    [Token(Token = "0x4001A6D")]
    [FieldOffset(Offset = "0x30")]
    private float maxDamageAddDefault;
    [Token(Token = "0x4001A6E")]
    [FieldOffset(Offset = "0x34")]
    private float damageAddPerTimesOverBase;
    [Token(Token = "0x4001A6F")]
    [FieldOffset(Offset = "0x38")]
    private float updateStatsInterval;
    [Token(Token = "0x4001A70")]
    [FieldOffset(Offset = "0x3C")]
    private float nextUpdateDamageTime;

    [Token(Token = "0x6001CE7")]
    [Address(RVA = "0x4319B0", Offset = "0x4305B0", Length = "0x181")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001CE8")]
    [Address(RVA = "0x431850", Offset = "0x430450", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001CE9")]
    [Address(RVA = "0x431FB0", Offset = "0x430BB0", Length = "0x2FC")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001CEA")]
    [Address(RVA = "0x431E80", Offset = "0x430A80", Length = "0x122")]
    private void TickSpeedIncrease()
    {
    }

    [Token(Token = "0x6001CEB")]
    [Address(RVA = "0x431CA0", Offset = "0x4308A0", Length = "0x1DA")]
    private void TickDamageIncrease()
    {
    }

    [Token(Token = "0x6001CEC")]
    [Address(RVA = "0x431B40", Offset = "0x430740", Length = "0x158")]
    private void OnDamage(PlayerHealth ph, DamageContainer dc, bool brokeShield)
    {
    }

    [Token(Token = "0x6001CED")]
    [Address(RVA = "0x4319A0", Offset = "0x4305A0", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001CEE")]
    [Address(RVA = "0x4322B0", Offset = "0x430EB0", Length = "0x38")]
    public PassiveAbilitySpeedDemon()
    {
    }
  }
}
