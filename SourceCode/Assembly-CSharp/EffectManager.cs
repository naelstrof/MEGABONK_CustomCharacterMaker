// Decompiled with JetBrains decompiler
// Type: EffectManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups;
using Assets.Scripts.Inventory__Items__Pickups.Items;
using Assets.Scripts.Inventory__Items__Pickups.Pickups;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Assets.Scripts.UI.InGame.Rewards;
using Cpp2ILInjected;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000D0")]
public class EffectManager : MonoBehaviour
{
  [Token(Token = "0x40006B8")]
  [FieldOffset(Offset = "0x20")]
  public GameObject nukePickup;
  [Token(Token = "0x40006B9")]
  [FieldOffset(Offset = "0x28")]
  public GameObject magnetPickup;
  [Token(Token = "0x40006BA")]
  [FieldOffset(Offset = "0x30")]
  public GameObject hastePickup;
  [Token(Token = "0x40006BB")]
  [FieldOffset(Offset = "0x38")]
  public GameObject ragePickup;
  [Token(Token = "0x40006BC")]
  [FieldOffset(Offset = "0x40")]
  public GameObject shieldPickup;
  [Token(Token = "0x40006BD")]
  [FieldOffset(Offset = "0x48")]
  public GameObject stonksPickup;
  [Token(Token = "0x40006BE")]
  [FieldOffset(Offset = "0x50")]
  public GameObject healthPickup;
  [Token(Token = "0x40006BF")]
  [FieldOffset(Offset = "0x58")]
  public GameObject playerDamage;
  [Token(Token = "0x40006C0")]
  [FieldOffset(Offset = "0x60")]
  public GameObject playerLandHard;
  [Token(Token = "0x40006C1")]
  [FieldOffset(Offset = "0x68")]
  public GameObject smokeHit;
  [Token(Token = "0x40006C2")]
  [FieldOffset(Offset = "0x70")]
  public GameObject goldSkeletonBreakEffect;
  [Token(Token = "0x40006C3")]
  [FieldOffset(Offset = "0x78")]
  public GameObject xpSkeletonBreakEffect;
  [Token(Token = "0x40006C4")]
  [FieldOffset(Offset = "0x80")]
  public GameObject pickupOrbFx;
  [Token(Token = "0x40006C5")]
  [FieldOffset(Offset = "0x88")]
  public GameObject chestPickup;
  [Token(Token = "0x40006C6")]
  [FieldOffset(Offset = "0x90")]
  public GameObject chestDiscard;
  [Token(Token = "0x40006C7")]
  [FieldOffset(Offset = "0x98")]
  public GameObject openChestNormal;
  [Token(Token = "0x40006C8")]
  [FieldOffset(Offset = "0xA0")]
  public GameObject wuiFreeChest;
  [Token(Token = "0x40006C9")]
  [FieldOffset(Offset = "0xA8")]
  public GameObject magnetFx;
  [Token(Token = "0x40006CA")]
  [FieldOffset(Offset = "0xB0")]
  public GameObject electricPlugFx;
  [Token(Token = "0x40006CB")]
  [FieldOffset(Offset = "0xB8")]
  public GameObject bananaQuest;
  [Token(Token = "0x40006CC")]
  [FieldOffset(Offset = "0xC0")]
  public GameObject luckTomeQuest;
  [Token(Token = "0x40006CD")]
  [FieldOffset(Offset = "0xC8")]
  public GameObject shotgunQuest;
  [Token(Token = "0x40006CE")]
  [FieldOffset(Offset = "0xD0")]
  public GameObject katanaQuest;
  [Token(Token = "0x40006CF")]
  [FieldOffset(Offset = "0xD8")]
  public GameObject campfire;
  [Token(Token = "0x40006D0")]
  [FieldOffset(Offset = "0xE0")]
  public GameObject banishFx;
  [Token(Token = "0x40006D1")]
  [FieldOffset(Offset = "0xE8")]
  public GameObject stealItemWui;
  [Token(Token = "0x40006D2")]
  [FieldOffset(Offset = "0xF0")]
  public GameObject giveItemWui;
  [Token(Token = "0x40006D3")]
  [FieldOffset(Offset = "0xF8")]
  public GameObject mirrorFx;
  [Token(Token = "0x40006D4")]
  [FieldOffset(Offset = "0x100")]
  public GameObject zapEffect;
  [Token(Token = "0x40006D5")]
  [FieldOffset(Offset = "0x108")]
  public GameObject desertStormFx;
  [Token(Token = "0x40006D6")]
  [FieldOffset(Offset = "0x110")]
  public GameObject tornado;
  [Token(Token = "0x40006D7")]
  [FieldOffset(Offset = "0x118")]
  public GameObject tumbleweed;
  [Token(Token = "0x40006D8")]
  [FieldOffset(Offset = "0x120")]
  public GameObject monkeCage;
  [Token(Token = "0x40006D9")]
  [FieldOffset(Offset = "0x128")]
  public GameObject monkeCageKey;
  [Token(Token = "0x40006DA")]
  [FieldOffset(Offset = "0x130")]
  public GameObject bushQuest;
  [Token(Token = "0x40006DB")]
  [FieldOffset(Offset = "0x138")]
  public GameObject banditQuest;
  [Token(Token = "0x40006DC")]
  [FieldOffset(Offset = "0x140")]
  public GameObject boomboxQuest;
  [Token(Token = "0x40006DD")]
  [FieldOffset(Offset = "0x148")]
  public GameObject blindSphere;
  [Token(Token = "0x40006DE")]
  [FieldOffset(Offset = "0x150")]
  public GameObject floorIsLava;
  [Token(Token = "0x40006DF")]
  [FieldOffset(Offset = "0x158")]
  public GameObject gloveLightning;
  [Token(Token = "0x40006E0")]
  [FieldOffset(Offset = "0x160")]
  public GameObject glovePoison;
  [Token(Token = "0x40006E1")]
  [FieldOffset(Offset = "0x168")]
  public GameObject gloveBlood;
  [Token(Token = "0x40006E2")]
  [FieldOffset(Offset = "0x170")]
  public GameObject gloveCurse;
  [Token(Token = "0x40006E3")]
  [FieldOffset(Offset = "0x178")]
  public GameObject glovePower;
  [Token(Token = "0x40006E4")]
  [FieldOffset(Offset = "0x180")]
  private List<EffectStat> effectStatsQueue;
  [Token(Token = "0x40006E5")]
  public static EffectManager Instance;
  [Token(Token = "0x40006E6")]
  [FieldOffset(Offset = "0x188")]
  private string critText;
  [Token(Token = "0x40006E7")]
  [FieldOffset(Offset = "0x190")]
  private string megaCritText;
  [Token(Token = "0x40006E8")]
  [FieldOffset(Offset = "0x198")]
  public HashSet<Enemy> currentlyExplodingEnemy;
  [Token(Token = "0x40006E9")]
  private static readonly Dictionary<EWeapon, string> weaponNamesCache;
  [Token(Token = "0x40006EA")]
  [FieldOffset(Offset = "0x1A0")]
  public GameObject americanExplosionEffect;
  [Token(Token = "0x40006EB")]
  [FieldOffset(Offset = "0x1A8")]
  public GameObject americanExplosionEffectStart;
  [Token(Token = "0x40006EC")]
  [FieldOffset(Offset = "0x1B0")]
  private float baseChestDropChance;
  [Token(Token = "0x40006ED")]
  [FieldOffset(Offset = "0x1B4")]
  private float lastChestAtTime;
  [Token(Token = "0x40006EE")]
  [FieldOffset(Offset = "0x1B8")]
  private EffectPlayer electricPlugEffect;
  [Token(Token = "0x40006EF")]
  [FieldOffset(Offset = "0x1C0")]
  private EffectPlayer activeMirrorFx;
  [Token(Token = "0x40006F0")]
  [FieldOffset(Offset = "0x1C8")]
  private EffectPlayer activeZapFx;
  [Token(Token = "0x40006F1")]
  [FieldOffset(Offset = "0x1D0")]
  private DesertStorm desertStorm;
  [Token(Token = "0x40006F2")]
  [FieldOffset(Offset = "0x1D8")]
  public GameObject spawnedLuckTomeObject;
  [Token(Token = "0x40006F3")]
  [FieldOffset(Offset = "0x1E0")]
  public GameObject spawnedShotgunObject;
  [Token(Token = "0x40006F4")]
  [FieldOffset(Offset = "0x1E8")]
  public GameObject spawnedKatanaObject;
  [Token(Token = "0x40006F5")]
  [FieldOffset(Offset = "0x1F0")]
  private Dictionary<GameObject, ItemProjectile> activeGhostProjectiles;
  [Token(Token = "0x40006F6")]
  [FieldOffset(Offset = "0x1F8")]
  private bool hasSpawnedFirstEliteChest;

  [Token(Token = "0x60005AE")]
  [Address(RVA = "0x493F10", Offset = "0x492B10", Length = "0x958")]
  private void Awake()
  {
  }

  [Token(Token = "0x60005AF")]
  [Address(RVA = "0x4992D0", Offset = "0x497ED0", Length = "0x17F")]
  public void PlayerLandHard()
  {
  }

  [Token(Token = "0x60005B0")]
  [Address(RVA = "0x4960A0", Offset = "0x494CA0", Length = "0x40A")]
  private void OnDamage(PlayerHealth ph, DamageContainer dc, bool shieldDamage)
  {
  }

  [Token(Token = "0x60005B1")]
  [Address(RVA = "0x495C70", Offset = "0x494870", Length = "0x42D")]
  public void NewDamageNumbers(DamageContainer dc, Enemy enemy)
  {
  }

  [Token(Token = "0x60005B2")]
  [Address(RVA = "0x499450", Offset = "0x498050", Length = "0x109")]
  public void PopupText(string text, Color color, Vector3 position, int textSize = 24)
  {
  }

  [Token(Token = "0x60005B3")]
  [Address(RVA = "0x499560", Offset = "0x498160", Length = "0x109")]
  public void PopupText(float damage, Color color, Vector3 position, int textSize = 24)
  {
  }

  [Token(Token = "0x60005B4")]
  [Address(RVA = "0x499150", Offset = "0x497D50", Length = "0x171")]
  public void PickupEffect()
  {
  }

  [Token(Token = "0x60005B5")]
  [Address(RVA = "0x4959E0", Offset = "0x4945E0", Length = "0x10C")]
  public void GoldBurstEffect(Vector3 position)
  {
  }

  [Token(Token = "0x60005B6")]
  [Address(RVA = "0x497310", Offset = "0x495F10", Length = "0x6D0")]
  private void OnEnemyDied(Enemy enemy, DamageContainer deathSource)
  {
  }

  [Token(Token = "0x60005B7")]
  [Address(RVA = "0x496D50", Offset = "0x495950", Length = "0x5B8")]
  private void OnEnemyDamage(Enemy enemy, DamageContainer dc)
  {
  }

  [Token(Token = "0x60005B8")]
  [Address(RVA = "0x4955E0", Offset = "0x4941E0", Length = "0x8E")]
  public void ExploderEnemy(Enemy enemy)
  {
  }

  [Token(Token = "0x60005B9")]
  [Address(RVA = "0x495550", Offset = "0x494150", Length = "0x84")]
  private IEnumerator ExploderDeath(Enemy enemy) => (IEnumerator) null;

  [Token(Token = "0x60005BA")]
  [Address(RVA = "0x4979F0", Offset = "0x4965F0", Length = "0x18E")]
  public void OnHeal(PlayerHealth ph, float value, bool isShield)
  {
  }

  [Token(Token = "0x60005BB")]
  [Address(RVA = "0x495170", Offset = "0x493D70", Length = "0x2C1")]
  public void EnemyHitEffect(
    Vector3 hitPos,
    Vector3 moveDir,
    bool hitEnemy,
    string source,
    GameObject weaponHitEffect,
    bool useSfx)
  {
  }

  [Token(Token = "0x60005BC")]
  [Address(RVA = "0x495440", Offset = "0x494040", Length = "0x10B")]
  public void EnemyHitEffect(
    Vector3 hitPos,
    Vector3 moveDir,
    bool hitEnemy,
    EWeapon eWeapon,
    GameObject weaponHitEffect,
    bool useSfx)
  {
  }

  [Token(Token = "0x60005BD")]
  [Address(RVA = "0x499EF0", Offset = "0x498AF0", Length = "0x14A")]
  public void SpawnPickupOrb(EPickup ePickup, Vector3 position)
  {
  }

  [Token(Token = "0x60005BE")]
  [Address(RVA = "0x49A7D0", Offset = "0x4993D0", Length = "0x181")]
  public CircleWarning WarningSphere(
    Vector3 position,
    float radius,
    float time,
    Action completeAction)
  {
    return (CircleWarning) null;
  }

  [Token(Token = "0x60005BF")]
  [Address(RVA = "0x49A960", Offset = "0x499560", Length = "0x1DB")]
  public bool WarningTube(
    Vector3 position,
    Vector3 dir,
    float radius,
    float distance,
    float time,
    Action completeAction)
  {
    return false;
  }

  [Token(Token = "0x60005C0")]
  [Address(RVA = "0x494A80", Offset = "0x493680", Length = "0x499")]
  private void CheckChestSpawn(Enemy enemy)
  {
  }

  [Token(Token = "0x60005C1")]
  [Address(RVA = "0x499670", Offset = "0x498270", Length = "0x20C")]
  public void SpawnChest(GameObject chestPrefab, Vector3 pos)
  {
  }

  [Token(Token = "0x60005C2")]
  [Address(RVA = "0x495670", Offset = "0x494270", Length = "0x11F")]
  private float GetChestDropChance(Enemy enemy) => 0.0f;

  [Token(Token = "0x60005C3")]
  [Address(RVA = "0x495790", Offset = "0x494390", Length = "0xA9")]
  private float GetChestDropTimeMultiplier() => 0.0f;

  [Token(Token = "0x60005C4")]
  [Address(RVA = "0x497E00", Offset = "0x496A00", Length = "0x282")]
  private void OnItemRemoved(EItem item, bool showEffect)
  {
  }

  [Token(Token = "0x60005C5")]
  [Address(RVA = "0x497B80", Offset = "0x496780", Length = "0x275")]
  private void OnItemAdded(EItem item)
  {
  }

  [Token(Token = "0x60005C6")]
  [Address(RVA = "0x494870", Offset = "0x493470", Length = "0x208")]
  public void BanishItem(UnlockableBase unlockable)
  {
  }

  [Token(Token = "0x60005C7")]
  [Address(RVA = "0x49A040", Offset = "0x498C40", Length = "0xA6")]
  public void SpawnRockets(int num, float damage, float procCoefficient, string damageSource)
  {
  }

  [Token(Token = "0x60005C8")]
  [Address(RVA = "0x494F20", Offset = "0x493B20", Length = "0x8F")]
  private IEnumerator DoSpawnRockets(
    int num,
    float damage,
    float procCoefficient,
    string damageSource)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x60005C9")]
  [Address(RVA = "0x495AF0", Offset = "0x4946F0", Length = "0x174")]
  public void MagnetEffect()
  {
  }

  [Token(Token = "0x60005CA")]
  [Address(RVA = "0x494FB0", Offset = "0x493BB0", Length = "0x1B4")]
  public void ElectricalPlugEffect()
  {
  }

  [Token(Token = "0x60005CB")]
  [Address(RVA = "0x499C40", Offset = "0x498840", Length = "0x2A5")]
  public void SpawnMirrorFx(Vector3 pos, Vector3 dir, float size)
  {
  }

  [Token(Token = "0x60005CC")]
  [Address(RVA = "0x49AB40", Offset = "0x499740", Length = "0x197")]
  public void ZapEffect(Vector3 pos)
  {
  }

  [Token(Token = "0x60005CD")]
  [Address(RVA = "0x495840", Offset = "0x494440", Length = "0xEA")]
  public DesertStorm GetDesertStorm() => (DesertStorm) null;

  [Token(Token = "0x60005CE")]
  [Address(RVA = "0x49A0F0", Offset = "0x498CF0", Length = "0x91")]
  public void SpawnTornadoes(int amount)
  {
  }

  [Token(Token = "0x60005CF")]
  [Address(RVA = "0x49A190", Offset = "0x498D90", Length = "0x1BA")]
  public void SpawnTumbleWeeds(int amount)
  {
  }

  [Token(Token = "0x60005D0")]
  [Address(RVA = "0x49A590", Offset = "0x499190", Length = "0x11E")]
  public void TrySpawnLuckQuest(Vector3 pos)
  {
  }

  [Token(Token = "0x60005D1")]
  [Address(RVA = "0x49A6B0", Offset = "0x4992B0", Length = "0x11E")]
  public void TrySpawnShotgunQuest(Vector3 pos)
  {
  }

  [Token(Token = "0x60005D2")]
  [Address(RVA = "0x49A470", Offset = "0x499070", Length = "0x11E")]
  public void TrySpawnKatanaQuest(Vector3 pos)
  {
  }

  [Token(Token = "0x60005D3")]
  [Address(RVA = "0x49A350", Offset = "0x498F50", Length = "0x118")]
  public void TakeItem(
    UnlockableBase data,
    Transform target,
    Vector3 targetOffset,
    float hoverTime = 1f,
    float moveTime = 1f,
    float scale = 1f)
  {
  }

  [Token(Token = "0x60005D4")]
  [Address(RVA = "0x495930", Offset = "0x494530", Length = "0xA5")]
  public void GiveItem(UnlockableBase data)
  {
  }

  [Token(Token = "0x60005D5")]
  [Address(RVA = "0x498090", Offset = "0x496C90", Length = "0xE72")]
  private void OnMapGenerationComplete()
  {
  }

  [Token(Token = "0x60005D6")]
  [Address(RVA = "0x499880", Offset = "0x498480", Length = "0x3B9")]
  public void SpawnGhostProjectile(float damage, float duration, string damageSource)
  {
  }

  [Token(Token = "0x60005D7")]
  [Address(RVA = "0x4964B0", Offset = "0x4950B0", Length = "0x891")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60005D8")]
  [Address(RVA = "0x498F10", Offset = "0x497B10", Length = "0x218")]
  private void OnPickup(Pickup pickup)
  {
  }

  [Token(Token = "0x60005D9")]
  [Address(RVA = "0x49AEA0", Offset = "0x499AA0", Length = "0x12D")]
  public EffectManager()
  {
  }

  [Token(Token = "0x60005DA")]
  [Address(RVA = "0x49ACE0", Offset = "0x4998E0", Length = "0x1BE")]
  static EffectManager()
  {
  }
}
