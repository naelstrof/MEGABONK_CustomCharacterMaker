// Decompiled with JetBrains decompiler
// Type: LookAtPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000036")]
public class LookAtPlayer : MonoBehaviour
{
  [Token(Token = "0x4000198")]
  [FieldOffset(Offset = "0x20")]
  private float zoom;
  [Token(Token = "0x4000199")]
  [FieldOffset(Offset = "0x28")]
  public Transform target;

  [Token(Token = "0x600017D")]
  [Address(RVA = "0x35E0B0", Offset = "0x35CCB0", Length = "0xB3")]
  private void Update()
  {
  }

  [Token(Token = "0x600017E")]
  [Address(RVA = "0x35E170", Offset = "0x35CD70", Length = "0x16")]
  private void Zoom()
  {
  }

  [Token(Token = "0x600017F")]
  [Address(RVA = "0x35E190", Offset = "0x35CD90", Length = "0xE")]
  public LookAtPlayer()
  {
  }
}
