// Decompiled with JetBrains decompiler
// Type: DestroyObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

[Token(Token = "0x20000F7")]
public class DestroyObject : MonoBehaviour
{
  [Token(Token = "0x40007CF")]
  [FieldOffset(Offset = "0x20")]
  public float time;
  [Token(Token = "0x40007D0")]
  [FieldOffset(Offset = "0x28")]
  public Action OnDestroy;

  [Token(Token = "0x60006A1")]
  [Address(RVA = "0x4B51D0", Offset = "0x4B3DD0", Length = "0x41")]
  private void Start()
  {
  }

  [Token(Token = "0x60006A2")]
  [Address(RVA = "0x4B5160", Offset = "0x4B3D60", Length = "0x6A")]
  private void DestroySelf()
  {
  }

  [Token(Token = "0x60006A3")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public DestroyObject()
  {
  }
}
