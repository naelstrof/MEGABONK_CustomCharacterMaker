// Decompiled with JetBrains decompiler
// Type: ResetTrail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000105")]
public class ResetTrail : MonoBehaviour
{
  [Token(Token = "0x40007FE")]
  [FieldOffset(Offset = "0x20")]
  public TrailRenderer trailRenderer;

  [Token(Token = "0x60006CB")]
  [Address(RVA = "0x4C1C80", Offset = "0x4C0880", Length = "0x73")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x60006CC")]
  [Address(RVA = "0x4C1D00", Offset = "0x4C0900", Length = "0x89")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x60006CD")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ResetTrail()
  {
  }
}
