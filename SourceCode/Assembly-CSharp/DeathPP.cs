// Decompiled with JetBrains decompiler
// Type: DeathPP
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000147")]
public class DeathPP : MonoBehaviour
{
  [Token(Token = "0x4000991")]
  [FieldOffset(Offset = "0x20")]
  public PostProcessVolume volume;
  [Token(Token = "0x4000992")]
  [FieldOffset(Offset = "0x28")]
  private ColorGrading cg;
  [Token(Token = "0x4000993")]
  [FieldOffset(Offset = "0x30")]
  private Vignette vignette;
  [Token(Token = "0x4000994")]
  [FieldOffset(Offset = "0x38")]
  private float deadVignetteIntensity;
  [Token(Token = "0x4000995")]
  [FieldOffset(Offset = "0x3C")]
  private float deadVignetteSmoothness;
  [Token(Token = "0x4000996")]
  [FieldOffset(Offset = "0x40")]
  private float deadContrast;
  [Token(Token = "0x4000997")]
  [FieldOffset(Offset = "0x44")]
  private float deadSaturation;
  [Token(Token = "0x4000998")]
  [FieldOffset(Offset = "0x48")]
  private bool dead;

  [Token(Token = "0x6000840")]
  [Address(RVA = "0x4D0780", Offset = "0x4CF380", Length = "0x1CF")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000841")]
  [Address(RVA = "0x4D0950", Offset = "0x4CF550", Length = "0x138")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000842")]
  [Address(RVA = "0x4D0A90", Offset = "0x4CF690", Length = "0x51")]
  private void OnPlayerDied()
  {
  }

  [Token(Token = "0x6000843")]
  [Address(RVA = "0x4D0AF0", Offset = "0x4CF6F0", Length = "0x24C")]
  private void Update()
  {
  }

  [Token(Token = "0x6000844")]
  [Address(RVA = "0x4D0D40", Offset = "0x4CF940", Length = "0x23")]
  public DeathPP()
  {
  }
}
