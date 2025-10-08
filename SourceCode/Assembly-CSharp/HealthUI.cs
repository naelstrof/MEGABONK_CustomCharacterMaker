// Decompiled with JetBrains decompiler
// Type: HealthUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000208")]
public class HealthUI : MonoBehaviour
{
  [Token(Token = "0x4000E4C")]
  [FieldOffset(Offset = "0x20")]
  public Transform healthBar;
  [Token(Token = "0x4000E4D")]
  [FieldOffset(Offset = "0x28")]
  public Transform shieldBar;
  [Token(Token = "0x4000E4E")]
  [FieldOffset(Offset = "0x30")]
  public Transform overhealBar;
  [Token(Token = "0x4000E4F")]
  [FieldOffset(Offset = "0x38")]
  private Vector3 defaultPosition;
  [Token(Token = "0x4000E50")]
  [FieldOffset(Offset = "0x48")]
  public TextMeshProUGUI t_hp;
  [Token(Token = "0x4000E51")]
  [FieldOffset(Offset = "0x50")]
  public TextMeshProUGUI t_shield;
  [Token(Token = "0x4000E52")]
  [FieldOffset(Offset = "0x58")]
  public bool followPlayer;

  [Token(Token = "0x6000D4F")]
  [Address(RVA = "0x525910", Offset = "0x524510", Length = "0x952")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000D50")]
  [Address(RVA = "0x526280", Offset = "0x524E80", Length = "0x81F")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000D51")]
  [Address(RVA = "0x526AA0", Offset = "0x5256A0", Length = "0x1E")]
  private void OnPlayerInventoryInit(PlayerInventory inventory)
  {
  }

  [Token(Token = "0x6000D52")]
  [Address(RVA = "0x526CD0", Offset = "0x5258D0", Length = "0x88")]
  private void Start()
  {
  }

  [Token(Token = "0x6000D53")]
  [Address(RVA = "0x527190", Offset = "0x525D90", Length = "0x2C2")]
  private void Update()
  {
  }

  [Token(Token = "0x6000D54")]
  [Address(RVA = "0x526D60", Offset = "0x525960", Length = "0x3AD")]
  private void UpdateBars(PlayerHealth ph)
  {
  }

  [Token(Token = "0x6000D55")]
  [Address(RVA = "0x527110", Offset = "0x525D10", Length = "0x7D")]
  private void UpdateHealthBar(Transform bar, float value, float max)
  {
  }

  [Token(Token = "0x6000D56")]
  [Address(RVA = "0x526B00", Offset = "0x525700", Length = "0x31")]
  private void OnPortalOpen()
  {
  }

  [Token(Token = "0x6000D57")]
  [Address(RVA = "0x526AC0", Offset = "0x5256C0", Length = "0x31")]
  private void OnPortalClose()
  {
  }

  [Token(Token = "0x6000D58")]
  [Address(RVA = "0x526270", Offset = "0x524E70", Length = "0x8")]
  private void OnHeal(PlayerHealth ph, float amount, bool isShield)
  {
  }

  [Token(Token = "0x6000D59")]
  [Address(RVA = "0x526270", Offset = "0x524E70", Length = "0x8")]
  private void OnDamageTaken(PlayerHealth ph, DamageContainer dc, bool shieldDamage)
  {
  }

  [Token(Token = "0x6000D5A")]
  [Address(RVA = "0x526270", Offset = "0x524E70", Length = "0x8")]
  private void OnMaxValuesChanged(PlayerHealth ph)
  {
  }

  [Token(Token = "0x6000D5B")]
  [Address(RVA = "0x526270", Offset = "0x524E70", Length = "0x8")]
  private void OnOverhealChanged(PlayerHealth ph)
  {
  }

  [Token(Token = "0x6000D5C")]
  [Address(RVA = "0x526B40", Offset = "0x525740", Length = "0x9F")]
  private void OnSettingUpdated(string settingName, object oldValue, object newValue)
  {
  }

  [Token(Token = "0x6000D5D")]
  [Address(RVA = "0x526BE0", Offset = "0x5257E0", Length = "0xE3")]
  private void SetHealthBarColor(EHpBarColor color)
  {
  }

  [Token(Token = "0x6000D5E")]
  [Address(RVA = "0x527460", Offset = "0x526060", Length = "0xB")]
  public HealthUI()
  {
  }
}
