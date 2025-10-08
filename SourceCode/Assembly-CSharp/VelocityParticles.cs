// Decompiled with JetBrains decompiler
// Type: VelocityParticles
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000103")]
public class VelocityParticles : MonoBehaviour
{
  [Token(Token = "0x40007F7")]
  [FieldOffset(Offset = "0x20")]
  public ParticleSystem[] particleSystems;
  [Token(Token = "0x40007F8")]
  [FieldOffset(Offset = "0x28")]
  private ParticleSystem.VelocityOverLifetimeModule[] velocityModules;
  [Token(Token = "0x40007F9")]
  [FieldOffset(Offset = "0x30")]
  private Vector3 velocity;
  [Token(Token = "0x40007FA")]
  [FieldOffset(Offset = "0x3C")]
  private Vector3 previousPos;

  [Token(Token = "0x60006C4")]
  [Address(RVA = "0x4CA900", Offset = "0x4C9500", Length = "0x116")]
  private void Start()
  {
  }

  [Token(Token = "0x60006C5")]
  [Address(RVA = "0x4CAA20", Offset = "0x4C9620", Length = "0x2C9")]
  private void Update()
  {
  }

  [Token(Token = "0x60006C6")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public VelocityParticles()
  {
  }
}
