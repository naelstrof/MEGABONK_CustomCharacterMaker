// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Upgrades.UpgradeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Upgrades
{
  [CreateAssetMenu(menuName = "Me/UpgradeData", order = 1)]
  [Token(Token = "0x200037B")]
  public class UpgradeData : ScriptableObject
  {
    [Token(Token = "0x400179B")]
    [FieldOffset(Offset = "0x18")]
    public List<StatModifier> upgradeModifiers;

    [Token(Token = "0x60018EA")]
    [Address(RVA = "0x3F8C40", Offset = "0x3F7840", Length = "0xE0")]
    public List<StatModifier> GetUpgradeOffer(ERarity rarity, EWeapon eWeapon) => (List<StatModifier>) null;

    [Token(Token = "0x60018EB")]
    [Address(RVA = "0x3F8B30", Offset = "0x3F7730", Length = "0x106")]
    private StatModifier GetRandomModifier(StatModifier randomModifier, float multiplier) => (StatModifier) default;

    [Token(Token = "0x60018EC")]
    [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
    public UpgradeData()
    {
    }
  }
}
