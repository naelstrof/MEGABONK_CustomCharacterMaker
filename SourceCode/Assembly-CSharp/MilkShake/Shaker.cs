// Decompiled with JetBrains decompiler
// Type: MilkShake.Shaker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace MilkShake
{
  [AddComponentMenu("MilkShake/Shaker")]
  [Token(Token = "0x20002BC")]
  public class Shaker : MonoBehaviour
  {
    [Token(Token = "0x40012B4")]
    public static List<Shaker> GlobalShakers;
    [SerializeField]
    [Token(Token = "0x40012B5")]
    [FieldOffset(Offset = "0x20")]
    private bool addToGlobalShakers;
    [Token(Token = "0x40012B6")]
    [FieldOffset(Offset = "0x28")]
    private List<ShakeInstance> activeShakes;

    [Token(Token = "0x6001496")]
    [Address(RVA = "0x393CA0", Offset = "0x3928A0", Length = "0x1B8")]
    public static ShakeInstance ShakeAll(IShakeParameters shakeData, int? seed = null) => (ShakeInstance) null;

    [Token(Token = "0x6001497")]
    [Address(RVA = "0x393AE0", Offset = "0x3926E0", Length = "0x1B7")]
    public static void ShakeAllSeparate(
      IShakeParameters shakeData,
      List<ShakeInstance> shakeInstances = null,
      int? seed = null)
    {
    }

    [Token(Token = "0x6001498")]
    [Address(RVA = "0x3938D0", Offset = "0x3924D0", Length = "0x209")]
    public static void ShakeAllFromPoint(
      Vector3 point,
      float maxDistance,
      IShakeParameters shakeData,
      List<ShakeInstance> shakeInstances = null,
      int? seed = null)
    {
    }

    [Token(Token = "0x6001499")]
    [Address(RVA = "0x393560", Offset = "0x392160", Length = "0x14C")]
    public static void AddShakeAll(ShakeInstance shakeInstance)
    {
    }

    [Token(Token = "0x600149A")]
    [Address(RVA = "0x393760", Offset = "0x392360", Length = "0xD9")]
    private void Awake()
    {
    }

    [Token(Token = "0x600149B")]
    [Address(RVA = "0x393840", Offset = "0x392440", Length = "0x84")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600149C")]
    [Address(RVA = "0x3940C0", Offset = "0x392CC0", Length = "0x21F")]
    private void Update()
    {
    }

    [Token(Token = "0x600149D")]
    [Address(RVA = "0x394040", Offset = "0x392C40", Length = "0x7F")]
    public ShakeInstance Shake(IShakeParameters shakeData, int? seed = null) => (ShakeInstance) null;

    [Token(Token = "0x600149E")]
    [Address(RVA = "0x393E60", Offset = "0x392A60", Length = "0x1D1")]
    public ShakeInstance ShakeFromPoint(
      Vector3 point,
      float maxDistance,
      IShakeParameters shakeData,
      int? seed = null)
    {
      return (ShakeInstance) null;
    }

    [Token(Token = "0x600149F")]
    [Address(RVA = "0x3936B0", Offset = "0x3922B0", Length = "0xAA")]
    public void AddShake(ShakeInstance shakeInstance)
    {
    }

    [Token(Token = "0x60014A0")]
    [Address(RVA = "0x394370", Offset = "0x392F70", Length = "0x77")]
    public Shaker()
    {
    }

    [Token(Token = "0x60014A1")]
    [Address(RVA = "0x3942E0", Offset = "0x392EE0", Length = "0x84")]
    static Shaker()
    {
    }
  }
}
