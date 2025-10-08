// Decompiled with JetBrains decompiler
// Type: CombatAura
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Combat.ConstantAttacks;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000052")]
public class CombatAura : ConstantAttack
{
  [Token(Token = "0x40002BC")]
  [FieldOffset(Offset = "0x28")]
  private float defaultRadius;
  [Token(Token = "0x40002BD")]
  [FieldOffset(Offset = "0x30")]
  public ParticleSystem[] particles;
  [Token(Token = "0x40002BE")]
  [FieldOffset(Offset = "0x38")]
  private Color[] defaultColors;
  [Token(Token = "0x40002BF")]
  [FieldOffset(Offset = "0x40")]
  private float radius;
  [Token(Token = "0x40002C0")]
  [FieldOffset(Offset = "0x44")]
  private float cooldown;
  [Token(Token = "0x40002C1")]
  [FieldOffset(Offset = "0x48")]
  private float oldRadius;
  [Token(Token = "0x40002C2")]
  [FieldOffset(Offset = "0x4C")]
  private float scaleTimer;
  [Token(Token = "0x40002C3")]
  [FieldOffset(Offset = "0x50")]
  private float scaleOverTime;
  [Token(Token = "0x40002C4")]
  [FieldOffset(Offset = "0x54")]
  private float fadeMultiplier;
  [Token(Token = "0x40002C5")]
  [FieldOffset(Offset = "0x58")]
  private float minSizeMultiplier;
  [Token(Token = "0x40002C6")]
  [FieldOffset(Offset = "0x5C")]
  private float maxSizeMultiplier;
  [Token(Token = "0x40002C7")]
  [FieldOffset(Offset = "0x60")]
  private float minCooldown;
  [Token(Token = "0x40002C8")]
  [FieldOffset(Offset = "0x64")]
  private float nextCheckDamageTime;

  [Token(Token = "0x600023A")]
  [Address(RVA = "0x358370", Offset = "0x356F70", Length = "0x184")]
  protected override void Init()
  {
  }

  [Token(Token = "0x600023B")]
  [Address(RVA = "0x3579E0", Offset = "0x3565E0", Length = "0x3B")]
  protected override void OnWeaponStatUpdate(EStat stat, EWeapon weapon)
  {
  }

  [Token(Token = "0x600023C")]
  [Address(RVA = "0x358500", Offset = "0x357100", Length = "0x19")]
  protected override void OnStatUpdate(EStat stat)
  {
  }

  [Token(Token = "0x600023D")]
  [Address(RVA = "0x358360", Offset = "0x356F60", Length = "0x9")]
  public override float GetAuraRotationSpeed() => 0.0f;

  [Token(Token = "0x600023E")]
  [Address(RVA = "0x358590", Offset = "0x357190", Length = "0x241")]
  private void UpdateSize()
  {
  }

  [Token(Token = "0x600023F")]
  [Address(RVA = "0x3587E0", Offset = "0x3573E0", Length = "0x12D")]
  private void Update()
  {
  }

  [Token(Token = "0x6000240")]
  [Address(RVA = "0x358520", Offset = "0x357120", Length = "0x6C")]
  private void UpdateCooldown()
  {
  }

  [Token(Token = "0x6000241")]
  [Address(RVA = "0x357E70", Offset = "0x356A70", Length = "0x4EC")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000242")]
  [Address(RVA = "0x358910", Offset = "0x357510", Length = "0x2A")]
  public CombatAura()
  {
  }
}
