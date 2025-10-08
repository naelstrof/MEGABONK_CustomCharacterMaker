// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Weapons.EnemyScanContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Weapons
{
  [Token(Token = "0x2000365")]
  public class EnemyScanContainer
  {
    [Token(Token = "0x4001733")]
    [FieldOffset(Offset = "0x10")]
    public float range;
    [Token(Token = "0x4001734")]
    [FieldOffset(Offset = "0x14")]
    public float time;
    [Token(Token = "0x4001735")]
    [FieldOffset(Offset = "0x18")]
    public Vector3 position;
    [Token(Token = "0x4001736")]
    private const float distThreshold = 2f;
    [Token(Token = "0x4001737")]
    private const float distThresholdSqr = 4f;
    [Token(Token = "0x4001738")]
    private const float timeThreshold = 0.04f;
    [Token(Token = "0x4001739")]
    private const float rangeThreshold = 1f;

    [Token(Token = "0x600183E")]
    [Address(RVA = "0x3E3CB0", Offset = "0x3E28B0", Length = "0x55")]
    public EnemyScanContainer(Vector3 position, float time, float range)
    {
    }

    [Token(Token = "0x600183F")]
    [Address(RVA = "0x3E3B90", Offset = "0x3E2790", Length = "0x111")]
    public bool IsEqual(Vector3 pos, float t, float range) => false;

    [Token(Token = "0x6001840")]
    [Address(RVA = "0x3E3B40", Offset = "0x3E2740", Length = "0x42")]
    public bool IsEqual(EnemyScanContainer other) => false;
  }
}
