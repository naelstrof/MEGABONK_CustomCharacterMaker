// Decompiled with JetBrains decompiler
// Type: OutlineButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x2000158")]
public class OutlineButton : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
{
  [Token(Token = "0x4000A1D")]
  [FieldOffset(Offset = "0x20")]
  public RawImage outline;

  [Token(Token = "0x60008B2")]
  [Address(RVA = "0x4DB880", Offset = "0x4DA480", Length = "0x20")]
  public void OnSelect(BaseEventData eventData)
  {
  }

  [Token(Token = "0x60008B3")]
  [Address(RVA = "0x4DB850", Offset = "0x4DA450", Length = "0x20")]
  public void OnDeselect(BaseEventData eventData)
  {
  }

  [Token(Token = "0x60008B4")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public OutlineButton()
  {
  }
}
