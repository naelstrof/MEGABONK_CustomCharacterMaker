// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Interactables.OpenChest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Interactables
{
  [Token(Token = "0x20003ED")]
  public class OpenChest : MonoBehaviour
  {
    [Token(Token = "0x4001A0D")]
    [FieldOffset(Offset = "0x20")]
    public EChest chestType;
    [Token(Token = "0x4001A0E")]
    [FieldOffset(Offset = "0x24")]
    private float delay;
    [Token(Token = "0x4001A0F")]
    [FieldOffset(Offset = "0x28")]
    private float readyForPickupTime;
    [Token(Token = "0x4001A10")]
    [FieldOffset(Offset = "0x2C")]
    private bool pickedup;

    [Token(Token = "0x6001C5A")]
    [Address(RVA = "0x429F50", Offset = "0x428B50", Length = "0x60")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001C5B")]
    [Address(RVA = "0x42A020", Offset = "0x428C20", Length = "0x130")]
    private void OnTriggerStay(Collider other)
    {
    }

    [Token(Token = "0x6001C5C")]
    [Address(RVA = "0x429FB0", Offset = "0x428BB0", Length = "0x6B")]
    private bool CanPickup() => false;

    [Token(Token = "0x6001C5D")]
    [Address(RVA = "0x42A160", Offset = "0x428D60", Length = "0xE")]
    public OpenChest()
    {
    }
  }
}
