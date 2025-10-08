// Decompiled with JetBrains decompiler
// Type: ObjectAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000100")]
public class ObjectAnimation : MonoBehaviour
{
  [Token(Token = "0x40007EA")]
  [FieldOffset(Offset = "0x20")]
  public float scale;
  [Token(Token = "0x40007EB")]
  [FieldOffset(Offset = "0x24")]
  public float scaleSpeed;
  [Token(Token = "0x40007EC")]
  [FieldOffset(Offset = "0x28")]
  private Vector3 defaultScale;

  [Token(Token = "0x60006BA")]
  [Address(RVA = "0x4BF530", Offset = "0x4BE130", Length = "0x3F")]
  private void Awake()
  {
  }

  [Token(Token = "0x60006BB")]
  [Address(RVA = "0x4BF570", Offset = "0x4BE170", Length = "0x20A")]
  private void Update()
  {
  }

  [Token(Token = "0x60006BC")]
  [Address(RVA = "0x4BF780", Offset = "0x4BE380", Length = "0x15")]
  public ObjectAnimation()
  {
  }
}
