// Decompiled with JetBrains decompiler
// Type: HolyBookEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Items;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000068")]
public class HolyBookEffect : MonoBehaviour
{
  [Token(Token = "0x4000347")]
  [FieldOffset(Offset = "0x20")]
  public EffectPlayer effectPlayer;

  [Token(Token = "0x60002A4")]
  [Address(RVA = "0x4684E0", Offset = "0x4670E0", Length = "0x338")]
  private void Awake()
  {
  }

  [Token(Token = "0x60002A5")]
  [Address(RVA = "0x468820", Offset = "0x467420", Length = "0x338")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60002A6")]
  [Address(RVA = "0x468B60", Offset = "0x467760", Length = "0xA")]
  private void Start()
  {
  }

  [Token(Token = "0x60002A7")]
  [Address(RVA = "0x468B60", Offset = "0x467760", Length = "0xA")]
  private void OnInventory(PlayerInventory inv)
  {
  }

  [Token(Token = "0x60002A8")]
  [Address(RVA = "0x468C50", Offset = "0x467850", Length = "0xEA")]
  private void Refresh(ItemBase obj)
  {
  }

  [Token(Token = "0x60002A9")]
  [Address(RVA = "0x468B70", Offset = "0x467770", Length = "0xDB")]
  public void OnUse(float radius)
  {
  }

  [Token(Token = "0x60002AA")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public HolyBookEffect()
  {
  }
}
