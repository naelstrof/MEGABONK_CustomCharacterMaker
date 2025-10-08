// Decompiled with JetBrains decompiler
// Type: ProGrids.pg_Util
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace ProGrids
{
  [Token(Token = "0x20002AF")]
  public static class pg_Util
  {
    [Token(Token = "0x4001288")]
    private const float EPSILON = 0.0001f;
    [Token(Token = "0x4001289")]
    private static Dictionary<Transform, pg_Util.SnapEnabledOverride> m_SnapOverrideCache;
    [Token(Token = "0x400128A")]
    private static Dictionary<Type, bool> m_NoSnapAttributeTypeCache;
    [Token(Token = "0x400128B")]
    private static Dictionary<Type, MethodInfo> m_ConditionalSnapAttributeCache;

    [Token(Token = "0x600142E")]
    [Address(RVA = "0x3A09C0", Offset = "0x39F5C0", Length = "0x1FA")]
    public static Color ColorWithString(string value) => new Color();

    [Token(Token = "0x600142F")]
    [Address(RVA = "0x3A2230", Offset = "0x3A0E30", Length = "0x9F")]
    private static Vector3 VectorToMask(Vector3 vec) => new Vector3();

    [Token(Token = "0x6001430")]
    [Address(RVA = "0x3A10E0", Offset = "0x39FCE0", Length = "0x49")]
    private static Axis MaskToAxis(Vector3 vec) => new Axis();

    [Token(Token = "0x6001431")]
    [Address(RVA = "0x3A0270", Offset = "0x39EE70", Length = "0x45")]
    private static Axis BestAxis(Vector3 vec) => new Axis();

    [Token(Token = "0x6001432")]
    [Address(RVA = "0x3A02C0", Offset = "0x39EEC0", Length = "0x615")]
    public static Axis CalcDragAxis(Vector3 movement, Camera cam) => new Axis();

    [Token(Token = "0x6001433")]
    [Address(RVA = "0x3A21F0", Offset = "0x3A0DF0", Length = "0x3A")]
    public static float ValueFromMask(Vector3 val, Vector3 mask) => 0.0f;

    [Token(Token = "0x6001434")]
    [Address(RVA = "0x3A2030", Offset = "0x3A0C30", Length = "0xB9")]
    public static Vector3 SnapValue(Vector3 val, float snapValue) => new Vector3();

    [Token(Token = "0x6001435")]
    [Address(RVA = "0x3A0BC0", Offset = "0x39F7C0", Length = "0x42A")]
    private static Type GetType(string type, string assembly = null) => (Type) null;

    [Token(Token = "0x6001436")]
    [Address(RVA = "0x3A1130", Offset = "0x39FD30", Length = "0xEF")]
    public static void SetUnityGridEnabled(bool isEnabled)
    {
    }

    [Token(Token = "0x6001437")]
    [Address(RVA = "0x3A0FF0", Offset = "0x39FBF0", Length = "0xE1")]
    public static bool GetUnityGridEnabled() => false;

    [Token(Token = "0x6001438")]
    [Address(RVA = "0x3A1ED0", Offset = "0x3A0AD0", Length = "0x156")]
    public static Vector3 SnapValue(Vector3 val, Vector3 mask, float snapValue) => new Vector3();

    [Token(Token = "0x6001439")]
    [Address(RVA = "0x3A1B10", Offset = "0x3A0710", Length = "0x15A")]
    public static Vector3 SnapToCeil(Vector3 val, Vector3 mask, float snapValue) => new Vector3();

    [Token(Token = "0x600143A")]
    [Address(RVA = "0x3A1CA0", Offset = "0x3A08A0", Length = "0xD0")]
    public static Vector3 SnapToFloor(Vector3 val, float snapValue) => new Vector3();

    [Token(Token = "0x600143B")]
    [Address(RVA = "0x3A1D70", Offset = "0x3A0970", Length = "0x15A")]
    public static Vector3 SnapToFloor(Vector3 val, Vector3 mask, float snapValue) => new Vector3();

    [Token(Token = "0x600143C")]
    [Address(RVA = "0x3A20F0", Offset = "0x3A0CF0", Length = "0xF4")]
    public static float Snap(float val, float round) => 0.0f;

    [Token(Token = "0x600143D")]
    [Address(RVA = "0x3A1C70", Offset = "0x3A0870", Length = "0x23")]
    public static float SnapToFloor(float val, float snapValue) => 0.0f;

    [Token(Token = "0x600143E")]
    [Address(RVA = "0x3A1AE0", Offset = "0x3A06E0", Length = "0x23")]
    public static float SnapToCeil(float val, float snapValue) => 0.0f;

    [Token(Token = "0x600143F")]
    [Address(RVA = "0x3A08E0", Offset = "0x39F4E0", Length = "0x64")]
    public static Vector3 CeilFloor(Vector3 v) => new Vector3();

    [Token(Token = "0x6001440")]
    [Address(RVA = "0x3A0950", Offset = "0x39F550", Length = "0x6F")]
    public static void ClearSnapEnabledCache()
    {
    }

    [Token(Token = "0x6001441")]
    [Address(RVA = "0x3A1230", Offset = "0x39FE30", Length = "0x8A0")]
    public static bool SnapIsEnabled(Transform t) => false;

    [Token(Token = "0x6001442")]
    [Address(RVA = "0x3A22D0", Offset = "0x3A0ED0", Length = "0x148")]
    static pg_Util()
    {
    }

    [Token(Token = "0x20002B0")]
    private abstract class SnapEnabledOverride
    {
      [Token(Token = "0x6001443")]
      public abstract bool IsEnabled();

      [Token(Token = "0x6001444")]
      [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
      protected SnapEnabledOverride()
      {
      }
    }

    [Token(Token = "0x20002B1")]
    private class SnapIsEnabledOverride : pg_Util.SnapEnabledOverride
    {
      [Token(Token = "0x400128C")]
      [FieldOffset(Offset = "0x10")]
      private bool m_SnapIsEnabled;

      [Token(Token = "0x6001445")]
      [Address(RVA = "0x3943F0", Offset = "0x392FF0", Length = "0x26")]
      public SnapIsEnabledOverride(bool snapIsEnabled)
      {
      }

      [Token(Token = "0x6001446")]
      [Address(RVA = "0x36C9C0", Offset = "0x36B5C0", Length = "0x5")]
      public override bool IsEnabled() => false;
    }

    [Token(Token = "0x20002B2")]
    private class ConditionalSnapOverride : pg_Util.SnapEnabledOverride
    {
      [Token(Token = "0x400128D")]
      [FieldOffset(Offset = "0x10")]
      public Func<bool> m_IsEnabledDelegate;

      [Token(Token = "0x6001447")]
      [Address(RVA = "0x36E040", Offset = "0x36CC40", Length = "0x31")]
      public ConditionalSnapOverride(Func<bool> d)
      {
      }

      [Token(Token = "0x6001448")]
      [Address(RVA = "0x388F20", Offset = "0x387B20", Length = "0x25")]
      public override bool IsEnabled() => false;
    }
  }
}
