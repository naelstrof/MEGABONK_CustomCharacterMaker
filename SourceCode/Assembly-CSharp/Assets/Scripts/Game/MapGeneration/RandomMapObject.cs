// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.MapGeneration.RandomMapObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

namespace Assets.Scripts.Game.MapGeneration
{
  [Token(Token = "0x2000420")]
  [Serializable]
  public class RandomMapObject
  {
    [Token(Token = "0x4001AF1")]
    [FieldOffset(Offset = "0x10")]
    public int amount;
    [Token(Token = "0x4001AF2")]
    [FieldOffset(Offset = "0x14")]
    public int maxAmount;
    [Token(Token = "0x4001AF3")]
    [FieldOffset(Offset = "0x18")]
    public float checkRadius;
    [Token(Token = "0x4001AF4")]
    [FieldOffset(Offset = "0x1C")]
    public float scaleMin;
    [Token(Token = "0x4001AF5")]
    [FieldOffset(Offset = "0x20")]
    public float scaleMax;
    [Token(Token = "0x4001AF6")]
    [FieldOffset(Offset = "0x24")]
    public float maxSlopeAngle;
    [Token(Token = "0x4001AF7")]
    [FieldOffset(Offset = "0x28")]
    public float upOffset;
    [Token(Token = "0x4001AF8")]
    [FieldOffset(Offset = "0x30")]
    public GameObject[] prefabs;
    [Token(Token = "0x4001AF9")]
    [FieldOffset(Offset = "0x38")]
    public Vector3 randomRotationVector;
    [Token(Token = "0x4001AFA")]
    [FieldOffset(Offset = "0x44")]
    public bool alignWithNormal;

    [Token(Token = "0x6001DBE")]
    [Address(RVA = "0x450170", Offset = "0x44ED70", Length = "0x8A")]
    public int GetAmount() => 0;

    [Token(Token = "0x6001DBF")]
    [Address(RVA = "0x450200", Offset = "0x44EE00", Length = "0x45")]
    public RandomMapObject()
    {
    }
  }
}
