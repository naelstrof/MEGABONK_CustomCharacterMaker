// Decompiled with JetBrains decompiler
// Type: DisableObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000F9")]
public class DisableObject : MonoBehaviour
{
  [Token(Token = "0x40007D3")]
  [FieldOffset(Offset = "0x20")]
  public float time;

  [Token(Token = "0x60006A7")]
  [Address(RVA = "0x4B5320", Offset = "0x4B3F20", Length = "0x41")]
  private void Start()
  {
  }

  [Token(Token = "0x60006A8")]
  [Address(RVA = "0x3563C0", Offset = "0x354FC0", Length = "0x26")]
  private void DestroySelf()
  {
  }

  [Token(Token = "0x60006A9")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public DisableObject()
  {
  }
}
