// Decompiled with JetBrains decompiler
// Type: Campfire
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000040")]
public class Campfire : MonoBehaviour
{
  [Token(Token = "0x40001CB")]
  [FieldOffset(Offset = "0x20")]
  public ParticleSystem createFx;
  [Token(Token = "0x40001CC")]
  [FieldOffset(Offset = "0x28")]
  public AudioSource audioSource;
  [Token(Token = "0x40001CD")]
  [FieldOffset(Offset = "0x30")]
  public RandomSfx randomSfx;
  [Token(Token = "0x40001CE")]
  [FieldOffset(Offset = "0x38")]
  private float animationTimer;
  [Token(Token = "0x40001CF")]
  [FieldOffset(Offset = "0x3C")]
  private bool isActive;
  [Token(Token = "0x40001D0")]
  [FieldOffset(Offset = "0x40")]
  private float animateTime;
  [Token(Token = "0x40001D1")]
  [FieldOffset(Offset = "0x44")]
  private Vector3 fromScale;

  [Token(Token = "0x60001BC")]
  [Address(RVA = "0x355F40", Offset = "0x354B40", Length = "0x291")]
  public void StartFire(Vector3 pos)
  {
  }

  [Token(Token = "0x60001BD")]
  [Address(RVA = "0x355F30", Offset = "0x354B30", Length = "0x5")]
  public void EndFire()
  {
  }

  [Token(Token = "0x60001BE")]
  [Address(RVA = "0x3561E0", Offset = "0x354DE0", Length = "0x1CB")]
  private void Update()
  {
  }

  [Token(Token = "0x60001BF")]
  [Address(RVA = "0x3563B0", Offset = "0x354FB0", Length = "0xE")]
  public Campfire()
  {
  }
}
