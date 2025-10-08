// Decompiled with JetBrains decompiler
// Type: LookTowardsPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000FD")]
public class LookTowardsPlayer : MonoBehaviour
{
  [Token(Token = "0x40007E0")]
  [FieldOffset(Offset = "0x20")]
  public bool onlyXZ;
  [Token(Token = "0x40007E1")]
  [FieldOffset(Offset = "0x21")]
  public bool lerp;

  [Token(Token = "0x60006B3")]
  [Address(RVA = "0x4BC680", Offset = "0x4BB280", Length = "0x3E9")]
  private void Update()
  {
  }

  [Token(Token = "0x60006B4")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public LookTowardsPlayer()
  {
  }
}
