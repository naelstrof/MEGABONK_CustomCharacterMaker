// Decompiled with JetBrains decompiler
// Type: DamagePlayerCollider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000054")]
public class DamagePlayerCollider : MonoBehaviour
{
  [Token(Token = "0x40002D9")]
  [FieldOffset(Offset = "0x20")]
  public float knockbackForce;
  [Token(Token = "0x40002DA")]
  [FieldOffset(Offset = "0x24")]
  public float damage;
  [Token(Token = "0x40002DB")]
  [FieldOffset(Offset = "0x28")]
  public float refreshTime;
  [Token(Token = "0x40002DC")]
  [FieldOffset(Offset = "0x2C")]
  private float readyAtTime;

  [Token(Token = "0x600024F")]
  [Address(RVA = "0x3592E0", Offset = "0x357EE0", Length = "0x2FF")]
  private void OnCollisionEnter(Collision collision)
  {
  }

  [Token(Token = "0x6000250")]
  [Address(RVA = "0x3595E0", Offset = "0x3581E0", Length = "0x1C")]
  public DamagePlayerCollider()
  {
  }
}
