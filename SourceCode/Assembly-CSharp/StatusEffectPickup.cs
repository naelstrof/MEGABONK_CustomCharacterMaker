// Decompiled with JetBrains decompiler
// Type: StatusEffectPickup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Pickups;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000AD")]
public class StatusEffectPickup : MonoBehaviour
{
  [Token(Token = "0x400056E")]
  [FieldOffset(Offset = "0x20")]
  public EPickup ePickup;
  [Token(Token = "0x400056F")]
  [FieldOffset(Offset = "0x24")]
  public EStatusEffect statusEffect;
  [Token(Token = "0x4000570")]
  [FieldOffset(Offset = "0x28")]
  public GameObject sparksEffect;
  [Token(Token = "0x4000571")]
  [FieldOffset(Offset = "0x30")]
  public GameObject pickupImpactEffect;
  [Token(Token = "0x4000572")]
  [FieldOffset(Offset = "0x38")]
  public bool rotateToPlayerVelocity;
  [Token(Token = "0x4000573")]
  [FieldOffset(Offset = "0x39")]
  public bool useFeetPosition;
  [Token(Token = "0x4000574")]
  [FieldOffset(Offset = "0x3C")]
  private float timeLeft;

  [Token(Token = "0x600045E")]
  [Address(RVA = "0x48F210", Offset = "0x48DE10", Length = "0x501")]
  public void Set()
  {
  }

  [Token(Token = "0x600045F")]
  [Address(RVA = "0x48F1D0", Offset = "0x48DDD0", Length = "0x30")]
  private void OnPickupTriggered(Pickup pickup)
  {
  }

  [Token(Token = "0x6000460")]
  [Address(RVA = "0x48F720", Offset = "0x48E320", Length = "0x275")]
  private void Update()
  {
  }

  [Token(Token = "0x6000461")]
  [Address(RVA = "0x48EE90", Offset = "0x48DA90", Length = "0x1BF")]
  private bool HasStatusEffect() => false;

  [Token(Token = "0x6000462")]
  [Address(RVA = "0x48EE30", Offset = "0x48DA30", Length = "0x56")]
  private void DestroySelf()
  {
  }

  [Token(Token = "0x6000463")]
  [Address(RVA = "0x48F050", Offset = "0x48DC50", Length = "0x17F")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000464")]
  [Address(RVA = "0x48F9A0", Offset = "0x48E5A0", Length = "0xB")]
  public StatusEffectPickup()
  {
  }
}
