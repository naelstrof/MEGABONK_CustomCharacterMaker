// Decompiled with JetBrains decompiler
// Type: SelectionButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x200018C")]
public abstract class SelectionButton : 
  MonoBehaviour,
  ISelectHandler,
  IEventSystemHandler,
  IDeselectHandler
{
  [Token(Token = "0x4000B56")]
  [FieldOffset(Offset = "0x20")]
  public GameObject selectionOverlay;
  [Token(Token = "0x4000B57")]
  [FieldOffset(Offset = "0x28")]
  public RawImage i_icon;
  [Token(Token = "0x4000B58")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_name;
  [Token(Token = "0x4000B59")]
  [FieldOffset(Offset = "0x38")]
  private Button button;
  [Token(Token = "0x4000B5A")]
  [FieldOffset(Offset = "0x40")]
  protected bool clicked;
  [Token(Token = "0x4000B5B")]
  [FieldOffset(Offset = "0x41")]
  protected bool selected;

  [Token(Token = "0x60009F5")]
  [Address(RVA = "0x4FA8D0", Offset = "0x4F94D0", Length = "0xD5")]
  private void Awake()
  {
  }

  [Token(Token = "0x60009F6")]
  [Address(RVA = "0x4FAB10", Offset = "0x4F9710", Length = "0xAA")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60009F7")]
  protected abstract void Init();

  [Token(Token = "0x60009F8")]
  protected abstract void Cleanup();

  [Token(Token = "0x60009F9")]
  [Address(RVA = "0x4FAC50", Offset = "0x4F9850", Length = "0x55B")]
  private void Update()
  {
  }

  [Token(Token = "0x60009FA")]
  [Address(RVA = "0x4FAA10", Offset = "0x4F9610", Length = "0x61")]
  public void Enable()
  {
  }

  [Token(Token = "0x60009FB")]
  [Address(RVA = "0x4FA9B0", Offset = "0x4F95B0", Length = "0x5D")]
  public void Disable()
  {
  }

  [Token(Token = "0x60009FC")]
  [Address(RVA = "0x4FAA80", Offset = "0x4F9680", Length = "0x3E")]
  protected void OnClick()
  {
  }

  [Token(Token = "0x60009FD")]
  protected abstract void OnClicked();

  [Token(Token = "0x60009FE")]
  [Address(RVA = "0x4FAC00", Offset = "0x4F9800", Length = "0x43")]
  protected void UpdateSelectionOverlay()
  {
  }

  [Token(Token = "0x60009FF")]
  [Address(RVA = "0x4FABC0", Offset = "0x4F97C0", Length = "0x3E")]
  public void OnSelect(BaseEventData eventData)
  {
  }

  [Token(Token = "0x6000A00")]
  [Address(RVA = "0x4FABC0", Offset = "0x4F97C0", Length = "0x3E")]
  public void SelectCharacter()
  {
  }

  [Token(Token = "0x6000A01")]
  protected abstract void OnSelectedCharacter();

  [Token(Token = "0x6000A02")]
  [Address(RVA = "0x4FAAC0", Offset = "0x4F96C0", Length = "0x43")]
  public void OnDeselect(BaseEventData eventData)
  {
  }

  [Token(Token = "0x6000A03")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  protected SelectionButton()
  {
  }
}
