// Decompiled with JetBrains decompiler
// Type: ProGrids.pg_Enum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace ProGrids
{
  [Token(Token = "0x20002AC")]
  public static class pg_Enum
  {
    [Token(Token = "0x6001429")]
    [Address(RVA = "0x3A0120", Offset = "0x39ED20", Length = "0xCC")]
    public static Vector3 InverseAxisMask(Vector3 v, Axis axis) => new Vector3();

    [Token(Token = "0x600142A")]
    [Address(RVA = "0x3A0040", Offset = "0x39EC40", Length = "0xD3")]
    public static Vector3 AxisMask(Vector3 v, Axis axis) => new Vector3();

    [Token(Token = "0x600142B")]
    [Address(RVA = "0x3A01F0", Offset = "0x39EDF0", Length = "0x5C")]
    public static float SnapUnitValue(SnapUnit su) => 0.0f;
  }
}
