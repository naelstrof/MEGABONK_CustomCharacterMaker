// Decompiled with JetBrains decompiler
// Type: PlayerMovement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Movement;
using Assets.Scripts.Player.Movement;
using Cpp2ILInjected;
using System;
using UnityEngine;
using UnityEngine.Splines;

[Token(Token = "0x2000017")]
public class PlayerMovement : MonoBehaviour
{
  [Token(Token = "0x400005E")]
  [FieldOffset(Offset = "0x20")]
  public Transform playerCam;
  [Token(Token = "0x400005F")]
  [FieldOffset(Offset = "0x28")]
  public Transform orientation;
  [Token(Token = "0x4000060")]
  [FieldOffset(Offset = "0x30")]
  public Transform feet;
  [Token(Token = "0x4000061")]
  [FieldOffset(Offset = "0x38")]
  public Transform head;
  [Token(Token = "0x4000062")]
  [FieldOffset(Offset = "0x40")]
  public LayerMask whatIsGround;
  [Token(Token = "0x4000063")]
  [FieldOffset(Offset = "0x44")]
  public LayerMask whatIsGroundOnly;
  [Token(Token = "0x4000064")]
  [FieldOffset(Offset = "0x48")]
  private Rigidbody rb;
  [Token(Token = "0x4000065")]
  [FieldOffset(Offset = "0x50")]
  private float currentMoveSpeed;
  [Token(Token = "0x4000066")]
  [FieldOffset(Offset = "0x54")]
  private float currentMaxSpeed;
  [Token(Token = "0x4000067")]
  [FieldOffset(Offset = "0x58")]
  private float counterMovement;
  [Token(Token = "0x4000068")]
  [FieldOffset(Offset = "0x5C")]
  private float defaultCounterMovement;
  [Token(Token = "0x4000069")]
  [FieldOffset(Offset = "0x60")]
  private float threshold;
  [Token(Token = "0x400006A")]
  [FieldOffset(Offset = "0x64")]
  private int readyToCounterX;
  [Token(Token = "0x400006B")]
  [FieldOffset(Offset = "0x68")]
  private int readyToCounterY;
  [Token(Token = "0x400006C")]
  [FieldOffset(Offset = "0x6C")]
  private float slowDownSpeed;
  [Token(Token = "0x400006D")]
  [FieldOffset(Offset = "0x70")]
  private float pushMultiplier;
  [Token(Token = "0x400006E")]
  [FieldOffset(Offset = "0x74")]
  private float pushResetSpeed;
  [Token(Token = "0x400006F")]
  [FieldOffset(Offset = "0x78")]
  private float resetPushCounter;
  [Token(Token = "0x4000070")]
  [FieldOffset(Offset = "0x7C")]
  private float resetPushCounterValue;
  [Token(Token = "0x4000071")]
  [FieldOffset(Offset = "0x80")]
  private float maxSlopeAngle;
  [Token(Token = "0x4000072")]
  [FieldOffset(Offset = "0x84")]
  private float slideAngle;
  [Token(Token = "0x4000073")]
  [FieldOffset(Offset = "0x88")]
  private float minBreakFallAngle;
  [Token(Token = "0x4000074")]
  [FieldOffset(Offset = "0x8C")]
  private float maxBreakFallAngle;
  [Token(Token = "0x4000075")]
  [FieldOffset(Offset = "0x90")]
  private int surfaceDelay;
  [Token(Token = "0x4000076")]
  [FieldOffset(Offset = "0x94")]
  private int groundCancel;
  [Token(Token = "0x4000077")]
  [FieldOffset(Offset = "0x98")]
  private int surfCancel;
  [Token(Token = "0x4000078")]
  [FieldOffset(Offset = "0x9C")]
  private int climbCancel;
  [Token(Token = "0x4000079")]
  [FieldOffset(Offset = "0xA0")]
  public bool onRamp;
  [Token(Token = "0x400007A")]
  [FieldOffset(Offset = "0xA1")]
  private bool pushed;
  [Token(Token = "0x400007B")]
  [FieldOffset(Offset = "0xA2")]
  public bool grounded;
  [Token(Token = "0x400007C")]
  [FieldOffset(Offset = "0xA3")]
  private bool isUnderwater;
  [Token(Token = "0x400007D")]
  [FieldOffset(Offset = "0xA4")]
  private bool onGround;
  [Token(Token = "0x400007E")]
  [FieldOffset(Offset = "0xA5")]
  private bool surfing;
  [Token(Token = "0x400007F")]
  [FieldOffset(Offset = "0xA6")]
  private bool cancellingGrounded;
  [Token(Token = "0x4000080")]
  [FieldOffset(Offset = "0xA7")]
  private bool cancellingSurf;
  [Token(Token = "0x4000081")]
  [FieldOffset(Offset = "0xA8")]
  private Vector3 playerScale;
  [Token(Token = "0x4000082")]
  [FieldOffset(Offset = "0xB4")]
  private Vector3 crouchScale;
  [Token(Token = "0x4000083")]
  [FieldOffset(Offset = "0xC0")]
  private float slideCounterMovement;
  [Token(Token = "0x4000084")]
  public const float crouchRatio = 1f;
  [Token(Token = "0x4000085")]
  [FieldOffset(Offset = "0xC4")]
  private float playerHeight;
  [Token(Token = "0x4000086")]
  [FieldOffset(Offset = "0xC8")]
  private float slideThresholdSpeed;
  [Token(Token = "0x4000087")]
  [FieldOffset(Offset = "0xCC")]
  private bool readyToCrouch;
  [Token(Token = "0x4000088")]
  [FieldOffset(Offset = "0xCD")]
  private bool readyToSlide;
  [Token(Token = "0x4000089")]
  [FieldOffset(Offset = "0xCE")]
  private bool justLanded;
  [Token(Token = "0x400008A")]
  [FieldOffset(Offset = "0xCF")]
  private bool justUncrouched;
  [Token(Token = "0x400008B")]
  [FieldOffset(Offset = "0xD0")]
  private bool readyToJump;
  [Token(Token = "0x400008C")]
  [FieldOffset(Offset = "0xD4")]
  private int aerialJumps;
  [Token(Token = "0x400008D")]
  [FieldOffset(Offset = "0xD8")]
  private float x;
  [Token(Token = "0x400008E")]
  [FieldOffset(Offset = "0xDC")]
  private float y;
  [Token(Token = "0x400008F")]
  [FieldOffset(Offset = "0xE0")]
  private float mouseDeltaX;
  [Token(Token = "0x4000090")]
  [FieldOffset(Offset = "0xE4")]
  private float mouseDeltaY;
  [Token(Token = "0x4000091")]
  [FieldOffset(Offset = "0xE8")]
  private bool jumping;
  [Token(Token = "0x4000092")]
  [FieldOffset(Offset = "0xE9")]
  private bool crouching;
  [Token(Token = "0x4000094")]
  [FieldOffset(Offset = "0xF0")]
  private Vector3 normalVector;
  [Token(Token = "0x4000095")]
  [FieldOffset(Offset = "0x100")]
  private CapsuleCollider playerCollider;
  [Token(Token = "0x4000097")]
  [FieldOffset(Offset = "0x10C")]
  private float fallSpeed;
  [Token(Token = "0x4000098")]
  [FieldOffset(Offset = "0x110")]
  private Vector3 lastVelocity;
  [Token(Token = "0x4000099")]
  [FieldOffset(Offset = "0x11C")]
  private int resetJumpCounter;
  [Token(Token = "0x400009A")]
  [FieldOffset(Offset = "0x120")]
  private int jumpCounterResetTime;
  [Token(Token = "0x400009B")]
  [FieldOffset(Offset = "0x124")]
  private int crouchCooldownCounter;
  [Token(Token = "0x400009C")]
  [FieldOffset(Offset = "0x128")]
  private int crouchCooldownCounterMax;
  [Token(Token = "0x400009D")]
  [FieldOffset(Offset = "0x12C")]
  private int slideCooldownCounter;
  [Token(Token = "0x400009E")]
  [FieldOffset(Offset = "0x130")]
  private int slideCooldownCounterMax;
  [Token(Token = "0x400009F")]
  [FieldOffset(Offset = "0x134")]
  private int justLandedCounter;
  [Token(Token = "0x40000A0")]
  [FieldOffset(Offset = "0x138")]
  private int justLandedCounterMax;
  [Token(Token = "0x40000A1")]
  [FieldOffset(Offset = "0x13C")]
  private int justUncrouchedCounter;
  [Token(Token = "0x40000A2")]
  [FieldOffset(Offset = "0x140")]
  private int justUncrouchedCounterMax;
  [Token(Token = "0x40000A3")]
  [FieldOffset(Offset = "0x144")]
  private Vector3 headHeight;
  [Token(Token = "0x40000A4")]
  [FieldOffset(Offset = "0x150")]
  private Vector3 crouchHeadHeight;
  [Token(Token = "0x40000A5")]
  [FieldOffset(Offset = "0x15C")]
  private Vector3 feetHeight;
  [Token(Token = "0x40000A6")]
  public static Action<PlayerMovement> A_Jumped;
  [Token(Token = "0x40000A7")]
  public static Action<PlayerMovement> A_Crouched;
  [Token(Token = "0x40000A8")]
  public static Action<PlayerMovement> A_MovementState;
  [Token(Token = "0x40000A9")]
  public static PlayerMovement Instance;
  [Token(Token = "0x40000AA")]
  [FieldOffset(Offset = "0x168")]
  public PlayerMovementValues movementValues;
  [Token(Token = "0x40000AB")]
  [FieldOffset(Offset = "0x170")]
  private ECharacter currentCharacter;
  [Token(Token = "0x40000AC")]
  [FieldOffset(Offset = "0x174")]
  private EMovementState lastMovementState;
  [Token(Token = "0x40000AD")]
  [FieldOffset(Offset = "0x178")]
  public InputState inputState;
  [Token(Token = "0x40000AE")]
  [FieldOffset(Offset = "0x18C")]
  private bool frozen;
  [Token(Token = "0x40000AF")]
  [FieldOffset(Offset = "0x18D")]
  public bool isDashing;
  [Token(Token = "0x40000B0")]
  [FieldOffset(Offset = "0x190")]
  private float leftGroundAtTime;
  [Token(Token = "0x40000B1")]
  [FieldOffset(Offset = "0x198")]
  private Rail rail;
  [Token(Token = "0x40000B2")]
  [FieldOffset(Offset = "0x1A0")]
  private float railSpeed;
  [Token(Token = "0x40000B3")]
  [FieldOffset(Offset = "0x1A4")]
  private float progress;
  [Token(Token = "0x40000B4")]
  [FieldOffset(Offset = "0x1A8")]
  private float railDirectionMultiplier;
  [Token(Token = "0x40000B5")]
  [FieldOffset(Offset = "0x1AC")]
  private float canJumpOffRailTime;
  [Token(Token = "0x40000B6")]
  [FieldOffset(Offset = "0x1B0")]
  private float canJumpOffRailAtTime;
  [Token(Token = "0x40000B7")]
  [FieldOffset(Offset = "0x1B4")]
  private Vector3 railOffsetPosition;
  [Token(Token = "0x40000B8")]
  [FieldOffset(Offset = "0x1C0")]
  private Vector3 railOffsetPositionStart;
  [Token(Token = "0x40000B9")]
  [FieldOffset(Offset = "0x1CC")]
  private float railOffsetPositionTimer;
  [Token(Token = "0x40000BA")]
  [FieldOffset(Offset = "0x1D0")]
  private float railLerpTime;
  [Token(Token = "0x40000BB")]
  public static Action<bool> A_ToggleGrind;
  [Token(Token = "0x40000BC")]
  [FieldOffset(Offset = "0x1D8")]
  public PlayerSfxs playerSfx;
  [Token(Token = "0x40000BD")]
  public static Action A_StartedWallClimb;
  [Token(Token = "0x40000BE")]
  [FieldOffset(Offset = "0x1E0")]
  private float minWallClimbSpeed;
  [Token(Token = "0x40000BF")]
  [FieldOffset(Offset = "0x1E4")]
  private float wallClimbCooldown;
  [Token(Token = "0x40000C0")]
  [FieldOffset(Offset = "0x1E8")]
  private float canWallClimbAtTime;
  [Token(Token = "0x40000C1")]
  [FieldOffset(Offset = "0x1EC")]
  private float wallrunAttachAngle;
  [Token(Token = "0x40000C4")]
  [FieldOffset(Offset = "0x208")]
  private bool isNoclipping;
  [Token(Token = "0x40000C5")]
  [FieldOffset(Offset = "0x20C")]
  private FrictionModifier.EFrictionSurface surface;
  [Token(Token = "0x40000C6")]
  [FieldOffset(Offset = "0x210")]
  private GameObject groundedObject;
  [Token(Token = "0x40000C7")]
  [FieldOffset(Offset = "0x218")]
  private float unstuckForce;
  [Token(Token = "0x40000C8")]
  [FieldOffset(Offset = "0x21C")]
  private float stuckTimer;
  [Token(Token = "0x40000C9")]
  [FieldOffset(Offset = "0x220")]
  private float stuckTimerMax;
  [Token(Token = "0x40000CA")]
  [FieldOffset(Offset = "0x224")]
  private float lastFallSpeed;
  [Token(Token = "0x40000CB")]
  [FieldOffset(Offset = "0x228")]
  private float lastTouchedWallTime;
  [Token(Token = "0x40000CC")]
  public static Action<Vector3> CameraBob;
  [Token(Token = "0x40000CD")]
  public static Action<float> A_Landed;
  [Token(Token = "0x40000CE")]
  public static Action<Vector3, float> A_LandedSmoke;
  [Token(Token = "0x40000CF")]
  public static Action<float> Shake;
  [Token(Token = "0x40000D0")]
  [FieldOffset(Offset = "0x22C")]
  private bool wallClimbing;
  [Token(Token = "0x40000D1")]
  public static Action<bool> A_Grounded;
  [Token(Token = "0x40000D2")]
  public static Action<PlayerMovement> A_SlideStart;
  [Token(Token = "0x40000D3")]
  public static Action<PlayerMovement> A_Wallrun;
  [Token(Token = "0x40000D4")]
  [FieldOffset(Offset = "0x230")]
  private float jumpAnimationCooldownSlide;
  [Token(Token = "0x40000D5")]
  [FieldOffset(Offset = "0x234")]
  private float jumpedTime;
  [Token(Token = "0x40000D6")]
  [FieldOffset(Offset = "0x238")]
  private float landedAtTime;
  [Token(Token = "0x40000D7")]
  [FieldOffset(Offset = "0x23C")]
  private float landingJumpCooldownPegeMode;
  [Token(Token = "0x40000D8")]
  [FieldOffset(Offset = "0x240")]
  private int climbCancelTicks;
  [Token(Token = "0x40000D9")]
  [FieldOffset(Offset = "0x244")]
  private float avgVelocity;
  [Token(Token = "0x40000DA")]
  [FieldOffset(Offset = "0x248")]
  private Vector3 standingFeetOffset;
  [Token(Token = "0x40000DB")]
  [FieldOffset(Offset = "0x254")]
  private Vector3 crouchingFeetOffset;
  [Token(Token = "0x40000DC")]
  [FieldOffset(Offset = "0x260")]
  private float lastTouchedTornadoTime;

  [field: Token(Token = "0x4000093")]
  [field: FieldOffset(Offset = "0xEC")]
  [Token(Token = "0x17000001")]
  public PlayerMovement.CrouchState crouchState { [Token(Token = "0x600004E"), Address(RVA = "0x34C5D0", Offset = "0x34B1D0", Length = "0x7")] get; [Token(Token = "0x600004F"), Address(RVA = "0x34C630", Offset = "0x34B230", Length = "0x7")] private set; }

  [field: Token(Token = "0x4000096")]
  [field: FieldOffset(Offset = "0x108")]
  [Token(Token = "0x17000002")]
  public float playerRadius { [Token(Token = "0x6000050"), Address(RVA = "0x345910", Offset = "0x344510", Length = "0x9")] get; [Token(Token = "0x6000051"), Address(RVA = "0x34C670", Offset = "0x34B270", Length = "0x9")] private set; }

  [Token(Token = "0x6000052")]
  [Address(RVA = "0x34BBF0", Offset = "0x34A7F0", Length = "0xA5")]
  private void UpdateTickRate(int tickRate)
  {
  }

  [Token(Token = "0x6000053")]
  [Address(RVA = "0x343780", Offset = "0x342380", Length = "0x21D")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000054")]
  [Address(RVA = "0x3492D0", Offset = "0x347ED0", Length = "0x21D")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000055")]
  [Address(RVA = "0x3494F0", Offset = "0x3480F0", Length = "0xE0")]
  private void OnWaterEnter(Water water)
  {
  }

  [Token(Token = "0x6000056")]
  [Address(RVA = "0x3495E0", Offset = "0x3481E0", Length = "0x8")]
  private void OnWaterExit(Water water)
  {
  }

  [Token(Token = "0x6000057")]
  [Address(RVA = "0x346850", Offset = "0x345450", Length = "0x67")]
  private bool IsInitialized() => false;

  [Token(Token = "0x6000058")]
  [Address(RVA = "0x346010", Offset = "0x344C10", Length = "0x491")]
  private void Initialize()
  {
  }

  [Token(Token = "0x6000059")]
  [Address(RVA = "0x34A1A0", Offset = "0x348DA0", Length = "0x280")]
  public void ResetState(ECharacter character, Vector3 dir)
  {
  }

  [Token(Token = "0x600005A")]
  [Address(RVA = "0x34A430", Offset = "0x349030", Length = "0x39")]
  public void SetBetterInput(InputState input)
  {
  }

  [Token(Token = "0x600005B")]
  [Address(RVA = "0x3455C0", Offset = "0x3441C0", Length = "0x24")]
  public void Freeze(bool b)
  {
  }

  [Token(Token = "0x600005C")]
  [Address(RVA = "0x3479F0", Offset = "0x3465F0", Length = "0xD95")]
  public void MovementTick()
  {
  }

  [Token(Token = "0x600005D")]
  [Address(RVA = "0x34A790", Offset = "0x349390", Length = "0x4BD")]
  public void StartRail(Rail rail)
  {
  }

  [Token(Token = "0x600005E")]
  [Address(RVA = "0x34B250", Offset = "0x349E50", Length = "0x302")]
  public void StopRail()
  {
  }

  [Token(Token = "0x600005F")]
  [Address(RVA = "0x349730", Offset = "0x348330", Length = "0x322")]
  private void RailMovement()
  {
  }

  [Token(Token = "0x6000060")]
  [Address(RVA = "0x345920", Offset = "0x344520", Length = "0x159")]
  private Vector3 GetRailPosition() => new Vector3();

  [Token(Token = "0x6000061")]
  [Address(RVA = "0x343C10", Offset = "0x342810", Length = "0x59")]
  public bool CanStartGrind() => false;

  [Token(Token = "0x6000062")]
  [Address(RVA = "0x346720", Offset = "0x345320", Length = "0x53")]
  public bool IsGrinding() => false;

  [Token(Token = "0x6000063")]
  [Address(RVA = "0x3456E0", Offset = "0x3442E0", Length = "0x75")]
  public Vector3 GetGrindNormal() => new Vector3();

  [Token(Token = "0x6000064")]
  [Address(RVA = "0x345620", Offset = "0x344220", Length = "0xB5")]
  public Vector3 GetGrindDirection() => new Vector3();

  [Token(Token = "0x6000065")]
  [Address(RVA = "0x345400", Offset = "0x344000", Length = "0x1B1")]
  private float FindClosestPointOnSpline(SplineContainer spline, Vector3 position) => 0.0f;

  [Token(Token = "0x6000066")]
  [Address(RVA = "0x345DB0", Offset = "0x3449B0", Length = "0x1C")]
  private float GetWallClimbSpeed() => 0.0f;

  [Token(Token = "0x6000067")]
  [Address(RVA = "0x34C020", Offset = "0x34AC20", Length = "0x187")]
  private void WallClimbing()
  {
  }

  [Token(Token = "0x6000068")]
  [Address(RVA = "0x344040", Offset = "0x342C40", Length = "0x1A7")]
  private bool CanWallClimb(Vector3 normal, Collision other) => false;

  [Token(Token = "0x6000069")]
  [Address(RVA = "0x34B590", Offset = "0x34A190", Length = "0x66")]
  private void StopWallClimbing()
  {
  }

  [Token(Token = "0x600006A")]
  [Address(RVA = "0x346D20", Offset = "0x345920", Length = "0x10")]
  public bool IsWallClimbing() => false;

  [field: Token(Token = "0x40000C2")]
  [field: FieldOffset(Offset = "0x1F0")]
  [Token(Token = "0x17000003")]
  public Vector3 wallNormal { [Token(Token = "0x600006B"), Address(RVA = "0x34C610", Offset = "0x34B210", Length = "0x19")] get; [Token(Token = "0x600006C"), Address(RVA = "0x34C680", Offset = "0x34B280", Length = "0x16")] private set; }

  [Token(Token = "0x600006D")]
  [Address(RVA = "0x344390", Offset = "0x342F90", Length = "0x3E")]
  private bool CheckIfPlayerWantsToWallClimb(Vector3 normal) => false;

  [Token(Token = "0x600006E")]
  [Address(RVA = "0x349D30", Offset = "0x348930", Length = "0x3DE")]
  private float RelativeToLook(Vector3 normal) => 0.0f;

  [Token(Token = "0x600006F")]
  [Address(RVA = "0x3464B0", Offset = "0x3450B0", Length = "0x11B")]
  private Vector3 InputVectorRelativeToLook() => new Vector3();

  [Token(Token = "0x6000070")]
  [Address(RVA = "0x34BD50", Offset = "0x34A950", Length = "0x2C0")]
  private void VerifyPosition()
  {
  }

  [Token(Token = "0x6000071")]
  [Address(RVA = "0x34B600", Offset = "0x34A200", Length = "0x234")]
  public void TeleportPlayerBackToBounds(Vector3 pos)
  {
  }

  [field: Token(Token = "0x40000C3")]
  [field: FieldOffset(Offset = "0x1FC")]
  [Token(Token = "0x17000004")]
  public Vector3 lastGroundedPosition { [Token(Token = "0x6000072"), Address(RVA = "0x34C5F0", Offset = "0x34B1F0", Length = "0x19")] get; [Token(Token = "0x6000073"), Address(RVA = "0x34C650", Offset = "0x34B250", Length = "0x16")] private set; }

  [Token(Token = "0x6000074")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void Update()
  {
  }

  [Token(Token = "0x6000075")]
  [Address(RVA = "0x348790", Offset = "0x347390", Length = "0x296")]
  private void NoclipMovement()
  {
  }

  [Token(Token = "0x6000076")]
  [Address(RVA = "0x3457A0", Offset = "0x3443A0", Length = "0x67")]
  public Vector2 GetLocalVelocity() => new Vector2();

  [Token(Token = "0x6000077")]
  [Address(RVA = "0x343590", Offset = "0x342190", Length = "0xDA")]
  public static Vector3 AirAccelerate(
    Vector3 velocity,
    Vector3 wishdir,
    float wishspeed,
    float accel,
    float airCap,
    float deltaTime,
    float gainMultiplier = 1f)
  {
    return new Vector3();
  }

  [Token(Token = "0x6000078")]
  [Address(RVA = "0x345DD0", Offset = "0x3449D0", Length = "0x12A")]
  public Vector3 GetWishDir() => new Vector3();

  [Token(Token = "0x6000079")]
  [Address(RVA = "0x3457A0", Offset = "0x3443A0", Length = "0x67")]
  public Vector2 VelRelativeToLook() => new Vector2();

  [Token(Token = "0x600007A")]
  [Address(RVA = "0x348A30", Offset = "0x347630", Length = "0x38D")]
  private void OnCollisionEnter(Collision other)
  {
  }

  [Token(Token = "0x600007B")]
  [Address(RVA = "0x3445E0", Offset = "0x3431E0", Length = "0x1AD")]
  private void CheckLanding(Vector3 point, Vector3 normal)
  {
  }

  [Token(Token = "0x600007C")]
  [Address(RVA = "0x344790", Offset = "0x343390", Length = "0x224")]
  private void CheckStuck()
  {
  }

  [Token(Token = "0x600007D")]
  [Address(RVA = "0x3441F0", Offset = "0x342DF0", Length = "0x19D")]
  private void CheckFallDamageBug()
  {
  }

  [Token(Token = "0x600007E")]
  [Address(RVA = "0x343F90", Offset = "0x342B90", Length = "0xB0")]
  public bool CanTakeFallDamage(Vector3 normal) => false;

  [Token(Token = "0x600007F")]
  [Address(RVA = "0x348DC0", Offset = "0x3479C0", Length = "0x501")]
  private void OnCollisionStay(Collision other)
  {
  }

  [Token(Token = "0x6000080")]
  [Address(RVA = "0x34A6A0", Offset = "0x3492A0", Length = "0xE3")]
  private void StartGrounded()
  {
  }

  [Token(Token = "0x6000081")]
  [Address(RVA = "0x34B940", Offset = "0x34A540", Length = "0x211")]
  private void UpdateCooldowns()
  {
  }

  [Token(Token = "0x6000082")]
  [Address(RVA = "0x3443D0", Offset = "0x342FD0", Length = "0x20C")]
  private void CheckInput()
  {
  }

  [Token(Token = "0x6000083")]
  [Address(RVA = "0x34A510", Offset = "0x349110", Length = "0x182")]
  private void StartCrouch()
  {
  }

  [Token(Token = "0x6000084")]
  [Address(RVA = "0x34B090", Offset = "0x349C90", Length = "0x44")]
  private void StopCrouch()
  {
  }

  [Token(Token = "0x6000085")]
  [Address(RVA = "0x343C70", Offset = "0x342870", Length = "0x318")]
  private bool CanStopCrouching() => false;

  [Token(Token = "0x6000086")]
  [Address(RVA = "0x346680", Offset = "0x345280", Length = "0xB")]
  public bool IsCrouching() => false;

  [Token(Token = "0x6000087")]
  [Address(RVA = "0x34BCA0", Offset = "0x34A8A0", Length = "0xA0")]
  private bool UseLimitedMovement() => false;

  [Token(Token = "0x6000088")]
  [Address(RVA = "0x34AC50", Offset = "0x349850", Length = "0x436")]
  private void StartSlide()
  {
  }

  [Token(Token = "0x6000089")]
  [Address(RVA = "0x34B560", Offset = "0x34A160", Length = "0x12")]
  private void StopSlide()
  {
  }

  [Token(Token = "0x600008A")]
  [Address(RVA = "0x346A50", Offset = "0x345650", Length = "0xB")]
  public bool IsSliding() => false;

  [Token(Token = "0x600008B")]
  [Address(RVA = "0x3469C0", Offset = "0x3455C0", Length = "0x86")]
  public bool IsSlidingAnimation() => false;

  [Token(Token = "0x600008C")]
  [Address(RVA = "0x34BB60", Offset = "0x34A760", Length = "0x81")]
  private void UpdateCrouchState()
  {
  }

  [Token(Token = "0x600008D")]
  [Address(RVA = "0x34C1B0", Offset = "0x34ADB0", Length = "0x2E6")]
  private void WaterMovement()
  {
  }

  [Token(Token = "0x600008E")]
  [Address(RVA = "0x346D10", Offset = "0x345910", Length = "0x8")]
  private bool IsUnderwater() => false;

  [Token(Token = "0x600008F")]
  [Address(RVA = "0x349A60", Offset = "0x348660", Length = "0x2B8")]
  private void RampMovement(Vector2 mag)
  {
  }

  [Token(Token = "0x6000090")]
  [Address(RVA = "0x349620", Offset = "0x348220", Length = "0x101")]
  public void RocketJump(Vector3 pushForce)
  {
  }

  [Token(Token = "0x6000091")]
  [Address(RVA = "0x349620", Offset = "0x348220", Length = "0x101")]
  public void PushPlayer(Vector3 pushForce)
  {
  }

  [Token(Token = "0x6000092")]
  [Address(RVA = "0x3495F0", Offset = "0x3481F0", Length = "0x2E")]
  public void PushPlayerButKeepMovement()
  {
  }

  [Token(Token = "0x6000093")]
  [Address(RVA = "0x3439A0", Offset = "0x3425A0", Length = "0x14A")]
  public void BouncePlayer(Vector3 pushForce)
  {
  }

  [Token(Token = "0x6000094")]
  [Address(RVA = "0x349D20", Offset = "0x348920", Length = "0xB")]
  public bool RecentlyJumped() => false;

  [Token(Token = "0x6000095")]
  [Address(RVA = "0x346B00", Offset = "0x345700", Length = "0x20C")]
  public bool IsTouchingGround() => false;

  [Token(Token = "0x6000096")]
  [Address(RVA = "0x345F00", Offset = "0x344B00", Length = "0x10F")]
  public bool HasFooting() => false;

  [Token(Token = "0x6000097")]
  [Address(RVA = "0x343670", Offset = "0x342270", Length = "0x10F")]
  private bool AreFeetTouchingFloor() => false;

  [Token(Token = "0x6000098")]
  [Address(RVA = "0x34A470", Offset = "0x349070", Length = "0x98")]
  private void SetKinematic(bool b)
  {
  }

  [Token(Token = "0x6000099")]
  [Address(RVA = "0x3465D0", Offset = "0x3451D0", Length = "0xA7")]
  private bool IsBreakingFall(Vector3 normal) => false;

  [Token(Token = "0x600009A")]
  [Address(RVA = "0x343B50", Offset = "0x342750", Length = "0xB6")]
  private bool CanJump() => false;

  [Token(Token = "0x600009B")]
  [Address(RVA = "0x34A110", Offset = "0x348D10", Length = "0x88")]
  private void ResetAerialJumps()
  {
  }

  [Token(Token = "0x600009C")]
  [Address(RVA = "0x346E00", Offset = "0x345A00", Length = "0xBE4")]
  public void Jump()
  {
  }

  [Token(Token = "0x600009D")]
  [Address(RVA = "0x345760", Offset = "0x344360", Length = "0x3F")]
  private float GetJumpForce() => 0.0f;

  [Token(Token = "0x600009E")]
  [Address(RVA = "0x3449C0", Offset = "0x3435C0", Length = "0x990")]
  private void CounterMovement(float x, float y, Vector2 mag)
  {
  }

  [Token(Token = "0x600009F")]
  [Address(RVA = "0x346780", Offset = "0x345380", Length = "0x43")]
  private bool IsHoldingAgainstHorizontalVel(Vector2 vel) => false;

  [Token(Token = "0x60000A0")]
  [Address(RVA = "0x3467D0", Offset = "0x3453D0", Length = "0x43")]
  private bool IsHoldingAgainstVerticalVel(Vector2 vel) => false;

  [Token(Token = "0x60000A1")]
  [Address(RVA = "0x346690", Offset = "0x345290", Length = "0x88")]
  private bool IsFloor(Vector3 v) => false;

  [Token(Token = "0x60000A2")]
  [Address(RVA = "0x346930", Offset = "0x345530", Length = "0x84")]
  private bool IsSlideable(Vector3 v) => false;

  [Token(Token = "0x60000A3")]
  [Address(RVA = "0x346A60", Offset = "0x345660", Length = "0x9E")]
  private bool IsSurf(Vector3 v) => false;

  [Token(Token = "0x60000A4")]
  [Address(RVA = "0x346D30", Offset = "0x345930", Length = "0xCD")]
  private bool IsWall(Vector3 v) => false;

  [Token(Token = "0x60000A5")]
  [Address(RVA = "0x3468C0", Offset = "0x3454C0", Length = "0x6C")]
  private bool IsRoof(Vector3 v) => false;

  [Token(Token = "0x60000A6")]
  [Address(RVA = "0x34B8B0", Offset = "0x34A4B0", Length = "0x8F")]
  private void UpdateCollisionChecks()
  {
  }

  [Token(Token = "0x60000A7")]
  [Address(RVA = "0x34B190", Offset = "0x349D90", Length = "0xB9")]
  private void StopGrounded()
  {
  }

  [Token(Token = "0x60000A8")]
  [Address(RVA = "0x34B580", Offset = "0x34A180", Length = "0x8")]
  private void StopSurf()
  {
  }

  [Token(Token = "0x60000A9")]
  [Address(RVA = "0x345D70", Offset = "0x344970", Length = "0x3B")]
  public Vector3 GetVelocity() => new Vector3();

  [Token(Token = "0x60000AA")]
  [Address(RVA = "0x3455F0", Offset = "0x3441F0", Length = "0x9")]
  public float GetAverageVelocity() => 0.0f;

  [Token(Token = "0x60000AB")]
  [Address(RVA = "0x345C50", Offset = "0x344850", Length = "0xCD")]
  public float GetSpeedHorizontal() => 0.0f;

  [Token(Token = "0x60000AC")]
  [Address(RVA = "0x345D20", Offset = "0x344920", Length = "0x41")]
  public float GetSpeed() => 0.0f;

  [Token(Token = "0x60000AD")]
  [Address(RVA = "0x345600", Offset = "0x344200", Length = "0x9")]
  public float GetFallSpeed() => 0.0f;

  [Token(Token = "0x60000AE")]
  [Address(RVA = "0x345900", Offset = "0x344500", Length = "0x8")]
  public Collider GetPlayerCollider() => (Collider) null;

  [Token(Token = "0x60000AF")]
  [Address(RVA = "0x3458E0", Offset = "0x3444E0", Length = "0x1D")]
  public Transform GetPlayerCamTransform() => (Transform) null;

  [Token(Token = "0x60000B0")]
  [Address(RVA = "0x345C40", Offset = "0x344840", Length = "0x5")]
  public Rigidbody GetRb() => (Rigidbody) null;

  [Token(Token = "0x60000B1")]
  [Address(RVA = "0x34B0E0", Offset = "0x349CE0", Length = "0xAE")]
  public void StopFallVelocity()
  {
  }

  [Token(Token = "0x60000B2")]
  [Address(RVA = "0x345A80", Offset = "0x344680", Length = "0x10B")]
  public Vector3 GetRbFeetPosition() => new Vector3();

  [Token(Token = "0x60000B3")]
  [Address(RVA = "0x345B90", Offset = "0x344790", Length = "0xAD")]
  public Vector3 GetRbHeadPosition() => new Vector3();

  [Token(Token = "0x60000B4")]
  [Address(RVA = "0x345360", Offset = "0x343F60", Length = "0x95")]
  public Vector3 FeetPositionToRb(Vector3 feetPos, bool wasCrouching = false) => new Vector3();

  [Token(Token = "0x60000B5")]
  [Address(RVA = "0x343AF0", Offset = "0x3426F0", Length = "0x5E")]
  public bool CanFloat() => false;

  [Token(Token = "0x60000B6")]
  [Address(RVA = "0x345610", Offset = "0x344210", Length = "0x9")]
  public float GetFeetOffset() => 0.0f;

  [Token(Token = "0x60000B7")]
  [Address(RVA = "0x345810", Offset = "0x344410", Length = "0xA2")]
  public EMovementState GetMovementState() => new EMovementState();

  [Token(Token = "0x60000B8")]
  [Address(RVA = "0x345910", Offset = "0x344510", Length = "0x9")]
  public float GetPlayerRadius() => 0.0f;

  [Token(Token = "0x60000B9")]
  [Address(RVA = "0x3458C0", Offset = "0x3444C0", Length = "0x19")]
  public Vector3 GetNormal() => new Vector3();

  [Token(Token = "0x60000BA")]
  [Address(RVA = "0x346820", Offset = "0x345420", Length = "0x27")]
  public bool IsHoldingMovement() => false;

  [field: Token(Token = "0x40000DD")]
  [field: FieldOffset(Offset = "0x264")]
  [Token(Token = "0x17000005")]
  public bool isTouchingTornado { [Token(Token = "0x60000BB"), Address(RVA = "0x34C5E0", Offset = "0x34B1E0", Length = "0x8")] get; [Token(Token = "0x60000BC"), Address(RVA = "0x34C640", Offset = "0x34B240", Length = "0x7")] private set; }

  [Token(Token = "0x60000BD")]
  [Address(RVA = "0x34B840", Offset = "0x34A440", Length = "0x61")]
  public void TouchingTornado()
  {
  }

  [Token(Token = "0x60000BE")]
  [Address(RVA = "0x34C4A0", Offset = "0x34B0A0", Length = "0x12E")]
  public PlayerMovement()
  {
  }

  [Token(Token = "0x2000018")]
  public enum CrouchState
  {
    [Token(Token = "0x40000DF")] None,
    [Token(Token = "0x40000E0")] Crouching,
    [Token(Token = "0x40000E1")] Sliding,
  }
}
