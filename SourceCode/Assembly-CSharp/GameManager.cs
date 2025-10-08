// Decompiled with JetBrains decompiler
// Type: GameManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Player;
using Cpp2ILInjected;
using System;
using System.Collections;
using UnityEngine;

[Token(Token = "0x20000D4")]
public class GameManager : MonoBehaviour
{
  [Token(Token = "0x400070A")]
  [FieldOffset(Offset = "0x20")]
  public LayerMask whatIsGround;
  [Token(Token = "0x400070B")]
  [FieldOffset(Offset = "0x24")]
  public LayerMask whatIsProjectileRaycast;
  [Token(Token = "0x400070C")]
  [FieldOffset(Offset = "0x28")]
  public LayerMask whatIsEnemy;
  [Token(Token = "0x400070D")]
  [FieldOffset(Offset = "0x2C")]
  public LayerMask whatIsObjects;
  [Token(Token = "0x400070E")]
  [FieldOffset(Offset = "0x30")]
  public LayerMask whatIsPlayer;
  [Token(Token = "0x400070F")]
  [FieldOffset(Offset = "0x34")]
  public LayerMask whatIsGroundAndObjects;
  [Token(Token = "0x4000710")]
  [FieldOffset(Offset = "0x38")]
  public LayerMask whatIsCameraCollision;
  [Token(Token = "0x4000711")]
  [FieldOffset(Offset = "0x3C")]
  public LayerMask whatIsBlockingRails;
  [Token(Token = "0x4000712")]
  [FieldOffset(Offset = "0x40")]
  public LayerMask whatIsProjectileObstruction;
  [Token(Token = "0x4000713")]
  [FieldOffset(Offset = "0x44")]
  private float gameTimer;
  [Token(Token = "0x4000714")]
  public static GameManager Instance;
  [Token(Token = "0x4000715")]
  public static Action A_StageStarted;
  [Token(Token = "0x4000716")]
  public static Action A_RunStarted;
  [Token(Token = "0x4000717")]
  public static Action A_GameOver;
  [Token(Token = "0x4000718")]
  [FieldOffset(Offset = "0x48")]
  public MyPlayer player;
  [Token(Token = "0x4000719")]
  [FieldOffset(Offset = "0x50")]
  public PlayerCamera playerCamera;
  [Token(Token = "0x400071A")]
  [FieldOffset(Offset = "0x58")]
  public UiManager uiManager;
  [Token(Token = "0x400071B")]
  [FieldOffset(Offset = "0x60")]
  public int bossCurses;
  [Token(Token = "0x400071C")]
  [FieldOffset(Offset = "0x64")]
  private bool inited;
  [Token(Token = "0x400071D")]
  [FieldOffset(Offset = "0x68")]
  public float totalStageTime;
  [Token(Token = "0x400071E")]
  public const float finalBossFightTime = 600f;
  [Token(Token = "0x4000720")]
  [FieldOffset(Offset = "0x6D")]
  private bool isPlaying;
  [Token(Token = "0x4000721")]
  [FieldOffset(Offset = "0x6E")]
  public bool cutscene;

  [Token(Token = "0x60005EB")]
  [Address(RVA = "0x49B230", Offset = "0x499E30", Length = "0x7")]
  private void Awake()
  {
  }

  [Token(Token = "0x60005EC")]
  [Address(RVA = "0x49BD40", Offset = "0x49A940", Length = "0x30A")]
  private void TryInit()
  {
  }

  [Token(Token = "0x60005ED")]
  [Address(RVA = "0x49B240", Offset = "0x499E40", Length = "0x4A")]
  public void CreateInstances()
  {
  }

  [Token(Token = "0x60005EE")]
  [Address(RVA = "0x49BC40", Offset = "0x49A840", Length = "0xF2")]
  private void Start()
  {
  }

  [Token(Token = "0x60005EF")]
  [Address(RVA = "0x49B730", Offset = "0x49A330", Length = "0x246")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60005F0")]
  [Address(RVA = "0x49C050", Offset = "0x49AC50", Length = "0xB9")]
  private void Update()
  {
  }

  [Token(Token = "0x60005F1")]
  [Address(RVA = "0x49B390", Offset = "0x499F90", Length = "0x86")]
  public PlayerMovement GetPlayerMovement() => (PlayerMovement) null;

  [Token(Token = "0x60005F2")]
  [Address(RVA = "0x49B420", Offset = "0x49A020", Length = "0xB6")]
  public MyPlayer GetPlayer() => (MyPlayer) null;

  [Token(Token = "0x60005F3")]
  [Address(RVA = "0x4489D0", Offset = "0x4475D0", Length = "0x6")]
  public float GetAliveTime() => 0.0f;

  [Token(Token = "0x60005F4")]
  [Address(RVA = "0x49B300", Offset = "0x499F00", Length = "0x8F")]
  public PlayerInventory GetPlayerInventory() => (PlayerInventory) null;

  [field: Token(Token = "0x400071F")]
  [field: FieldOffset(Offset = "0x6C")]
  [Token(Token = "0x1700002F")]
  public bool isGameOver { [Token(Token = "0x60005F5"), Address(RVA = "0x49C110", Offset = "0x49AD10", Length = "0x5")] get; [Token(Token = "0x60005F6"), Address(RVA = "0x49C120", Offset = "0x49AD20", Length = "0x4")] private set; }

  [Token(Token = "0x60005F7")]
  [Address(RVA = "0x49B980", Offset = "0x49A580", Length = "0xA3")]
  private void OnDied()
  {
  }

  [Token(Token = "0x60005F8")]
  [Address(RVA = "0x49BBD0", Offset = "0x49A7D0", Length = "0x57")]
  public void OnTeleportAway()
  {
  }

  [Token(Token = "0x60005F9")]
  [Address(RVA = "0x49B290", Offset = "0x499E90", Length = "0x4B")]
  private IEnumerator DoDeathAnimation() => (IEnumerator) null;

  [Token(Token = "0x60005FA")]
  [Address(RVA = "0x49B5A0", Offset = "0x49A1A0", Length = "0xC4")]
  public bool IsFinalSwarm() => false;

  [Token(Token = "0x60005FB")]
  [Address(RVA = "0x49B4F0", Offset = "0x49A0F0", Length = "0x9")]
  public static float GetViewDistance() => 0.0f;

  [Token(Token = "0x60005FC")]
  [Address(RVA = "0x49B4E0", Offset = "0x49A0E0", Length = "0x9")]
  public static float GetViewDistanceSqr() => 0.0f;

  [Token(Token = "0x60005FD")]
  [Address(RVA = "0x49B2F0", Offset = "0x499EF0", Length = "0x9")]
  public static float GetEnemyTeleportDistance() => 0.0f;

  [Token(Token = "0x60005FE")]
  [Address(RVA = "0x49B2E0", Offset = "0x499EE0", Length = "0x9")]
  public static float GetEnemyTeleportDistanceSqr() => 0.0f;

  [Token(Token = "0x60005FF")]
  [Address(RVA = "0x49B680", Offset = "0x49A280", Length = "0xAC")]
  public bool IsTimeFreeze() => false;

  [Token(Token = "0x6000600")]
  [Address(RVA = "0x49B670", Offset = "0x49A270", Length = "0x5")]
  public bool IsPlaying() => false;

  [Token(Token = "0x6000601")]
  [Address(RVA = "0x49B500", Offset = "0x49A100", Length = "0x93")]
  public bool IsFinalBossDead() => false;

  [Token(Token = "0x6000602")]
  [Address(RVA = "0x49BC30", Offset = "0x49A830", Length = "0x5")]
  public void StartPlaying()
  {
  }

  [Token(Token = "0x6000603")]
  [Address(RVA = "0x49BA30", Offset = "0x49A630", Length = "0x191")]
  private void OnStageBossDied()
  {
  }

  [Token(Token = "0x6000604")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public GameManager()
  {
  }
}
