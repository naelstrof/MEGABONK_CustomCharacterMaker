// Decompiled with JetBrains decompiler
// Type: PauseAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200002B")]
public class PauseAudio : MonoBehaviour
{
  [Token(Token = "0x400017B")]
  [FieldOffset(Offset = "0x20")]
  public AudioSource source;
  [Token(Token = "0x400017C")]
  [FieldOffset(Offset = "0x28")]
  private bool isPaused;

  [Token(Token = "0x6000156")]
  [Address(RVA = "0x361F80", Offset = "0x360B80", Length = "0x140")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000157")]
  [Address(RVA = "0x3620D0", Offset = "0x360CD0", Length = "0x140")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000158")]
  [Address(RVA = "0x362290", Offset = "0x360E90", Length = "0x49")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x6000159")]
  [Address(RVA = "0x362220", Offset = "0x360E20", Length = "0x6E")]
  private void OnPause(bool paused)
  {
  }

  [Token(Token = "0x600015A")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public PauseAudio()
  {
  }
}
