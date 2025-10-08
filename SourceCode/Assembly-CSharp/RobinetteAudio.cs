// Decompiled with JetBrains decompiler
// Type: RobinetteAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200002E")]
public class RobinetteAudio : MonoBehaviour
{
  [Token(Token = "0x4000186")]
  [FieldOffset(Offset = "0x20")]
  public AudioSource audioSource;
  [Token(Token = "0x4000187")]
  [FieldOffset(Offset = "0x28")]
  public float desiredVolume;
  [Token(Token = "0x4000188")]
  [FieldOffset(Offset = "0x30")]
  public Animator animator;

  [Token(Token = "0x6000164")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000165")]
  [Address(RVA = "0x3652E0", Offset = "0x363EE0", Length = "0x1F8")]
  private void Update()
  {
  }

  [Token(Token = "0x6000166")]
  [Address(RVA = "0x359A40", Offset = "0x358640", Length = "0xE")]
  public RobinetteAudio()
  {
  }
}
