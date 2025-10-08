// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Actors.Player.MyPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Actors.Player
{
  [Token(Token = "0x2000451")]
  public class MyPlayer : MonoBehaviour
  {
    [Token(Token = "0x4001BF9")]
    [FieldOffset(Offset = "0x20")]
    public PlayerRenderer playerRenderer;
    [Token(Token = "0x4001BFA")]
    [FieldOffset(Offset = "0x28")]
    public PlayerMovement playerMovement;
    [Token(Token = "0x4001BFB")]
    [FieldOffset(Offset = "0x30")]
    public ParticleSystem levelupParticles;
    [Token(Token = "0x4001BFC")]
    [FieldOffset(Offset = "0x38")]
    public AudioSource levelupSfx;
    [Token(Token = "0x4001BFD")]
    [FieldOffset(Offset = "0x40")]
    public ECharacter character;
    [Token(Token = "0x4001BFE")]
    [FieldOffset(Offset = "0x48")]
    public PlayerInput playerInput;
    [Token(Token = "0x4001BFF")]
    [FieldOffset(Offset = "0x50")]
    public AuraAttacks playerConstantAttacks;
    [Token(Token = "0x4001C00")]
    [FieldOffset(Offset = "0x58")]
    public PlayerSfxs playerSfxs;
    [Token(Token = "0x4001C01")]
    [FieldOffset(Offset = "0x60")]
    public PlayerEffects playerEffects;
    [Token(Token = "0x4001C02")]
    [FieldOffset(Offset = "0x68")]
    public GameObject fogOfWar;
    [Token(Token = "0x4001C03")]
    [FieldOffset(Offset = "0x70")]
    public GameObject teleportEffect;
    [Token(Token = "0x4001C04")]
    [FieldOffset(Offset = "0x78")]
    public UnityEngine.Camera minimapCamera;
    [Token(Token = "0x4001C05")]
    [FieldOffset(Offset = "0x80")]
    private bool inited;
    [Token(Token = "0x4001C07")]
    [FieldOffset(Offset = "0x88")]
    public PlayerInventory inventory;
    [Token(Token = "0x4001C08")]
    public static Action<PlayerInventory> A_PlayerInventoryInitialized;
    [Token(Token = "0x4001C09")]
    public static MyPlayer Instance;
    [Token(Token = "0x4001C0A")]
    public static Action A_PrePlayerSpawn;
    [Token(Token = "0x4001C0B")]
    [FieldOffset(Offset = "0x90")]
    public float height;
    [Token(Token = "0x4001C0C")]
    [FieldOffset(Offset = "0x98")]
    public Transform feet;
    [Token(Token = "0x4001C0D")]
    [FieldOffset(Offset = "0xA0")]
    public Transform head;
    [Token(Token = "0x4001C0E")]
    [FieldOffset(Offset = "0xA8")]
    public Vector3 spawnDir;
    [Token(Token = "0x4001C0F")]
    [FieldOffset(Offset = "0xB4")]
    public float width;
    [Token(Token = "0x4001C10")]
    [FieldOffset(Offset = "0xB8")]
    private bool started;
    [Token(Token = "0x4001C11")]
    [FieldOffset(Offset = "0xBC")]
    private float nextChangeTime;
    [Token(Token = "0x4001C12")]
    [FieldOffset(Offset = "0xC0")]
    private bool isInvincible;
    [Token(Token = "0x4001C13")]
    [FieldOffset(Offset = "0xC4")]
    private float damageCooldownOverAtTime;
    [Token(Token = "0x4001C14")]
    [FieldOffset(Offset = "0xC8")]
    private float lastCalledTime;
    [Token(Token = "0x4001C15")]
    [FieldOffset(Offset = "0xD0")]
    private Dictionary<GameObject, float> enemyCooldowns;
    [Token(Token = "0x4001C16")]
    [FieldOffset(Offset = "0xD8")]
    private float enemyAttackCooldown;
    [Token(Token = "0x4001C17")]
    [FieldOffset(Offset = "0xDC")]
    private int enemyLayer;
    [Token(Token = "0x4001C18")]
    public static Action A_Collided;
    [Token(Token = "0x4001C19")]
    public static Action A_CollidedEnemy;
    [Token(Token = "0x4001C1A")]
    [FieldOffset(Offset = "0xE0")]
    private float movingDirectionBias;
    [Token(Token = "0x4001C1B")]
    [FieldOffset(Offset = "0xE4")]
    private float shootingDirectionBias;
    [Token(Token = "0x4001C1C")]
    [FieldOffset(Offset = "0xE8")]
    private float biasMoveSpeed;
    [Token(Token = "0x4001C1D")]
    [FieldOffset(Offset = "0xEC")]
    private Vector3 averageMovingDirection;
    [Token(Token = "0x4001C1E")]
    [FieldOffset(Offset = "0xF8")]
    private Vector3 averageMovingDirectionShooting;
    [Token(Token = "0x4001C1F")]
    [FieldOffset(Offset = "0x104")]
    private float maxVectorSize;
    [Token(Token = "0x4001C20")]
    [FieldOffset(Offset = "0x108")]
    private float maxVectorSizeShooting;
    [Token(Token = "0x4001C21")]
    [FieldOffset(Offset = "0x110")]
    public Transform arrow;
    [Token(Token = "0x4001C22")]
    [FieldOffset(Offset = "0x118")]
    public Transform shootingArrow;
    [Token(Token = "0x4001C23")]
    [FieldOffset(Offset = "0x120")]
    public bool isTeleporting;
    [Token(Token = "0x4001C24")]
    private static float defaultBaseDamage;
    [Token(Token = "0x4001C25")]
    [FieldOffset(Offset = "0x124")]
    private float baseDamage;

    [field: Token(Token = "0x4001C06")]
    [field: FieldOffset(Offset = "0x84")]
    [Token(Token = "0x17000398")]
    public float baseMovementSpeed { [Token(Token = "0x6001EC8"), Address(RVA = "0x44F640", Offset = "0x44E240", Length = "0x9")] get; [Token(Token = "0x6001EC9"), Address(RVA = "0x44F650", Offset = "0x44E250", Length = "0x9")] private set; }

    [Token(Token = "0x6001ECA")]
    [Address(RVA = "0x44CA10", Offset = "0x44B610", Length = "0x7")]
    public void Awake()
    {
    }

    [Token(Token = "0x6001ECB")]
    [Address(RVA = "0x44EB80", Offset = "0x44D780", Length = "0x528")]
    public void TryInit()
    {
    }

    [Token(Token = "0x6001ECC")]
    [Address(RVA = "0x44E9C0", Offset = "0x44D5C0", Length = "0x8C")]
    private void Start()
    {
    }

    [Token(Token = "0x6001ECD")]
    [Address(RVA = "0x44E3C0", Offset = "0x44CFC0", Length = "0x468")]
    public void Spawn(Vector3 position, Vector3 direction, bool useHeightOffset = false)
    {
    }

    [Token(Token = "0x6001ECE")]
    [Address(RVA = "0x44E830", Offset = "0x44D430", Length = "0x182")]
    public void StartPlayer(ECharacter character, Vector3 direction)
    {
    }

    [Token(Token = "0x6001ECF")]
    [Address(RVA = "0x44DF30", Offset = "0x44CB30", Length = "0x484")]
    public void RefreshSize(CharacterData characterData, Vector3 direction, float sizeMultiplier = 1f)
    {
    }

    [Token(Token = "0x6001ED0")]
    [Address(RVA = "0x44CB70", Offset = "0x44B770", Length = "0x129")]
    private void FixedUpdate()
    {
    }

    [Token(Token = "0x6001ED1")]
    [Address(RVA = "0x44F500", Offset = "0x44E100", Length = "0x19")]
    private void Update()
    {
    }

    [Token(Token = "0x6001ED2")]
    [Address(RVA = "0x44D590", Offset = "0x44C190", Length = "0x171")]
    private void OnDamage(PlayerHealth ph, DamageContainer dc, bool shieldDamage)
    {
    }

    [Token(Token = "0x6001ED3")]
    [Address(RVA = "0x44CAC0", Offset = "0x44B6C0", Length = "0xA1")]
    private void DamageCooldownOver()
    {
    }

    [Token(Token = "0x6001ED4")]
    [Address(RVA = "0x44DB90", Offset = "0x44C790", Length = "0x193")]
    public void OnLevelUp()
    {
    }

    [Token(Token = "0x6001ED5")]
    [Address(RVA = "0x44EA50", Offset = "0x44D650", Length = "0x45")]
    private void StopLevelupParticles()
    {
    }

    [Token(Token = "0x6001ED6")]
    [Address(RVA = "0x44CEA0", Offset = "0x44BAA0", Length = "0x6E8")]
    private void OnCollisionStay(Collision other)
    {
    }

    [Token(Token = "0x6001ED7")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x6001ED8")]
    [Address(RVA = "0x44CAB0", Offset = "0x44B6B0", Length = "0xB")]
    private bool CanTakeDamage() => false;

    [Token(Token = "0x6001ED9")]
    [Address(RVA = "0x44F0B0", Offset = "0x44DCB0", Length = "0x441")]
    public void UpdateSpawnDirectionBias()
    {
    }

    [Token(Token = "0x6001EDA")]
    [Address(RVA = "0x44CDE0", Offset = "0x44B9E0", Length = "0x90")]
    public float GetSpawnDirectionBias() => 0.0f;

    [Token(Token = "0x6001EDB")]
    [Address(RVA = "0x44CCC0", Offset = "0x44B8C0", Length = "0x19")]
    public Vector3 GetAverageMovingDirection() => new Vector3();

    [Token(Token = "0x6001EDC")]
    [Address(RVA = "0x44CCA0", Offset = "0x44B8A0", Length = "0x19")]
    public Vector3 GetAverageMovingDirectionTarget() => new Vector3();

    [Token(Token = "0x6001EDD")]
    [Address(RVA = "0x44CE70", Offset = "0x44BA70", Length = "0x29")]
    public bool IsDead() => false;

    [Token(Token = "0x6001EDE")]
    [Address(RVA = "0x44DD30", Offset = "0x44C930", Length = "0x1C4")]
    private void OnPlayerDied()
    {
    }

    [Token(Token = "0x6001EDF")]
    [Address(RVA = "0x44EB10", Offset = "0x44D710", Length = "0x63")]
    public void TeleportPlayer()
    {
    }

    [Token(Token = "0x6001EE0")]
    [Address(RVA = "0x44EAA0", Offset = "0x44D6A0", Length = "0x6D")]
    private void TeleportEnd()
    {
    }

    [Token(Token = "0x6001EE1")]
    [Address(RVA = "0x44DF00", Offset = "0x44CB00", Length = "0x20")]
    public void PauseInventory(bool b)
    {
    }

    [Token(Token = "0x6001EE2")]
    [Address(RVA = "0x44CCF0", Offset = "0x44B8F0", Length = "0xE0")]
    public Vector3 GetFeetPosition() => new Vector3();

    [Token(Token = "0x6001EE3")]
    [Address(RVA = "0x44CA20", Offset = "0x44B620", Length = "0x8B")]
    private void CalculateBaseDamage()
    {
    }

    [Token(Token = "0x6001EE4")]
    [Address(RVA = "0x44CCE0", Offset = "0x44B8E0", Length = "0x9")]
    public float GetBaseDamage() => 0.0f;

    [Token(Token = "0x6001EE5")]
    [Address(RVA = "0x44D710", Offset = "0x44C310", Length = "0x472")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6001EE6")]
    [Address(RVA = "0x44F560", Offset = "0x44E160", Length = "0xE0")]
    public MyPlayer()
    {
    }

    [Token(Token = "0x6001EE7")]
    [Address(RVA = "0x44F520", Offset = "0x44E120", Length = "0x3A")]
    static MyPlayer()
    {
    }
  }
}
