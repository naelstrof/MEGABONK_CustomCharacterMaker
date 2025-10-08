// Decompiled with JetBrains decompiler
// Type: PlayerEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200001E")]
public class PlayerEffects : MonoBehaviour
{
  [Token(Token = "0x4000117")]
  [FieldOffset(Offset = "0x20")]
  public GameObject mirrorFx;
  [Token(Token = "0x4000118")]
  [FieldOffset(Offset = "0x28")]
  public GameObject flexFx;
  [Token(Token = "0x4000119")]
  [FieldOffset(Offset = "0x30")]
  public PlayerRenderer playerRenderer;
  [Token(Token = "0x400011A")]
  [FieldOffset(Offset = "0x38")]
  public ParticleSystem dashPs;
  [Token(Token = "0x400011B")]
  [FieldOffset(Offset = "0x40")]
  public ParticleSystem dashCloudPs;
  [Token(Token = "0x400011C")]
  [FieldOffset(Offset = "0x48")]
  private ParticleSystem.EmissionModule dashEmission;
  [Token(Token = "0x400011D")]
  [FieldOffset(Offset = "0x50")]
  private float dangerValue;
  [Token(Token = "0x400011E")]
  [FieldOffset(Offset = "0x54")]
  private float dangerTarget;
  [Token(Token = "0x400011F")]
  [FieldOffset(Offset = "0x58")]
  private float lastHp;
  [Token(Token = "0x4000120")]
  [FieldOffset(Offset = "0x5C")]
  private float timeLowHp;
  [Token(Token = "0x4000121")]
  private const float dangerIncreaseSpeed = 4f;
  [Token(Token = "0x4000122")]
  private const float dangerDecaySpeed = 0.02f;
  [Token(Token = "0x4000123")]
  private const float sustainedLowThreshold = 15f;
  [Token(Token = "0x4000124")]
  private const float lerpSpeed = 1.5f;

  [Token(Token = "0x60000FB")]
  [Address(RVA = "0x340550", Offset = "0x33F150", Length = "0x33A")]
  private void Awake()
  {
  }

  [Token(Token = "0x60000FC")]
  [Address(RVA = "0x340B90", Offset = "0x33F790", Length = "0x317")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60000FD")]
  [Address(RVA = "0x340A10", Offset = "0x33F610", Length = "0x179")]
  private void OnCharacterSet(CharacterData characterData)
  {
  }

  [Token(Token = "0x60000FE")]
  [Address(RVA = "0x340F20", Offset = "0x33FB20", Length = "0x560")]
  private void Update()
  {
  }

  [Token(Token = "0x60000FF")]
  [Address(RVA = "0x340890", Offset = "0x33F490", Length = "0x124")]
  private void DashFx()
  {
  }

  [Token(Token = "0x6000100")]
  [Address(RVA = "0x340EF0", Offset = "0x33FAF0", Length = "0x27")]
  private float RemapHpRatio(float hpRatio, float min, float max) => 0.0f;

  [Token(Token = "0x6000101")]
  [Address(RVA = "0x340A00", Offset = "0x33F600", Length = "0x6")]
  public float GetDangerRatio() => 0.0f;

  [Token(Token = "0x6000102")]
  [Address(RVA = "0x3409C0", Offset = "0x33F5C0", Length = "0x32")]
  public float GetDangerRatioMusic() => 0.0f;

  [Token(Token = "0x6000103")]
  [Address(RVA = "0x340ED0", Offset = "0x33FAD0", Length = "0x1E")]
  private void OnMirrorReady(bool isReady)
  {
  }

  [Token(Token = "0x6000104")]
  [Address(RVA = "0x340EB0", Offset = "0x33FAB0", Length = "0x1E")]
  private void OnFlexReady(bool isReady)
  {
  }

  [Token(Token = "0x6000105")]
  [Address(RVA = "0x341490", Offset = "0x340090", Length = "0xE")]
  public PlayerEffects()
  {
  }
}
