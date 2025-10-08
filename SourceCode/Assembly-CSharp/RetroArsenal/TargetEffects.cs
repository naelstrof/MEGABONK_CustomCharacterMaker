// Decompiled with JetBrains decompiler
// Type: RetroArsenal.TargetEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace RetroArsenal
{
  [Token(Token = "0x2000465")]
  [Serializable]
  public class TargetEffects
  {
    [Token(Token = "0x4001CF0")]
    [FieldOffset(Offset = "0x10")]
    public GameObject hitParticle;
    [Token(Token = "0x4001CF1")]
    [FieldOffset(Offset = "0x18")]
    public GameObject respawnParticle;
    [Token(Token = "0x4001CF2")]
    [FieldOffset(Offset = "0x20")]
    public List<GameObject> deathParticles;
    [Token(Token = "0x4001CF3")]
    [FieldOffset(Offset = "0x28")]
    public AudioClip destroySound;
    [Token(Token = "0x4001CF4")]
    [FieldOffset(Offset = "0x30")]
    public AudioClip respawnSound;

    [Token(Token = "0x6001FB1")]
    [Address(RVA = "0x45A310", Offset = "0x458F10", Length = "0x77")]
    public TargetEffects()
    {
    }
  }
}
