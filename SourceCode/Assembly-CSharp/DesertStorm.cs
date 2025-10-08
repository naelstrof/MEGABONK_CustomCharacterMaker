// Decompiled with JetBrains decompiler
// Type: DesertStorm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000076")]
public class DesertStorm : MonoBehaviour
{
  [Token(Token = "0x400039A")]
  [FieldOffset(Offset = "0x20")]
  public MeshRenderer fogOfWarRenderer;
  [Token(Token = "0x400039B")]
  [FieldOffset(Offset = "0x28")]
  private Material fogOfWarMaterial;
  [Token(Token = "0x400039C")]
  [FieldOffset(Offset = "0x30")]
  public ParticleSystem[] stormParticles;
  [Token(Token = "0x400039D")]
  [FieldOffset(Offset = "0x38")]
  public AudioSource audio;
  [Token(Token = "0x400039E")]
  [FieldOffset(Offset = "0x40")]
  private float fadeOverTime;
  [Token(Token = "0x400039F")]
  [FieldOffset(Offset = "0x44")]
  private float fadeTime;
  [Token(Token = "0x40003A0")]
  [FieldOffset(Offset = "0x48")]
  private bool isStorm;
  [Token(Token = "0x40003A1")]
  [FieldOffset(Offset = "0x4C")]
  private float audioVolume;
  [Token(Token = "0x40003A2")]
  [FieldOffset(Offset = "0x50")]
  private float oldFogValue;
  [Token(Token = "0x40003A3")]
  [FieldOffset(Offset = "0x54")]
  private Color oldFogColor;
  [Token(Token = "0x40003A4")]
  [FieldOffset(Offset = "0x64")]
  private Color stormColor;
  [Token(Token = "0x40003A5")]
  [FieldOffset(Offset = "0x74")]
  private float stormFogIntensity;

  [Token(Token = "0x60002F6")]
  [Address(RVA = "0x45FE00", Offset = "0x45EA00", Length = "0x98")]
  private void TryInit()
  {
  }

  [Token(Token = "0x60002F7")]
  [Address(RVA = "0x45FB80", Offset = "0x45E780", Length = "0x1FE")]
  public void FadeIn()
  {
  }

  [Token(Token = "0x60002F8")]
  [Address(RVA = "0x45FD80", Offset = "0x45E980", Length = "0x70")]
  public void FadeOut()
  {
  }

  [Token(Token = "0x60002F9")]
  [Address(RVA = "0x45FEA0", Offset = "0x45EAA0", Length = "0x347")]
  private void Update()
  {
  }

  [Token(Token = "0x60002FA")]
  [Address(RVA = "0x4601F0", Offset = "0x45EDF0", Length = "0x15")]
  public DesertStorm()
  {
  }
}
