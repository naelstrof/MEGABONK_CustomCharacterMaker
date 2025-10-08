// Decompiled with JetBrains decompiler
// Type: ToolTipObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x20001F4")]
public class ToolTipObject : 
  MonoBehaviour,
  IPointerEnterHandler,
  IEventSystemHandler,
  IPointerExitHandler
{
  [TextArea]
  [Token(Token = "0x4000DE8")]
  [FieldOffset(Offset = "0x20")]
  public string text;
  [Token(Token = "0x4000DE9")]
  [FieldOffset(Offset = "0x28")]
  private float hoverTimeForShow;
  [Token(Token = "0x4000DEA")]
  [FieldOffset(Offset = "0x2C")]
  private float startedHoveringTime;
  [Token(Token = "0x4000DEB")]
  [FieldOffset(Offset = "0x30")]
  private bool hovering;
  [Token(Token = "0x4000DEC")]
  [FieldOffset(Offset = "0x31")]
  private bool showed;

  [Token(Token = "0x6000CEA")]
  [Address(RVA = "0x531B60", Offset = "0x530760", Length = "0x35")]
  public void OnPointerEnter(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000CEB")]
  [Address(RVA = "0x531BA0", Offset = "0x5307A0", Length = "0x95")]
  private void Update()
  {
  }

  [Token(Token = "0x6000CEC")]
  [Address(RVA = "0x531B00", Offset = "0x530700", Length = "0x5C")]
  public void OnPointerExit(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000CED")]
  [Address(RVA = "0x531B00", Offset = "0x530700", Length = "0x5C")]
  private void CloseTooltip()
  {
  }

  [Token(Token = "0x6000CEE")]
  [Address(RVA = "0x531B00", Offset = "0x530700", Length = "0x5C")]
  public void OnDisable()
  {
  }

  [Token(Token = "0x6000CEF")]
  [Address(RVA = "0x531C40", Offset = "0x530840", Length = "0xE")]
  public ToolTipObject()
  {
  }
}
