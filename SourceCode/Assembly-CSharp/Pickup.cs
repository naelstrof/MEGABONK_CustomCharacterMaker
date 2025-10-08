// Decompiled with JetBrains decompiler
// Type: Pickup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Pickups;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000A8")]
public class Pickup : MonoBehaviour
{
  [Token(Token = "0x4000537")]
  [FieldOffset(Offset = "0x20")]
  public LinkedListNode<Pickup> linkedListNode;
  [Token(Token = "0x4000538")]
  [FieldOffset(Offset = "0x28")]
  public EPickup ePickup;
  [Token(Token = "0x4000539")]
  [FieldOffset(Offset = "0x2C")]
  private int value;
  [Token(Token = "0x400053A")]
  [FieldOffset(Offset = "0x30")]
  private bool pickedUp;
  [Token(Token = "0x400053B")]
  [FieldOffset(Offset = "0x38")]
  private Transform target;
  [Token(Token = "0x400053C")]
  [FieldOffset(Offset = "0x40")]
  private float speed;
  [Token(Token = "0x400053D")]
  [FieldOffset(Offset = "0x48")]
  public Collider collider;
  [Token(Token = "0x400053E")]
  [FieldOffset(Offset = "0x50")]
  public Action<int> A_ValueUpdated;
  [Token(Token = "0x400053F")]
  public static Action<Pickup> A_PickupTriggered;
  [Token(Token = "0x4000540")]
  [FieldOffset(Offset = "0x58")]
  private Vector3 startPosition;
  [Token(Token = "0x4000541")]
  [FieldOffset(Offset = "0x64")]
  private float readyForPickupTime;
  [Token(Token = "0x4000542")]
  [FieldOffset(Offset = "0x68")]
  private bool ignoreMagnetMultiplier;
  [Token(Token = "0x4000543")]
  [FieldOffset(Offset = "0x6C")]
  public float floatOffset;
  [Token(Token = "0x4000544")]
  [FieldOffset(Offset = "0x70")]
  public float floatSpeed;
  [Token(Token = "0x4000545")]
  [FieldOffset(Offset = "0x74")]
  private float floatRandomOffset;
  [Token(Token = "0x4000546")]
  [FieldOffset(Offset = "0x78")]
  public float floatRotationSpeed;
  [Token(Token = "0x4000547")]
  [FieldOffset(Offset = "0x7C")]
  public bool animateRotation;
  [Token(Token = "0x4000548")]
  [FieldOffset(Offset = "0x7D")]
  public bool animatePosition;

  [Token(Token = "0x600042E")]
  [Address(RVA = "0x482500", Offset = "0x481100", Length = "0x8C")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x600042F")]
  [Address(RVA = "0x482750", Offset = "0x481350", Length = "0xF8")]
  public void Set(Vector3 pos, int value, float pickupDelay)
  {
  }

  [Token(Token = "0x6000430")]
  [Address(RVA = "0x482360", Offset = "0x480F60", Length = "0x27")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000431")]
  [Address(RVA = "0x481ED0", Offset = "0x480AD0", Length = "0x1C")]
  public void AddValue(int addValue)
  {
  }

  [Token(Token = "0x6000432")]
  [Address(RVA = "0x481EF0", Offset = "0x480AF0", Length = "0x35")]
  public void AddValue(Pickup other)
  {
  }

  [Token(Token = "0x6000433")]
  [Address(RVA = "0x482730", Offset = "0x481330", Length = "0x19")]
  private void SetValue(int v)
  {
  }

  [Token(Token = "0x6000434")]
  [Address(RVA = "0x482590", Offset = "0x481190", Length = "0x190")]
  private void OnTriggerStay(Collider other)
  {
  }

  [Token(Token = "0x6000435")]
  [Address(RVA = "0x4829C0", Offset = "0x4815C0", Length = "0x16F")]
  public void StartFollowingPlayer(Transform target)
  {
  }

  [Token(Token = "0x6000436")]
  [Address(RVA = "0x481F30", Offset = "0x480B30", Length = "0x3FC")]
  private void ApplyPickup()
  {
  }

  [Token(Token = "0x6000437")]
  [Address(RVA = "0x482850", Offset = "0x481450", Length = "0x162")]
  private void ShowUi(EPickup ePickup)
  {
  }

  [Token(Token = "0x6000438")]
  [Address(RVA = "0x482B30", Offset = "0x481730", Length = "0x485")]
  private void Update()
  {
  }

  [Token(Token = "0x6000439")]
  [Address(RVA = "0x482410", Offset = "0x481010", Length = "0xDD")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x600043A")]
  [Address(RVA = "0x482390", Offset = "0x480F90", Length = "0x7C")]
  public virtual bool CanPickup() => false;

  [Token(Token = "0x600043B")]
  [Address(RVA = "0x4824F0", Offset = "0x4810F0", Length = "0x4")]
  public int GetValue() => 0;

  [Token(Token = "0x600043C")]
  [Address(RVA = "0x482FC0", Offset = "0x481BC0", Length = "0x23")]
  public Pickup()
  {
  }
}
