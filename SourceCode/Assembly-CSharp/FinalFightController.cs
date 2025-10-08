// Decompiled with JetBrains decompiler
// Type: FinalFightController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x2000070")]
public class FinalFightController : MonoBehaviour
{
  [Token(Token = "0x400036A")]
  [FieldOffset(Offset = "0x20")]
  public Transform bossSpawnPoint;
  [Token(Token = "0x400036B")]
  [FieldOffset(Offset = "0x28")]
  public Enemy boss;
  [Token(Token = "0x400036C")]
  [FieldOffset(Offset = "0x30")]
  public BossPylon[] pylons;
  [Token(Token = "0x400036D")]
  [FieldOffset(Offset = "0x38")]
  private List<BossPylon> activePylons;
  [Token(Token = "0x400036E")]
  [FieldOffset(Offset = "0x40")]
  public GameObject orbFollowing;
  [Token(Token = "0x400036F")]
  [FieldOffset(Offset = "0x48")]
  public GameObject orbShooty;
  [Token(Token = "0x4000370")]
  [FieldOffset(Offset = "0x50")]
  public GameObject orbBleed;
  [Token(Token = "0x4000371")]
  [FieldOffset(Offset = "0x58")]
  public GameObject stealWeaponWui;
  [Token(Token = "0x4000372")]
  [FieldOffset(Offset = "0x60")]
  public AudioSource audioPylonsSpawn;
  [Token(Token = "0x4000373")]
  public static Action<bool> A_BossDefeated;
  [Token(Token = "0x4000374")]
  public static bool isFightingFinalBoss;
  [Token(Token = "0x4000375")]
  [FieldOffset(Offset = "0x68")]
  private int numWeaponsToTake;
  [Token(Token = "0x4000376")]
  [FieldOffset(Offset = "0x6C")]
  private int numWeaponsTaken;
  [Token(Token = "0x4000377")]
  [FieldOffset(Offset = "0x70")]
  private float takeWeaponAtTime;
  [Token(Token = "0x4000378")]
  [FieldOffset(Offset = "0x74")]
  private float weaponTakeInterval;
  [Token(Token = "0x4000379")]
  [FieldOffset(Offset = "0x78")]
  private float healInterval;
  [Token(Token = "0x400037A")]
  [FieldOffset(Offset = "0x7C")]
  private float nextHealTime;
  [Token(Token = "0x400037B")]
  [FieldOffset(Offset = "0x80")]
  private float bossDeadGracePeriod;
  [Token(Token = "0x400037D")]
  [FieldOffset(Offset = "0x88")]
  private float nextOrbsFollowingTime;
  [Token(Token = "0x400037E")]
  [FieldOffset(Offset = "0x8C")]
  private float nextOrbsShootyTime;
  [Token(Token = "0x400037F")]
  [FieldOffset(Offset = "0x90")]
  private float nextOrbsBleedTime;
  [Token(Token = "0x4000380")]
  [FieldOffset(Offset = "0x94")]
  private float lastSpecialAttackTime;
  [Token(Token = "0x4000381")]
  [FieldOffset(Offset = "0x98")]
  private float goonsDeadAtTime;
  [Token(Token = "0x4000382")]
  [FieldOffset(Offset = "0x9C")]
  private float goonSpawnInterval;
  [Token(Token = "0x4000383")]
  [FieldOffset(Offset = "0xA0")]
  private List<Enemy> goons;
  [Token(Token = "0x4000384")]
  public static Action A_PylonsStarted;

  [Token(Token = "0x17000014")]
  public bool isBossDefeated
  {
    [Token(Token = "0x60002CC"), Address(RVA = "0x466F00", Offset = "0x465B00", Length = "0x50")] get => false;
  }

  [Token(Token = "0x60002CD")]
  [Address(RVA = "0x463A80", Offset = "0x462680", Length = "0x469")]
  private void Awake()
  {
  }

  [Token(Token = "0x60002CE")]
  [Address(RVA = "0x464510", Offset = "0x463110", Length = "0x469")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60002CF")]
  [Address(RVA = "0x465610", Offset = "0x464210", Length = "0x359")]
  public void SpawnBoss()
  {
  }

  [Token(Token = "0x60002D0")]
  [Address(RVA = "0x463EF0", Offset = "0x462AF0", Length = "0x265")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x60002D1")]
  [Address(RVA = "0x466D60", Offset = "0x465960", Length = "0x99")]
  private void TakeWeapons()
  {
  }

  [Token(Token = "0x60002D2")]
  [Address(RVA = "0x464AC0", Offset = "0x4636C0", Length = "0x71D")]
  private void OnEnemyReleasedFromPool(Enemy enemy)
  {
  }

  [Token(Token = "0x60002D3")]
  [Address(RVA = "0x4651E0", Offset = "0x463DE0", Length = "0x1EE")]
  private void OnPlayerDied()
  {
  }

  [field: Token(Token = "0x400037C")]
  [field: FieldOffset(Offset = "0x84")]
  [Token(Token = "0x17000015")]
  public int currentPhase { [Token(Token = "0x60002D4"), Address(RVA = "0x466EF0", Offset = "0x465AF0", Length = "0x7")] get; [Token(Token = "0x60002D5"), Address(RVA = "0x466F50", Offset = "0x465B50", Length = "0x7")] private set; }

  [Token(Token = "0x60002D6")]
  [Address(RVA = "0x466650", Offset = "0x465250", Length = "0xD")]
  private void StartPhase(int phase)
  {
  }

  [Token(Token = "0x60002D7")]
  [Address(RVA = "0x466A20", Offset = "0x465620", Length = "0x335")]
  public void TakeWeapon()
  {
  }

  [Token(Token = "0x60002D8")]
  [Address(RVA = "0x464180", Offset = "0x462D80", Length = "0x20E")]
  private void GiveWeaponBack()
  {
  }

  [Token(Token = "0x60002D9")]
  [Address(RVA = "0x466380", Offset = "0x464F80", Length = "0x2CF")]
  private void SpecialAttacks()
  {
  }

  [Token(Token = "0x60002DA")]
  [Address(RVA = "0x465E80", Offset = "0x464A80", Length = "0x29A")]
  private void SpawnOrbsFollowing()
  {
  }

  [Token(Token = "0x60002DB")]
  [Address(RVA = "0x466120", Offset = "0x464D20", Length = "0x25D")]
  private void SpawnOrbsShooty()
  {
  }

  [Token(Token = "0x60002DC")]
  [Address(RVA = "0x465C00", Offset = "0x464800", Length = "0x270")]
  private void SpawnOrbsBleed()
  {
  }

  [Token(Token = "0x60002DD")]
  [Address(RVA = "0x464160", Offset = "0x462D60", Length = "0x13")]
  private int GetNumOrbs() => 0;

  [Token(Token = "0x60002DE")]
  [Address(RVA = "0x464390", Offset = "0x462F90", Length = "0x17D")]
  private void IgnoreCollisions(List<GameObject> orbs)
  {
  }

  [Token(Token = "0x60002DF")]
  [Address(RVA = "0x465970", Offset = "0x464570", Length = "0x283")]
  private void SpawnGoons()
  {
  }

  [Token(Token = "0x60002E0")]
  [Address(RVA = "0x463A00", Offset = "0x462600", Length = "0x73")]
  private bool ArePylonsActive() => false;

  [Token(Token = "0x60002E1")]
  [Address(RVA = "0x4653D0", Offset = "0x463FD0", Length = "0x8C")]
  private void OnPylonCharged(BossPylon pylon)
  {
  }

  [Token(Token = "0x60002E2")]
  [Address(RVA = "0x4655D0", Offset = "0x4641D0", Length = "0x30")]
  private void PylonsDone()
  {
  }

  [Token(Token = "0x60002E3")]
  [Address(RVA = "0x466660", Offset = "0x465260", Length = "0x3B4")]
  private void StartPylons()
  {
  }

  [Token(Token = "0x60002E4")]
  [Address(RVA = "0x465460", Offset = "0x464060", Length = "0x168")]
  private void PylonHealing()
  {
  }

  [Token(Token = "0x60002E5")]
  [Address(RVA = "0x464980", Offset = "0x463580", Length = "0x132")]
  private void OnEnemyDamage(Enemy enemy, DamageContainer dc)
  {
  }

  [Token(Token = "0x60002E6")]
  [Address(RVA = "0x466E00", Offset = "0x465A00", Length = "0xE5")]
  public FinalFightController()
  {
  }
}
