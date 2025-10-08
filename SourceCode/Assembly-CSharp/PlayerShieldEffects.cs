// Decompiled with JetBrains decompiler
// Type: PlayerShieldEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200001F")]
public class PlayerShieldEffects : MonoBehaviour
{
  [Token(Token = "0x4000125")]
  [FieldOffset(Offset = "0x20")]
  public ParticleSystem shieldBreakFx;
  [Token(Token = "0x4000126")]
  [FieldOffset(Offset = "0x28")]
  public ParticleSystem shieldChargeFx;
  [Token(Token = "0x4000127")]
  [FieldOffset(Offset = "0x30")]
  public AudioSource shieldBreakSfx;
  [Token(Token = "0x4000128")]
  [FieldOffset(Offset = "0x38")]
  public AudioSource shieldChargeSfx;
  [Token(Token = "0x4000129")]
  [FieldOffset(Offset = "0x40")]
  private bool shieldBroken;

  [Token(Token = "0x6000106")]
  [Address(RVA = "0x350F90", Offset = "0x34FB90", Length = "0x241")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000107")]
  [Address(RVA = "0x351230", Offset = "0x34FE30", Length = "0x241")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000108")]
  [Address(RVA = "0x3511E0", Offset = "0x34FDE0", Length = "0x4A")]
  private void OnDamage(PlayerHealth ph, DamageContainer dc, bool shieldDamage)
  {
  }

  [Token(Token = "0x6000109")]
  [Address(RVA = "0x351480", Offset = "0x350080", Length = "0x50")]
  private void OnHeal(PlayerHealth ph, float amount, bool isShield)
  {
  }

  [Token(Token = "0x600010A")]
  [Address(RVA = "0x3514E0", Offset = "0x3500E0", Length = "0xB")]
  public PlayerShieldEffects()
  {
  }
}
