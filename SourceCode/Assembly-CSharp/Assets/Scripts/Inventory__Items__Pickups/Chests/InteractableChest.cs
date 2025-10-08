// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Chests.InteractableChest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Interactables;
using Cpp2ILInjected;
using System;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Chests
{
  [Token(Token = "0x20003E9")]
  public class InteractableChest : BaseInteractable
  {
    [Token(Token = "0x40019F3")]
    [FieldOffset(Offset = "0x58")]
    public EChest chestType;
    [Token(Token = "0x40019F4")]
    [FieldOffset(Offset = "0x5C")]
    private float rotation;
    [Token(Token = "0x40019F5")]
    [FieldOffset(Offset = "0x60")]
    public Transform icon;
    [Token(Token = "0x40019F6")]
    public static Action A_ChestBought;
    [Token(Token = "0x40019F7")]
    [FieldOffset(Offset = "0x68")]
    private bool opening;

    [Token(Token = "0x6001C3C")]
    [Address(RVA = "0x420260", Offset = "0x41EE60", Length = "0x120")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001C3D")]
    [Address(RVA = "0x420DA0", Offset = "0x41F9A0", Length = "0x12A")]
    private new void OnDestroy()
    {
    }

    [Token(Token = "0x6001C3E")]
    [Address(RVA = "0x420ED0", Offset = "0x41FAD0", Length = "0x1AA")]
    private new void Start()
    {
    }

    [Token(Token = "0x6001C3F")]
    [Address(RVA = "0x420690", Offset = "0x41F290", Length = "0x1EB")]
    public override bool Interact() => false;

    [Token(Token = "0x6001C40")]
    [Address(RVA = "0x420880", Offset = "0x41F480", Length = "0x516")]
    private void OnChestWindowClose()
    {
    }

    [Token(Token = "0x6001C41")]
    [Address(RVA = "0x420510", Offset = "0x41F110", Length = "0x11C")]
    public override string GetInteractString() => (string) null;

    [Token(Token = "0x6001C42")]
    [Address(RVA = "0x420460", Offset = "0x41F060", Length = "0xAF")]
    public override Color GetColor() => new Color();

    [Token(Token = "0x6001C43")]
    [Address(RVA = "0x420630", Offset = "0x41F230", Length = "0x54")]
    private int GetPrice() => 0;

    [Token(Token = "0x6001C44")]
    [Address(RVA = "0x420390", Offset = "0x41EF90", Length = "0xC9")]
    private bool CanAfford() => false;

    [Token(Token = "0x6001C45")]
    [Address(RVA = "0x421080", Offset = "0x41FC80", Length = "0xE")]
    public InteractableChest()
    {
    }
  }
}
