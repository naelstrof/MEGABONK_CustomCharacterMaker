// Decompiled with JetBrains decompiler
// Type: ZapBar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200020C")]
public class ZapBar : MonoBehaviour
{
  [Token(Token = "0x4000E6B")]
  [FieldOffset(Offset = "0x20")]
  public GameObject zapIcon;
  [Token(Token = "0x4000E6C")]
  [FieldOffset(Offset = "0x28")]
  public GameObject zapBar;
  [Token(Token = "0x4000E6D")]
  [FieldOffset(Offset = "0x30")]
  public Transform barFill;
  [Token(Token = "0x4000E6E")]
  [FieldOffset(Offset = "0x38")]
  private PassiveAbilityZooma zapAbility;

  [Token(Token = "0x6000D68")]
  [Address(RVA = "0x5401D0", Offset = "0x53EDD0", Length = "0xA6")]
  private void Start()
  {
  }

  [Token(Token = "0x6000D69")]
  [Address(RVA = "0x540020", Offset = "0x53EC20", Length = "0x1A3")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000D6A")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ZapBar()
  {
  }
}
