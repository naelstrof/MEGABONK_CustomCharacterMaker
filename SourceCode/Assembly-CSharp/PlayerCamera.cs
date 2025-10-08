// Decompiled with JetBrains decompiler
// Type: PlayerCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using MilkShake;
using System;
using UnityEngine;

[Token(Token = "0x2000038")]
public class PlayerCamera : MonoBehaviour
{
  [Token(Token = "0x400019E")]
  [FieldOffset(Offset = "0x20")]
  public Vector3 offset3rdPerson;
  [Token(Token = "0x400019F")]
  [FieldOffset(Offset = "0x2C")]
  private float currentBob;
  [Token(Token = "0x40001A0")]
  [FieldOffset(Offset = "0x30")]
  private float desiredBob;
  [Token(Token = "0x40001A1")]
  [FieldOffset(Offset = "0x38")]
  public Shaker shaker;
  [Token(Token = "0x40001A2")]
  [FieldOffset(Offset = "0x40")]
  private PlayerCamera.ECameraState cameraState;
  [Token(Token = "0x40001A3")]
  [FieldOffset(Offset = "0x48")]
  public CameraOutlines cameraOutlines;
  [Token(Token = "0x40001A4")]
  [FieldOffset(Offset = "0x50")]
  public Camera camera;
  [Token(Token = "0x40001A5")]
  [FieldOffset(Offset = "0x58")]
  private bool inited;
  [Token(Token = "0x40001A6")]
  public static PlayerCamera Instance;
  [Token(Token = "0x40001A7")]
  [FieldOffset(Offset = "0x5C")]
  private float defaultZ;
  [Token(Token = "0x40001A8")]
  [FieldOffset(Offset = "0x60")]
  private Transform portal;
  [Token(Token = "0x40001A9")]
  [FieldOffset(Offset = "0x68")]
  public bool isPortalCameraFocusingPlayer;
  [Token(Token = "0x40001AA")]
  [FieldOffset(Offset = "0x6C")]
  private float currentZ;
  [Token(Token = "0x40001AB")]
  [FieldOffset(Offset = "0x70")]
  private float maxExtraZoomoutDistance;
  [Token(Token = "0x40001AC")]
  [FieldOffset(Offset = "0x74")]
  public bool useCenter;
  [Token(Token = "0x40001AD")]
  [FieldOffset(Offset = "0x78")]
  public Transform testingTarget;
  [Token(Token = "0x40001AE")]
  [FieldOffset(Offset = "0x80")]
  public Camera deathCamera;
  [Token(Token = "0x40001AF")]
  [FieldOffset(Offset = "0x88")]
  public RenderTexture deathRenderTexture;
  [Token(Token = "0x40001B0")]
  [FieldOffset(Offset = "0x90")]
  private float deathOffset;
  [Token(Token = "0x40001B1")]
  public static Action<GameObject> A_CameraFadeObjectEnter;
  [Token(Token = "0x40001B2")]
  [FieldOffset(Offset = "0x94")]
  private float cameraRadius;
  [Token(Token = "0x40001B3")]
  [FieldOffset(Offset = "0x98")]
  public float testDist;

  [Token(Token = "0x6000185")]
  [Address(RVA = "0x362460", Offset = "0x361060", Length = "0x7")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000186")]
  [Address(RVA = "0x364810", Offset = "0x363410", Length = "0x3F3")]
  public void TryInit()
  {
  }

  [Token(Token = "0x6000187")]
  [Address(RVA = "0x363BB0", Offset = "0x3627B0", Length = "0x2A1")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000188")]
  [Address(RVA = "0x362400", Offset = "0x361000", Length = "0x5F")]
  private void Start()
  {
  }

  [Token(Token = "0x6000189")]
  [Address(RVA = "0x362400", Offset = "0x361000", Length = "0x5F")]
  private void AdjustCameraFar()
  {
  }

  [Token(Token = "0x600018A")]
  [Address(RVA = "0x363880", Offset = "0x362480", Length = "0x4")]
  public PlayerCamera.ECameraState GetCameraState() => new PlayerCamera.ECameraState();

  [Token(Token = "0x600018B")]
  [Address(RVA = "0x364E30", Offset = "0x363A30", Length = "0xE8")]
  private void Update()
  {
  }

  [Token(Token = "0x600018C")]
  [Address(RVA = "0x364C10", Offset = "0x363810", Length = "0xC0")]
  private void UpdateBob()
  {
  }

  [Token(Token = "0x600018D")]
  [Address(RVA = "0x364550", Offset = "0x363150", Length = "0x4")]
  public void SetCameraState(PlayerCamera.ECameraState state)
  {
  }

  [Token(Token = "0x600018E")]
  [Address(RVA = "0x362480", Offset = "0x361080", Length = "0xE6")]
  public void CameraInput(Vector3 playerRotation)
  {
  }

  [Token(Token = "0x600018F")]
  [Address(RVA = "0x3645D0", Offset = "0x3631D0", Length = "0x226")]
  public void StartPortalCamera(Transform portal)
  {
  }

  [Token(Token = "0x6000190")]
  [Address(RVA = "0x364800", Offset = "0x363400", Length = "0x8")]
  public void StopPortalCamera()
  {
  }

  [Token(Token = "0x6000191")]
  [Address(RVA = "0x364090", Offset = "0x362C90", Length = "0x4BA")]
  private void PortalCamera()
  {
  }

  [Token(Token = "0x6000192")]
  [Address(RVA = "0x363AA0", Offset = "0x3626A0", Length = "0xCC")]
  public Vector3 GetPortalOffsetPosition(Vector3 portalForward) => new Vector3();

  [Token(Token = "0x6000193")]
  [Address(RVA = "0x363FB0", Offset = "0x362BB0", Length = "0xDC")]
  private void PlayerCam(Vector3 playerRotation)
  {
  }

  [Token(Token = "0x6000194")]
  [Address(RVA = "0x3627D0", Offset = "0x3613D0", Length = "0x418")]
  private void DeathCam()
  {
  }

  [Token(Token = "0x6000195")]
  [Address(RVA = "0x363890", Offset = "0x362490", Length = "0x20A")]
  private Vector3 GetPlayerHeadPosition() => new Vector3();

  [Token(Token = "0x6000196")]
  [Address(RVA = "0x363000", Offset = "0x361C00", Length = "0x872")]
  private Vector3 GetCameraPosition() => new Vector3();

  [Token(Token = "0x6000197")]
  [Address(RVA = "0x362570", Offset = "0x361170", Length = "0x25F")]
  private void CheckFadeObjects(Ray ray, float distance, float radius)
  {
  }

  [Token(Token = "0x6000198")]
  [Address(RVA = "0x362BF0", Offset = "0x3617F0", Length = "0x12D")]
  public void DeathCamera()
  {
  }

  [Token(Token = "0x6000199")]
  [Address(RVA = "0x363B70", Offset = "0x362770", Length = "0x32")]
  public void HideDeathCamera()
  {
  }

  [Token(Token = "0x600019A")]
  [Address(RVA = "0x363E60", Offset = "0x362A60", Length = "0x15")]
  private void OnPlayerLanded(float fallSpeed)
  {
  }

  [Token(Token = "0x600019B")]
  [Address(RVA = "0x362470", Offset = "0x361070", Length = "0x6")]
  private void BobOnce(float strength = 0.5f)
  {
  }

  [Token(Token = "0x600019C")]
  [Address(RVA = "0x362F80", Offset = "0x361B80", Length = "0x74")]
  private Vector3 GetBobOffset() => new Vector3();

  [Token(Token = "0x600019D")]
  [Address(RVA = "0x362E20", Offset = "0x361A20", Length = "0x15E")]
  private float Get3rdPersonOffset() => 0.0f;

  [Token(Token = "0x600019E")]
  [Address(RVA = "0x362D20", Offset = "0x361920", Length = "0xF6")]
  private Vector3 Get3rdPersonOffset(float zValue) => new Vector3();

  [Token(Token = "0x600019F")]
  [Address(RVA = "0x363E80", Offset = "0x362A80", Length = "0x126")]
  private void OnSettingUpdated(string name, object oldValue, object newValue)
  {
  }

  [Token(Token = "0x60001A0")]
  [Address(RVA = "0x364560", Offset = "0x363160", Length = "0x51")]
  public void SetFov(int fov)
  {
  }

  [Token(Token = "0x60001A1")]
  [Address(RVA = "0x3645C0", Offset = "0x3631C0", Length = "0x7")]
  public void SetZoom(float ratio)
  {
  }

  [Token(Token = "0x60001A2")]
  [Address(RVA = "0x364CD0", Offset = "0x3638D0", Length = "0x152")]
  private void UpdateZoom()
  {
  }

  [Token(Token = "0x60001A3")]
  [Address(RVA = "0x364F20", Offset = "0x363B20", Length = "0x42")]
  public PlayerCamera()
  {
  }

  [Token(Token = "0x2000039")]
  public enum ECameraState
  {
    [Token(Token = "0x40001B5")] Portal,
    [Token(Token = "0x40001B6")] Player,
    [Token(Token = "0x40001B7")] Death,
  }
}
