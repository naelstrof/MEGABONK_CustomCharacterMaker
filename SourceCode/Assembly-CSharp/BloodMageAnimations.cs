// Decompiled with JetBrains decompiler
// Type: BloodMageAnimations
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200003F")]
public class BloodMageAnimations : MonoBehaviour
{
  [Token(Token = "0x40001C8")]
  [FieldOffset(Offset = "0x20")]
  public AudioSource audioHoverLoop;
  [Token(Token = "0x40001C9")]
  [FieldOffset(Offset = "0x28")]
  private float defaultVolume;
  [Token(Token = "0x40001CA")]
  [FieldOffset(Offset = "0x2C")]
  private float currentPitch;

  [Token(Token = "0x60001B9")]
  [Address(RVA = "0x352620", Offset = "0x351220", Length = "0x29")]
  private void Awake()
  {
  }

  [Token(Token = "0x60001BA")]
  [Address(RVA = "0x352650", Offset = "0x351250", Length = "0x2AA")]
  private void Update()
  {
  }

  [Token(Token = "0x60001BB")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public BloodMageAnimations()
  {
  }
}
