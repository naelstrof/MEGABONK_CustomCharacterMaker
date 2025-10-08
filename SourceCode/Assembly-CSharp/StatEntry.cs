// Decompiled with JetBrains decompiler
// Type: StatEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200016E")]
public class StatEntry : MonoBehaviour
{
  [Token(Token = "0x4000A96")]
  [FieldOffset(Offset = "0x20")]
  public RawImage icon;
  [Token(Token = "0x4000A97")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_stat;
  [Token(Token = "0x4000A98")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_value;
  [Token(Token = "0x4000A99")]
  [FieldOffset(Offset = "0x38")]
  private EStat stat;
  [Token(Token = "0x4000A9A")]
  [FieldOffset(Offset = "0x40")]
  public ToolTipObject toolTipObject;

  [Token(Token = "0x6000939")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x600093A")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void RefreshValues()
  {
  }

  [Token(Token = "0x600093B")]
  [Address(RVA = "0x4DEC10", Offset = "0x4DD810", Length = "0x180")]
  public void Set(EStat stat)
  {
  }

  [Token(Token = "0x600093C")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public StatEntry()
  {
  }
}
