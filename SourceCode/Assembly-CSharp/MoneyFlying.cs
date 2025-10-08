// Decompiled with JetBrains decompiler
// Type: MoneyFlying
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200008A")]
public class MoneyFlying : MonoBehaviour
{
  [Token(Token = "0x4000469")]
  public static int maxMoneyObjects;
  [Token(Token = "0x400046A")]
  [FieldOffset(Offset = "0x20")]
  public int value;
  [Token(Token = "0x400046B")]
  [FieldOffset(Offset = "0x24")]
  private bool pickedUp;
  [Token(Token = "0x400046C")]
  [FieldOffset(Offset = "0x28")]
  private Transform target;
  [Token(Token = "0x400046D")]
  [FieldOffset(Offset = "0x30")]
  private float speed;
  [Token(Token = "0x400046E")]
  [FieldOffset(Offset = "0x38")]
  public ParticleSystem ps;
  [Token(Token = "0x400046F")]
  [FieldOffset(Offset = "0x40")]
  public Color colorTier1;
  [Token(Token = "0x4000470")]
  [FieldOffset(Offset = "0x50")]
  public Color colorTier2;
  [Token(Token = "0x4000471")]
  [FieldOffset(Offset = "0x60")]
  public Color colorTier3;
  [Token(Token = "0x4000472")]
  [FieldOffset(Offset = "0x70")]
  private float currentSize;
  [Token(Token = "0x4000473")]
  [FieldOffset(Offset = "0x74")]
  private Vector3 randomDir;
  [Token(Token = "0x4000474")]
  [FieldOffset(Offset = "0x80")]
  private float rndSpeed;
  [Token(Token = "0x4000475")]
  [FieldOffset(Offset = "0x84")]
  private float rndMaxSpeed;
  [Token(Token = "0x4000476")]
  [FieldOffset(Offset = "0x88")]
  private float rndTime;

  [Token(Token = "0x6000378")]
  [Address(RVA = "0x469C50", Offset = "0x468850", Length = "0x1BE")]
  public void Set(int value, Vector3 pos)
  {
  }

  [Token(Token = "0x6000379")]
  [Address(RVA = "0x469760", Offset = "0x468360", Length = "0xA")]
  public void AddValue(int value)
  {
  }

  [Token(Token = "0x600037A")]
  [Address(RVA = "0x469A80", Offset = "0x468680", Length = "0x1C7")]
  private void RefreshVisuals()
  {
  }

  [Token(Token = "0x600037B")]
  [Address(RVA = "0x469E10", Offset = "0x468A10", Length = "0x37D")]
  private void Update()
  {
  }

  [Token(Token = "0x600037C")]
  [Address(RVA = "0x469770", Offset = "0x468370", Length = "0x1D1")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x600037D")]
  [Address(RVA = "0x469950", Offset = "0x468550", Length = "0x129")]
  private void Pickup()
  {
  }

  [Token(Token = "0x600037E")]
  [Address(RVA = "0x46A1D0", Offset = "0x468DD0", Length = "0x18")]
  public MoneyFlying()
  {
  }

  [Token(Token = "0x600037F")]
  [Address(RVA = "0x46A190", Offset = "0x468D90", Length = "0x39")]
  static MoneyFlying()
  {
  }
}
