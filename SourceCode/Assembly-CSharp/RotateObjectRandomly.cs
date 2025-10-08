// Decompiled with JetBrains decompiler
// Type: RotateObjectRandomly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000107")]
public class RotateObjectRandomly : MonoBehaviour
{
  [Token(Token = "0x4000802")]
  [FieldOffset(Offset = "0x20")]
  public float minSpeed;
  [Token(Token = "0x4000803")]
  [FieldOffset(Offset = "0x24")]
  public float maxSpeed;
  [Token(Token = "0x4000804")]
  [FieldOffset(Offset = "0x28")]
  private float speed;
  [Token(Token = "0x4000805")]
  [FieldOffset(Offset = "0x2C")]
  private Vector3 rotation;

  [Token(Token = "0x60006D0")]
  [Address(RVA = "0x4C2080", Offset = "0x4C0C80", Length = "0xFF")]
  private void Start()
  {
  }

  [Token(Token = "0x60006D1")]
  [Address(RVA = "0x4C2080", Offset = "0x4C0C80", Length = "0xFF")]
  public void FindNewRotation()
  {
  }

  [Token(Token = "0x60006D2")]
  [Address(RVA = "0x4C2180", Offset = "0x4C0D80", Length = "0x10A")]
  private void Update()
  {
  }

  [Token(Token = "0x60006D3")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public RotateObjectRandomly()
  {
  }
}
