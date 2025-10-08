// Decompiled with JetBrains decompiler
// Type: ToxicBarrelEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Items;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000069")]
public class ToxicBarrelEffect : MonoBehaviour
{
  [Token(Token = "0x4000348")]
  [FieldOffset(Offset = "0x20")]
  public EffectPlayer effectPlayer;

  [Token(Token = "0x60002AB")]
  [Address(RVA = "0x46FFB0", Offset = "0x46EBB0", Length = "0x338")]
  private void Awake()
  {
  }

  [Token(Token = "0x60002AC")]
  [Address(RVA = "0x4702F0", Offset = "0x46EEF0", Length = "0x338")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60002AD")]
  [Address(RVA = "0x470630", Offset = "0x46F230", Length = "0xA")]
  private void Start()
  {
  }

  [Token(Token = "0x60002AE")]
  [Address(RVA = "0x470630", Offset = "0x46F230", Length = "0xA")]
  private void OnInventory(PlayerInventory inv)
  {
  }

  [Token(Token = "0x60002AF")]
  [Address(RVA = "0x470640", Offset = "0x46F240", Length = "0xEA")]
  private void Refresh(ItemBase obj)
  {
  }

  [Token(Token = "0x60002B0")]
  [Address(RVA = "0x468B70", Offset = "0x467770", Length = "0xDB")]
  public void OnUse(float radius)
  {
  }

  [Token(Token = "0x60002B1")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ToxicBarrelEffect()
  {
  }
}
