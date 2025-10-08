// Decompiled with JetBrains decompiler
// Type: LowpassController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Audio;

[Token(Token = "0x2000028")]
public class LowpassController : MonoBehaviour
{
  [Token(Token = "0x400015D")]
  [FieldOffset(Offset = "0x20")]
  public AudioLowPassFilter filter;
  [Token(Token = "0x400015E")]
  [FieldOffset(Offset = "0x28")]
  private float defaultCutoff;
  [Token(Token = "0x400015F")]
  [FieldOffset(Offset = "0x2C")]
  private float desiredCutoff;
  [Token(Token = "0x4000160")]
  [FieldOffset(Offset = "0x30")]
  private float lowCutoff;
  [Token(Token = "0x4000161")]
  [FieldOffset(Offset = "0x34")]
  private bool isTimeFreeze;
  [Token(Token = "0x4000162")]
  [FieldOffset(Offset = "0x35")]
  private bool isUnderwater;
  [Token(Token = "0x4000163")]
  [FieldOffset(Offset = "0x38")]
  public AudioMixer audioMixer;
  [Token(Token = "0x4000164")]
  [FieldOffset(Offset = "0x40")]
  private float lowpassFrequency;

  [Token(Token = "0x6000134")]
  [Address(RVA = "0x35E1A0", Offset = "0x35CDA0", Length = "0x51D")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000135")]
  [Address(RVA = "0x35E7E0", Offset = "0x35D3E0", Length = "0x5AF")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000136")]
  [Address(RVA = "0x35EDA0", Offset = "0x35D9A0", Length = "0x5")]
  private void OnWaterFilterEnter(Water filter)
  {
  }

  [Token(Token = "0x6000137")]
  [Address(RVA = "0x35EDB0", Offset = "0x35D9B0", Length = "0x5")]
  private void OnWaterFilterExit(Water filter)
  {
  }

  [Token(Token = "0x6000138")]
  [Address(RVA = "0x35ED90", Offset = "0x35D990", Length = "0xD")]
  private void OnStatusEffectAdded(EStatusEffect eStatusEffect, bool newEffect)
  {
  }

  [Token(Token = "0x6000139")]
  [Address(RVA = "0x35ED90", Offset = "0x35D990", Length = "0xD")]
  private void OnStatusEffectRemoved(EStatusEffect eStatusEffect)
  {
  }

  [Token(Token = "0x600013A")]
  [Address(RVA = "0x35EDC0", Offset = "0x35D9C0", Length = "0x10C")]
  private void RefreshTimeFreeze()
  {
  }

  [Token(Token = "0x600013B")]
  [Address(RVA = "0x35E6C0", Offset = "0x35D2C0", Length = "0x115")]
  private float GetDesiredCutoff() => 0.0f;

  [Token(Token = "0x600013C")]
  [Address(RVA = "0x35EED0", Offset = "0x35DAD0", Length = "0x212")]
  private void Update()
  {
  }

  [Token(Token = "0x600013D")]
  [Address(RVA = "0x35F0F0", Offset = "0x35DCF0", Length = "0x23")]
  public LowpassController()
  {
  }
}
