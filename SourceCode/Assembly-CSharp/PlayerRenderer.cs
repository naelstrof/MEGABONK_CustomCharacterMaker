// Decompiled with JetBrains decompiler
// Type: PlayerRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x200001C")]
public class PlayerRenderer : MonoBehaviour
{
  [Token(Token = "0x40000F4")]
  [FieldOffset(Offset = "0x20")]
  public PlayerMovement playerMovement;
  [Token(Token = "0x40000F5")]
  [FieldOffset(Offset = "0x28")]
  public Animator animator;
  [Token(Token = "0x40000F6")]
  [FieldOffset(Offset = "0x30")]
  public Material damageFlash;
  [Token(Token = "0x40000F7")]
  [FieldOffset(Offset = "0x38")]
  private Material defaultMaterial;
  [Token(Token = "0x40000F8")]
  [FieldOffset(Offset = "0x40")]
  public SkinnedMeshRenderer renderer;
  [Token(Token = "0x40000F9")]
  [FieldOffset(Offset = "0x48")]
  public Transform hips;
  [Token(Token = "0x40000FA")]
  [FieldOffset(Offset = "0x50")]
  public Transform torso;
  [Token(Token = "0x40000FB")]
  [FieldOffset(Offset = "0x58")]
  private Quaternion desiredLookRotation;
  [Token(Token = "0x40000FC")]
  [FieldOffset(Offset = "0x68")]
  private float rotationSpeed;
  [Token(Token = "0x40000FD")]
  [FieldOffset(Offset = "0x6C")]
  private float stoppedMovingAtTime;
  [Token(Token = "0x40000FE")]
  [FieldOffset(Offset = "0x70")]
  private float movingToIdleTimeout;
  [Token(Token = "0x40000FF")]
  [FieldOffset(Offset = "0x74")]
  private bool moving;
  [Token(Token = "0x4000100")]
  [FieldOffset(Offset = "0x78")]
  private float resetMaterialTime;
  [Token(Token = "0x4000101")]
  [FieldOffset(Offset = "0x80")]
  private GameObject rendererObject;
  [Token(Token = "0x4000102")]
  [FieldOffset(Offset = "0x88")]
  public Action<CharacterData> A_CharacterSet;
  [Token(Token = "0x4000103")]
  [FieldOffset(Offset = "0x90")]
  private CharacterData characterData;
  [Token(Token = "0x4000104")]
  [FieldOffset(Offset = "0x98")]
  private SkinData skinData;
  [Token(Token = "0x4000105")]
  [FieldOffset(Offset = "0xA0")]
  protected Material[] activeMaterials;
  [Token(Token = "0x4000106")]
  [FieldOffset(Offset = "0xA8")]
  private List<Material> allMaterials;
  [Token(Token = "0x4000107")]
  [FieldOffset(Offset = "0xB0")]
  private bool isDamageFlash;
  [Token(Token = "0x4000108")]
  [FieldOffset(Offset = "0xB8")]
  private Material[] beforeDamageFlashMaterials;
  [Token(Token = "0x4000109")]
  [FieldOffset(Offset = "0xC0")]
  private bool shieldActive;
  [Token(Token = "0x400010A")]
  [FieldOffset(Offset = "0xC8")]
  private Outline outline;
  [Token(Token = "0x400010B")]
  [FieldOffset(Offset = "0xD0")]
  public Color shieldColor;
  [Token(Token = "0x400010C")]
  [FieldOffset(Offset = "0xE0")]
  public Color colorFreeze;
  [Token(Token = "0x400010D")]
  [FieldOffset(Offset = "0xF0")]
  public Color colorMud;
  [Token(Token = "0x400010E")]
  [FieldOffset(Offset = "0x100")]
  public Color poisonColor;
  [Token(Token = "0x400010F")]
  [FieldOffset(Offset = "0x110")]
  public Color colorNothing;
  [Token(Token = "0x4000110")]
  [FieldOffset(Offset = "0x120")]
  private Vector3 smoothedNormal;
  [Token(Token = "0x4000111")]
  [FieldOffset(Offset = "0x12C")]
  private Vector3 lastValidMoveDirection;
  [Token(Token = "0x4000112")]
  [FieldOffset(Offset = "0x138")]
  private float smoothingMultiplier;

  [Token(Token = "0x60000DE")]
  [Address(RVA = "0x34C6A0", Offset = "0x34B2A0", Length = "0x83E")]
  private void Awake()
  {
  }

  [Token(Token = "0x60000DF")]
  [Address(RVA = "0x34D6F0", Offset = "0x34C2F0", Length = "0x83E")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60000E0")]
  [Address(RVA = "0x34DF60", Offset = "0x34CB60", Length = "0x31")]
  private void OnInventoryInit(PlayerInventory inventory)
  {
  }

  [Token(Token = "0x60000E1")]
  [Address(RVA = "0x34EA80", Offset = "0x34D680", Length = "0x718")]
  public void SetCharacter(
    CharacterData characterData,
    PlayerInventory inventory,
    Vector3 spawnDir)
  {
  }

  [Token(Token = "0x60000E2")]
  [Address(RVA = "0x34D050", Offset = "0x34BC50", Length = "0x466")]
  private void CreateMaterials(int amount)
  {
  }

  [Token(Token = "0x60000E3")]
  [Address(RVA = "0x34F710", Offset = "0x34E310", Length = "0x8EF")]
  public void SetSkin(SkinData skinData)
  {
  }

  [Token(Token = "0x60000E4")]
  [Address(RVA = "0x34D570", Offset = "0x34C170", Length = "0x53")]
  private bool HasRenderer() => false;

  [Token(Token = "0x60000E5")]
  [Address(RVA = "0x34EA40", Offset = "0x34D640", Length = "0x3D")]
  public void ResetMaterial()
  {
  }

  [Token(Token = "0x60000E6")]
  [Address(RVA = "0x34D4C0", Offset = "0x34C0C0", Length = "0x57")]
  public void ForceMoving(bool b)
  {
  }

  [Token(Token = "0x60000E7")]
  [Address(RVA = "0x350000", Offset = "0x34EC00", Length = "0xF5F")]
  private void Update()
  {
  }

  [Token(Token = "0x60000E8")]
  [Address(RVA = "0x34D520", Offset = "0x34C120", Length = "0x47")]
  private void ForceWalkAnimation()
  {
  }

  [Token(Token = "0x60000E9")]
  [Address(RVA = "0x34DFA0", Offset = "0x34CBA0", Length = "0x93")]
  private void OnPause(bool paused)
  {
  }

  [Token(Token = "0x60000EA")]
  [Address(RVA = "0x34D5D0", Offset = "0x34C1D0", Length = "0xE5")]
  private void OnDamage(PlayerHealth ph, DamageContainer dc, bool shieldDamage)
  {
  }

  [Token(Token = "0x60000EB")]
  [Address(RVA = "0x34DF30", Offset = "0x34CB30", Length = "0x28")]
  private void OnHeal(PlayerHealth ph, float amount, bool isShield)
  {
  }

  [Token(Token = "0x60000EC")]
  [Address(RVA = "0x34CEE0", Offset = "0x34BAE0", Length = "0x16E")]
  private void ChangeShield(bool on)
  {
  }

  [Token(Token = "0x60000ED")]
  [Address(RVA = "0x34E050", Offset = "0x34CC50", Length = "0x15B")]
  private void RefreshPlayerOutlines()
  {
  }

  [Token(Token = "0x60000EE")]
  [Address(RVA = "0x34F290", Offset = "0x34DE90", Length = "0x174")]
  public void SetMaterial(Material mat)
  {
  }

  [Token(Token = "0x60000EF")]
  [Address(RVA = "0x34F1A0", Offset = "0x34DDA0", Length = "0xEA")]
  public void SetIdle()
  {
  }

  [Token(Token = "0x60000F0")]
  [Address(RVA = "0x34D6C0", Offset = "0x34C2C0", Length = "0x21")]
  private void OnDeath()
  {
  }

  [Token(Token = "0x60000F1")]
  [Address(RVA = "0x34E040", Offset = "0x34CC40", Length = "0x7")]
  private void OnStatusEffectAdded(EStatusEffect effect, bool newEffect)
  {
  }

  [Token(Token = "0x60000F2")]
  [Address(RVA = "0x34E040", Offset = "0x34CC40", Length = "0x7")]
  private void OnStatusEffectRemoved(EStatusEffect effect)
  {
  }

  [Token(Token = "0x60000F3")]
  [Address(RVA = "0x34E1B0", Offset = "0x34CDB0", Length = "0x88A")]
  private void RefreshStatusEffectColor()
  {
  }

  [Token(Token = "0x60000F4")]
  [Address(RVA = "0x34F410", Offset = "0x34E010", Length = "0xDB")]
  public void SetOutlineColor(Color color)
  {
  }

  [Token(Token = "0x60000F5")]
  [Address(RVA = "0x34F5B0", Offset = "0x34E1B0", Length = "0x154")]
  public void SetRim(Color color, float size)
  {
  }

  [Token(Token = "0x60000F6")]
  [Address(RVA = "0x34F4F0", Offset = "0x34E0F0", Length = "0xBB")]
  public void SetRimOff()
  {
  }

  [Token(Token = "0x60000F7")]
  [Address(RVA = "0x350F60", Offset = "0x34FB60", Length = "0x29")]
  public PlayerRenderer()
  {
  }
}
