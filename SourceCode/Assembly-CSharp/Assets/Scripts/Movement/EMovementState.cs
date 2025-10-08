// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Movement.EMovementState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Assets.Scripts.Movement
{
  [Flags]
  [Token(Token = "0x200044E")]
  public enum EMovementState
  {
    [Token(Token = "0x4001BDE")] Idle = 1,
    [Token(Token = "0x4001BDF")] Walking = 2,
    [Token(Token = "0x4001BE0")] Crouching = 4,
    [Token(Token = "0x4001BE1")] Sliding = 8,
    [Token(Token = "0x4001BE2")] Airborne = 16, // 0x00000010
    [Token(Token = "0x4001BE3")] Wallrunning = 32, // 0x00000020
    [Token(Token = "0x4001BE4")] CategoryCrouched = Sliding | Crouching, // 0x0000000C
    [Token(Token = "0x4001BE5")] CategoryFootstepNoise = Wallrunning | Walking, // 0x00000022
  }
}
