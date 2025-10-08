// Decompiled with JetBrains decompiler
// Type: PlaySfxOnEnable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200002C")]
public class PlaySfxOnEnable : MonoBehaviour
{
  [Token(Token = "0x400017D")]
  [FieldOffset(Offset = "0x20")]
  public RandomSfx randomSfx;
  [Token(Token = "0x400017E")]
  [FieldOffset(Offset = "0x28")]
  public AudioSource audioSource;

  [Token(Token = "0x600015B")]
  [Address(RVA = "0x3622E0", Offset = "0x360EE0", Length = "0x98")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x600015C")]
  [Address(RVA = "0x362380", Offset = "0x360F80", Length = "0x74")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x600015D")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public PlaySfxOnEnable()
  {
  }
}
