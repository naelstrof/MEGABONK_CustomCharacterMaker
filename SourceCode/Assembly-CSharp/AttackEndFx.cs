// Decompiled with JetBrains decompiler
// Type: AttackEndFx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000B1")]
public class AttackEndFx : MonoBehaviour
{
  [Token(Token = "0x4000597")]
  [FieldOffset(Offset = "0x20")]
  public ParticleSystem ps;

  [Token(Token = "0x600047E")]
  [Address(RVA = "0x475000", Offset = "0x473C00", Length = "0x1D")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x600047F")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public AttackEndFx()
  {
  }
}
