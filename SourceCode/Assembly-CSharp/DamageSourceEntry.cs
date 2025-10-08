// Decompiled with JetBrains decompiler
// Type: DamageSourceEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Stats;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200014C")]
public class DamageSourceEntry : MonoBehaviour
{
  [Token(Token = "0x40009C1")]
  [FieldOffset(Offset = "0x20")]
  public RawImage icon;
  [Token(Token = "0x40009C2")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_sourceName;
  [Token(Token = "0x40009C3")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_lvl;
  [Token(Token = "0x40009C4")]
  [FieldOffset(Offset = "0x38")]
  public TextMeshProUGUI t_dmg;
  [Token(Token = "0x40009C5")]
  [FieldOffset(Offset = "0x40")]
  public TextMeshProUGUI t_dps;

  [Token(Token = "0x6000865")]
  [Address(RVA = "0x4D0530", Offset = "0x4CF130", Length = "0x249")]
  public void Set(DamageSource dmgSource)
  {
  }

  [Token(Token = "0x6000866")]
  [Address(RVA = "0x4D04E0", Offset = "0x4CF0E0", Length = "0x50")]
  private string FormatNumberWithSpaces(float num) => (string) null;

  [Token(Token = "0x6000867")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public DamageSourceEntry()
  {
  }
}
