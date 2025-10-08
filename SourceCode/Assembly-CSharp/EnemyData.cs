// Decompiled with JetBrains decompiler
// Type: EnemyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Assets.Scripts._Data.MapsAndStages;
using Assets.Scripts.Game.Combat.EnemySpecialAttacks;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(menuName = "Me/Enemy", order = 1)]
[Token(Token = "0x2000218")]
public class EnemyData : ScriptableObject
{
  [Header("Meta")]
  [Token(Token = "0x4000E93")]
  [FieldOffset(Offset = "0x18")]
  public EEnemy enemyName;
  [Token(Token = "0x4000E94")]
  [FieldOffset(Offset = "0x20")]
  public string displayName;
  [Token(Token = "0x4000E95")]
  [FieldOffset(Offset = "0x28")]
  public string description;
  [Header("Rendering")]
  [Token(Token = "0x4000E96")]
  [FieldOffset(Offset = "0x30")]
  public Material material;
  [Token(Token = "0x4000E97")]
  [FieldOffset(Offset = "0x38")]
  public AnimatedMeshScriptableObject animation;
  [Token(Token = "0x4000E98")]
  [FieldOffset(Offset = "0x40")]
  public Vector3 rendererOffset;
  [Token(Token = "0x4000E99")]
  [FieldOffset(Offset = "0x4C")]
  public Vector3 rendererRotationOffset;
  [Token(Token = "0x4000E9A")]
  [FieldOffset(Offset = "0x58")]
  public float rendererScale;
  [Token(Token = "0x4000E9B")]
  [FieldOffset(Offset = "0x5C")]
  public float colliderRadius;
  [Token(Token = "0x4000E9C")]
  [FieldOffset(Offset = "0x60")]
  public float overrideHeight;
  [Token(Token = "0x4000E9D")]
  [FieldOffset(Offset = "0x64")]
  public Vector3 colliderCenter;
  [Header("Stats")]
  [Token(Token = "0x4000E9E")]
  [FieldOffset(Offset = "0x70")]
  public int hp;
  [Token(Token = "0x4000E9F")]
  [FieldOffset(Offset = "0x74")]
  public int damage;
  [Token(Token = "0x4000EA0")]
  [FieldOffset(Offset = "0x78")]
  public int shield;
  [Token(Token = "0x4000EA1")]
  [FieldOffset(Offset = "0x7C")]
  public bool isPoison;
  [Token(Token = "0x4000EA2")]
  [FieldOffset(Offset = "0x80")]
  public float knockbackResistance;
  [Token(Token = "0x4000EA3")]
  [FieldOffset(Offset = "0x84")]
  public bool nukeProtection;
  [Header("Movement")]
  [Token(Token = "0x4000EA4")]
  [FieldOffset(Offset = "0x88")]
  public float mass;
  [Token(Token = "0x4000EA5")]
  [FieldOffset(Offset = "0x8C")]
  public float speed;
  [Token(Token = "0x4000EA6")]
  [FieldOffset(Offset = "0x90")]
  public bool isFlying;
  [Token(Token = "0x4000EA7")]
  [FieldOffset(Offset = "0x94")]
  public float teleportCooldown;
  [Token(Token = "0x4000EA8")]
  [FieldOffset(Offset = "0x98")]
  public bool isRunningFromPlayer;
  [Token(Token = "0x4000EA9")]
  [FieldOffset(Offset = "0x9C")]
  public float minStayAtDistance;
  [Token(Token = "0x4000EAA")]
  [FieldOffset(Offset = "0xA0")]
  public float maxStayAtDistance;
  [Header("Other")]
  [Token(Token = "0x4000EAB")]
  [FieldOffset(Offset = "0xA4")]
  public int xp;
  [Token(Token = "0x4000EAC")]
  [FieldOffset(Offset = "0xA8")]
  public float despawnTime;
  [Token(Token = "0x4000EAD")]
  [FieldOffset(Offset = "0xAC")]
  public bool canBeElite;
  [Header("Special Attacks")]
  [Token(Token = "0x4000EAE")]
  [FieldOffset(Offset = "0xB0")]
  public EnemySpecialAttack[] specialAttacks;
  [Header("Spawning")]
  [Token(Token = "0x4000EAF")]
  [FieldOffset(Offset = "0xB8")]
  public EMap maps;
  [Token(Token = "0x4000EB0")]
  [FieldOffset(Offset = "0xBC")]
  public int minStage;
  [Token(Token = "0x4000EB1")]
  [FieldOffset(Offset = "0xC0")]
  public float creditCost;
  [Token(Token = "0x4000EB2")]
  [FieldOffset(Offset = "0xC4")]
  public float canSpawnAfterTime;
  [Token(Token = "0x4000EB3")]
  [FieldOffset(Offset = "0xC8")]
  public LocalizedString forceName;

  [Token(Token = "0x6000D93")]
  [Address(RVA = "0x521320", Offset = "0x51FF20", Length = "0x4C")]
  public string GetName() => (string) null;

  [Token(Token = "0x6000D94")]
  [Address(RVA = "0x430D40", Offset = "0x42F940", Length = "0x6")]
  public int GetGold() => 0;

  [Token(Token = "0x6000D95")]
  [Address(RVA = "0x521370", Offset = "0x51FF70", Length = "0x7")]
  public int GetXp() => 0;

  [Token(Token = "0x6000D96")]
  [Address(RVA = "0x521250", Offset = "0x51FE50", Length = "0xB7")]
  public int GetEliteXp() => 0;

  [Token(Token = "0x6000D97")]
  [Address(RVA = "0x521310", Offset = "0x51FF10", Length = "0x9")]
  public float GetKnockback() => 0.0f;

  [Token(Token = "0x6000D98")]
  [Address(RVA = "0x521240", Offset = "0x51FE40", Length = "0x9")]
  public float GetDamage() => 0.0f;

  [Token(Token = "0x6000D99")]
  [Address(RVA = "0x521380", Offset = "0x51FF80", Length = "0xDD")]
  public EnemyData()
  {
  }
}
