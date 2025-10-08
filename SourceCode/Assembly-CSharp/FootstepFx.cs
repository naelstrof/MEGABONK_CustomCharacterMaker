// Decompiled with JetBrains decompiler
// Type: FootstepFx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000FC")]
public class FootstepFx : MonoBehaviour
{
  [Token(Token = "0x40007DD")]
  [FieldOffset(Offset = "0x20")]
  public RandomSfx sfx;
  [Token(Token = "0x40007DE")]
  [FieldOffset(Offset = "0x28")]
  public ParticleSystem ps;
  [Token(Token = "0x40007DF")]
  [FieldOffset(Offset = "0x30")]
  private bool inited;

  [Token(Token = "0x60006B0")]
  [Address(RVA = "0x4B7AF0", Offset = "0x4B66F0", Length = "0xCA")]
  private void Awake()
  {
  }

  [Token(Token = "0x60006B1")]
  [Address(RVA = "0x4B7BC0", Offset = "0x4B67C0", Length = "0x3F")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60006B2")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public FootstepFx()
  {
  }
}
