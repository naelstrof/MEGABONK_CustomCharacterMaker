// Decompiled with JetBrains decompiler
// Type: MilkShake.ShakeParameters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

namespace MilkShake
{
  [Token(Token = "0x20002BA")]
  [Serializable]
  public class ShakeParameters : IShakeParameters
  {
    [Header("Shake Type")]
    [SerializeField]
    [Token(Token = "0x40012A6")]
    [FieldOffset(Offset = "0x10")]
    private ShakeType shakeType;
    [Header("Shake Strength")]
    [SerializeField]
    [Token(Token = "0x40012A7")]
    [FieldOffset(Offset = "0x14")]
    private float strength;
    [SerializeField]
    [Token(Token = "0x40012A8")]
    [FieldOffset(Offset = "0x18")]
    private float roughness;
    [Header("Fade")]
    [SerializeField]
    [Token(Token = "0x40012A9")]
    [FieldOffset(Offset = "0x1C")]
    private float fadeIn;
    [SerializeField]
    [Token(Token = "0x40012AA")]
    [FieldOffset(Offset = "0x20")]
    private float fadeOut;
    [Header("Shake Influence")]
    [SerializeField]
    [Token(Token = "0x40012AB")]
    [FieldOffset(Offset = "0x24")]
    private Vector3 positionInfluence;
    [SerializeField]
    [Token(Token = "0x40012AC")]
    [FieldOffset(Offset = "0x30")]
    private Vector3 rotationInfluence;

    [Token(Token = "0x6001477")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public ShakeParameters()
    {
    }

    [Token(Token = "0x6001478")]
    [Address(RVA = "0x393130", Offset = "0x391D30", Length = "0x1F0")]
    public ShakeParameters(IShakeParameters original)
    {
    }

    [Token(Token = "0x1700036C")]
    public ShakeType ShakeType
    {
      [Token(Token = "0x6001479"), Address(RVA = "0x36AC50", Offset = "0x369850", Length = "0x4")] get => new ShakeType();
      [Token(Token = "0x600147A"), Address(RVA = "0x36AC60", Offset = "0x369860", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x1700036D")]
    public float Strength
    {
      [Token(Token = "0x600147B"), Address(RVA = "0x3933A0", Offset = "0x391FA0", Length = "0x6")] get => 0.0f;
      [Token(Token = "0x600147C"), Address(RVA = "0x393400", Offset = "0x392000", Length = "0x6")] set
      {
      }
    }

    [Token(Token = "0x1700036E")]
    public float Roughness
    {
      [Token(Token = "0x600147D"), Address(RVA = "0x393390", Offset = "0x391F90", Length = "0x6")] get => 0.0f;
      [Token(Token = "0x600147E"), Address(RVA = "0x3933F0", Offset = "0x391FF0", Length = "0x6")] set
      {
      }
    }

    [Token(Token = "0x1700036F")]
    public float FadeIn
    {
      [Token(Token = "0x600147F"), Address(RVA = "0x393330", Offset = "0x391F30", Length = "0x6")] get => 0.0f;
      [Token(Token = "0x6001480"), Address(RVA = "0x3933B0", Offset = "0x391FB0", Length = "0x6")] set
      {
      }
    }

    [Token(Token = "0x17000370")]
    public float FadeOut
    {
      [Token(Token = "0x6001481"), Address(RVA = "0x393340", Offset = "0x391F40", Length = "0x6")] get => 0.0f;
      [Token(Token = "0x6001482"), Address(RVA = "0x3933C0", Offset = "0x391FC0", Length = "0x6")] set
      {
      }
    }

    [Token(Token = "0x17000371")]
    public Vector3 PositionInfluence
    {
      [Token(Token = "0x6001483"), Address(RVA = "0x393350", Offset = "0x391F50", Length = "0x13")] get => new Vector3();
      [Token(Token = "0x6001484"), Address(RVA = "0x3933D0", Offset = "0x391FD0", Length = "0x10")] set
      {
      }
    }

    [Token(Token = "0x17000372")]
    public Vector3 RotationInfluence
    {
      [Token(Token = "0x6001485"), Address(RVA = "0x393370", Offset = "0x391F70", Length = "0x13")] get => new Vector3();
      [Token(Token = "0x6001486"), Address(RVA = "0x3933E0", Offset = "0x391FE0", Length = "0x10")] set
      {
      }
    }
  }
}
