// Decompiled with JetBrains decompiler
// Type: DetectRails
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000014")]
public class DetectRails : MonoBehaviour
{
  [Token(Token = "0x4000058")]
  [FieldOffset(Offset = "0x20")]
  public LayerMask whatIsRails;
  [Token(Token = "0x4000059")]
  [FieldOffset(Offset = "0x28")]
  private PlayerMovement playerMovement;

  [Token(Token = "0x6000048")]
  [Address(RVA = "0x33C6D0", Offset = "0x33B2D0", Length = "0x16B")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000049")]
  [Address(RVA = "0x33CC90", Offset = "0x33B890", Length = "0x140")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600004A")]
  [Address(RVA = "0x33CC70", Offset = "0x33B870", Length = "0x1D")]
  private void OnDamage(PlayerHealth arg1, DamageContainer arg2, bool arg3)
  {
  }

  [Token(Token = "0x600004B")]
  [Address(RVA = "0x33C840", Offset = "0x33B440", Length = "0x428")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x600004C")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public DetectRails()
  {
  }
}
