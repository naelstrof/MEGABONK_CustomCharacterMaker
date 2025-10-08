// Decompiled with JetBrains decompiler
// Type: Tornado
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000082")]
public class Tornado : MonoBehaviour
{
  [Token(Token = "0x40003FA")]
  [FieldOffset(Offset = "0x20")]
  public float force;
  [Token(Token = "0x40003FB")]
  [FieldOffset(Offset = "0x28")]
  public Rigidbody rb;
  [Token(Token = "0x40003FC")]
  [FieldOffset(Offset = "0x30")]
  private Vector3 desiredVelocity;
  [Token(Token = "0x40003FD")]
  [FieldOffset(Offset = "0x3C")]
  private float speed;
  [Token(Token = "0x40003FE")]
  [FieldOffset(Offset = "0x40")]
  private float actualSpeed;
  [Token(Token = "0x40003FF")]
  [FieldOffset(Offset = "0x44")]
  private Vector3 lastPos;
  [Token(Token = "0x4000400")]
  [FieldOffset(Offset = "0x50")]
  public AudioSource audio;
  [Token(Token = "0x4000401")]
  [FieldOffset(Offset = "0x58")]
  private float defaultVolume;
  [Token(Token = "0x4000402")]
  [FieldOffset(Offset = "0x5C")]
  private float startTime;
  [Token(Token = "0x4000403")]
  [FieldOffset(Offset = "0x60")]
  private float stopTime;
  [Token(Token = "0x4000404")]
  [FieldOffset(Offset = "0x64")]
  private Vector3 defaultScale;
  [Token(Token = "0x4000405")]
  [FieldOffset(Offset = "0x70")]
  private float scaleMultiplier;
  [Token(Token = "0x4000406")]
  [FieldOffset(Offset = "0x74")]
  private float fadeTime;

  [Token(Token = "0x600032C")]
  [Address(RVA = "0x46F8D0", Offset = "0x46E4D0", Length = "0x15F")]
  private void Start()
  {
  }

  [Token(Token = "0x600032D")]
  [Address(RVA = "0x46F700", Offset = "0x46E300", Length = "0x1C0")]
  private void Spawn()
  {
  }

  [Token(Token = "0x600032E")]
  [Address(RVA = "0x46F160", Offset = "0x46DD60", Length = "0x9E")]
  private void FindNewDir()
  {
  }

  [Token(Token = "0x600032F")]
  [Address(RVA = "0x46FA30", Offset = "0x46E630", Length = "0x54B")]
  private void Update()
  {
  }

  [Token(Token = "0x6000330")]
  [Address(RVA = "0x46F200", Offset = "0x46DE00", Length = "0x4F5")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000331")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void OnDrawGizmosSelected()
  {
  }

  [Token(Token = "0x6000332")]
  [Address(RVA = "0x46FF80", Offset = "0x46EB80", Length = "0x23")]
  public Tornado()
  {
  }
}
