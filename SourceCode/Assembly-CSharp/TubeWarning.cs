// Decompiled with JetBrains decompiler
// Type: TubeWarning
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

[Token(Token = "0x200006C")]
public class TubeWarning : MonoBehaviour
{
  [Token(Token = "0x4000350")]
  [FieldOffset(Offset = "0x20")]
  public ParticleSystem ps;
  [Token(Token = "0x4000351")]
  [FieldOffset(Offset = "0x28")]
  private float timer;
  [Token(Token = "0x4000352")]
  [FieldOffset(Offset = "0x2C")]
  private float fixedTimer;
  [Token(Token = "0x4000353")]
  [FieldOffset(Offset = "0x30")]
  private float warningTime;
  [Token(Token = "0x4000354")]
  [FieldOffset(Offset = "0x38")]
  private Action completeAction;
  [Token(Token = "0x4000355")]
  [FieldOffset(Offset = "0x40")]
  private bool done;

  [Token(Token = "0x60002B8")]
  [Address(RVA = "0x4707F0", Offset = "0x46F3F0", Length = "0x124")]
  public void Set(float radius, float length, float time, Action completeAction)
  {
  }

  [Token(Token = "0x60002B9")]
  [Address(RVA = "0x470920", Offset = "0x46F520", Length = "0x22F")]
  private void Update()
  {
  }

  [Token(Token = "0x60002BA")]
  [Address(RVA = "0x470730", Offset = "0x46F330", Length = "0xB8")]
  public void ReleaseToPool()
  {
  }

  [Token(Token = "0x60002BB")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public TubeWarning()
  {
  }
}
