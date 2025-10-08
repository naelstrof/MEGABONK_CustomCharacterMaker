// Decompiled with JetBrains decompiler
// Type: GenericPowerupPrefab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Pickups;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000A7")]
public class GenericPowerupPrefab : MonoBehaviour
{
  [Token(Token = "0x400052A")]
  [FieldOffset(Offset = "0x20")]
  public Pickup pickup;
  [Token(Token = "0x400052B")]
  [FieldOffset(Offset = "0x28")]
  public ParticleSystem ps;
  [Token(Token = "0x400052C")]
  [FieldOffset(Offset = "0x30")]
  public MeshRenderer minimapRenderer;
  [Token(Token = "0x400052D")]
  [FieldOffset(Offset = "0x38")]
  public MeshRenderer iconRenderer;
  [Token(Token = "0x400052E")]
  [FieldOffset(Offset = "0x40")]
  public Material hpMaterial;
  [Token(Token = "0x400052F")]
  [FieldOffset(Offset = "0x48")]
  public Material nukeMaterial;
  [Token(Token = "0x4000530")]
  [FieldOffset(Offset = "0x50")]
  public Material timeFreezeMaterial;
  [Token(Token = "0x4000531")]
  [FieldOffset(Offset = "0x58")]
  public Material shieldMaterial;
  [Token(Token = "0x4000532")]
  [FieldOffset(Offset = "0x60")]
  public Material rageMaterial;
  [Token(Token = "0x4000533")]
  [FieldOffset(Offset = "0x68")]
  public Material hasteMaterial;
  [Token(Token = "0x4000534")]
  [FieldOffset(Offset = "0x70")]
  public Material stonksMaterial;
  [Token(Token = "0x4000535")]
  [FieldOffset(Offset = "0x78")]
  public Material magnetMaterial;
  [Token(Token = "0x4000536")]
  [FieldOffset(Offset = "0x80")]
  private MaterialPropertyBlock propertyBlock;

  [Token(Token = "0x600042A")]
  [Address(RVA = "0x476190", Offset = "0x474D90", Length = "0x90")]
  private void TryInit()
  {
  }

  [Token(Token = "0x600042B")]
  [Address(RVA = "0x475F90", Offset = "0x474B90", Length = "0x1D4")]
  public void Set(EPickup ePickup)
  {
  }

  [Token(Token = "0x600042C")]
  [Address(RVA = "0x475F20", Offset = "0x474B20", Length = "0x4C")]
  private Material GetMinimapMaterial(EPickup ePickup) => (Material) null;

  [Token(Token = "0x600042D")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public GenericPowerupPrefab()
  {
  }
}
