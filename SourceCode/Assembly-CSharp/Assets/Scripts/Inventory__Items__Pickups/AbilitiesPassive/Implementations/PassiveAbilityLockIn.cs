// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityLockIn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x20003FB")]
  public class PassiveAbilityLockIn : PassiveAbility
  {
    [Token(Token = "0x4001A58")]
    [FieldOffset(Offset = "0x18")]
    public int thornsPerLevel;
    [Token(Token = "0x4001A59")]
    [FieldOffset(Offset = "0x1C")]
    private float maxDamage;
    [Token(Token = "0x4001A5A")]
    [FieldOffset(Offset = "0x20")]
    private float maxDamagePerLevel;
    [Token(Token = "0x4001A5B")]
    [FieldOffset(Offset = "0x24")]
    private float updateCooldown;
    [Token(Token = "0x4001A5C")]
    [FieldOffset(Offset = "0x28")]
    private float nextUpdateTime;
    [Token(Token = "0x4001A5D")]
    [FieldOffset(Offset = "0x2C")]
    private float lastValue;

    [Token(Token = "0x6001CB7")]
    [Address(RVA = "0x42F250", Offset = "0x42DE50", Length = "0x31E")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001CB8")]
    [Address(RVA = "0x42ED80", Offset = "0x42D980", Length = "0x317")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001CB9")]
    [Address(RVA = "0x42F570", Offset = "0x42E170", Length = "0x92")]
    private void OnAegisChange(int currentAmount)
    {
    }

    [Token(Token = "0x6001CBA")]
    [Address(RVA = "0x42F6C0", Offset = "0x42E2C0", Length = "0x210")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001CBB")]
    [Address(RVA = "0x42F610", Offset = "0x42E210", Length = "0xA7")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001CBC")]
    [Address(RVA = "0x42F240", Offset = "0x42DE40", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001CBD")]
    [Address(RVA = "0x42F0A0", Offset = "0x42DCA0", Length = "0x19F")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001CBE")]
    [Address(RVA = "0x42F8E0", Offset = "0x42E4E0", Length = "0x2A")]
    public PassiveAbilityLockIn()
    {
    }
  }
}
