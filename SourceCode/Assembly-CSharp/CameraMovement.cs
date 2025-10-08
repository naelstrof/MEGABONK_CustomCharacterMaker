// Decompiled with JetBrains decompiler
// Type: CameraMovement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using MilkShake;
using UnityEngine;

[Token(Token = "0x2000234")]
public class CameraMovement : MonoBehaviour
{
  [Token(Token = "0x4000F60")]
  [FieldOffset(Offset = "0x20")]
  public Shaker shaker;
  [Token(Token = "0x4000F61")]
  [FieldOffset(Offset = "0x28")]
  public ShakePreset preset;

  [Token(Token = "0x6000E3B")]
  [Address(RVA = "0x51D480", Offset = "0x51C080", Length = "0x28")]
  private void Start()
  {
  }

  [Token(Token = "0x6000E3C")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public CameraMovement()
  {
  }
}
