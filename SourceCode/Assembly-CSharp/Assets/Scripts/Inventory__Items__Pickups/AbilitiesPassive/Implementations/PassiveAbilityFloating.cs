// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityFloating
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x20003F8")]
  public class PassiveAbilityFloating : PassiveAbility
  {
    [Token(Token = "0x6001CA4")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001CA5")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001CA6")]
    [Address(RVA = "0x42E1D0", Offset = "0x42CDD0", Length = "0x1DE")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001CA7")]
    [Address(RVA = "0x3FF460", Offset = "0x3FE060", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001CA8")]
    [Address(RVA = "0x42E3B0", Offset = "0x42CFB0", Length = "0x7")]
    public PassiveAbilityFloating()
    {
    }
  }
}
