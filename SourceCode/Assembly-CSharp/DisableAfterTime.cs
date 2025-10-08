// Decompiled with JetBrains decompiler
// Type: DisableAfterTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000F8")]
public class DisableAfterTime : MonoBehaviour
{
  [Token(Token = "0x40007D1")]
  [FieldOffset(Offset = "0x20")]
  public float disableDelay;
  [Token(Token = "0x40007D2")]
  [FieldOffset(Offset = "0x24")]
  private float disableAtTime;

  [Token(Token = "0x60006A4")]
  [Address(RVA = "0x4B5220", Offset = "0x4B3E20", Length = "0x60")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60006A5")]
  [Address(RVA = "0x4B5280", Offset = "0x4B3E80", Length = "0x82")]
  private void Update()
  {
  }

  [Token(Token = "0x60006A6")]
  [Address(RVA = "0x4B5310", Offset = "0x4B3F10", Length = "0xE")]
  public DisableAfterTime()
  {
  }
}
