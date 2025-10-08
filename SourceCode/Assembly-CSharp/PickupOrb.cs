// Decompiled with JetBrains decompiler
// Type: PickupOrb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Pickups;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000AB")]
public class PickupOrb : MonoBehaviour
{
  [Token(Token = "0x4000561")]
  [FieldOffset(Offset = "0x20")]
  public GameObject hitEffect;
  [Token(Token = "0x4000562")]
  [FieldOffset(Offset = "0x28")]
  public TrailRenderer trail;
  [Token(Token = "0x4000563")]
  [FieldOffset(Offset = "0x30")]
  public ParticleSystem[] particleSystems;
  [Token(Token = "0x4000564")]
  [FieldOffset(Offset = "0x38")]
  public Rigidbody rb;
  [Token(Token = "0x4000565")]
  [FieldOffset(Offset = "0x40")]
  public EPickup ePickup;
  [Token(Token = "0x4000566")]
  [FieldOffset(Offset = "0x44")]
  private bool isDone;

  [Token(Token = "0x6000453")]
  [Address(RVA = "0x4819E0", Offset = "0x4805E0", Length = "0x44")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000454")]
  [Address(RVA = "0x481BF0", Offset = "0x4807F0", Length = "0x27E")]
  public void Set(EPickup ePickup)
  {
  }

  [Token(Token = "0x6000455")]
  [Address(RVA = "0x481A30", Offset = "0x480630", Length = "0x1BF")]
  private void OnCollisionEnter(Collision collision)
  {
  }

  [Token(Token = "0x6000456")]
  [Address(RVA = "0x481E70", Offset = "0x480A70", Length = "0x56")]
  private void Timeout()
  {
  }

  [Token(Token = "0x6000457")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public PickupOrb()
  {
  }
}
