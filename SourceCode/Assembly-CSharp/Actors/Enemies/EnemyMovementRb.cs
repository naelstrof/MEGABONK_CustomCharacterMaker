// Decompiled with JetBrains decompiler
// Type: Actors.Enemies.EnemyMovementRb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Game.Combat.EnemyDebuffs;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace Actors.Enemies
{
  [Token(Token = "0x20002CB")]
  public class EnemyMovementRb : MonoBehaviour
  {
    [Token(Token = "0x400130A")]
    [FieldOffset(Offset = "0x20")]
    public Enemy enemy;
    [Token(Token = "0x400130B")]
    [FieldOffset(Offset = "0x28")]
    public Rigidbody rb;
    [Token(Token = "0x400130C")]
    [FieldOffset(Offset = "0x30")]
    private float nextStepTime;
    [Token(Token = "0x400130D")]
    [FieldOffset(Offset = "0x34")]
    private Vector3 offsetBias;
    [Token(Token = "0x400130E")]
    [FieldOffset(Offset = "0x40")]
    private Vector3 desiredVelocity;
    [Token(Token = "0x400130F")]
    [FieldOffset(Offset = "0x4C")]
    private Quaternion desiredRotation;
    [Token(Token = "0x4001310")]
    [FieldOffset(Offset = "0x5C")]
    private float knockbackResetSpeed;
    [Token(Token = "0x4001311")]
    [FieldOffset(Offset = "0x60")]
    private Vector3 knockbackVelocity;
    [Token(Token = "0x4001312")]
    [FieldOffset(Offset = "0x6C")]
    private float randomOffset;
    [Token(Token = "0x4001313")]
    [FieldOffset(Offset = "0x70")]
    private float randomGroundedCheckOffset;
    [Token(Token = "0x4001314")]
    [FieldOffset(Offset = "0x74")]
    public EnemyMovementRb.State state;
    [Token(Token = "0x4001315")]
    [FieldOffset(Offset = "0x78")]
    private float flyingKnockupVel;
    [Token(Token = "0x4001316")]
    [FieldOffset(Offset = "0x7C")]
    private bool canRotate;
    [Token(Token = "0x4001317")]
    [FieldOffset(Offset = "0x7D")]
    private bool isClimbing;
    [Token(Token = "0x4001318")]
    [FieldOffset(Offset = "0x80")]
    private float nextClimbCheckTime;
    [Token(Token = "0x4001319")]
    [FieldOffset(Offset = "0x84")]
    private float nextGroundedCheckTime;
    [Token(Token = "0x400131A")]
    [FieldOffset(Offset = "0x88")]
    private float groundCheckInterval;
    [Token(Token = "0x400131C")]
    [FieldOffset(Offset = "0x8D")]
    private bool dashing;
    [Token(Token = "0x400131D")]
    [FieldOffset(Offset = "0x90")]
    private float dashStopTime;
    [Token(Token = "0x400131E")]
    [FieldOffset(Offset = "0x94")]
    private Vector3 dashDirection;
    [Token(Token = "0x400131F")]
    [FieldOffset(Offset = "0xA0")]
    private float dashSpeed;
    [Token(Token = "0x4001320")]
    [FieldOffset(Offset = "0xA4")]
    private bool isDashingWall;
    [Token(Token = "0x4001321")]
    [FieldOffset(Offset = "0xA8")]
    private HashSet<EDebuff> debuffs;
    [Token(Token = "0x4001322")]
    [FieldOffset(Offset = "0xB0")]
    private Vector3 baseVelocity;
    [Token(Token = "0x4001323")]
    private const float baseRotationSpeed = 10f;
    [Token(Token = "0x4001324")]
    [FieldOffset(Offset = "0xBC")]
    private float rotationSpeed;
    [Token(Token = "0x4001325")]
    [FieldOffset(Offset = "0xC0")]
    private Vector3 flyingOffset;
    [Token(Token = "0x4001326")]
    [FieldOffset(Offset = "0xCC")]
    public float distanceToTarget;
    [Token(Token = "0x4001327")]
    [FieldOffset(Offset = "0xD0")]
    private bool isStationary;
    [Token(Token = "0x4001328")]
    [FieldOffset(Offset = "0xD4")]
    private float nextGetSpeedTime;
    [Token(Token = "0x4001329")]
    [FieldOffset(Offset = "0xD8")]
    private float getSpeedCooldown;
    [Token(Token = "0x400132A")]
    [FieldOffset(Offset = "0xDC")]
    private float storedSpeed;
    [Token(Token = "0x400132B")]
    private static float knockbackConstant;
    [Token(Token = "0x400132C")]
    private const float maxKnockback = 5f;
    [Token(Token = "0x400132D")]
    private const float maxBossKnockback = 2.25f;
    [Token(Token = "0x400132E")]
    [FieldOffset(Offset = "0xE0")]
    private float maxKnockbackVelSqrBoss;
    [Token(Token = "0x400132F")]
    [FieldOffset(Offset = "0xE8")]
    private Transform suckTarget;
    [Token(Token = "0x4001330")]
    [FieldOffset(Offset = "0xF0")]
    private float totalSuckTime;
    [Token(Token = "0x4001331")]
    [FieldOffset(Offset = "0xF4")]
    private float totalSuckTimeMax;
    [Token(Token = "0x4001332")]
    [FieldOffset(Offset = "0xF8")]
    private float nextCheckDamageTime;

    [Token(Token = "0x60014CD")]
    [Address(RVA = "0x38A5D0", Offset = "0x3891D0", Length = "0x138")]
    private void Awake()
    {
    }

    [Token(Token = "0x60014CE")]
    [Address(RVA = "0x38CD00", Offset = "0x38B900", Length = "0x138")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60014CF")]
    [Address(RVA = "0x38BE60", Offset = "0x38AA60", Length = "0x293")]
    public void Init()
    {
    }

    [Token(Token = "0x60014D0")]
    [Address(RVA = "0x38C560", Offset = "0x38B160", Length = "0x79B")]
    public void MyFixedUpdate()
    {
    }

    [Token(Token = "0x60014D1")]
    [Address(RVA = "0x38D440", Offset = "0x38C040", Length = "0x580")]
    private float TryClimbWall() => 0.0f;

    [field: Token(Token = "0x400131B")]
    [field: FieldOffset(Offset = "0x8C")]
    [Token(Token = "0x1700037A")]
    public bool grounded { [Token(Token = "0x60014D2"), Address(RVA = "0x38DB40", Offset = "0x38C740", Length = "0x8")] get; [Token(Token = "0x60014D3"), Address(RVA = "0x38DB50", Offset = "0x38C750", Length = "0x7")] private set; }

    [Token(Token = "0x60014D4")]
    [Address(RVA = "0x38A770", Offset = "0x389370", Length = "0x1F7")]
    private void CheckGrounded()
    {
    }

    [Token(Token = "0x60014D5")]
    [Address(RVA = "0x38BC50", Offset = "0x38A850", Length = "0x209")]
    private Vector3 GetTargetPosition() => new Vector3();

    [Token(Token = "0x60014D6")]
    [Address(RVA = "0x38A970", Offset = "0x389570", Length = "0x152")]
    public void DashStart(Vector3 dir, float dashTime, float dashSpeed)
    {
    }

    [Token(Token = "0x60014D7")]
    [Address(RVA = "0x38CE80", Offset = "0x38BA80", Length = "0x55")]
    public void SetDashDirection(Vector3 dir)
    {
    }

    [Token(Token = "0x60014D8")]
    [Address(RVA = "0x38AAD0", Offset = "0x3896D0", Length = "0x635")]
    private void Dashing()
    {
    }

    [Token(Token = "0x60014D9")]
    [Address(RVA = "0x38D270", Offset = "0x38BE70", Length = "0x8")]
    public void StopDash()
    {
    }

    [Token(Token = "0x60014DA")]
    [Address(RVA = "0x38D280", Offset = "0x38BE80", Length = "0x20")]
    public void StopMovement()
    {
    }

    [Token(Token = "0x60014DB")]
    [Address(RVA = "0x38D240", Offset = "0x38BE40", Length = "0x20")]
    public void StartMovement()
    {
    }

    [Token(Token = "0x60014DC")]
    [Address(RVA = "0x38CFC0", Offset = "0x38BBC0", Length = "0x27E")]
    private void SetVelocity(Vector3 vel)
    {
    }

    [Token(Token = "0x60014DD")]
    [Address(RVA = "0x38D310", Offset = "0x38BF10", Length = "0x121")]
    private void TimescaleVelocity()
    {
    }

    [Token(Token = "0x60014DE")]
    [Address(RVA = "0x38B110", Offset = "0x389D10", Length = "0x793")]
    public void FindNextPosition()
    {
    }

    [Token(Token = "0x60014DF")]
    [Address(RVA = "0x38CEE0", Offset = "0x38BAE0", Length = "0xDB")]
    public void SetDesiredRotation(Vector3 targetPos)
    {
    }

    [Token(Token = "0x60014E0")]
    [Address(RVA = "0x38BB80", Offset = "0x38A780", Length = "0xC0")]
    private float GetSpeed() => 0.0f;

    [Token(Token = "0x60014E1")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public void MyUpdate()
    {
    }

    [Token(Token = "0x60014E2")]
    [Address(RVA = "0x38CE40", Offset = "0x38BA40", Length = "0x3B")]
    public void Pause(bool isPaused)
    {
    }

    [Token(Token = "0x60014E3")]
    [Address(RVA = "0x38C100", Offset = "0x38AD00", Length = "0x1D5")]
    public void KnockUp(float knockbackForce)
    {
    }

    [Token(Token = "0x60014E4")]
    [Address(RVA = "0x38C2E0", Offset = "0x38AEE0", Length = "0x69")]
    public void Knockback(DamageContainer dc)
    {
    }

    [Token(Token = "0x60014E5")]
    [Address(RVA = "0x38C350", Offset = "0x38AF50", Length = "0x205")]
    public void Knockback(Vector3 dir, float knockback)
    {
    }

    [Token(Token = "0x60014E6")]
    [Address(RVA = "0x38D2C0", Offset = "0x38BEC0", Length = "0x4F")]
    public void Suck(Transform target)
    {
    }

    [Token(Token = "0x60014E7")]
    [Address(RVA = "0x38D2B0", Offset = "0x38BEB0", Length = "0x8")]
    public void StopSuck()
    {
    }

    [Token(Token = "0x60014E8")]
    [Address(RVA = "0x38A710", Offset = "0x389310", Length = "0x5D")]
    private bool CanFindNextPosition() => false;

    [Token(Token = "0x60014E9")]
    [Address(RVA = "0x38B9C0", Offset = "0x38A5C0", Length = "0x1B8")]
    private float GetNextStepTime(float distanceToTarget) => 0.0f;

    [Token(Token = "0x60014EA")]
    [Address(RVA = "0x38B8B0", Offset = "0x38A4B0", Length = "0x108")]
    private float GetNextGroundCheckOffset(float distanceToTarget) => 0.0f;

    [Token(Token = "0x60014EB")]
    [Address(RVA = "0x38DA10", Offset = "0x38C610", Length = "0x121")]
    public EnemyMovementRb()
    {
    }

    [Token(Token = "0x60014EC")]
    [Address(RVA = "0x38D9D0", Offset = "0x38C5D0", Length = "0x39")]
    static EnemyMovementRb()
    {
    }

    [Token(Token = "0x20002CC")]
    public enum State
    {
      [Token(Token = "0x4001334")] Normal,
      [Token(Token = "0x4001335")] Sucked,
      [Token(Token = "0x4001336")] Charmed,
    }
  }
}
