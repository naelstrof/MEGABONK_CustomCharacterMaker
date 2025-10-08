// Decompiled with JetBrains decompiler
// Type: MyButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x2000176")]
public abstract class MyButton : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
  [Token(Token = "0x4000AC4")]
  [FieldOffset(Offset = "0x20")]
  protected bool isHovering;
  [Token(Token = "0x4000AC5")]
  [FieldOffset(Offset = "0x28")]
  public Transform scaleOnHover;
  [Token(Token = "0x4000AC6")]
  [FieldOffset(Offset = "0x30")]
  protected Button button;
  [Token(Token = "0x4000AC7")]
  [FieldOffset(Offset = "0x38")]
  public float hoverScale;
  [Token(Token = "0x4000AC8")]
  [FieldOffset(Offset = "0x3C")]
  private MyButton.EButtonState state;
  [Token(Token = "0x4000AC9")]
  [FieldOffset(Offset = "0x40")]
  public GameObject disabledOverlay;
  [Token(Token = "0x4000ACA")]
  [FieldOffset(Offset = "0x48")]
  public AudioClip customSfx;
  [Token(Token = "0x4000ACB")]
  [FieldOffset(Offset = "0x50")]
  protected float selectedAtTime;

  [Token(Token = "0x6000966")]
  [Address(RVA = "0x4DB030", Offset = "0x4D9C30", Length = "0xF9")]
  protected void Awake()
  {
  }

  [Token(Token = "0x6000967")]
  [Address(RVA = "0x4DB510", Offset = "0x4DA110", Length = "0x65")]
  public void SetFocus(bool focus)
  {
  }

  [Token(Token = "0x6000968")]
  [Address(RVA = "0x4DB5A0", Offset = "0x4DA1A0", Length = "0x12")]
  public void SetInteractable(bool interactable)
  {
  }

  [Token(Token = "0x6000969")]
  [Address(RVA = "0x4DB580", Offset = "0x4DA180", Length = "0x14")]
  public void SetInteractableButKeepSelectionOn(bool interactable)
  {
  }

  [Token(Token = "0x600096A")]
  [Address(RVA = "0x4DB300", Offset = "0x4D9F00", Length = "0x175")]
  private void RefreshState()
  {
  }

  [Token(Token = "0x600096B")]
  [Address(RVA = "0x4DB480", Offset = "0x4DA080", Length = "0x85")]
  public void SetDisabledOverlayButKeepInteractable(bool enabled)
  {
  }

  [Token(Token = "0x600096C")]
  public abstract void StartHover();

  [Token(Token = "0x600096D")]
  public abstract void StopHover();

  [Token(Token = "0x600096E")]
  protected abstract void OnClick();

  [Token(Token = "0x600096F")]
  [Address(RVA = "0x4DB250", Offset = "0x4D9E50", Length = "0xA6")]
  protected void PlaySfx()
  {
  }

  [Token(Token = "0x6000970")]
  [Address(RVA = "0x4DB1C0", Offset = "0x4D9DC0", Length = "0x84")]
  public void OnSelect(BaseEventData eventData)
  {
  }

  [Token(Token = "0x6000971")]
  [Address(RVA = "0x4DB5C0", Offset = "0x4DA1C0", Length = "0x282")]
  protected void Update()
  {
  }

  [Token(Token = "0x6000972")]
  [Address(RVA = "0x4DB130", Offset = "0x4D9D30", Length = "0x8D")]
  public Button GetButton() => (Button) null;

  [Token(Token = "0x6000973")]
  [Address(RVA = "0x4D7090", Offset = "0x4D5C90", Length = "0xE")]
  protected MyButton()
  {
  }

  [Token(Token = "0x2000177")]
  public enum EButtonState
  {
    [Token(Token = "0x4000ACD")] Active,
    [Token(Token = "0x4000ACE")] Inactive,
    [Token(Token = "0x4000ACF")] InactiveWithSelection,
  }
}
