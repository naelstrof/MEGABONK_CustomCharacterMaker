// Decompiled with JetBrains decompiler
// Type: Assets.Scripts._Data.IUpgradable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts._Data
{
  [Token(Token = "0x20002CF")]
  public interface IUpgradable
  {
    [Token(Token = "0x60014F0")]
    string GetName();

    [Token(Token = "0x60014F1")]
    string GetUpgradeDescription(int level, List<StatModifier> upgradeOffer, ERarity rarity);

    [Token(Token = "0x60014F2")]
    Texture GetIcon();

    [Token(Token = "0x60014F3")]
    int GetLevel();

    [Token(Token = "0x60014F4")]
    int GetMaxLevel();

    [Token(Token = "0x60014F5")]
    List<StatModifier> GetUpgradeOffer(ERarity rarity);
  }
}
