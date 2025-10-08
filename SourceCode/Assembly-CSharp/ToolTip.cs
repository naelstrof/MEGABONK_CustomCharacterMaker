// Decompiled with JetBrains decompiler
// Type: ToolTip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001F3")]
public class ToolTip : MonoBehaviour
{
  [Token(Token = "0x4000DDE")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_tip;
  [Token(Token = "0x4000DDF")]
  [FieldOffset(Offset = "0x28")]
  public CanvasGroup group;
  [Token(Token = "0x4000DE0")]
  [FieldOffset(Offset = "0x30")]
  public Canvas parentCanvas;
  [Token(Token = "0x4000DE1")]
  [FieldOffset(Offset = "0x38")]
  public RectTransform backDrop;
  [Token(Token = "0x4000DE2")]
  public static ToolTip Instance;
  [Token(Token = "0x4000DE3")]
  [FieldOffset(Offset = "0x40")]
  private bool visible;
  [Token(Token = "0x4000DE4")]
  [FieldOffset(Offset = "0x41")]
  private bool useMouse;
  [Token(Token = "0x4000DE5")]
  [FieldOffset(Offset = "0x44")]
  private float x;
  [Token(Token = "0x4000DE6")]
  [FieldOffset(Offset = "0x48")]
  private float speed;
  [Token(Token = "0x4000DE7")]
  [FieldOffset(Offset = "0x4C")]
  private float offset;

  [Token(Token = "0x6000CE3")]
  [Address(RVA = "0x531C50", Offset = "0x530850", Length = "0x2B2")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000CE4")]
  [Address(RVA = "0x531F10", Offset = "0x530B10", Length = "0x1FE")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000CE5")]
  [Address(RVA = "0x532110", Offset = "0x530D10", Length = "0x33")]
  public void SetTip(string text)
  {
  }

  [Token(Token = "0x6000CE6")]
  [Address(RVA = "0x532150", Offset = "0x530D50", Length = "0x1DC")]
  public void SetTip(string text, RectTransform uiElement)
  {
  }

  [Token(Token = "0x6000CE7")]
  [Address(RVA = "0x3FA710", Offset = "0x3F9310", Length = "0x5")]
  public void HideTip()
  {
  }

  [Token(Token = "0x6000CE8")]
  [Address(RVA = "0x532330", Offset = "0x530F30", Length = "0x57A")]
  private void Update()
  {
  }

  [Token(Token = "0x6000CE9")]
  [Address(RVA = "0x5328B0", Offset = "0x5314B0", Length = "0x15")]
  public ToolTip()
  {
  }
}
