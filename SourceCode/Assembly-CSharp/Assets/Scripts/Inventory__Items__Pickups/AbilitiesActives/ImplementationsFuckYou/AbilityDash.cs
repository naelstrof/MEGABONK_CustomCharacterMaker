// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesActives.ImplementationsFuckYou.AbilityDash
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesActives.ImplementationsFuckYou
{
  [Token(Token = "0x200040C")]
  public class AbilityDash : ActiveAbility
  {
    [Token(Token = "0x4001A86")]
    [FieldOffset(Offset = "0x18")]
    private float dashDuration;
    [Token(Token = "0x4001A87")]
    [FieldOffset(Offset = "0x1C")]
    private float dashOverAtTime;
    [Token(Token = "0x4001A88")]
    [FieldOffset(Offset = "0x20")]
    private bool isDashing;
    [Token(Token = "0x4001A89")]
    [FieldOffset(Offset = "0x24")]
    private Vector3 dashDir;
    [Token(Token = "0x4001A8A")]
    [FieldOffset(Offset = "0x30")]
    private Vector3 preDashVel;
    [Token(Token = "0x4001A8B")]
    [FieldOffset(Offset = "0x3C")]
    private float dashSpeed;
    [Token(Token = "0x4001A8C")]
    [FieldOffset(Offset = "0x40")]
    private float dashSpeedToUse;

    [Token(Token = "0x6001D26")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001D27")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001D28")]
    [Address(RVA = "0x41BA70", Offset = "0x41A670", Length = "0x436")]
    public override void UseImplementation()
    {
    }

    [Token(Token = "0x6001D29")]
    [Address(RVA = "0x41B5A0", Offset = "0x41A1A0", Length = "0x1C3")]
    private void DashFinished()
    {
    }

    [Token(Token = "0x6001D2A")]
    [Address(RVA = "0x41B780", Offset = "0x41A380", Length = "0x2E0")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001D2B")]
    [Address(RVA = "0x41B770", Offset = "0x41A370", Length = "0x9")]
    public override float GetCooldown() => 0.0f;

    [Token(Token = "0x6001D2C")]
    [Address(RVA = "0x41BEB0", Offset = "0x41AAB0", Length = "0x15")]
    public AbilityDash()
    {
    }
  }
}
