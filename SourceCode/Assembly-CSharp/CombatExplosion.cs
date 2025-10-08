// Decompiled with JetBrains decompiler
// Type: CombatExplosion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200004E")]
public class CombatExplosion : MonoBehaviour
{
  [Token(Token = "0x400028C")]
  [FieldOffset(Offset = "0x20")]
  public float radius;
  [Header("Player")]
  [Token(Token = "0x400028D")]
  [FieldOffset(Offset = "0x24")]
  public float playerDamage;
  [Token(Token = "0x400028E")]
  [FieldOffset(Offset = "0x28")]
  public float playerKnockback;
  [Header("Enemy")]
  [Token(Token = "0x400028F")]
  [FieldOffset(Offset = "0x2C")]
  public float enemyKnockback;

  [Token(Token = "0x6000216")]
  [Address(RVA = "0x3589C0", Offset = "0x3575C0", Length = "0x8FC")]
  private void Start()
  {
  }

  [Token(Token = "0x6000217")]
  [Address(RVA = "0x358940", Offset = "0x357540", Length = "0x7C")]
  private void OnDrawGizmosSelected()
  {
  }

  [Token(Token = "0x6000218")]
  [Address(RVA = "0x3592C0", Offset = "0x357EC0", Length = "0x15")]
  public CombatExplosion()
  {
  }
}
