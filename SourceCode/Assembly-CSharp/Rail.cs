// Decompiled with JetBrains decompiler
// Type: Rail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Splines;

[Token(Token = "0x2000081")]
public class Rail : MonoBehaviour
{
  [Token(Token = "0x40003F3")]
  [FieldOffset(Offset = "0x20")]
  private bool isRailingPlayer;
  [Token(Token = "0x40003F4")]
  [FieldOffset(Offset = "0x24")]
  private float stopRailTime;
  [Token(Token = "0x40003F5")]
  [FieldOffset(Offset = "0x28")]
  public SplineContainer splineContainer;
  [Token(Token = "0x40003F6")]
  [FieldOffset(Offset = "0x30")]
  private float restoreCollisionAtTime;
  [Token(Token = "0x40003F7")]
  [FieldOffset(Offset = "0x34")]
  private bool isIgnoringCollision;
  [Token(Token = "0x40003F8")]
  [FieldOffset(Offset = "0x38")]
  public Collider renderCollider;
  [Token(Token = "0x40003F9")]
  [FieldOffset(Offset = "0x40")]
  private Collider playerCollider;

  [Token(Token = "0x6000326")]
  [Address(RVA = "0x46BEA0", Offset = "0x46AAA0", Length = "0x5D")]
  public bool IsOnCooldown() => false;

  [Token(Token = "0x6000327")]
  [Address(RVA = "0x46BD10", Offset = "0x46A910", Length = "0xC3")]
  public void Cooldown(Collider playerCollider)
  {
  }

  [Token(Token = "0x6000328")]
  [Address(RVA = "0x46BDE0", Offset = "0x46A9E0", Length = "0xB4")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000329")]
  [Address(RVA = "0x46BF00", Offset = "0x46AB00", Length = "0x552")]
  public bool IsValidPosition() => false;

  [Token(Token = "0x600032A")]
  [Address(RVA = "0x46C460", Offset = "0x46B060", Length = "0x6C")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x600032B")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public Rail()
  {
  }
}
