// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityQuantumXp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x20003FE")]
  public class PassiveAbilityQuantumXp : PassiveAbility
  {
    [Token(Token = "0x4001A61")]
    [FieldOffset(Offset = "0x18")]
    private float xpPerLevel;

    [Token(Token = "0x6001CCA")]
    [Address(RVA = "0x430370", Offset = "0x42EF70", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001CCB")]
    [Address(RVA = "0x430060", Offset = "0x42EC60", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001CCC")]
    [Address(RVA = "0x4304C0", Offset = "0x42F0C0", Length = "0x8F")]
    private void OnLevelup(int level)
    {
    }

    [Token(Token = "0x6001CCD")]
    [Address(RVA = "0x4301B0", Offset = "0x42EDB0", Length = "0x1AB")]
    public override string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001CCE")]
    [Address(RVA = "0x430360", Offset = "0x42EF60", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001CCF")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001CD0")]
    [Address(RVA = "0x430550", Offset = "0x42F150", Length = "0xE")]
    public PassiveAbilityQuantumXp()
    {
    }
  }
}
