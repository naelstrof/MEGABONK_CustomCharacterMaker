// Decompiled with JetBrains decompiler
// Type: InventoryItemPrefabUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Items;
using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000156")]
public class InventoryItemPrefabUI : MonoBehaviour
{
  [Token(Token = "0x40009FF")]
  [FieldOffset(Offset = "0x20")]
  public RawImage icon;
  [Token(Token = "0x4000A00")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_level;
  [Token(Token = "0x4000A01")]
  [FieldOffset(Offset = "0x30")]
  public GameObject lockedOverlay;
  [Token(Token = "0x4000A02")]
  [FieldOffset(Offset = "0x38")]
  public ToolTipObject toolTipObject;
  [Token(Token = "0x4000A03")]
  [FieldOffset(Offset = "0x40")]
  private UnlockableBase item;

  [Token(Token = "0x6000891")]
  [Address(RVA = "0x4D3ED0", Offset = "0x4D2AD0", Length = "0x128")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000892")]
  [Address(RVA = "0x4D4150", Offset = "0x4D2D50", Length = "0x128")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000893")]
  [Address(RVA = "0x4D4280", Offset = "0x4D2E80", Length = "0x93")]
  private void OnWeaponToggled(WeaponBase weaponBase)
  {
  }

  [Token(Token = "0x6000894")]
  [Address(RVA = "0x4D44C0", Offset = "0x4D30C0", Length = "0x42A")]
  public void SetItem(UnlockableBase item)
  {
  }

  [Token(Token = "0x6000895")]
  [Address(RVA = "0x4D4320", Offset = "0x4D2F20", Length = "0x19C")]
  private void RefreshEnabled(bool isEnabled)
  {
  }

  [Token(Token = "0x6000896")]
  [Address(RVA = "0x4D48F0", Offset = "0x4D34F0", Length = "0x275")]
  public void SetItem(EItem eItem)
  {
  }

  [Token(Token = "0x6000897")]
  [Address(RVA = "0x4D4000", Offset = "0x4D2C00", Length = "0x14F")]
  private int GetLevel(UnlockableBase item) => 0;

  [Token(Token = "0x6000898")]
  [Address(RVA = "0x4D4B70", Offset = "0x4D3770", Length = "0x76")]
  public void SetUnavailable()
  {
  }

  [Token(Token = "0x6000899")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public InventoryItemPrefabUI()
  {
  }
}
