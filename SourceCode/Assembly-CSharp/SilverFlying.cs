// Decompiled with JetBrains decompiler
// Type: SilverFlying
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200008B")]
public class SilverFlying : MonoBehaviour
{
  [Token(Token = "0x4000477")]
  [FieldOffset(Offset = "0x20")]
  private bool pickedUp;
  [Token(Token = "0x4000478")]
  [FieldOffset(Offset = "0x28")]
  private Transform target;
  [Token(Token = "0x4000479")]
  [FieldOffset(Offset = "0x30")]
  private float speed;
  [Token(Token = "0x400047A")]
  [FieldOffset(Offset = "0x34")]
  private Vector3 randomDir;
  [Token(Token = "0x400047B")]
  [FieldOffset(Offset = "0x40")]
  private float rndSpeed;
  [Token(Token = "0x400047C")]
  [FieldOffset(Offset = "0x44")]
  private float rndMaxSpeed;
  [Token(Token = "0x400047D")]
  [FieldOffset(Offset = "0x48")]
  private float rndTime;

  [Token(Token = "0x6000380")]
  [Address(RVA = "0x46D3F0", Offset = "0x46BFF0", Length = "0x19D")]
  public void Set(Vector3 pos)
  {
  }

  [Token(Token = "0x6000381")]
  [Address(RVA = "0x46D590", Offset = "0x46C190", Length = "0x3A5")]
  private void Update()
  {
  }

  [Token(Token = "0x6000382")]
  [Address(RVA = "0x46D0B0", Offset = "0x46BCB0", Length = "0x1E8")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000383")]
  [Address(RVA = "0x46D2A0", Offset = "0x46BEA0", Length = "0x140")]
  private void Pickup()
  {
  }

  [Token(Token = "0x6000384")]
  [Address(RVA = "0x46D940", Offset = "0x46C540", Length = "0xE")]
  public SilverFlying()
  {
  }
}
