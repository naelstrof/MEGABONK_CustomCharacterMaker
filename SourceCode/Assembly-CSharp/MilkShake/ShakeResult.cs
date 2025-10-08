// Decompiled with JetBrains decompiler
// Type: MilkShake.ShakeResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace MilkShake
{
  [Token(Token = "0x20002BD")]
  public struct ShakeResult
  {
    [Token(Token = "0x40012B7")]
    [FieldOffset(Offset = "0x0")]
    public Vector3 PositionShake;
    [Token(Token = "0x40012B8")]
    [FieldOffset(Offset = "0xC")]
    public Vector3 RotationShake;

    [Token(Token = "0x60014A2")]
    [Address(RVA = "0x3934D0", Offset = "0x3920D0", Length = "0x81")]
    public static ShakeResult operator +(ShakeResult a, ShakeResult b) => new ShakeResult();
  }
}
