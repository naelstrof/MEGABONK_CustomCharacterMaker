// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Interactables.DetectInteractables
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Interactables
{
  [Token(Token = "0x20003EE")]
  public class DetectInteractables : MonoBehaviour
  {
    [Token(Token = "0x4001A11")]
    [FieldOffset(Offset = "0x20")]
    private float interactableRange;
    [Token(Token = "0x4001A12")]
    [FieldOffset(Offset = "0x24")]
    public LayerMask whatIsInteractable;
    [Token(Token = "0x4001A13")]
    [FieldOffset(Offset = "0x28")]
    private BaseInteractable currentInteractable;
    [Token(Token = "0x4001A14")]
    [FieldOffset(Offset = "0x30")]
    public TextMeshProUGUI t_interact;
    [Token(Token = "0x4001A15")]
    [FieldOffset(Offset = "0x38")]
    public Transform uiParent;
    [Token(Token = "0x4001A16")]
    [FieldOffset(Offset = "0x40")]
    public MyGlyphDisplay glyphContainer;
    [Token(Token = "0x4001A17")]
    public static Action<BaseInteractable, bool> A_Interacted;
    [Token(Token = "0x4001A18")]
    [FieldOffset(Offset = "0x48")]
    private float animationTime;
    [Token(Token = "0x4001A19")]
    [FieldOffset(Offset = "0x4C")]
    private float animateOverTime;
    [Token(Token = "0x4001A1A")]
    [FieldOffset(Offset = "0x50")]
    private Vector3 fromScale;
    [Token(Token = "0x4001A1B")]
    [FieldOffset(Offset = "0x5C")]
    private Vector3 toScale;

    [Token(Token = "0x6001C5E")]
    [Address(RVA = "0x41F140", Offset = "0x41DD40", Length = "0x3E")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001C5F")]
    [Address(RVA = "0x41F220", Offset = "0x41DE20", Length = "0x453")]
    private void FixedUpdate()
    {
    }

    [Token(Token = "0x6001C60")]
    [Address(RVA = "0x41FA90", Offset = "0x41E690", Length = "0x197")]
    public void TryInteract()
    {
    }

    [Token(Token = "0x6001C61")]
    [Address(RVA = "0x41F180", Offset = "0x41DD80", Length = "0x9C")]
    private bool CanInteract() => false;

    [Token(Token = "0x6001C62")]
    [Address(RVA = "0x41FC30", Offset = "0x41E830", Length = "0x32F")]
    private void Update()
    {
    }

    [Token(Token = "0x6001C63")]
    [Address(RVA = "0x41F720", Offset = "0x41E320", Length = "0x202")]
    private void StartHovering(GameObject newObject)
    {
    }

    [Token(Token = "0x6001C64")]
    [Address(RVA = "0x41F930", Offset = "0x41E530", Length = "0x15E")]
    private void StopHovering()
    {
    }

    [Token(Token = "0x6001C65")]
    [Address(RVA = "0x41F680", Offset = "0x41E280", Length = "0x7")]
    public void InteractableDestroyed()
    {
    }

    [Token(Token = "0x6001C66")]
    [Address(RVA = "0x41F690", Offset = "0x41E290", Length = "0x8D")]
    private void RefreshGlyphContainer()
    {
    }

    [Token(Token = "0x6001C67")]
    [Address(RVA = "0x41FF60", Offset = "0x41EB60", Length = "0x15")]
    public DetectInteractables()
    {
    }
  }
}
