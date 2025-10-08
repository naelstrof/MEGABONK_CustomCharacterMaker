// Decompiled with JetBrains decompiler
// Type: Boulder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200007F")]
public class Boulder : MonoBehaviour
{
  [Token(Token = "0x40003E1")]
  [FieldOffset(Offset = "0x20")]
  public Rigidbody rb;
  [Token(Token = "0x40003E2")]
  [FieldOffset(Offset = "0x28")]
  private float defaultSize;
  [Token(Token = "0x40003E3")]
  [FieldOffset(Offset = "0x2C")]
  public float frictionStrength;
  [Token(Token = "0x40003E4")]
  [FieldOffset(Offset = "0x30")]
  public AudioSource audio;
  [Token(Token = "0x40003E5")]
  [FieldOffset(Offset = "0x38")]
  private float minSpeedVolume;
  [Token(Token = "0x40003E6")]
  [FieldOffset(Offset = "0x3C")]
  private float maxVolumeSpeed;

  [Token(Token = "0x600031A")]
  [Address(RVA = "0x45D6D0", Offset = "0x45C2D0", Length = "0x75")]
  private void Start()
  {
  }

  [Token(Token = "0x600031B")]
  [Address(RVA = "0x45D390", Offset = "0x45BF90", Length = "0x33A")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x600031C")]
  [Address(RVA = "0x45D750", Offset = "0x45C350", Length = "0x16C")]
  private void Update()
  {
  }

  [Token(Token = "0x600031D")]
  [Address(RVA = "0x45D8C0", Offset = "0x45C4C0", Length = "0x23")]
  public Boulder()
  {
  }
}
