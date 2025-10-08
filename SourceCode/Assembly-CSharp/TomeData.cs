// Decompiled with JetBrains decompiler
// Type: TomeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data;
using Assets.Scripts._Data.Tomes;
using Assets.Scripts.Inventory__Items__Pickups;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.Inventory__Items__Pickups.Upgrades;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Me/Tome", order = 1)]
[Token(Token = "0x2000227")]
public class TomeData : UnlockableBase, IUpgradable
{
  [Token(Token = "0x4000F0F")]
  [FieldOffset(Offset = "0x50")]
  public ETome eTome;
  [TextArea]
  [Token(Token = "0x4000F10")]
  [FieldOffset(Offset = "0x58")]
  public string description;
  [Token(Token = "0x4000F11")]
  [FieldOffset(Offset = "0x60")]
  public StatModifier statModifier;
  [Token(Token = "0x4000F12")]
  [FieldOffset(Offset = "0x68")]
  public Texture icon;
  [Token(Token = "0x4000F13")]
  [FieldOffset(Offset = "0x70")]
  public UpgradeData upgradeData;
  [Header("Unlocks")]
  [Token(Token = "0x4000F14")]
  [FieldOffset(Offset = "0x78")]
  public MyAchievement AchievementRequirement;

  [Token(Token = "0x6000DF7")]
  [Address(RVA = "0x531050", Offset = "0x52FC50", Length = "0xDB")]
  public string GetUpgradeDescription(int level, List<StatModifier> upgradeOffer, ERarity rarity) => (string) null;

  [Token(Token = "0x6000DF8")]
  [Address(RVA = "0x530E00", Offset = "0x52FA00", Length = "0xFD")]
  public override string GetDescription() => (string) null;

  [Token(Token = "0x6000DF9")]
  [Address(RVA = "0x41E7E0", Offset = "0x41D3E0", Length = "0x5")]
  public override Texture GetIcon() => (Texture) null;

  [Token(Token = "0x6000DFA")]
  [Address(RVA = "0x3D1A90", Offset = "0x3D0690", Length = "0x5")]
  public override MyAchievement GetUnlockRequirement() => (MyAchievement) null;

  [Token(Token = "0x6000DFB")]
  [Address(RVA = "0x395320", Offset = "0x393F20", Length = "0x3")]
  public override UnlockableBase GetUnlockableRequirement() => (UnlockableBase) null;

  [Token(Token = "0x6000DFC")]
  [Address(RVA = "0x530FE0", Offset = "0x52FBE0", Length = "0x63")]
  public override string GetUnlockableTypeDisplayString() => (string) null;

  [Token(Token = "0x6000DFD")]
  [Address(RVA = "0x530F00", Offset = "0x52FB00", Length = "0x53")]
  public override string GetInternalName() => (string) null;

  [Token(Token = "0x6000DFE")]
  [Address(RVA = "0x530F60", Offset = "0x52FB60", Length = "0x65")]
  public int GetLevel() => 0;

  [Token(Token = "0x6000DFF")]
  [Address(RVA = "0x530FD0", Offset = "0x52FBD0", Length = "0x6")]
  public int GetMaxLevel() => 0;

  [Token(Token = "0x6000E00")]
  [Address(RVA = "0x531130", Offset = "0x52FD30", Length = "0x19E")]
  public List<StatModifier> GetUpgradeOffer(ERarity rarity) => (List<StatModifier>) null;

  [Token(Token = "0x6000E01")]
  [Address(RVA = "0x52ED50", Offset = "0x52D950", Length = "0x7")]
  public TomeData()
  {
  }
}
