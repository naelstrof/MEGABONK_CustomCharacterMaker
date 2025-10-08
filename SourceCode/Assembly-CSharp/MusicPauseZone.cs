// Decompiled with JetBrains decompiler
// Type: MusicPauseZone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200002A")]
public class MusicPauseZone : MonoBehaviour
{
  [Token(Token = "0x4000178")]
  [FieldOffset(Offset = "0x20")]
  public float radius;
  [Token(Token = "0x4000179")]
  [FieldOffset(Offset = "0x24")]
  private float nextCheckTime;
  [Token(Token = "0x400017A")]
  [FieldOffset(Offset = "0x28")]
  private float checkDelay;

  [Token(Token = "0x6000153")]
  [Address(RVA = "0x361560", Offset = "0x360160", Length = "0x287")]
  private void Update()
  {
  }

  [Token(Token = "0x6000154")]
  [Address(RVA = "0x3614F0", Offset = "0x3600F0", Length = "0x60")]
  private void OnDrawGizmos()
  {
  }

  [Token(Token = "0x6000155")]
  [Address(RVA = "0x3617F0", Offset = "0x3603F0", Length = "0xE")]
  public MusicPauseZone()
  {
  }
}
