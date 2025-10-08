// Decompiled with JetBrains decompiler
// Type: TooltipNew
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001F5")]
public class TooltipNew : MonoBehaviour
{
  [Token(Token = "0x4000DED")]
  [FieldOffset(Offset = "0x20")]
  public Transform tooltipTransform;
  [Token(Token = "0x4000DEE")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_tip;
  [Token(Token = "0x4000DEF")]
  [FieldOffset(Offset = "0x30")]
  public TextSizer textSizer;

  [Token(Token = "0x6000CF0")]
  [Address(RVA = "0x5328D0", Offset = "0x5314D0", Length = "0x198")]
  public void Set(string text, RectTransform uiElement)
  {
  }

  [Token(Token = "0x6000CF1")]
  [Address(RVA = "0x4B2230", Offset = "0x4B0E30", Length = "0x2F")]
  public void Hide()
  {
  }

  [Token(Token = "0x6000CF2")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public TooltipNew()
  {
  }
}
