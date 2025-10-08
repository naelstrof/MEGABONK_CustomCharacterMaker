// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Interactables.InteractablePot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Pickups;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Interactables
{
  [Token(Token = "0x20003EF")]
  public class InteractablePot : BaseInteractable
  {
    [Token(Token = "0x4001A1C")]
    [FieldOffset(Offset = "0x58")]
    public GameObject goldPrefab;
    [Token(Token = "0x4001A1D")]
    [FieldOffset(Offset = "0x60")]
    public GameObject xpPrefab;
    [Token(Token = "0x4001A1E")]
    [FieldOffset(Offset = "0x68")]
    public GameObject hpPrefab;
    [Token(Token = "0x4001A1F")]
    [FieldOffset(Offset = "0x70")]
    public GameObject silverPrefab;
    [Token(Token = "0x4001A20")]
    [FieldOffset(Offset = "0x78")]
    public GameObject potBreakFx;
    [Token(Token = "0x4001A21")]
    [FieldOffset(Offset = "0x80")]
    private bool broken;
    [Token(Token = "0x4001A22")]
    [FieldOffset(Offset = "0x81")]
    public bool isBig;
    [Token(Token = "0x4001A23")]
    [FieldOffset(Offset = "0x82")]
    public bool isSilver;

    [Token(Token = "0x6001C68")]
    [Address(RVA = "0x4211E0", Offset = "0x41FDE0", Length = "0xAE9")]
    public override bool Interact() => false;

    [Token(Token = "0x6001C69")]
    [Address(RVA = "0x4210E0", Offset = "0x41FCE0", Length = "0xF2")]
    private int GetXp() => 0;

    [Token(Token = "0x6001C6A")]
    [Address(RVA = "0x421CD0", Offset = "0x4208D0", Length = "0x31A")]
    private void SpawnStuff(EPickup ePickup, int value, float pickupDelay, int amount)
    {
    }

    [Token(Token = "0x6001C6B")]
    [Address(RVA = "0x421090", Offset = "0x41FC90", Length = "0x46")]
    public override string GetInteractString() => (string) null;

    [Token(Token = "0x6001C6C")]
    [Address(RVA = "0x421FF0", Offset = "0x420BF0", Length = "0x7")]
    public InteractablePot()
    {
    }
  }
}
