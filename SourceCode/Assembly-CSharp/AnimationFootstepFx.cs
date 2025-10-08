// Decompiled with JetBrains decompiler
// Type: AnimationFootstepFx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200003D")]
public class AnimationFootstepFx : MonoBehaviour
{
  [Token(Token = "0x40001C4")]
  [FieldOffset(Offset = "0x20")]
  public Transform leftFoot;
  [Token(Token = "0x40001C5")]
  [FieldOffset(Offset = "0x28")]
  public Transform rightFoot;

  [Token(Token = "0x60001B1")]
  [Address(RVA = "0x352410", Offset = "0x351010", Length = "0x4B")]
  public void RightFoot()
  {
  }

  [Token(Token = "0x60001B2")]
  [Address(RVA = "0x3523C0", Offset = "0x350FC0", Length = "0x4B")]
  public void LeftFoot()
  {
  }

  [Token(Token = "0x60001B3")]
  [Address(RVA = "0x352460", Offset = "0x351060", Length = "0x1B2")]
  private void Spawn(Vector3 position)
  {
  }

  [Token(Token = "0x60001B4")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public AnimationFootstepFx()
  {
  }
}
