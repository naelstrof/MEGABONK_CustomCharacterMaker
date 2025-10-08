// Decompiled with JetBrains decompiler
// Type: FrictionModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000015")]
public class FrictionModifier : MonoBehaviour
{
  [Token(Token = "0x400005A")]
  [FieldOffset(Offset = "0x20")]
  public FrictionModifier.EFrictionSurface frictionSurface;

  [Token(Token = "0x600004D")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public FrictionModifier()
  {
  }

  [Token(Token = "0x2000016")]
  public enum EFrictionSurface
  {
    [Token(Token = "0x400005C")] Normal,
    [Token(Token = "0x400005D")] Ice,
  }
}
