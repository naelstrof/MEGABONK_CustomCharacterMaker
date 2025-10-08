// Decompiled with JetBrains decompiler
// Type: AnimationFootstepFx2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200003E")]
public class AnimationFootstepFx2 : MonoBehaviour
{
  [Token(Token = "0x40001C6")]
  [FieldOffset(Offset = "0x20")]
  public Transform leftFoot;
  [Token(Token = "0x40001C7")]
  [FieldOffset(Offset = "0x28")]
  public Transform rightFoot;

  [Token(Token = "0x60001B5")]
  [Address(RVA = "0x3521B0", Offset = "0x350DB0", Length = "0x4B")]
  public void RightFoot2()
  {
  }

  [Token(Token = "0x60001B6")]
  [Address(RVA = "0x352160", Offset = "0x350D60", Length = "0x4B")]
  public void LeftFoot2()
  {
  }

  [Token(Token = "0x60001B7")]
  [Address(RVA = "0x352200", Offset = "0x350E00", Length = "0x1B2")]
  private void Spawn(Vector3 position)
  {
  }

  [Token(Token = "0x60001B8")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public AnimationFootstepFx2()
  {
  }
}
