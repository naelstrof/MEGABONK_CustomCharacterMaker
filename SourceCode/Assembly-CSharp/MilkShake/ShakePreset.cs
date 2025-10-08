// Decompiled with JetBrains decompiler
// Type: MilkShake.ShakePreset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace MilkShake
{
  [CreateAssetMenu(fileName = "New Shake Preset", menuName = "MilkShake/Shake Preset")]
  [Token(Token = "0x20002BB")]
  public class ShakePreset : ScriptableObject, IShakeParameters
  {
    [Header("Shake Type")]
    [SerializeField]
    [Token(Token = "0x40012AD")]
    [FieldOffset(Offset = "0x18")]
    private ShakeType shakeType;
    [Header("Shake Strength")]
    [SerializeField]
    [Token(Token = "0x40012AE")]
    [FieldOffset(Offset = "0x1C")]
    private float strength;
    [SerializeField]
    [Token(Token = "0x40012AF")]
    [FieldOffset(Offset = "0x20")]
    private float roughness;
    [Header("Fade")]
    [SerializeField]
    [Token(Token = "0x40012B0")]
    [FieldOffset(Offset = "0x24")]
    private float fadeIn;
    [SerializeField]
    [Token(Token = "0x40012B1")]
    [FieldOffset(Offset = "0x28")]
    private float fadeOut;
    [Header("Shake Influence")]
    [SerializeField]
    [Token(Token = "0x40012B2")]
    [FieldOffset(Offset = "0x2C")]
    private Vector3 positionInfluence;
    [SerializeField]
    [Token(Token = "0x40012B3")]
    [FieldOffset(Offset = "0x38")]
    private Vector3 rotationInfluence;

    [Token(Token = "0x17000373")]
    public ShakeType ShakeType
    {
      [Token(Token = "0x6001487"), Address(RVA = "0x393470", Offset = "0x392070", Length = "0x4")] get => new ShakeType();
      [Token(Token = "0x6001488"), Address(RVA = "0x3934C0", Offset = "0x3920C0", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x17000374")]
    public float Strength
    {
      [Token(Token = "0x6001489"), Address(RVA = "0x393330", Offset = "0x391F30", Length = "0x6")] get => 0.0f;
      [Token(Token = "0x600148A"), Address(RVA = "0x3933B0", Offset = "0x391FB0", Length = "0x6")] set
      {
      }
    }

    [Token(Token = "0x17000375")]
    public float Roughness
    {
      [Token(Token = "0x600148B"), Address(RVA = "0x393340", Offset = "0x391F40", Length = "0x6")] get => 0.0f;
      [Token(Token = "0x600148C"), Address(RVA = "0x3933C0", Offset = "0x391FC0", Length = "0x6")] set
      {
      }
    }

    [Token(Token = "0x17000376")]
    public float FadeIn
    {
      [Token(Token = "0x600148D"), Address(RVA = "0x393410", Offset = "0x392010", Length = "0x6")] get => 0.0f;
      [Token(Token = "0x600148E"), Address(RVA = "0x393480", Offset = "0x392080", Length = "0x6")] set
      {
      }
    }

    [Token(Token = "0x17000377")]
    public float FadeOut
    {
      [Token(Token = "0x600148F"), Address(RVA = "0x393420", Offset = "0x392020", Length = "0x6")] get => 0.0f;
      [Token(Token = "0x6001490"), Address(RVA = "0x393490", Offset = "0x392090", Length = "0x6")] set
      {
      }
    }

    [Token(Token = "0x17000378")]
    public Vector3 PositionInfluence
    {
      [Token(Token = "0x6001491"), Address(RVA = "0x393430", Offset = "0x392030", Length = "0x13")] get => new Vector3();
      [Token(Token = "0x6001492"), Address(RVA = "0x3934A0", Offset = "0x3920A0", Length = "0x10")] set
      {
      }
    }

    [Token(Token = "0x17000379")]
    public Vector3 RotationInfluence
    {
      [Token(Token = "0x6001493"), Address(RVA = "0x393450", Offset = "0x392050", Length = "0x13")] get => new Vector3();
      [Token(Token = "0x6001494"), Address(RVA = "0x3934B0", Offset = "0x3920B0", Length = "0x10")] set
      {
      }
    }

    [Token(Token = "0x6001495")]
    [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
    public ShakePreset()
    {
    }
  }
}
