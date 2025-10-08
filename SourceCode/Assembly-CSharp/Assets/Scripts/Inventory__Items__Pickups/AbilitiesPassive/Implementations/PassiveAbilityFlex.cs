// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityFlex
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Cpp2ILInjected;
using System;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x20003F7")]
  public class PassiveAbilityFlex : PassiveAbility
  {
    [Token(Token = "0x4001A4A")]
    public static Action<bool> A_FlexReady;
    [Token(Token = "0x4001A4B")]
    private static float cooldown;
    [Token(Token = "0x4001A4C")]
    private static float minCooldown;
    [Token(Token = "0x4001A4D")]
    private static float maxCooldown;
    [Token(Token = "0x4001A4E")]
    [FieldOffset(Offset = "0x18")]
    private float cooldownReductionPerLevel;
    [Token(Token = "0x4001A4F")]
    [FieldOffset(Offset = "0x1C")]
    private float radius;
    [Token(Token = "0x4001A50")]
    private static float flexReadyAtTime;
    [Token(Token = "0x4001A51")]
    [FieldOffset(Offset = "0x20")]
    private bool canFlex;
    [Token(Token = "0x4001A52")]
    [FieldOffset(Offset = "0x28")]
    private DamageContainer reuseDc;
    [Token(Token = "0x4001A53")]
    [FieldOffset(Offset = "0x30")]
    private string damageSource;

    [Token(Token = "0x6001C97")]
    [Address(RVA = "0x42D520", Offset = "0x42C120", Length = "0x2ED")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001C98")]
    [Address(RVA = "0x42CFC0", Offset = "0x42BBC0", Length = "0x2B1")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001C99")]
    [Address(RVA = "0x42D8F0", Offset = "0x42C4F0", Length = "0xA5")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001C9A")]
    [Address(RVA = "0x42D9A0", Offset = "0x42C5A0", Length = "0xE7")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001C9B")]
    [Address(RVA = "0x42D810", Offset = "0x42C410", Length = "0xD9")]
    private void OnCheckStopDamage(DamageContainer dc, bool shieldDamage)
    {
    }

    [Token(Token = "0x6001C9C")]
    [Address(RVA = "0x42D280", Offset = "0x42BE80", Length = "0x61")]
    private float GetDamage() => 0.0f;

    [Token(Token = "0x6001C9D")]
    [Address(RVA = "0x42D450", Offset = "0x42C050", Length = "0x17")]
    private float GetKnockback() => 0.0f;

    [Token(Token = "0x6001C9E")]
    [Address(RVA = "0x42DA90", Offset = "0x42C690", Length = "0x61E")]
    private void UseFlex()
    {
    }

    [Token(Token = "0x6001C9F")]
    [Address(RVA = "0x42D480", Offset = "0x42C080", Length = "0x93")]
    private bool HasFlex() => false;

    [Token(Token = "0x6001CA0")]
    [Address(RVA = "0x42D470", Offset = "0x42C070", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001CA1")]
    [Address(RVA = "0x42D2F0", Offset = "0x42BEF0", Length = "0x158")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001CA2")]
    [Address(RVA = "0x42E120", Offset = "0x42CD20", Length = "0xAB")]
    public PassiveAbilityFlex()
    {
    }

    [Token(Token = "0x6001CA3")]
    [Address(RVA = "0x42E0B0", Offset = "0x42CCB0", Length = "0x64")]
    static PassiveAbilityFlex()
    {
    }
  }
}
