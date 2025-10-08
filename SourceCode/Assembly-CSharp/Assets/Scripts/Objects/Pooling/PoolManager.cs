// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Objects.Pooling.PoolManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Combat.EnemySpecialAttacks;
using Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations;
using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.Attacks;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace Assets.Scripts.Objects.Pooling
{
  [Token(Token = "0x200033A")]
  public class PoolManager : MonoBehaviour
  {
    [Token(Token = "0x40015FB")]
    [FieldOffset(Offset = "0x20")]
    public Transform damageNumbersParent;
    [Token(Token = "0x40015FC")]
    private static int maxCritPrefabs;
    [Token(Token = "0x40015FD")]
    [FieldOffset(Offset = "0x28")]
    private int maxBonkPrefabs;
    [Token(Token = "0x40015FE")]
    [FieldOffset(Offset = "0x2C")]
    private int maxBulletHitPrefabs;
    [Token(Token = "0x40015FF")]
    [FieldOffset(Offset = "0x30")]
    private int maxHitNumbers;
    [Token(Token = "0x4001600")]
    [FieldOffset(Offset = "0x34")]
    private int maxLightningStrikes;
    [Token(Token = "0x4001601")]
    [FieldOffset(Offset = "0x38")]
    private int maxFirefields;
    [Token(Token = "0x4001602")]
    [FieldOffset(Offset = "0x3C")]
    private int rocketPoolSize;
    [Token(Token = "0x4001603")]
    [FieldOffset(Offset = "0x40")]
    private int orbPoolSize;
    [Token(Token = "0x4001604")]
    [FieldOffset(Offset = "0x44")]
    private int explosionPoolSize;
    [Token(Token = "0x4001605")]
    private static int maxSilver;
    [Token(Token = "0x4001606")]
    private static int cursedHitsPoolSize;
    [Token(Token = "0x4001607")]
    private static int charmPoolSize;
    [Token(Token = "0x4001608")]
    private static int eatPoolSize;
    [Token(Token = "0x4001609")]
    public static PoolManager Instance;
    [Token(Token = "0x400160A")]
    [FieldOffset(Offset = "0x48")]
    private int maxWarningSpheres;
    [Token(Token = "0x400160B")]
    [FieldOffset(Offset = "0x50")]
    public GameObject xpPrefab;
    [Token(Token = "0x400160C")]
    [FieldOffset(Offset = "0x58")]
    public GameObject goldPrefab;
    [Token(Token = "0x400160D")]
    [FieldOffset(Offset = "0x60")]
    public GameObject silverPrefab;
    [Token(Token = "0x400160E")]
    [FieldOffset(Offset = "0x68")]
    public GameObject enemyPrefab;
    [Token(Token = "0x400160F")]
    [FieldOffset(Offset = "0x70")]
    public GameObject enemySpawnFxPrefab;
    [Token(Token = "0x4001610")]
    [FieldOffset(Offset = "0x78")]
    public GameObject damageNumbersPrefab;
    [Token(Token = "0x4001611")]
    [FieldOffset(Offset = "0x80")]
    public GameObject pickupEffectPrefab;
    [Token(Token = "0x4001612")]
    [FieldOffset(Offset = "0x88")]
    public GameObject goldBurstPrefab;
    [Token(Token = "0x4001613")]
    [FieldOffset(Offset = "0x90")]
    public GameObject critEffectPrefab;
    [Token(Token = "0x4001614")]
    [FieldOffset(Offset = "0x98")]
    public GameObject lightningStrikePrefab;
    [Token(Token = "0x4001615")]
    [FieldOffset(Offset = "0xA0")]
    public GameObject footstepPrefab;
    [Token(Token = "0x4001616")]
    [FieldOffset(Offset = "0xA8")]
    public GameObject enemyStatusSymbolsPrefab;
    [Token(Token = "0x4001617")]
    [FieldOffset(Offset = "0xB0")]
    public ObjectPool<GameObject> xpPool;
    [Token(Token = "0x4001618")]
    [FieldOffset(Offset = "0xB8")]
    public ObjectPool<GameObject> goldPool;
    [Token(Token = "0x4001619")]
    [FieldOffset(Offset = "0xC0")]
    public ObjectPool<GameObject> silverPool;
    [Token(Token = "0x400161A")]
    [FieldOffset(Offset = "0xC8")]
    public ObjectPool<GameObject> enemyPool;
    [Token(Token = "0x400161B")]
    [FieldOffset(Offset = "0xD0")]
    public ObjectPool<GameObject> enemySpawnFxPool;
    [Token(Token = "0x400161C")]
    [FieldOffset(Offset = "0xD8")]
    public ObjectPool<GameObject> damageNumbersPool;
    [Token(Token = "0x400161D")]
    [FieldOffset(Offset = "0xE0")]
    public ObjectPool<GameObject> pickupeffectPool;
    [Token(Token = "0x400161E")]
    [FieldOffset(Offset = "0xE8")]
    public ObjectPool<GameObject> goldBurstPool;
    [Token(Token = "0x400161F")]
    [FieldOffset(Offset = "0xF0")]
    public ObjectPool<GameObject> critEffectPool;
    [Token(Token = "0x4001620")]
    [FieldOffset(Offset = "0xF8")]
    public ObjectPool<GameObject> lightningStrikePool;
    [Token(Token = "0x4001621")]
    [FieldOffset(Offset = "0x100")]
    public ObjectPool<GameObject> footstepPool;
    [Token(Token = "0x4001622")]
    [FieldOffset(Offset = "0x108")]
    public ObjectPool<GameObject> enemyStatusSymbolsPool;
    [Token(Token = "0x4001623")]
    [FieldOffset(Offset = "0x110")]
    public ObjectPool<GameObject> powerupPool;
    [Token(Token = "0x4001624")]
    [FieldOffset(Offset = "0x118")]
    public ObjectPool<GameObject> warningTubePool;
    [Token(Token = "0x4001625")]
    [FieldOffset(Offset = "0x120")]
    public ObjectPool<GameObject> warningSpherePool;
    [Token(Token = "0x4001626")]
    [FieldOffset(Offset = "0x128")]
    public ObjectPool<GameObject> bullseyePool;
    [Token(Token = "0x4001627")]
    [FieldOffset(Offset = "0x130")]
    public ObjectPool<GameObject> poisonPool;
    [Token(Token = "0x4001628")]
    [FieldOffset(Offset = "0x138")]
    public GameObject defaultHitPrefab;
    [Token(Token = "0x4001629")]
    [FieldOffset(Offset = "0x140")]
    public GameObject powerupPrefab;
    [Token(Token = "0x400162A")]
    [FieldOffset(Offset = "0x148")]
    public GameObject warningTube;
    [Token(Token = "0x400162B")]
    [FieldOffset(Offset = "0x150")]
    public GameObject warningSphere;
    [Token(Token = "0x400162C")]
    [FieldOffset(Offset = "0x158")]
    public GameObject bullseye;
    [Token(Token = "0x400162D")]
    [FieldOffset(Offset = "0x160")]
    public GameObject poisonCloud;
    [Token(Token = "0x400162E")]
    [FieldOffset(Offset = "0x168")]
    public Dictionary<EWeapon, ObjectPool<GameObject>> weaponAttackPools;
    [Token(Token = "0x400162F")]
    [FieldOffset(Offset = "0x170")]
    public Dictionary<EWeapon, ObjectPool<GameObject>> projectilePools;
    [Token(Token = "0x4001630")]
    [FieldOffset(Offset = "0x178")]
    public Dictionary<string, ObjectPool<GameObject>> projectileDonePools;
    [Token(Token = "0x4001631")]
    [FieldOffset(Offset = "0x180")]
    public Dictionary<string, ObjectPool<GameObject>> projectileHitPools;
    [Token(Token = "0x4001632")]
    [FieldOffset(Offset = "0x188")]
    public Dictionary<string, ObjectPool<GameObject>> enemyAttacksPools;
    [Token(Token = "0x4001633")]
    [FieldOffset(Offset = "0x190")]
    public Dictionary<EEnemyAttack, ObjectPool<GameObject>> enemyAttacksFxPools;
    [Token(Token = "0x4001634")]
    [FieldOffset(Offset = "0x198")]
    private int itemFxPoolSizes;
    [Token(Token = "0x4001635")]
    [FieldOffset(Offset = "0x1A0")]
    public ObjectPool<GameObject> grandmaTonicPool;
    [Token(Token = "0x4001636")]
    [FieldOffset(Offset = "0x1A8")]
    public ObjectPool<GameObject> megaCritPool;
    [Token(Token = "0x4001637")]
    [FieldOffset(Offset = "0x1B0")]
    public ObjectPool<GameObject> executePool;
    [Token(Token = "0x4001638")]
    [FieldOffset(Offset = "0x1B8")]
    public ObjectPool<GameObject> spicyMeatballPool;
    [Token(Token = "0x4001639")]
    [FieldOffset(Offset = "0x1C0")]
    public ObjectPool<GameObject> chainLightningPool;
    [Token(Token = "0x400163A")]
    [FieldOffset(Offset = "0x1C8")]
    public ObjectPool<GameObject> freezeFxPool;
    [Token(Token = "0x400163B")]
    [FieldOffset(Offset = "0x1D0")]
    public ObjectPool<GameObject> firefieldPool;
    [Token(Token = "0x400163C")]
    [FieldOffset(Offset = "0x1D8")]
    public ObjectPool<GameObject> rocketPool;
    [Token(Token = "0x400163D")]
    [FieldOffset(Offset = "0x1E0")]
    public ObjectPool<GameObject> explosionPool;
    [Token(Token = "0x400163E")]
    [FieldOffset(Offset = "0x1E8")]
    public ObjectPool<GameObject> bonkPool;
    [Token(Token = "0x400163F")]
    [FieldOffset(Offset = "0x1F0")]
    public ObjectPool<GameObject> bulletHitPool;
    [Token(Token = "0x4001640")]
    [FieldOffset(Offset = "0x1F8")]
    public ObjectPool<GameObject> cursedHitPool;
    [Token(Token = "0x4001641")]
    [FieldOffset(Offset = "0x200")]
    public ObjectPool<GameObject> orbPool;
    [Token(Token = "0x4001642")]
    [FieldOffset(Offset = "0x208")]
    public ObjectPool<GameObject> ghostPool;
    [Token(Token = "0x4001643")]
    [FieldOffset(Offset = "0x210")]
    public ObjectPool<GameObject> angrySoulPool;
    [Token(Token = "0x4001644")]
    [FieldOffset(Offset = "0x218")]
    public ObjectPool<GameObject> charmPool;
    [Token(Token = "0x4001645")]
    [FieldOffset(Offset = "0x220")]
    public ObjectPool<GameObject> borgorPool;
    [Token(Token = "0x4001646")]
    [FieldOffset(Offset = "0x228")]
    public ObjectPool<GameObject> eatPool;
    [Token(Token = "0x4001647")]
    [FieldOffset(Offset = "0x230")]
    public ObjectPool<GameObject> bloodmarkPool;
    [Token(Token = "0x4001648")]
    [FieldOffset(Offset = "0x238")]
    public ObjectPool<GameObject> cactusPool;
    [Token(Token = "0x4001649")]
    [FieldOffset(Offset = "0x240")]
    public ObjectPool<GameObject> tumbleweedPool;
    [Token(Token = "0x400164A")]
    [FieldOffset(Offset = "0x248")]
    public ObjectPool<GameObject> tumbleweedBreakPool;
    [Token(Token = "0x400164B")]
    [FieldOffset(Offset = "0x250")]
    public ObjectPool<GameObject> quinMaskPool;
    [Token(Token = "0x400164C")]
    [FieldOffset(Offset = "0x258")]
    public GameObject grandmaTonicFx;
    [Token(Token = "0x400164D")]
    [FieldOffset(Offset = "0x260")]
    public GameObject megaCritFx;
    [Token(Token = "0x400164E")]
    [FieldOffset(Offset = "0x268")]
    public GameObject spicyMeatballFx;
    [Token(Token = "0x400164F")]
    [FieldOffset(Offset = "0x270")]
    public GameObject chainLightningFx;
    [Token(Token = "0x4001650")]
    [FieldOffset(Offset = "0x278")]
    public GameObject freezeFx;
    [Token(Token = "0x4001651")]
    [FieldOffset(Offset = "0x280")]
    public GameObject firefield;
    [Token(Token = "0x4001652")]
    [FieldOffset(Offset = "0x288")]
    public GameObject rocket;
    [Token(Token = "0x4001653")]
    [FieldOffset(Offset = "0x290")]
    public GameObject explosionFx;
    [Token(Token = "0x4001654")]
    [FieldOffset(Offset = "0x298")]
    public GameObject bonkFx;
    [Token(Token = "0x4001655")]
    [FieldOffset(Offset = "0x2A0")]
    public GameObject executeFx;
    [Token(Token = "0x4001656")]
    [FieldOffset(Offset = "0x2A8")]
    public GameObject bulletHit;
    [Token(Token = "0x4001657")]
    [FieldOffset(Offset = "0x2B0")]
    public GameObject cursedHit;
    [Token(Token = "0x4001658")]
    [FieldOffset(Offset = "0x2B8")]
    public GameObject orb;
    [Token(Token = "0x4001659")]
    [FieldOffset(Offset = "0x2C0")]
    public GameObject ghost;
    [Token(Token = "0x400165A")]
    [FieldOffset(Offset = "0x2C8")]
    public GameObject angrySoul;
    [Token(Token = "0x400165B")]
    [FieldOffset(Offset = "0x2D0")]
    public GameObject charmFx;
    [Token(Token = "0x400165C")]
    [FieldOffset(Offset = "0x2D8")]
    public GameObject borgor;
    [Token(Token = "0x400165D")]
    [FieldOffset(Offset = "0x2E0")]
    public GameObject eat;
    [Token(Token = "0x400165E")]
    [FieldOffset(Offset = "0x2E8")]
    public GameObject bloodmark;
    [Token(Token = "0x400165F")]
    [FieldOffset(Offset = "0x2F0")]
    public GameObject cactusFx;
    [Token(Token = "0x4001660")]
    [FieldOffset(Offset = "0x2F8")]
    public GameObject tumbleweed;
    [Token(Token = "0x4001661")]
    [FieldOffset(Offset = "0x300")]
    public GameObject tumbleweedBreak;
    [Token(Token = "0x4001662")]
    [FieldOffset(Offset = "0x308")]
    public GameObject quinMaskFx;
    [Token(Token = "0x4001663")]
    [FieldOffset(Offset = "0x310")]
    private Dictionary<GameObject, WeaponAttack> weaponAttacksDict;
    [Token(Token = "0x4001664")]
    [FieldOffset(Offset = "0x318")]
    private Dictionary<GameObject, ProjectileBase> projectileDict;
    [Token(Token = "0x4001665")]
    [FieldOffset(Offset = "0x320")]
    private Dictionary<GameObject, DamageNumbers> damageNumbersDict;
    [Token(Token = "0x4001666")]
    [FieldOffset(Offset = "0x328")]
    private Dictionary<GameObject, AttackHit> attackHitsDict;
    [Token(Token = "0x4001667")]
    [FieldOffset(Offset = "0x330")]
    private Dictionary<EWeapon, string> weaponStrings;

    [Token(Token = "0x6001730")]
    [Address(RVA = "0x3D52C0", Offset = "0x3D3EC0", Length = "0x109")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001731")]
    [Address(RVA = "0x3D72B0", Offset = "0x3D5EB0", Length = "0x2864")]
    private void Start()
    {
    }

    [Token(Token = "0x6001732")]
    [Address(RVA = "0x3D59D0", Offset = "0x3D45D0", Length = "0x1B5")]
    public DamageNumbers GetDamageNumber() => (DamageNumbers) null;

    [Token(Token = "0x6001733")]
    [Address(RVA = "0x3D55A0", Offset = "0x3D41A0", Length = "0x42E")]
    public WeaponAttack GetAttack(WeaponBase weaponBase) => (WeaponAttack) null;

    [Token(Token = "0x6001734")]
    [Address(RVA = "0x3D6FD0", Offset = "0x3D5BD0", Length = "0xB9")]
    public void ReturnAttack(WeaponAttack weaponAttack)
    {
    }

    [Token(Token = "0x6001735")]
    [Address(RVA = "0x3D6A90", Offset = "0x3D5690", Length = "0x44C")]
    public ProjectileBase GetProjectile(WeaponAttack weaponAttack) => (ProjectileBase) null;

    [Token(Token = "0x6001736")]
    [Address(RVA = "0x3D7200", Offset = "0x3D5E00", Length = "0xAF")]
    public void ReturnProjectile(WeaponAttack weaponAttack, GameObject projectile)
    {
    }

    [Token(Token = "0x6001737")]
    [Address(RVA = "0x3D6690", Offset = "0x3D5290", Length = "0x3F6")]
    public AttackHit GetProjectileHit(string source, GameObject hitPrefab) => (AttackHit) null;

    [Token(Token = "0x6001738")]
    [Address(RVA = "0x3D6260", Offset = "0x3D4E60", Length = "0x10D")]
    public GameObject GetProjectileDoneFx(EWeapon eWeapon, GameObject hitPrefab) => (GameObject) null;

    [Token(Token = "0x6001739")]
    [Address(RVA = "0x3D6370", Offset = "0x3D4F70", Length = "0x312")]
    public GameObject GetProjectileDoneFx(string source, GameObject hitPrefab) => (GameObject) null;

    [Token(Token = "0x600173A")]
    [Address(RVA = "0x3D5ED0", Offset = "0x3D4AD0", Length = "0x38D")]
    public GameObject GetEnemyAttack(EnemySpecialAttack specialAttack) => (GameObject) null;

    [Token(Token = "0x600173B")]
    [Address(RVA = "0x3D5B90", Offset = "0x3D4790", Length = "0x339")]
    public GameObject GetEnemyAttackFx(EnemySpecialAttackPrefab enemyAttackPrefab) => (GameObject) null;

    [Token(Token = "0x600173C")]
    [Address(RVA = "0x3D7090", Offset = "0x3D5C90", Length = "0xA7")]
    public void ReturnEnemyAttackFx(EnemyAttackEffectPrefab attackPrefab)
    {
    }

    [Token(Token = "0x600173D")]
    [Address(RVA = "0x3D7140", Offset = "0x3D5D40", Length = "0xB1")]
    public void ReturnEnemyAttack(EnemySpecialAttackPrefab specialAttackPrefab)
    {
    }

    [Token(Token = "0x600173E")]
    [Address(RVA = "0x3D54F0", Offset = "0x3D40F0", Length = "0xA0")]
    private GameObject CreatePooledItem(
      GameObject prefab,
      ObjectPool<GameObject> pool,
      int maxSize)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x600173F")]
    [Address(RVA = "0x3D53D0", Offset = "0x3D3FD0", Length = "0x11A")]
    private GameObject CreatePooledItemTimeout(
      GameObject prefab,
      ObjectPool<GameObject> pool,
      int maxSize,
      float time)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6001740")]
    [Address(RVA = "0x3D6F30", Offset = "0x3D5B30", Length = "0x22")]
    private void OnReturnedToPool(GameObject obj)
    {
    }

    [Token(Token = "0x6001741")]
    [Address(RVA = "0x3D6F60", Offset = "0x3D5B60", Length = "0x6D")]
    private void OnTakeFromPool(GameObject obj)
    {
    }

    [Token(Token = "0x6001742")]
    [Address(RVA = "0x3D6EE0", Offset = "0x3D5AE0", Length = "0x49")]
    private void OnDestroyPoolObject(GameObject obj)
    {
    }

    [Token(Token = "0x6001743")]
    [Address(RVA = "0x3DB060", Offset = "0x3D9C60", Length = "0x37A")]
    public PoolManager()
    {
    }

    [Token(Token = "0x6001744")]
    [Address(RVA = "0x3DAFD0", Offset = "0x3D9BD0", Length = "0x8D")]
    static PoolManager()
    {
    }
  }
}
