// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations.PassiveAbilityPlague
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
{
  [Token(Token = "0x20003FD")]
  public class PassiveAbilityPlague : PassiveAbility
  {
    [Token(Token = "0x4001A5E")]
    [FieldOffset(Offset = "0x18")]
    private int levelsPerStack;
    [Token(Token = "0x4001A5F")]
    [FieldOffset(Offset = "0x1C")]
    private float radius;
    [Token(Token = "0x4001A60")]
    [FieldOffset(Offset = "0x20")]
    private float duration;

    [Token(Token = "0x6001CC4")]
    [Address(RVA = "0x42FA80", Offset = "0x42E680", Length = "0x140")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001CC5")]
    [Address(RVA = "0x42F920", Offset = "0x42E520", Length = "0x140")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001CC6")]
    [Address(RVA = "0x42FBD0", Offset = "0x42E7D0", Length = "0x460")]
    private void OnEnemyDied(Enemy enemy, DamageContainer deathSource)
    {
    }

    [Token(Token = "0x6001CC7")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001CC8")]
    [Address(RVA = "0x42FA70", Offset = "0x42E670", Length = "0x6")]
    public override EPassive GetPassiveType() => new EPassive();

    [Token(Token = "0x6001CC9")]
    [Address(RVA = "0x430040", Offset = "0x42EC40", Length = "0x1C")]
    public PassiveAbilityPlague()
    {
    }
  }
}
