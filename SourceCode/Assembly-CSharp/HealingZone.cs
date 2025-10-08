// Decompiled with JetBrains decompiler
// Type: HealingZone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Items;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000066")]
public class HealingZone : MonoBehaviour
{
  [Token(Token = "0x400033E")]
  [FieldOffset(Offset = "0x20")]
  private float healInterval;
  [Token(Token = "0x400033F")]
  [FieldOffset(Offset = "0x24")]
  private float nextHealTime;
  [Token(Token = "0x4000340")]
  [FieldOffset(Offset = "0x28")]
  private float radius;
  [Token(Token = "0x4000341")]
  [FieldOffset(Offset = "0x2C")]
  private float healPerInterval;
  [Token(Token = "0x4000342")]
  [FieldOffset(Offset = "0x30")]
  private float defaultHealingPerInterval;

  [Token(Token = "0x6000295")]
  [Address(RVA = "0x4677B0", Offset = "0x4663B0", Length = "0x229")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000296")]
  [Address(RVA = "0x467C40", Offset = "0x466840", Length = "0x229")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000297")]
  [Address(RVA = "0x4680B0", Offset = "0x466CB0", Length = "0x400")]
  private void Start()
  {
  }

  [Token(Token = "0x6000298")]
  [Address(RVA = "0x4679E0", Offset = "0x4665E0", Length = "0x243")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000299")]
  [Address(RVA = "0x467E70", Offset = "0x466A70", Length = "0xD")]
  private void OnItemChanged(EItem item)
  {
  }

  [Token(Token = "0x600029A")]
  [Address(RVA = "0x467E70", Offset = "0x466A70", Length = "0xD")]
  private void OnItemChanged(EItem arg1, bool arg2)
  {
  }

  [Token(Token = "0x600029B")]
  [Address(RVA = "0x467E80", Offset = "0x466A80", Length = "0x229")]
  private void RefreshStats()
  {
  }

  [Token(Token = "0x600029C")]
  [Address(RVA = "0x393420", Offset = "0x392020", Length = "0x6")]
  private float GetRadius() => 0.0f;

  [Token(Token = "0x600029D")]
  [Address(RVA = "0x467C30", Offset = "0x466830", Length = "0x6")]
  private float GetHealAmount() => 0.0f;

  [Token(Token = "0x600029E")]
  [Address(RVA = "0x4684C0", Offset = "0x4670C0", Length = "0x15")]
  public HealingZone()
  {
  }
}
