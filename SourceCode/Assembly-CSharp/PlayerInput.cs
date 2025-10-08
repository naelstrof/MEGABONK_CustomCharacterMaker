// Decompiled with JetBrains decompiler
// Type: PlayerInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Interactables;
using Assets.Scripts.Player.Movement;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200001B")]
public class PlayerInput : MonoBehaviour
{
  [Token(Token = "0x40000E6")]
  [FieldOffset(Offset = "0x20")]
  public DetectInteractables detectInteractables;
  [Token(Token = "0x40000E7")]
  [FieldOffset(Offset = "0x28")]
  private float moveHorizontal;
  [Token(Token = "0x40000E8")]
  [FieldOffset(Offset = "0x2C")]
  private float moveVertical;
  [Token(Token = "0x40000E9")]
  [FieldOffset(Offset = "0x30")]
  private bool jumping;
  [Token(Token = "0x40000EA")]
  [FieldOffset(Offset = "0x31")]
  private bool interacting;
  [Token(Token = "0x40000EB")]
  [FieldOffset(Offset = "0x32")]
  private bool sliding;
  [Token(Token = "0x40000EC")]
  [FieldOffset(Offset = "0x33")]
  private bool aiming;
  [Token(Token = "0x40000ED")]
  [FieldOffset(Offset = "0x34")]
  private bool holdingJump;
  [Token(Token = "0x40000EE")]
  [FieldOffset(Offset = "0x38")]
  public Vector3 cameraRotation;
  [Token(Token = "0x40000EF")]
  [FieldOffset(Offset = "0x44")]
  private Vector3 desiredCameraRotation;
  [Token(Token = "0x40000F0")]
  [FieldOffset(Offset = "0x50")]
  private float cameraSmoothingMin;
  [Token(Token = "0x40000F1")]
  [FieldOffset(Offset = "0x54")]
  private float cameraSmoothingMax;
  [Token(Token = "0x40000F2")]
  [FieldOffset(Offset = "0x58")]
  private int jumpBufferTicks;
  [Token(Token = "0x40000F3")]
  [FieldOffset(Offset = "0x5C")]
  private int currentJumpBufferTick;

  [Token(Token = "0x60000CA")]
  [Address(RVA = "0x341D60", Offset = "0x340960", Length = "0x138")]
  private void Awake()
  {
  }

  [Token(Token = "0x60000CB")]
  [Address(RVA = "0x343070", Offset = "0x341C70", Length = "0x138")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60000CC")]
  [Address(RVA = "0x343390", Offset = "0x341F90", Length = "0x1DD")]
  private void Update()
  {
  }

  [Token(Token = "0x60000CD")]
  [Address(RVA = "0x3423E0", Offset = "0x340FE0", Length = "0x1B2")]
  public Vector3 GetWishDir() => new Vector3();

  [Token(Token = "0x60000CE")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void TestInput()
  {
  }

  [Token(Token = "0x60000CF")]
  [Address(RVA = "0x342C90", Offset = "0x341890", Length = "0x3D1")]
  private void MovementInput()
  {
  }

  [Token(Token = "0x60000D0")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void AbilityInput()
  {
  }

  [Token(Token = "0x60000D1")]
  [Address(RVA = "0x3432D0", Offset = "0x341ED0", Length = "0xBF")]
  public void SetSpawnDirection(Vector3 direction)
  {
  }

  [Token(Token = "0x60000D2")]
  [Address(RVA = "0x3425B0", Offset = "0x3411B0", Length = "0x47")]
  public bool IsHoldingJump() => false;

  [Token(Token = "0x60000D3")]
  [Address(RVA = "0x343250", Offset = "0x341E50", Length = "0x7A")]
  public void RotationInput()
  {
  }

  [Token(Token = "0x60000D4")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void AutoRotation()
  {
  }

  [Token(Token = "0x60000D5")]
  [Address(RVA = "0x342660", Offset = "0x341260", Length = "0x620")]
  private void ManualRotation()
  {
  }

  [Token(Token = "0x60000D6")]
  [Address(RVA = "0x3422E0", Offset = "0x340EE0", Length = "0x9E")]
  private float GetCameraSmoothing() => 0.0f;

  [Token(Token = "0x60000D7")]
  [Address(RVA = "0x341FA0", Offset = "0x340BA0", Length = "0x33A")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x60000D8")]
  [Address(RVA = "0x3431B0", Offset = "0x341DB0", Length = "0x93")]
  private void OnPlayerDied()
  {
  }

  [Token(Token = "0x60000D9")]
  [Address(RVA = "0x342380", Offset = "0x340F80", Length = "0x60")]
  private InputState GetInputState() => new InputState();

  [Token(Token = "0x60000DA")]
  [Address(RVA = "0x341EA0", Offset = "0x340AA0", Length = "0xF7")]
  private bool CanInput() => false;

  [Token(Token = "0x60000DB")]
  [Address(RVA = "0x342600", Offset = "0x341200", Length = "0x53")]
  private bool IsMovementDisabled() => false;

  [Token(Token = "0x60000DC")]
  [Address(RVA = "0x3425A0", Offset = "0x3411A0", Length = "0x5")]
  public bool IsAiming() => false;

  [Token(Token = "0x60000DD")]
  [Address(RVA = "0x343570", Offset = "0x342170", Length = "0x1C")]
  public PlayerInput()
  {
  }
}
