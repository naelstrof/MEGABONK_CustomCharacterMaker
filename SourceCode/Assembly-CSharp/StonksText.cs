// Decompiled with JetBrains decompiler
// Type: StonksText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x200013F")]
public class StonksText : MonoBehaviour
{
  [Token(Token = "0x400094D")]
  [FieldOffset(Offset = "0x20")]
  private int amount;
  [Token(Token = "0x400094E")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_gold;
  [Token(Token = "0x400094F")]
  [FieldOffset(Offset = "0x30")]
  private bool active;
  [Token(Token = "0x4000950")]
  [FieldOffset(Offset = "0x34")]
  private float rotationSpeed;
  [Token(Token = "0x4000951")]
  [FieldOffset(Offset = "0x38")]
  private float maxRotationAngle;
  [Token(Token = "0x4000952")]
  [FieldOffset(Offset = "0x3C")]
  private float timeCounter;
  [Token(Token = "0x4000953")]
  [FieldOffset(Offset = "0x40")]
  private float lerp;
  [Token(Token = "0x4000954")]
  [FieldOffset(Offset = "0x44")]
  private float lerp2;
  [Token(Token = "0x4000955")]
  [FieldOffset(Offset = "0x48")]
  private float scaleOffset;

  [Token(Token = "0x60007FE")]
  [Address(RVA = "0x4C6A80", Offset = "0x4C5680", Length = "0x341")]
  private void Awake()
  {
  }

  [Token(Token = "0x60007FF")]
  [Address(RVA = "0x4C7370", Offset = "0x4C5F70", Length = "0xCE")]
  public void Reset()
  {
  }

  [Token(Token = "0x6000800")]
  [Address(RVA = "0x4C7270", Offset = "0x4C5E70", Length = "0xE7")]
  private void OnStatusEffectAdded(EStatusEffect eStatusEffect, bool isNewEffect)
  {
  }

  [Token(Token = "0x6000801")]
  [Address(RVA = "0x4C7360", Offset = "0x4C5F60", Length = "0xA")]
  private void OnStatusEffectRemoved(EStatusEffect eStatusEffect)
  {
  }

  [Token(Token = "0x6000802")]
  [Address(RVA = "0x4C7120", Offset = "0x4C5D20", Length = "0x143")]
  private void OnEnemyDied(Enemy e, DamageContainer deathSource)
  {
  }

  [Token(Token = "0x6000803")]
  [Address(RVA = "0x4C7440", Offset = "0x4C6040", Length = "0x380")]
  private void Update()
  {
  }

  [Token(Token = "0x6000804")]
  [Address(RVA = "0x4C6DD0", Offset = "0x4C59D0", Length = "0x342")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000805")]
  [Address(RVA = "0x4C77D0", Offset = "0x4C63D0", Length = "0x15")]
  public StonksText()
  {
  }
}
