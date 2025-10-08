// Decompiled with JetBrains decompiler
// Type: InteractableTumbleWeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Pickups;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200009F")]
public class InteractableTumbleWeed : BaseInteractable
{
  [Token(Token = "0x40004EC")]
  public const int maxTumbleWeeds = 25;
  [Token(Token = "0x40004ED")]
  [FieldOffset(Offset = "0x58")]
  private bool broken;
  [Token(Token = "0x40004EE")]
  [FieldOffset(Offset = "0x60")]
  public Rigidbody rb;
  [Token(Token = "0x40004EF")]
  [FieldOffset(Offset = "0x68")]
  private Vector3 desiredVelocity;
  [Token(Token = "0x40004F0")]
  [FieldOffset(Offset = "0x74")]
  private float speed;
  [Token(Token = "0x40004F1")]
  [FieldOffset(Offset = "0x78")]
  private float actualSpeed;
  [Token(Token = "0x40004F2")]
  [FieldOffset(Offset = "0x7C")]
  private Vector3 lastPos;
  [Token(Token = "0x40004F3")]
  [FieldOffset(Offset = "0x88")]
  public AudioSource audio;
  [Token(Token = "0x40004F4")]
  [FieldOffset(Offset = "0x90")]
  private float defaultVolume;
  [Token(Token = "0x40004F5")]
  [FieldOffset(Offset = "0x94")]
  private float startTime;
  [Token(Token = "0x40004F6")]
  [FieldOffset(Offset = "0x98")]
  private float stopTime;
  [Token(Token = "0x40004F7")]
  [FieldOffset(Offset = "0x9C")]
  private float scaleMultiplier;

  [Token(Token = "0x60003FA")]
  [Address(RVA = "0x47B2A0", Offset = "0x479EA0", Length = "0x224")]
  public override bool Interact() => false;

  [Token(Token = "0x60003FB")]
  [Address(RVA = "0x47AC10", Offset = "0x479810", Length = "0x31A")]
  private void Despawn()
  {
  }

  [Token(Token = "0x60003FC")]
  [Address(RVA = "0x47B4D0", Offset = "0x47A0D0", Length = "0xB")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60003FD")]
  [Address(RVA = "0x47B4E0", Offset = "0x47A0E0", Length = "0x23F")]
  private void SpawnXp(EPickup ePickup, int value, float pickupDelay)
  {
  }

  [Token(Token = "0x60003FE")]
  [Address(RVA = "0x47B250", Offset = "0x479E50", Length = "0x46")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x60003FF")]
  [Address(RVA = "0x47B720", Offset = "0x47A320", Length = "0x2C0")]
  private void Spawn()
  {
  }

  [Token(Token = "0x6000400")]
  [Address(RVA = "0x47AF30", Offset = "0x479B30", Length = "0x9E")]
  private void FindNewDir()
  {
  }

  [Token(Token = "0x6000401")]
  [Address(RVA = "0x47AFD0", Offset = "0x479BD0", Length = "0x279")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000402")]
  [Address(RVA = "0x47B9F0", Offset = "0x47A5F0", Length = "0x19")]
  public InteractableTumbleWeed()
  {
  }
}
