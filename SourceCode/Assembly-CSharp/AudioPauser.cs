// Decompiled with JetBrains decompiler
// Type: AudioPauser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000025")]
public class AudioPauser : MonoBehaviour
{
  [Token(Token = "0x4000152")]
  [FieldOffset(Offset = "0x20")]
  public AudioSource audioSource;

  [Token(Token = "0x6000128")]
  [Address(RVA = "0x33A430", Offset = "0x339030", Length = "0x7")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x6000129")]
  [Address(RVA = "0x33A1A0", Offset = "0x338DA0", Length = "0x89")]
  private void FindAudioSource()
  {
  }

  [Token(Token = "0x600012A")]
  [Address(RVA = "0x33A050", Offset = "0x338C50", Length = "0x14A")]
  private void Awake()
  {
  }

  [Token(Token = "0x600012B")]
  [Address(RVA = "0x33A230", Offset = "0x338E30", Length = "0x140")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600012C")]
  [Address(RVA = "0x33A380", Offset = "0x338F80", Length = "0xA0")]
  private void OnPause(bool isPaused)
  {
  }

  [Token(Token = "0x600012D")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public AudioPauser()
  {
  }
}
