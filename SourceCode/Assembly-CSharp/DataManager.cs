// Decompiled with JetBrains decompiler
// Type: DataManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Assets.Scripts._Data.MapsAndStages;
using Assets.Scripts._Data.ShopItems;
using Assets.Scripts._Data.Tomes;
using Assets.Scripts.Audio.Music;
using Assets.Scripts.Inventory__Items__Pickups.Items;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Assets.Scripts.UI.InGame.Rewards;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000CF")]
public class DataManager : MonoBehaviour
{
  [Token(Token = "0x40006A1")]
  [FieldOffset(Offset = "0x20")]
  public List<ShopItemData> unsortedShopItems;
  [Token(Token = "0x40006A2")]
  [FieldOffset(Offset = "0x28")]
  public List<WeaponData> unsortedWeapons;
  [Token(Token = "0x40006A3")]
  [FieldOffset(Offset = "0x30")]
  public List<CharacterData> unsortedCharacterData;
  [Token(Token = "0x40006A4")]
  [FieldOffset(Offset = "0x38")]
  public List<TomeData> unsortedTomes;
  [Token(Token = "0x40006A5")]
  [FieldOffset(Offset = "0x40")]
  public List<MapData> maps;
  [Token(Token = "0x40006A6")]
  [FieldOffset(Offset = "0x48")]
  public List<EnemyData> unsortedEnemies;
  [Token(Token = "0x40006A7")]
  [FieldOffset(Offset = "0x50")]
  public List<EncounterData> unsortedEncounters;
  [Token(Token = "0x40006A8")]
  [FieldOffset(Offset = "0x58")]
  public List<MyAchievement> unsortedAchievements;
  [Token(Token = "0x40006A9")]
  [FieldOffset(Offset = "0x60")]
  public List<ItemData> unsortedItems;
  [Token(Token = "0x40006AA")]
  [FieldOffset(Offset = "0x68")]
  public List<UnlockableBase> unsortedUnlockables;
  [Token(Token = "0x40006AB")]
  [FieldOffset(Offset = "0x70")]
  public List<SkinData> unsortedSkins;
  [Token(Token = "0x40006AC")]
  [FieldOffset(Offset = "0x78")]
  public List<MusicTrack> unsortedMusic;
  [Token(Token = "0x40006AE")]
  [FieldOffset(Offset = "0x88")]
  private Dictionary<EWeapon, WeaponData> weapons;
  [Token(Token = "0x40006AF")]
  [FieldOffset(Offset = "0x90")]
  private Dictionary<ECharacter, CharacterData> characterData;
  [Token(Token = "0x40006B0")]
  [FieldOffset(Offset = "0x98")]
  private Dictionary<ETome, TomeData> tomeData;
  [Token(Token = "0x40006B1")]
  [FieldOffset(Offset = "0xA0")]
  private Dictionary<EEnemy, EnemyData> enemyData;
  [Token(Token = "0x40006B2")]
  [FieldOffset(Offset = "0xA8")]
  private Dictionary<EEncounter, EncounterData> encounterData;
  [Token(Token = "0x40006B3")]
  [FieldOffset(Offset = "0xB0")]
  private Dictionary<EItem, ItemData> itemData;
  [Token(Token = "0x40006B4")]
  [FieldOffset(Offset = "0xB8")]
  private Dictionary<string, MyAchievement> achievementsData;
  [Token(Token = "0x40006B5")]
  [FieldOffset(Offset = "0xC0")]
  private Dictionary<ECharacter, List<SkinData>> skinData;
  [Token(Token = "0x40006B6")]
  public static Action A_DataLoaded;
  [Token(Token = "0x40006B7")]
  public static DataManager Instance;

  [field: Token(Token = "0x40006AD")]
  [field: FieldOffset(Offset = "0x80")]
  [Token(Token = "0x1700002A")]
  public Dictionary<EShopItem, ShopItemData> shopItems { [Token(Token = "0x600059A"), Address(RVA = "0x37A270", Offset = "0x378E70", Length = "0x8")] get; }

  [Token(Token = "0x600059B")]
  [Address(RVA = "0x492C90", Offset = "0x491890", Length = "0xF80")]
  public void Load()
  {
  }

  [Token(Token = "0x600059C")]
  [Address(RVA = "0x492900", Offset = "0x491500", Length = "0x54")]
  public ShopItemData GetShopItemData(EShopItem item) => (ShopItemData) null;

  [Token(Token = "0x600059D")]
  [Address(RVA = "0x492C30", Offset = "0x491830", Length = "0x54")]
  public WeaponData GetWeapon(EWeapon weapon) => (WeaponData) null;

  [Token(Token = "0x600059E")]
  [Address(RVA = "0x4925B0", Offset = "0x4911B0", Length = "0x54")]
  public CharacterData GetCharacterData(ECharacter character) => (CharacterData) null;

  [Token(Token = "0x600059F")]
  [Address(RVA = "0x492BD0", Offset = "0x4917D0", Length = "0x54")]
  public TomeData GetTome(ETome eTome) => (TomeData) null;

  [Token(Token = "0x60005A0")]
  [Address(RVA = "0x4927C0", Offset = "0x4913C0", Length = "0x135")]
  public MapData GetMap(EMap map) => (MapData) null;

  [Token(Token = "0x60005A1")]
  [Address(RVA = "0x4924D0", Offset = "0x4910D0", Length = "0x62")]
  public List<TomeData> GetAllTomes() => (List<TomeData>) null;

  [Token(Token = "0x60005A2")]
  [Address(RVA = "0x492540", Offset = "0x491140", Length = "0x62")]
  public List<WeaponData> GetAllWeapons() => (List<WeaponData>) null;

  [Token(Token = "0x60005A3")]
  [Address(RVA = "0x4926D0", Offset = "0x4912D0", Length = "0x8B")]
  public EnemyData GetEnemyData(EEnemy eEnemy) => (EnemyData) null;

  [Token(Token = "0x60005A4")]
  [Address(RVA = "0x492670", Offset = "0x491270", Length = "0x54")]
  public EncounterData GetEncounter(EEncounter encounter) => (EncounterData) null;

  [Token(Token = "0x60005A5")]
  [Address(RVA = "0x492370", Offset = "0x490F70", Length = "0x8E")]
  public MyAchievement GetAchievement(string internalName) => (MyAchievement) null;

  [Token(Token = "0x60005A6")]
  [Address(RVA = "0x492760", Offset = "0x491360", Length = "0x54")]
  public ItemData GetItem(EItem item) => (ItemData) null;

  [Token(Token = "0x60005A7")]
  [Address(RVA = "0x492400", Offset = "0x491000", Length = "0xC3")]
  public List<UnlockableBase> GetAllPurchasable() => (List<UnlockableBase>) null;

  [Token(Token = "0x60005A8")]
  [Address(RVA = "0x492610", Offset = "0x491210", Length = "0x2C")]
  private string GetCharactersPath() => (string) null;

  [Token(Token = "0x60005A9")]
  [Address(RVA = "0x492BA0", Offset = "0x4917A0", Length = "0x2C")]
  private string GetTomePath() => (string) null;

  [Token(Token = "0x60005AA")]
  [Address(RVA = "0x492640", Offset = "0x491240", Length = "0x2C")]
  private string GetDataPath() => (string) null;

  [Token(Token = "0x60005AB")]
  [Address(RVA = "0x492B40", Offset = "0x491740", Length = "0x54")]
  public List<SkinData> GetSkins(ECharacter character) => (List<SkinData>) null;

  [Token(Token = "0x60005AC")]
  [Address(RVA = "0x492960", Offset = "0x491560", Length = "0x1D2")]
  public SkinData GetSkin(ECharacter character, int savedIndex) => (SkinData) null;

  [Token(Token = "0x60005AD")]
  [Address(RVA = "0x493C20", Offset = "0x492820", Length = "0x2E1")]
  public DataManager()
  {
  }
}
