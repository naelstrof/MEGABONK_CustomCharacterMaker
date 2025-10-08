// Decompiled with JetBrains decompiler
// Type: Inventory__Items__Pickups.Pickups.XpVisuals
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Inventory__Items__Pickups.Pickups
{
  [Token(Token = "0x20002C7")]
  public class XpVisuals : MonoBehaviour
  {
    [Token(Token = "0x40012D6")]
    [FieldOffset(Offset = "0x20")]
    public ParticleSystem ps;
    [Token(Token = "0x40012D7")]
    [FieldOffset(Offset = "0x28")]
    private ParticleSystem.MainModule psMain;
    [Token(Token = "0x40012D8")]
    [FieldOffset(Offset = "0x30")]
    public Pickup pickup;
    [Token(Token = "0x40012D9")]
    [FieldOffset(Offset = "0x38")]
    public Color c_low;
    [Token(Token = "0x40012DA")]
    [FieldOffset(Offset = "0x48")]
    public Color c_mid;
    [Token(Token = "0x40012DB")]
    [FieldOffset(Offset = "0x58")]
    public Color c_high;
    [Token(Token = "0x40012DC")]
    [FieldOffset(Offset = "0x68")]
    public Color c_echo;
    [Token(Token = "0x40012DD")]
    [FieldOffset(Offset = "0x78")]
    private XpVisuals.XpTier currentXpTier;

    [Token(Token = "0x60014C4")]
    [Address(RVA = "0x39FCD0", Offset = "0x39E8D0", Length = "0x11B")]
    private void Awake()
    {
    }

    [Token(Token = "0x60014C5")]
    [Address(RVA = "0x39FE10", Offset = "0x39EA10", Length = "0xFC")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60014C6")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    private void Update()
    {
    }

    [Token(Token = "0x60014C7")]
    [Address(RVA = "0x39FFD0", Offset = "0x39EBD0", Length = "0x66")]
    public void SetEchoXp()
    {
    }

    [Token(Token = "0x60014C8")]
    [Address(RVA = "0x39FF10", Offset = "0x39EB10", Length = "0xB6")]
    private void OnValueUpdated(int newValue)
    {
    }

    [Token(Token = "0x60014C9")]
    [Address(RVA = "0x39FDF0", Offset = "0x39E9F0", Length = "0x18")]
    private XpVisuals.XpTier GetXpTier(int value) => new XpVisuals.XpTier();

    [Token(Token = "0x60014CA")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public XpVisuals()
    {
    }

    [Token(Token = "0x20002C8")]
    private enum XpTier
    {
      [Token(Token = "0x40012DF")] Low = 0,
      [Token(Token = "0x40012E0")] Medium = 10, // 0x0000000A
      [Token(Token = "0x40012E1")] High = 50, // 0x00000032
    }
  }
}
