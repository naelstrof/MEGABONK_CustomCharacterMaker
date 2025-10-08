// Decompiled with JetBrains decompiler
// Type: WorldColliderTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000086")]
public class WorldColliderTrigger : MonoBehaviour
{
  [Token(Token = "0x4000462")]
  [FieldOffset(Offset = "0x20")]
  private float maxSlopeAngle;

  [Token(Token = "0x600035B")]
  [Address(RVA = "0x474A60", Offset = "0x473660", Length = "0x440")]
  private void OnCollisionStay(Collision collision)
  {
  }

  [Token(Token = "0x600035C")]
  [Address(RVA = "0x4749F0", Offset = "0x4735F0", Length = "0x6C")]
  private bool IsFloor(Vector3 v) => false;

  [Token(Token = "0x600035D")]
  [Address(RVA = "0x474960", Offset = "0x473560", Length = "0x85")]
  private bool IsCeiling(Vector3 v) => false;

  [Token(Token = "0x600035E")]
  [Address(RVA = "0x474EB0", Offset = "0x473AB0", Length = "0x148")]
  public WorldColliderTrigger()
  {
  }
}
