// Decompiled with JetBrains decompiler
// Type: ChallengeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.MapsAndStages;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "Me/Progression/Challenge", order = 1)]
[Token(Token = "0x200021D")]
public class ChallengeData : MyAchievement
{
  [Header("Challenge")]
  [Token(Token = "0x4000EF4")]
  [FieldOffset(Offset = "0x80")]
  public EMap map;
  [Token(Token = "0x4000EF5")]
  [FieldOffset(Offset = "0x84")]
  public int tier;
  [Token(Token = "0x4000EF6")]
  [FieldOffset(Offset = "0x88")]
  public float silverMultiplier;
  [Token(Token = "0x4000EF7")]
  [FieldOffset(Offset = "0x90")]
  public string suggestionAuthor;
  [Token(Token = "0x4000EF8")]
  [FieldOffset(Offset = "0x98")]
  public int requiresNumChallengesCompleted;
  [Token(Token = "0x4000EF9")]
  [FieldOffset(Offset = "0xA0")]
  public ChallengeModifier[] challengeModifiers;
  [Token(Token = "0x4000EFA")]
  [FieldOffset(Offset = "0xA8")]
  public ChallengeWinCondition winCondition;

  [Token(Token = "0x6000DB7")]
  [Address(RVA = "0x51D6F0", Offset = "0x51C2F0", Length = "0xEA")]
  public override string GetDisplayName() => (string) null;

  [Token(Token = "0x6000DB8")]
  [Address(RVA = "0x51D7F0", Offset = "0x51C3F0", Length = "0x2EB")]
  public override string GetUnlockRequirement() => (string) null;

  [Token(Token = "0x6000DB9")]
  [Address(RVA = "0x51D4B0", Offset = "0x51C0B0", Length = "0x98")]
  public bool CanShow() => false;

  [Token(Token = "0x6000DBA")]
  [Address(RVA = "0x51D7E0", Offset = "0x51C3E0", Length = "0xF")]
  public string GetSilverMultiplier() => (string) null;

  [Token(Token = "0x6000DBB")]
  [Address(RVA = "0x51D550", Offset = "0x51C150", Length = "0x19F")]
  public override int CompareTo(MyAchievement otherAch) => 0;

  [Token(Token = "0x6000DBC")]
  [Address(RVA = "0x51DAE0", Offset = "0x51C6E0", Length = "0x11")]
  public ChallengeData()
  {
  }
}
