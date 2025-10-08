// Decompiled with JetBrains decompiler
// Type: PlayerInventory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data;
using Assets.Scripts.Inventory__Items__Pickups;
using Assets.Scripts.Inventory__Items__Pickups.AbilitiesActives;
using Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive;
using Assets.Scripts.Inventory__Items__Pickups.Items;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Cpp2ILInjected;
using Inventory__Items__Pickups.Xp_and_Levels;
using System;
using System.Collections.Generic;

[Token(Token = "0x20000AF")]
public class PlayerInventory
{
  [Token(Token = "0x400057F")]
  [FieldOffset(Offset = "0x10")]
  public PlayerStatsNew playerStats;
  [Token(Token = "0x4000580")]
  [FieldOffset(Offset = "0x18")]
  public CharacterData characterData;
  [Token(Token = "0x4000581")]
  [FieldOffset(Offset = "0x20")]
  public ItemInventory itemInventory;
  [Token(Token = "0x4000582")]
  [FieldOffset(Offset = "0x28")]
  public WeaponInventory weaponInventory;
  [Token(Token = "0x4000583")]
  [FieldOffset(Offset = "0x30")]
  public PlayerXp playerXp;
  [Token(Token = "0x4000584")]
  [FieldOffset(Offset = "0x38")]
  public PlayerStatusEffects statusEffects;
  [Token(Token = "0x4000585")]
  [FieldOffset(Offset = "0x40")]
  public PlayerHealth playerHealth;
  [Token(Token = "0x4000586")]
  [FieldOffset(Offset = "0x48")]
  public TomeInventory tomeInventory;
  [Token(Token = "0x4000587")]
  [FieldOffset(Offset = "0x50")]
  public StatInventory statInventory;
  [Token(Token = "0x4000588")]
  [FieldOffset(Offset = "0x58")]
  public PassiveAbility passiveAbility;
  [Token(Token = "0x4000589")]
  [FieldOffset(Offset = "0x60")]
  public ActiveAbility activeAbility;
  [Token(Token = "0x400058B")]
  public static int maxGoldPerFrame;
  [Token(Token = "0x400058C")]
  public static int goldThisFrame;
  [Token(Token = "0x400058D")]
  [FieldOffset(Offset = "0x6C")]
  private bool hasHitGoldCap;
  [Token(Token = "0x400058F")]
  [FieldOffset(Offset = "0x74")]
  public int banishes;
  [Token(Token = "0x4000590")]
  [FieldOffset(Offset = "0x78")]
  public int refreshes;
  [Token(Token = "0x4000591")]
  [FieldOffset(Offset = "0x7C")]
  public int skips;
  [Token(Token = "0x4000592")]
  public static Action<PlayerInventory, int> A_GoldChange;
  [Token(Token = "0x4000593")]
  [FieldOffset(Offset = "0x80")]
  public bool pause;
  [Token(Token = "0x4000594")]
  [FieldOffset(Offset = "0x84")]
  public int skipsUsed;
  [Token(Token = "0x4000595")]
  [FieldOffset(Offset = "0x88")]
  public int refreshesUsed;
  [Token(Token = "0x4000596")]
  [FieldOffset(Offset = "0x8C")]
  public int banishesUsed;

  [field: Token(Token = "0x400058A")]
  [field: FieldOffset(Offset = "0x68")]
  [Token(Token = "0x17000028")]
  public float gold { [Token(Token = "0x600046D"), Address(RVA = "0x483DC0", Offset = "0x4829C0", Length = "0x6")] get; [Token(Token = "0x600046E"), Address(RVA = "0x483DE0", Offset = "0x4829E0", Length = "0x6")] private set; }

  [field: Token(Token = "0x400058E")]
  [field: FieldOffset(Offset = "0x70")]
  [Token(Token = "0x17000029")]
  public int goldInt { [Token(Token = "0x600046F"), Address(RVA = "0x483DB0", Offset = "0x4829B0", Length = "0x4")] get; [Token(Token = "0x6000470"), Address(RVA = "0x483DD0", Offset = "0x4829D0", Length = "0x4")] private set; }

  [Token(Token = "0x6000471")]
  [Address(RVA = "0x483AE0", Offset = "0x4826E0", Length = "0x2C4")]
  public PlayerInventory(CharacterData characterData, bool ignoreShopItems = false)
  {
  }

  [Token(Token = "0x6000472")]
  [Address(RVA = "0x483960", Offset = "0x482560", Length = "0xC1")]
  public void PhysicsTick()
  {
  }

  [Token(Token = "0x6000473")]
  [Address(RVA = "0x483A30", Offset = "0x482630", Length = "0x5C")]
  public void Update()
  {
  }

  [Token(Token = "0x6000474")]
  [Address(RVA = "0x4831A0", Offset = "0x481DA0", Length = "0x17A")]
  public void AddUpgrade(IUpgradable upgradable, List<StatModifier> upgradeOffer, ERarity rarity)
  {
  }

  [Token(Token = "0x6000475")]
  [Address(RVA = "0x483370", Offset = "0x481F70", Length = "0x246")]
  public void ChangeGold(int amount)
  {
  }

  [Token(Token = "0x6000476")]
  [Address(RVA = "0x483320", Offset = "0x481F20", Length = "0x46")]
  public void AddXp(int amount)
  {
  }

  [Token(Token = "0x6000477")]
  [Address(RVA = "0x4830D0", Offset = "0x481CD0", Length = "0xC3")]
  public void AddSilver(int amount)
  {
  }

  [Token(Token = "0x6000478")]
  [Address(RVA = "0x482FF0", Offset = "0x481BF0", Length = "0xD4")]
  public void AddLevel()
  {
  }

  [Token(Token = "0x6000479")]
  [Address(RVA = "0x483640", Offset = "0x482240", Length = "0x1A")]
  public int GetCharacterLevel() => 0;

  [Token(Token = "0x600047A")]
  [Address(RVA = "0x483660", Offset = "0x482260", Length = "0x34")]
  public bool HasPassive(EPassive passive) => false;

  [Token(Token = "0x600047B")]
  [Address(RVA = "0x4836A0", Offset = "0x4822A0", Length = "0x2B1")]
  private void InitSkipRefreshBanish()
  {
  }

  [Token(Token = "0x600047C")]
  [Address(RVA = "0x4835C0", Offset = "0x4821C0", Length = "0x7D")]
  public void Cleanup()
  {
  }

  [Token(Token = "0x600047D")]
  [Address(RVA = "0x483A90", Offset = "0x482690", Length = "0x4E")]
  static PlayerInventory()
  {
  }
}
