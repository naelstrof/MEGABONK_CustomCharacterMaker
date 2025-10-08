// Decompiled with JetBrains decompiler
// Type: InputSettingMouseClick
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x20001DB")]
public class InputSettingMouseClick : 
  MonoBehaviour,
  IPointerClickHandler,
  IEventSystemHandler,
  IPointerDownHandler,
  IPointerEnterHandler
{
  [Token(Token = "0x4000D5D")]
  [FieldOffset(Offset = "0x20")]
  public int index;
  [Token(Token = "0x4000D5E")]
  [FieldOffset(Offset = "0x28")]
  public InputSettingNew inputSettingNew;

  [Token(Token = "0x6000C44")]
  [Address(RVA = "0x5057B0", Offset = "0x5043B0", Length = "0xF7")]
  public void OnPointerClick(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000C45")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public void OnPointerDown(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000C46")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public void OnPointerEnter(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000C47")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public InputSettingMouseClick()
  {
  }
}
