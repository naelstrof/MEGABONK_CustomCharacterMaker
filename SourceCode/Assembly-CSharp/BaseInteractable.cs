// Decompiled with JetBrains decompiler
// Type: BaseInteractable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Interactables;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200008C")]
public abstract class BaseInteractable : MonoBehaviour
{
  [Token(Token = "0x400047E")]
  [FieldOffset(Offset = "0x20")]
  public bool isItemSource;
  [Token(Token = "0x400047F")]
  [FieldOffset(Offset = "0x28")]
  private Outline outline;
  [Token(Token = "0x4000480")]
  [FieldOffset(Offset = "0x30")]
  private DetectInteractables detectInteractables;
  [Token(Token = "0x4000481")]
  [FieldOffset(Offset = "0x38")]
  public Vector3 textOffset;
  [Token(Token = "0x4000482")]
  [FieldOffset(Offset = "0x44")]
  private Vector3 textOffsetCalculated;
  [Token(Token = "0x4000483")]
  [FieldOffset(Offset = "0x50")]
  public bool showOutline;

  [Token(Token = "0x6000385")]
  [Address(RVA = "0x4757F0", Offset = "0x4743F0", Length = "0x211")]
  protected void Start()
  {
  }

  [Token(Token = "0x6000386")]
  [Address(RVA = "0x4756B0", Offset = "0x4742B0", Length = "0x136")]
  public void StartHover(DetectInteractables detectInteractables)
  {
  }

  [Token(Token = "0x6000387")]
  [Address(RVA = "0x475A10", Offset = "0x474610", Length = "0xA7")]
  public void StopHover()
  {
  }

  [Token(Token = "0x6000388")]
  [Address(RVA = "0x475570", Offset = "0x474170", Length = "0x139")]
  protected void OnDestroy()
  {
  }

  [Token(Token = "0x6000389")]
  public abstract bool Interact();

  [Token(Token = "0x600038A")]
  public abstract string GetInteractString();

  [Token(Token = "0x600038B")]
  [Address(RVA = "0x394420", Offset = "0x393020", Length = "0xE")]
  public virtual Color GetColor() => new Color();

  [Token(Token = "0x600038C")]
  [Address(RVA = "0x375D80", Offset = "0x374980", Length = "0x3")]
  public virtual bool CanInteract() => false;

  [Token(Token = "0x600038D")]
  [Address(RVA = "0x475550", Offset = "0x474150", Length = "0x13")]
  public Vector3 GetOffset() => new Vector3();

  [Token(Token = "0x600038E")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  protected BaseInteractable()
  {
  }
}
