// Decompiled with JetBrains decompiler
// Type: ProGrids.PGExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace ProGrids
{
  [Token(Token = "0x20002B7")]
  public static class PGExtensions
  {
    [Token(Token = "0x6001454")]
    [Address(RVA = "0x3907F0", Offset = "0x38F3F0", Length = "0xA5")]
    public static bool Contains(this Transform[] t_arr, Transform t) => false;

    [Token(Token = "0x6001455")]
    [Address(RVA = "0x390930", Offset = "0x38F530", Length = "0x11")]
    public static float Sum(this Vector3 v) => 0.0f;

    [Token(Token = "0x6001456")]
    [Address(RVA = "0x3908A0", Offset = "0x38F4A0", Length = "0x82")]
    public static bool InFrustum(this Camera cam, Vector3 point) => false;
  }
}
