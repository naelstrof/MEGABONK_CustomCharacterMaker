// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Actors.Enemies.Enemy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Assets.Scripts.Game.Combat.EnemyDebuffs;
using Assets.Scripts.Game.Combat.EnemySpecialAttacks;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Actors.Enemies
{
  [Token(Token = "0x2000454")]
  public class Enemy : MonoBehaviour
  {
    [Token(Token = "0x4001C34")]
    [FieldOffset(Offset = "0x28")]
    public AnimatedMesh animatedMesh;
    [Token(Token = "0x4001C35")]
    [FieldOffset(Offset = "0x30")]
    public Renderer renderer;
    [Token(Token = "0x4001C36")]
    [FieldOffset(Offset = "0x38")]
    public EnemyRenderer enemyRenderer;
    [Token(Token = "0x4001C39")]
    [FieldOffset(Offset = "0x48")]
    public Rigidbody rb;
    [Token(Token = "0x4001C3A")]
    [FieldOffset(Offset = "0x50")]
    public CapsuleCollider collider;
    [Token(Token = "0x4001C3B")]
    [FieldOffset(Offset = "0x58")]
    public EnemyMovementRb enemyMovement;
    [Token(Token = "0x4001C3C")]
    [FieldOffset(Offset = "0x60")]
    public Material whiteMaterial;
    [Token(Token = "0x4001C3D")]
    [FieldOffset(Offset = "0x68")]
    public EnemyDissolve dissolve;
    [Token(Token = "0x4001C3E")]
    [FieldOffset(Offset = "0x70")]
    private float flashTime;
    [Token(Token = "0x4001C41")]
    [FieldOffset(Offset = "0x84")]
    public float maxHp;
    [Token(Token = "0x4001C45")]
    [FieldOffset(Offset = "0x98")]
    private float despawnAtTime;
    [Token(Token = "0x4001C47")]
    [FieldOffset(Offset = "0xA0")]
    public EEnemyState state;
    [Token(Token = "0x4001C48")]
    [FieldOffset(Offset = "0xA4")]
    private float eliteScaleMultiplier;
    [Token(Token = "0x4001C49")]
    [FieldOffset(Offset = "0xA8")]
    private SpecialAttackController specialAttackController;
    [Token(Token = "0x4001C4A")]
    public static int deaths;
    [Token(Token = "0x4001C4B")]
    public static Action<Enemy, DamageContainer> A_EnemyDied;
    [Token(Token = "0x4001C4C")]
    public static Action<Enemy> A_EnemyDiedPre;
    [Token(Token = "0x4001C4D")]
    public static Action<Enemy> A_EnemySpawned;
    [Token(Token = "0x4001C4E")]
    public static Action<Enemy> A_EnemyReleasedFromPool;
    [Token(Token = "0x4001C4F")]
    public static Action<Enemy> A_TargetOfInterestSpawn;
    [Token(Token = "0x4001C50")]
    public static Action<Enemy, DamageContainer> A_Damage;
    [Token(Token = "0x4001C51")]
    [FieldOffset(Offset = "0xB0")]
    public Action<Enemy, DamageContainer> A_DamageNonStatic;
    [Token(Token = "0x4001C52")]
    public static Action<Enemy> A_HealthChange;
    [Token(Token = "0x4001C53")]
    [FieldOffset(Offset = "0xB8")]
    private float controlHp;
    [Token(Token = "0x4001C54")]
    [FieldOffset(Offset = "0xBC")]
    private EEnemyFlag enemyFlag;
    [Token(Token = "0x4001C55")]
    [FieldOffset(Offset = "0xC0")]
    private float maxDespawnTime;
    [Token(Token = "0x4001C56")]
    [FieldOffset(Offset = "0xC4")]
    private float speedMultiplier;
    [Token(Token = "0x4001C57")]
    [FieldOffset(Offset = "0xC8")]
    private EnemyStatusSymbols statusSymbols;
    [Token(Token = "0x4001C58")]
    [FieldOffset(Offset = "0xD0")]
    private EEnemyFlag eliteChallengeFlags;
    [Token(Token = "0x4001C59")]
    [FieldOffset(Offset = "0xD4")]
    private Vector3 defaultScale;
    [Token(Token = "0x4001C5A")]
    [FieldOffset(Offset = "0xE0")]
    private Outline outline;
    [Token(Token = "0x4001C5B")]
    [FieldOffset(Offset = "0xE8")]
    public float teleportTime;
    [Token(Token = "0x4001C5C")]
    public static float defaultTeleportTime;
    [Token(Token = "0x4001C5D")]
    public static Action A_HpTamper;
    [Token(Token = "0x4001C5E")]
    [FieldOffset(Offset = "0xEC")]
    private float echoDamage;
    [Token(Token = "0x4001C5F")]
    [FieldOffset(Offset = "0xF0")]
    private float stopFlashTime;
    [Token(Token = "0x4001C60")]
    [FieldOffset(Offset = "0xF4")]
    private float readyToFlashTime;
    [Token(Token = "0x4001C61")]
    [FieldOffset(Offset = "0xF8")]
    public float flashInterval;
    [Token(Token = "0x4001C62")]
    [FieldOffset(Offset = "0xFC")]
    private bool flashing;
    [Token(Token = "0x4001C63")]
    [FieldOffset(Offset = "0xFD")]
    private bool isInvulnerable;
    [Token(Token = "0x4001C64")]
    public static Action<Enemy, bool> A_InvulnerableChanged;
    [Token(Token = "0x4001C65")]
    [FieldOffset(Offset = "0xFE")]
    private bool isDyingNextFrame;
    [Token(Token = "0x4001C66")]
    [FieldOffset(Offset = "0xFF")]
    private bool deathFunctionCalled;
    [Token(Token = "0x4001C67")]
    [FieldOffset(Offset = "0x100")]
    private float startTeleportThresholdDistance;
    [Token(Token = "0x4001C68")]
    [FieldOffset(Offset = "0x104")]
    private float lastTeleportTime;
    [Token(Token = "0x4001C69")]
    [FieldOffset(Offset = "0x108")]
    public Dictionary<EDebuff, EnemyDebuff> debuffs;
    [Token(Token = "0x4001C6A")]
    [FieldOffset(Offset = "0x110")]
    public HashSet<EDebuff> debuffsToRemove;
    [Token(Token = "0x4001C6B")]
    [FieldOffset(Offset = "0x118")]
    private Dictionary<EDebuff, AddDebuffContainer> debuffsToAdd;
    [Token(Token = "0x4001C6C")]
    [FieldOffset(Offset = "0x120")]
    public Action<EDebuff> A_DebuffAdded;
    [Token(Token = "0x4001C6D")]
    [FieldOffset(Offset = "0x128")]
    public Action<EDebuff> A_DebuffRemoved;
    [Token(Token = "0x4001C6E")]
    [FieldOffset(Offset = "0x130")]
    private Dictionary<EDebuff, int> debuffCounts;
    [Token(Token = "0x4001C6F")]
    [FieldOffset(Offset = "0x138")]
    private int maxStunsAndFreezes;
    [Token(Token = "0x4001C70")]
    [FieldOffset(Offset = "0x13C")]
    private float nextVerifyTime;
    [Token(Token = "0x4001C71")]
    [FieldOffset(Offset = "0x140")]
    private float nextTeleportTimeCheck;
    [Token(Token = "0x4001C72")]
    [FieldOffset(Offset = "0x144")]
    private float teleportCheckInterval;
    [Token(Token = "0x4001C73")]
    [FieldOffset(Offset = "0x148")]
    private float minStayAtDistance;
    [Token(Token = "0x4001C74")]
    [FieldOffset(Offset = "0x14C")]
    private float maxStayAtDistance;
    [Token(Token = "0x4001C75")]
    [FieldOffset(Offset = "0x150")]
    private bool allowSpecialAttacks;
    [Token(Token = "0x4001C76")]
    [FieldOffset(Offset = "0x154")]
    private float basePowerupDropChance;

    [field: Token(Token = "0x4001C33")]
    [field: FieldOffset(Offset = "0x20")]
    [Token(Token = "0x17000399")]
    public EnemyData enemyData { [Token(Token = "0x6001EE8"), Address(RVA = "0x36C790", Offset = "0x36B390", Length = "0x5")] get; [Token(Token = "0x6001EE9"), Address(RVA = "0x359A30", Offset = "0x358630", Length = "0xD")] private set; }

    [field: Token(Token = "0x4001C37")]
    [field: FieldOffset(Offset = "0x40")]
    [Token(Token = "0x1700039A")]
    public float meshHeight { [Token(Token = "0x6001EEA"), Address(RVA = "0x444F40", Offset = "0x443B40", Length = "0x6")] get; [Token(Token = "0x6001EEB"), Address(RVA = "0x448A20", Offset = "0x447620", Length = "0x6")] private set; }

    [field: Token(Token = "0x4001C38")]
    [field: FieldOffset(Offset = "0x44")]
    [Token(Token = "0x1700039B")]
    public float meshRadius { [Token(Token = "0x6001EEC"), Address(RVA = "0x4489D0", Offset = "0x4475D0", Length = "0x6")] get; [Token(Token = "0x6001EED"), Address(RVA = "0x448A30", Offset = "0x447630", Length = "0x6")] private set; }

    [field: Token(Token = "0x4001C3F")]
    [field: FieldOffset(Offset = "0x74")]
    [Token(Token = "0x1700039C")]
    public Vector3 feetOffset { [Token(Token = "0x6001EEE"), Address(RVA = "0x4489A0", Offset = "0x4475A0", Length = "0x13")] get; [Token(Token = "0x6001EEF"), Address(RVA = "0x448A00", Offset = "0x447600", Length = "0x10")] private set; }

    [field: Token(Token = "0x4001C40")]
    [field: FieldOffset(Offset = "0x80")]
    [Token(Token = "0x1700039D")]
    public float hp { [Token(Token = "0x6001EF0"), Address(RVA = "0x4489C0", Offset = "0x4475C0", Length = "0x9")] get; [Token(Token = "0x6001EF1"), Address(RVA = "0x448A10", Offset = "0x447610", Length = "0x9")] set; }

    [field: Token(Token = "0x4001C42")]
    [field: FieldOffset(Offset = "0x88")]
    [Token(Token = "0x1700039E")]
    public uint id { [Token(Token = "0x6001EF2"), Address(RVA = "0x399690", Offset = "0x398290", Length = "0x7")] get; [Token(Token = "0x6001EF3"), Address(RVA = "0x399820", Offset = "0x398420", Length = "0x7")] private set; }

    [field: Token(Token = "0x4001C43")]
    [field: FieldOffset(Offset = "0x8C")]
    [Token(Token = "0x1700039F")]
    public int waveNumber { [Token(Token = "0x6001EF4"), Address(RVA = "0x4489F0", Offset = "0x4475F0", Length = "0x7")] get; [Token(Token = "0x6001EF5"), Address(RVA = "0x448A60", Offset = "0x447660", Length = "0x7")] set; }

    [field: Token(Token = "0x4001C44")]
    [field: FieldOffset(Offset = "0x90")]
    [Token(Token = "0x170003A0")]
    public Rigidbody target { [Token(Token = "0x6001EF6"), Address(RVA = "0x399680", Offset = "0x398280", Length = "0x8")] get; [Token(Token = "0x6001EF7"), Address(RVA = "0x448A40", Offset = "0x447640", Length = "0x13")] private set; }

    [field: Token(Token = "0x4001C46")]
    [field: FieldOffset(Offset = "0x9C")]
    [Token(Token = "0x170003A1")]
    public float spawnedAtTime { [Token(Token = "0x6001EF8"), Address(RVA = "0x4489E0", Offset = "0x4475E0", Length = "0x9")] get; [Token(Token = "0x6001EF9"), Address(RVA = "0x365C90", Offset = "0x364890", Length = "0x9")] private set; }

    [Token(Token = "0x6001EFA")]
    [Address(RVA = "0x445390", Offset = "0x443F90", Length = "0xF42")]
    public void InitEnemy(
      uint id,
      EnemyData enemyData,
      Vector3 pos,
      int waveNumber,
      EEnemyFlag flag = EEnemyFlag.None,
      bool canBeElite = true)
    {
    }

    [Token(Token = "0x6001EFB")]
    [Address(RVA = "0x447890", Offset = "0x446490", Length = "0x9")]
    public void SetSpeedMultiplier(float f)
    {
    }

    [Token(Token = "0x6001EFC")]
    [Address(RVA = "0x447A20", Offset = "0x446620", Length = "0x21")]
    public void SetSwarmMultiplierHp(float f)
    {
    }

    [Token(Token = "0x6001EFD")]
    [Address(RVA = "0x444F80", Offset = "0x443B80", Length = "0x106")]
    public float GetSpeed() => 0.0f;

    [Token(Token = "0x6001EFE")]
    [Address(RVA = "0x430D40", Offset = "0x42F940", Length = "0x6")]
    public int GetMoney() => 0;

    [Token(Token = "0x6001EFF")]
    [Address(RVA = "0x444B30", Offset = "0x443730", Length = "0x33")]
    private void Freeze()
    {
    }

    [Token(Token = "0x6001F00")]
    [Address(RVA = "0x448470", Offset = "0x447070", Length = "0x33")]
    private void UnFreeze()
    {
    }

    [Token(Token = "0x6001F01")]
    [Address(RVA = "0x443620", Offset = "0x442220", Length = "0x7C")]
    private void CheckScale()
    {
    }

    [Token(Token = "0x6001F02")]
    [Address(RVA = "0x446770", Offset = "0x445370", Length = "0x7")]
    public void MakeChallenge()
    {
    }

    [Token(Token = "0x6001F03")]
    [Address(RVA = "0x4436A0", Offset = "0x4422A0", Length = "0x371")]
    private void CheckStatusSymbols()
    {
    }

    [Token(Token = "0x6001F04")]
    [Address(RVA = "0x445160", Offset = "0x443D60", Length = "0x224")]
    public void Heal(int amount)
    {
    }

    [Token(Token = "0x6001F05")]
    [Address(RVA = "0x447830", Offset = "0x446430", Length = "0x34")]
    private void SetBoss()
    {
    }

    [Token(Token = "0x6001F06")]
    [Address(RVA = "0x4478A0", Offset = "0x4464A0", Length = "0x17E")]
    public void SetSummonerMiniboss()
    {
    }

    [Token(Token = "0x6001F07")]
    [Address(RVA = "0x446590", Offset = "0x445190", Length = "0x41")]
    public bool IsStageBoss() => false;

    [Token(Token = "0x6001F08")]
    [Address(RVA = "0x4462E0", Offset = "0x444EE0", Length = "0x41")]
    public bool IsBoss() => false;

    [Token(Token = "0x6001F09")]
    [Address(RVA = "0x446400", Offset = "0x445000", Length = "0x41")]
    public bool IsElite() => false;

    [Token(Token = "0x6001F0A")]
    [Address(RVA = "0x446330", Offset = "0x444F30", Length = "0x41")]
    public bool IsChallenge() => false;

    [Token(Token = "0x6001F0B")]
    [Address(RVA = "0x4463B0", Offset = "0x444FB0", Length = "0x42")]
    public bool IsEliteChallenge() => false;

    [Token(Token = "0x6001F0C")]
    [Address(RVA = "0x446450", Offset = "0x445050", Length = "0x41")]
    public bool IsFinalBoss() => false;

    [Token(Token = "0x6001F0D")]
    [Address(RVA = "0x447870", Offset = "0x446470", Length = "0x19")]
    public void SetMinibossGoon(float hp)
    {
    }

    [Token(Token = "0x6001F0E")]
    [Address(RVA = "0x4428C0", Offset = "0x4414C0", Length = "0x348")]
    private void AddStatusSymbols()
    {
    }

    [Token(Token = "0x6001F0F")]
    [Address(RVA = "0x447690", Offset = "0x446290", Length = "0x155")]
    private void RemoveStatusSymbols()
    {
    }

    [Token(Token = "0x6001F10")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    private void ResetUi()
    {
    }

    [Token(Token = "0x6001F11")]
    [Address(RVA = "0x442C10", Offset = "0x441810", Length = "0x48D")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001F12")]
    [Address(RVA = "0x446C60", Offset = "0x445860", Length = "0x413")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6001F13")]
    [Address(RVA = "0x4470B0", Offset = "0x445CB0", Length = "0x38")]
    private void OnStatusEffectAdded(EStatusEffect eStatusEffect, bool newEffect)
    {
    }

    [Token(Token = "0x6001F14")]
    [Address(RVA = "0x4470F0", Offset = "0x445CF0", Length = "0x38")]
    private void OnStatusEffectRemoved(EStatusEffect eStatusEffect)
    {
    }

    [Token(Token = "0x6001F15")]
    [Address(RVA = "0x447A80", Offset = "0x446680", Length = "0x95")]
    private IEnumerator StartTeleporting(Vector3 toPosition, bool skipStart = false) => (IEnumerator) null;

    [Token(Token = "0x6001F16")]
    [Address(RVA = "0x4444B0", Offset = "0x4430B0", Length = "0x67")]
    private IEnumerator Despawn() => (IEnumerator) null;

    [Token(Token = "0x6001F17")]
    [Address(RVA = "0x443C90", Offset = "0x442890", Length = "0x98")]
    public void DamageFromPlayerWeapon(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001F18")]
    [Address(RVA = "0x443BF0", Offset = "0x4427F0", Length = "0x98")]
    public void DamageFromPlayerOther(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001F19")]
    [Address(RVA = "0x443BE0", Offset = "0x4427E0", Length = "0x8")]
    public void DamageExternal(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001F1A")]
    [Address(RVA = "0x445100", Offset = "0x443D00", Length = "0x54")]
    public bool HasDebuff(EDebuff debuff) => false;

    [Token(Token = "0x6001F1B")]
    [Address(RVA = "0x447300", Offset = "0x445F00", Length = "0x14B")]
    public void ReleaseEcho()
    {
    }

    [Token(Token = "0x6001F1C")]
    [Address(RVA = "0x443D30", Offset = "0x442930", Length = "0x443")]
    private void Damage(DamageContainer damageContainer)
    {
    }

    [Token(Token = "0x6001F1D")]
    [Address(RVA = "0x446830", Offset = "0x445430", Length = "0x56")]
    public void MakeWhite()
    {
    }

    [Token(Token = "0x6001F1E")]
    [Address(RVA = "0x446650", Offset = "0x445250", Length = "0x11C")]
    public void Kill()
    {
    }

    [Token(Token = "0x6001F1F")]
    [Address(RVA = "0x443170", Offset = "0x441D70", Length = "0x23")]
    public bool CanTakeDamage() => false;

    [Token(Token = "0x6001F20")]
    [Address(RVA = "0x446780", Offset = "0x445380", Length = "0xA4")]
    public void MakeInvulnerable(bool invulnerable)
    {
    }

    [Token(Token = "0x6001F21")]
    [Address(RVA = "0x444520", Offset = "0x443120", Length = "0x46")]
    public void DiedNextFrame()
    {
    }

    [Token(Token = "0x6001F22")]
    [Address(RVA = "0x4446D0", Offset = "0x4432D0", Length = "0xBC")]
    private void EnemyDied()
    {
    }

    [Token(Token = "0x6001F23")]
    [Address(RVA = "0x4445B0", Offset = "0x4431B0", Length = "0x11D")]
    public void EnemyDied(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001F24")]
    [Address(RVA = "0x447090", Offset = "0x445C90", Length = "0x1E")]
    private void OnPaused(bool paused)
    {
    }

    [Token(Token = "0x6001F25")]
    [Address(RVA = "0x447080", Offset = "0x445C80", Length = "0x7")]
    private void OnDissolveFinished()
    {
    }

    [Token(Token = "0x6001F26")]
    [Address(RVA = "0x447450", Offset = "0x446050", Length = "0x3F")]
    private void ReleaseToPoolNextFrame()
    {
    }

    [Token(Token = "0x6001F27")]
    [Address(RVA = "0x447490", Offset = "0x446090", Length = "0x107")]
    public void ReleaseToPool()
    {
    }

    [Token(Token = "0x6001F28")]
    [Address(RVA = "0x446890", Offset = "0x445490", Length = "0x370")]
    public void MyFixedUpdate()
    {
    }

    [Token(Token = "0x6001F29")]
    [Address(RVA = "0x4426E0", Offset = "0x4412E0", Length = "0x1D0")]
    public void AddDebuff(EDebuff eDebuff, DamageContainer dc, float duration, int stacks = 1)
    {
    }

    [Token(Token = "0x6001F2A")]
    [Address(RVA = "0x442420", Offset = "0x441020", Length = "0x2BF")]
    private void AddDebuffImplementation(AddDebuffContainer debuffContainer)
    {
    }

    [Token(Token = "0x6001F2B")]
    [Address(RVA = "0x4475A0", Offset = "0x4461A0", Length = "0xED")]
    public void RemoveDebuff(EDebuff debuff, bool fromDeath)
    {
    }

    [Token(Token = "0x6001F2C")]
    [Address(RVA = "0x444180", Offset = "0x442D80", Length = "0x324")]
    public void DebuffTick()
    {
    }

    [Token(Token = "0x6001F2D")]
    [Address(RVA = "0x447130", Offset = "0x445D30", Length = "0x14B")]
    public void QueueClearAllDebuffs()
    {
    }

    [Token(Token = "0x6001F2E")]
    [Address(RVA = "0x443A20", Offset = "0x442620", Length = "0x1B8")]
    public void ClearAllDebuffs()
    {
    }

    [Token(Token = "0x6001F2F")]
    [Address(RVA = "0x4431A0", Offset = "0x441DA0", Length = "0x475")]
    public void Charm(DamageContainer dc, float duration)
    {
    }

    [Token(Token = "0x6001F30")]
    [Address(RVA = "0x447280", Offset = "0x445E80", Length = "0x78")]
    public void ReleaseCharm()
    {
    }

    [Token(Token = "0x6001F31")]
    [Address(RVA = "0x444790", Offset = "0x443390", Length = "0x39B")]
    public void FindTarget()
    {
    }

    [Token(Token = "0x6001F32")]
    [Address(RVA = "0x4484B0", Offset = "0x4470B0", Length = "0x242")]
    private void VerifyPosition()
    {
    }

    [Token(Token = "0x6001F33")]
    [Address(RVA = "0x447B20", Offset = "0x446720", Length = "0xEE")]
    public void TeleportToPlayer()
    {
    }

    [Token(Token = "0x6001F34")]
    [Address(RVA = "0x447C10", Offset = "0x446810", Length = "0x103")]
    private void TryDespawn()
    {
    }

    [Token(Token = "0x6001F35")]
    [Address(RVA = "0x446640", Offset = "0x445240", Length = "0xB")]
    public bool IsTeleporting() => false;

    [Token(Token = "0x6001F36")]
    [Address(RVA = "0x447D20", Offset = "0x446920", Length = "0x748")]
    private void TryTeleport()
    {
    }

    [Token(Token = "0x6001F37")]
    [Address(RVA = "0x447A50", Offset = "0x446650", Length = "0x27")]
    public void StartSpecialAttack()
    {
    }

    [Token(Token = "0x6001F38")]
    [Address(RVA = "0x444580", Offset = "0x443180", Length = "0x27")]
    public void EndSpecialAttack()
    {
    }

    [Token(Token = "0x6001F39")]
    [Address(RVA = "0x446C10", Offset = "0x445810", Length = "0x43")]
    public void MyUpdate()
    {
    }

    [Token(Token = "0x6001F3A")]
    [Address(RVA = "0x4430A0", Offset = "0x441CA0", Length = "0xC6")]
    public bool CanMove() => false;

    [Token(Token = "0x6001F3B")]
    [Address(RVA = "0x446520", Offset = "0x445120", Length = "0x69")]
    public bool IsRunningFromPlayer() => false;

    [Token(Token = "0x6001F3C")]
    [Address(RVA = "0x4465E0", Offset = "0x4451E0", Length = "0x56")]
    private bool IsStationary() => false;

    [Token(Token = "0x6001F3D")]
    [Address(RVA = "0x445090", Offset = "0x443C90", Length = "0x6B")]
    public int GetXp() => 0;

    [Token(Token = "0x6001F3E")]
    [Address(RVA = "0x4477F0", Offset = "0x4463F0", Length = "0x3C")]
    private void ResetMaterial()
    {
    }

    [Token(Token = "0x6001F3F")]
    [Address(RVA = "0x4463A0", Offset = "0x444FA0", Length = "0xE")]
    public bool IsDead() => false;

    [Token(Token = "0x6001F40")]
    [Address(RVA = "0x446380", Offset = "0x444F80", Length = "0x16")]
    public bool IsDeadOrDyingNextFrame() => false;

    [Token(Token = "0x6001F41")]
    [Address(RVA = "0x444C50", Offset = "0x443850", Length = "0x47")]
    public Vector3 GetCenterPosition() => new Vector3();

    [Token(Token = "0x6001F42")]
    [Address(RVA = "0x444CA0", Offset = "0x4438A0", Length = "0x4A")]
    public Vector3 GetFeetPosition() => new Vector3();

    [Token(Token = "0x6001F43")]
    [Address(RVA = "0x444E50", Offset = "0x443A50", Length = "0xE9")]
    public Vector3 GetHeadPosition() => new Vector3();

    [Token(Token = "0x6001F44")]
    [Address(RVA = "0x444CF0", Offset = "0x4438F0", Length = "0x152")]
    public Vector3 GetGroundCheckPosition() => new Vector3();

    [Token(Token = "0x6001F45")]
    [Address(RVA = "0x4464A0", Offset = "0x4450A0", Length = "0x80")]
    public bool IsImportantEnemy() => false;

    [Token(Token = "0x6001F46")]
    [Address(RVA = "0x444F40", Offset = "0x443B40", Length = "0x6")]
    public float GetHeight() => 0.0f;

    [Token(Token = "0x6001F47")]
    [Address(RVA = "0x444570", Offset = "0x443170", Length = "0x8")]
    public void DisableSpecialAttacks()
    {
    }

    [Token(Token = "0x6001F48")]
    [Address(RVA = "0x444B70", Offset = "0x443770", Length = "0xDD")]
    public Vector3 GetBottomPosition() => new Vector3();

    [Token(Token = "0x6001F49")]
    [Address(RVA = "0x444F70", Offset = "0x443B70", Length = "0x9")]
    public float GetPowerupDropChance() => 0.0f;

    [Token(Token = "0x6001F4A")]
    [Address(RVA = "0x444F50", Offset = "0x443B50", Length = "0x11")]
    public float GetHpRatio() => 0.0f;

    [Token(Token = "0x6001F4B")]
    [Address(RVA = "0x448740", Offset = "0x447340", Length = "0x254")]
    public Enemy()
    {
    }

    [Token(Token = "0x6001F4C")]
    [Address(RVA = "0x448700", Offset = "0x447300", Length = "0x3A")]
    static Enemy()
    {
    }
  }
}
