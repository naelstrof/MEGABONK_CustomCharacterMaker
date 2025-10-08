// Decompiled with JetBrains decompiler
// Type: SlowmoPP
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x200014B")]
public class SlowmoPP : MonoBehaviour
{
  [Token(Token = "0x40009B1")]
  [FieldOffset(Offset = "0x20")]
  public PostProcessVolume volume;
  [Token(Token = "0x40009B2")]
  [FieldOffset(Offset = "0x28")]
  private ColorGrading cg;
  [Token(Token = "0x40009B3")]
  [FieldOffset(Offset = "0x30")]
  private LensDistortion lens;
  [Token(Token = "0x40009B4")]
  [FieldOffset(Offset = "0x38")]
  private bool isTimeFreeze;
  [Token(Token = "0x40009B5")]
  [FieldOffset(Offset = "0x39")]
  private bool isSlowmo;
  [Token(Token = "0x40009B6")]
  [FieldOffset(Offset = "0x3A")]
  private bool isDone;
  [Token(Token = "0x40009B7")]
  [FieldOffset(Offset = "0x3C")]
  private float timer;
  [Token(Token = "0x40009B8")]
  [FieldOffset(Offset = "0x40")]
  private float transitionTime;
  [Token(Token = "0x40009B9")]
  [FieldOffset(Offset = "0x44")]
  private float dLens;
  [Token(Token = "0x40009BA")]
  [FieldOffset(Offset = "0x48")]
  private float dExposure;
  [Token(Token = "0x40009BB")]
  [FieldOffset(Offset = "0x4C")]
  private float dSaturation;
  [Token(Token = "0x40009BC")]
  [FieldOffset(Offset = "0x50")]
  private float fromLens;
  [Token(Token = "0x40009BD")]
  [FieldOffset(Offset = "0x54")]
  private float fromExposure;
  [Token(Token = "0x40009BE")]
  [FieldOffset(Offset = "0x58")]
  private float fromSaturation;
  [Token(Token = "0x40009BF")]
  [FieldOffset(Offset = "0x5C")]
  private Color desiredColor;
  [Token(Token = "0x40009C0")]
  [FieldOffset(Offset = "0x6C")]
  private Color fromColor;

  [Token(Token = "0x600085C")]
  [Address(RVA = "0x4DD970", Offset = "0x4DC570", Length = "0x452")]
  private void Awake()
  {
  }

  [Token(Token = "0x600085D")]
  [Address(RVA = "0x4DDE90", Offset = "0x4DCA90", Length = "0x336")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600085E")]
  [Address(RVA = "0x4DE1E0", Offset = "0x4DCDE0", Length = "0x352")]
  private void RefreshTimeFreeze()
  {
  }

  [Token(Token = "0x600085F")]
  [Address(RVA = "0x4DE1D0", Offset = "0x4DCDD0", Length = "0xD")]
  private void OnStatusEffectAdded(EStatusEffect eStatusEffect, bool newEffect)
  {
  }

  [Token(Token = "0x6000860")]
  [Address(RVA = "0x4DE1D0", Offset = "0x4DCDD0", Length = "0xD")]
  private void OnStatusEffectRemoved(EStatusEffect eStatusEffect)
  {
  }

  [Token(Token = "0x6000861")]
  [Address(RVA = "0x4DE540", Offset = "0x4DD140", Length = "0x16E")]
  private void StartTimeFreeze()
  {
  }

  [Token(Token = "0x6000862")]
  [Address(RVA = "0x4DDDD0", Offset = "0x4DC9D0", Length = "0xB6")]
  private void EndTimeFreeze()
  {
  }

  [Token(Token = "0x6000863")]
  [Address(RVA = "0x4DE6B0", Offset = "0x4DD2B0", Length = "0x268")]
  private void Update()
  {
  }

  [Token(Token = "0x6000864")]
  [Address(RVA = "0x4DE920", Offset = "0x4DD520", Length = "0x15")]
  public SlowmoPP()
  {
  }
}
