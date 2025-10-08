// Decompiled with JetBrains decompiler
// Type: CharacterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Audio.Music;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Me/Character", order = 1)]
[Token(Token = "0x2000217")]
public class CharacterData : UnlockableBase
{
  [Header("Meta")]
  [Token(Token = "0x4000E81")]
  [FieldOffset(Offset = "0x50")]
  public ECharacter eCharacter;
  [TextArea]
  [Token(Token = "0x4000E82")]
  [FieldOffset(Offset = "0x58")]
  public string description;
  [Token(Token = "0x4000E83")]
  [FieldOffset(Offset = "0x60")]
  public Texture icon;
  [Header("Stats")]
  [Token(Token = "0x4000E84")]
  [FieldOffset(Offset = "0x68")]
  public List<StatModifier> statModifiers;
  [Range(1f, 10f)]
  [Token(Token = "0x4000E85")]
  [FieldOffset(Offset = "0x70")]
  public int coolness;
  [Range(1f, 10f)]
  [Token(Token = "0x4000E86")]
  [FieldOffset(Offset = "0x74")]
  public int difficulty;
  [Header("Other")]
  [Token(Token = "0x4000E87")]
  [FieldOffset(Offset = "0x78")]
  public GameObject prefab;
  [Token(Token = "0x4000E88")]
  [FieldOffset(Offset = "0x80")]
  public AudioClip[] audioFootsteps;
  [Token(Token = "0x4000E89")]
  [FieldOffset(Offset = "0x88")]
  public MusicTrack themeSong;
  [Header("Data")]
  [Token(Token = "0x4000E8A")]
  [FieldOffset(Offset = "0x90")]
  public WeaponData weapon;
  [Token(Token = "0x4000E8B")]
  [FieldOffset(Offset = "0x98")]
  public PassiveData passive;
  [Token(Token = "0x4000E8C")]
  [FieldOffset(Offset = "0xA0")]
  public float colliderHeight;
  [Token(Token = "0x4000E8D")]
  [FieldOffset(Offset = "0xA4")]
  public float colliderWidth;
  [Token(Token = "0x4000E8E")]
  [FieldOffset(Offset = "0xA8")]
  public Dictionary<EStatCategory, float> categoryScores;
  [Token(Token = "0x4000E8F")]
  [FieldOffset(Offset = "0xB0")]
  public Dictionary<EStatCategory, float> categoryRatios;
  [Token(Token = "0x4000E90")]
  [FieldOffset(Offset = "0xB8")]
  public List<StatCategoryRatio> StatCategoryRatios;
  [Header("Unlocks")]
  [Token(Token = "0x4000E91")]
  [FieldOffset(Offset = "0xC0")]
  public MyAchievement achievementRequirement;
  [Token(Token = "0x4000E92")]
  [FieldOffset(Offset = "0xC8")]
  public int numQuestsRequiredForVisibilityInCharacterSelection;

  [Token(Token = "0x6000D8A")]
  [Address(RVA = "0x51EDE0", Offset = "0x51D9E0", Length = "0x1FA")]
  public void Init()
  {
  }

  [Token(Token = "0x6000D8B")]
  [Address(RVA = "0x3992F0", Offset = "0x397EF0", Length = "0x5")]
  public override Texture GetIcon() => (Texture) null;

  [Token(Token = "0x6000D8C")]
  [Address(RVA = "0x37A3D0", Offset = "0x378FD0", Length = "0x8")]
  public override MyAchievement GetUnlockRequirement() => (MyAchievement) null;

  [Token(Token = "0x6000D8D")]
  [Address(RVA = "0x51EFE0", Offset = "0x51DBE0", Length = "0x103")]
  public bool IsBlackedOutInCharacterSelectionScreen() => false;

  [Token(Token = "0x6000D8E")]
  [Address(RVA = "0x51ECD0", Offset = "0x51D8D0", Length = "0x91")]
  public override UnlockableBase GetUnlockableRequirement() => (UnlockableBase) null;

  [Token(Token = "0x6000D8F")]
  [Address(RVA = "0x51ED70", Offset = "0x51D970", Length = "0x63")]
  public override string GetUnlockableTypeDisplayString() => (string) null;

  [Token(Token = "0x6000D90")]
  [Address(RVA = "0x51EC70", Offset = "0x51D870", Length = "0x53")]
  public override string GetInternalName() => (string) null;

  [Token(Token = "0x6000D91")]
  [Address(RVA = "0x51EBC0", Offset = "0x51D7C0", Length = "0xAF")]
  public int GetDisplayRank() => 0;

  [Token(Token = "0x6000D92")]
  [Address(RVA = "0x51F0F0", Offset = "0x51DCF0", Length = "0x63")]
  public CharacterData()
  {
  }
}
