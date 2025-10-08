// Decompiled with JetBrains decompiler
// Type: PickupManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups.Pickups;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000AA")]
public class PickupManager : MonoBehaviour
{
  [Token(Token = "0x400054A")]
  [FieldOffset(Offset = "0x20")]
  public LayerMask whatIsPickups;
  [Token(Token = "0x400054B")]
  [FieldOffset(Offset = "0x28")]
  public GameObject hastePrefab;
  [Token(Token = "0x400054C")]
  [FieldOffset(Offset = "0x30")]
  public GameObject healthPrefab;
  [Token(Token = "0x400054D")]
  [FieldOffset(Offset = "0x38")]
  public GameObject magnetPrefab;
  [Token(Token = "0x400054E")]
  [FieldOffset(Offset = "0x40")]
  public GameObject nukePrefab;
  [Token(Token = "0x400054F")]
  [FieldOffset(Offset = "0x48")]
  public GameObject ragePrefab;
  [Token(Token = "0x4000550")]
  [FieldOffset(Offset = "0x50")]
  public GameObject shieldPrefab;
  [Token(Token = "0x4000551")]
  [FieldOffset(Offset = "0x58")]
  public GameObject stonksPrefab;
  [Token(Token = "0x4000552")]
  [FieldOffset(Offset = "0x60")]
  public GameObject timeFreezePrefab;
  [Token(Token = "0x4000553")]
  [FieldOffset(Offset = "0x68")]
  private PickupStackableList xpList;
  [Token(Token = "0x4000554")]
  [FieldOffset(Offset = "0x70")]
  private PickupStackableList goldList;
  [Token(Token = "0x4000555")]
  [FieldOffset(Offset = "0x78")]
  private float stackRadius;
  [Token(Token = "0x4000556")]
  [FieldOffset(Offset = "0x7C")]
  private float stackRadiusMin;
  [Token(Token = "0x4000557")]
  [FieldOffset(Offset = "0x80")]
  private float stackRadiusMax;
  [Token(Token = "0x4000558")]
  [FieldOffset(Offset = "0x84")]
  private float stackRadiusMaxTime;
  [Token(Token = "0x4000559")]
  public static int maxXpObjects;
  [Token(Token = "0x400055A")]
  public static int maxGoldObjects;
  [Token(Token = "0x400055B")]
  public static PickupManager Instance;
  [Token(Token = "0x400055C")]
  [FieldOffset(Offset = "0x88")]
  private Vector3 hoverHeight;
  [Token(Token = "0x400055D")]
  [FieldOffset(Offset = "0x98")]
  private EPickup[] powerups;
  [Token(Token = "0x400055E")]
  [FieldOffset(Offset = "0xA0")]
  private float lastPowerupAtTime;
  [Token(Token = "0x400055F")]
  public static int maxPowerupsOnMap;
  [Token(Token = "0x4000560")]
  [FieldOffset(Offset = "0xA4")]
  private int numPowerupsOnMap;

  [Token(Token = "0x6000440")]
  [Address(RVA = "0x47FB00", Offset = "0x47E700", Length = "0x2ED")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000441")]
  [Address(RVA = "0x4804F0", Offset = "0x47F0F0", Length = "0x1AE")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000442")]
  [Address(RVA = "0x481120", Offset = "0x47FD20", Length = "0xA0")]
  private void SlowUpdate()
  {
  }

  [Token(Token = "0x6000443")]
  [Address(RVA = "0x4806A0", Offset = "0x47F2A0", Length = "0x6F2")]
  private void OnEnemyDied(Enemy enemy, DamageContainer deathSource)
  {
  }

  [Token(Token = "0x6000444")]
  [Address(RVA = "0x480440", Offset = "0x47F040", Length = "0xA9")]
  private EPickup GetRandomPowerup() => new EPickup();

  [Token(Token = "0x6000445")]
  [Address(RVA = "0x4802B0", Offset = "0x47EEB0", Length = "0xDC")]
  private float GetPowerupDropChance(Enemy enemy) => 0.0f;

  [Token(Token = "0x6000446")]
  [Address(RVA = "0x480390", Offset = "0x47EF90", Length = "0xA9")]
  private float GetPowerupTimeMultiplier() => 0.0f;

  [Token(Token = "0x6000447")]
  [Address(RVA = "0x4811D0", Offset = "0x47FDD0", Length = "0x500")]
  public Pickup SpawnPickup(
    EPickup ePickup,
    Vector3 pos,
    int value,
    bool useRandomOffsetPosition = true,
    float pickupDelay = 0.0f)
  {
    return (Pickup) null;
  }

  [Token(Token = "0x6000448")]
  [Address(RVA = "0x480010", Offset = "0x47EC10", Length = "0x7")]
  public void CountAdd()
  {
  }

  [Token(Token = "0x6000449")]
  [Address(RVA = "0x481110", Offset = "0x47FD10", Length = "0x7")]
  public void PowerupCountRemove()
  {
  }

  [Token(Token = "0x600044A")]
  [Address(RVA = "0x47FDF0", Offset = "0x47E9F0", Length = "0xAF")]
  public bool CanSpawnPowerup() => false;

  [Token(Token = "0x600044B")]
  [Address(RVA = "0x481700", Offset = "0x480300", Length = "0x15A")]
  private Pickup SpawnPooledPickup(EPickup ePickup) => (Pickup) null;

  [Token(Token = "0x600044C")]
  [Address(RVA = "0x480F20", Offset = "0x47FB20", Length = "0x1E2")]
  public void PickupTriggered(Pickup pickup)
  {
  }

  [Token(Token = "0x600044D")]
  [Address(RVA = "0x480DA0", Offset = "0x47F9A0", Length = "0x174")]
  public void PickupAllXp()
  {
  }

  [Token(Token = "0x600044E")]
  [Address(RVA = "0x47FEA0", Offset = "0x47EAA0", Length = "0x16D")]
  private bool CheckOverlap(EPickup ePickup, Vector3 pos, out Pickup overlappingPickup)
  {
    overlappingPickup = (Pickup) null;
    return false;
  }

  [Token(Token = "0x600044F")]
  [Address(RVA = "0x480190", Offset = "0x47ED90", Length = "0x111")]
  public GameObject GetNewPickup(EPickup pickup, Vector3 pos) => (GameObject) null;

  [Token(Token = "0x6000450")]
  [Address(RVA = "0x480020", Offset = "0x47EC20", Length = "0x163")]
  public void DespawnPickup(Pickup pickup)
  {
  }

  [Token(Token = "0x6000451")]
  [Address(RVA = "0x4818D0", Offset = "0x4804D0", Length = "0x107")]
  public PickupManager()
  {
  }

  [Token(Token = "0x6000452")]
  [Address(RVA = "0x481860", Offset = "0x480460", Length = "0x63")]
  static PickupManager()
  {
  }
}
