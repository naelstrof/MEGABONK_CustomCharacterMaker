// Decompiled with JetBrains decompiler
// Type: Utility.RaycastUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace Utility
{
  [Token(Token = "0x20002C1")]
  public class RaycastUtility
  {
    [Token(Token = "0x40012C2")]
    private static Collider[] coneCastBuffer;

    [Token(Token = "0x60014A5")]
    [Address(RVA = "0x392440", Offset = "0x391040", Length = "0x23A")]
    public static Vector3 RayToGround(Vector3 pos, float maxDistance = 9999f) => new Vector3();

    [Token(Token = "0x60014A6")]
    [Address(RVA = "0x392250", Offset = "0x390E50", Length = "0x1E4")]
    public static Vector3 RayToGround(Vector3 pos, LayerMask layerMask, float maxDistance = 9999f) => new Vector3();

    [Token(Token = "0x60014A7")]
    [Address(RVA = "0x391390", Offset = "0x38FF90", Length = "0x757")]
    public static List<Collider> ConeCastAll(
      Vector3 origin,
      Vector3 direction,
      float maxDistance,
      float coneAngle)
    {
      return (List<Collider>) null;
    }

    [Token(Token = "0x60014A8")]
    [Address(RVA = "0x391AF0", Offset = "0x3906F0", Length = "0x34B")]
    public static HashSet<Collider> ConeCastNew(
      Vector3 origin,
      Vector3 direction,
      float distance,
      float coneAngle)
    {
      return (HashSet<Collider>) null;
    }

    [Token(Token = "0x60014A9")]
    [Address(RVA = "0x391E40", Offset = "0x390A40", Length = "0x407")]
    public static List<RaycastUtility.ConeSphere> GetConecastPositions(
      Vector3 pos,
      Vector3 dir,
      float dist,
      float coneAngle)
    {
      return (List<RaycastUtility.ConeSphere>) null;
    }

    [Token(Token = "0x60014AA")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public RaycastUtility()
    {
    }

    [Token(Token = "0x60014AB")]
    [Address(RVA = "0x392680", Offset = "0x391280", Length = "0x98")]
    static RaycastUtility()
    {
    }

    [Token(Token = "0x20002C2")]
    public struct ConeSphere
    {
      [Token(Token = "0x40012C3")]
      [FieldOffset(Offset = "0x0")]
      public Vector3 pos;
      [Token(Token = "0x40012C4")]
      [FieldOffset(Offset = "0xC")]
      public float radius;

      [Token(Token = "0x60014AC")]
      [Address(RVA = "0x388F50", Offset = "0x387B50", Length = "0x14")]
      public ConeSphere(Vector3 position, float radius)
      {
        this.pos = new Vector3();
        this.radius = 0.0f;
      }
    }
  }
}
