// Decompiled with JetBrains decompiler
// Type: AnimationEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200003C")]
public class AnimationEffect : MonoBehaviour
{
  [Token(Token = "0x40001C2")]
  [FieldOffset(Offset = "0x20")]
  public RandomSfx[] audioSources;
  [Token(Token = "0x40001C3")]
  [FieldOffset(Offset = "0x28")]
  public ParticleSystem[] particles;

  [Token(Token = "0x60001AE")]
  [Address(RVA = "0x352120", Offset = "0x350D20", Length = "0x36")]
  public void PlayEffect(int index)
  {
  }

  [Token(Token = "0x60001AF")]
  [Address(RVA = "0x3520D0", Offset = "0x350CD0", Length = "0x42")]
  public void PlayAudio(int index)
  {
  }

  [Token(Token = "0x60001B0")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public AnimationEffect()
  {
  }
}
