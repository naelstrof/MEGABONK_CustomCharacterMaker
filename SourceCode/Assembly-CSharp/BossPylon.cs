// Decompiled with JetBrains decompiler
// Type: BossPylon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using System;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000084")]
public class BossPylon : MonoBehaviour
{
  [Token(Token = "0x400041C")]
  [FieldOffset(Offset = "0x20")]
  private Vector3 startPosition;
  [Token(Token = "0x400041D")]
  [FieldOffset(Offset = "0x2C")]
  private float chargeTime;
  [Token(Token = "0x400041E")]
  [FieldOffset(Offset = "0x30")]
  private float chargeProgress;
  [Token(Token = "0x400041F")]
  [FieldOffset(Offset = "0x38")]
  private MaterialPropertyBlock zonePropertyBlock;
  [Token(Token = "0x4000420")]
  [FieldOffset(Offset = "0x40")]
  public Renderer zoneRenderer;
  [Token(Token = "0x4000421")]
  [FieldOffset(Offset = "0x48")]
  private Color zoneColor;
  [Token(Token = "0x4000422")]
  [FieldOffset(Offset = "0x58")]
  private Color startColor;
  [Token(Token = "0x4000423")]
  [FieldOffset(Offset = "0x68")]
  public GameObject minimapIcon;
  [Token(Token = "0x4000424")]
  [FieldOffset(Offset = "0x70")]
  public Image circleProgress;
  [Token(Token = "0x4000425")]
  [FieldOffset(Offset = "0x78")]
  public CanvasGroup circleParent;
  [Token(Token = "0x4000426")]
  [FieldOffset(Offset = "0x80")]
  public AudioSource audioStart;
  [Token(Token = "0x4000427")]
  [FieldOffset(Offset = "0x88")]
  public AudioSource audioLoop;
  [Token(Token = "0x4000428")]
  [FieldOffset(Offset = "0x90")]
  public AudioSource audioComplete;
  [Token(Token = "0x4000429")]
  [FieldOffset(Offset = "0x98")]
  public AudioSource audioAbort;
  [Token(Token = "0x400042A")]
  [FieldOffset(Offset = "0xA0")]
  public GameObject finishParticles;
  [Token(Token = "0x400042B")]
  [FieldOffset(Offset = "0xA8")]
  public GameObject altarIcon;
  [Token(Token = "0x400042C")]
  public static Action<BossPylon> A_Charged;
  [Token(Token = "0x400042D")]
  [FieldOffset(Offset = "0xB0")]
  private Enemy boss;
  [Token(Token = "0x400042E")]
  [FieldOffset(Offset = "0xB8")]
  public LineRenderer laser;
  [Token(Token = "0x400042F")]
  [FieldOffset(Offset = "0xC0")]
  private int arcPointCount;
  [Token(Token = "0x4000430")]
  [FieldOffset(Offset = "0xC4")]
  private float arcHeight;
  [Token(Token = "0x4000431")]
  [FieldOffset(Offset = "0xC8")]
  private float moveTime;
  [Token(Token = "0x4000432")]
  [FieldOffset(Offset = "0xCC")]
  private Vector3 fromPos;
  [Token(Token = "0x4000433")]
  [FieldOffset(Offset = "0xD8")]
  private Vector3 toPos;
  [Token(Token = "0x4000434")]
  [FieldOffset(Offset = "0xE8")]
  public ParticleSystem moveFx;
  [Token(Token = "0x4000435")]
  [FieldOffset(Offset = "0xF0")]
  private float height;
  [Token(Token = "0x4000436")]
  [FieldOffset(Offset = "0xF4")]
  private float moveOverSeconds;
  [Token(Token = "0x4000437")]
  [FieldOffset(Offset = "0xF8")]
  private bool burying;
  [Token(Token = "0x4000438")]
  [FieldOffset(Offset = "0xFC")]
  private float currentChargeTime;
  [Token(Token = "0x4000439")]
  [FieldOffset(Offset = "0x100")]
  private bool wasLoopAudioPlayingWhenPaused;
  [Token(Token = "0x400043A")]
  [FieldOffset(Offset = "0x104")]
  private float pitchStart;
  [Token(Token = "0x400043B")]
  [FieldOffset(Offset = "0x108")]
  private float pitchEnd;
  [Token(Token = "0x400043C")]
  [FieldOffset(Offset = "0x10C")]
  private bool completed;
  [Token(Token = "0x400043D")]
  [FieldOffset(Offset = "0x10D")]
  private bool charging;
  [Token(Token = "0x400043E")]
  [FieldOffset(Offset = "0x110")]
  private float volumeWhenExit;

  [Token(Token = "0x600033A")]
  [Address(RVA = "0x45CB70", Offset = "0x45B770", Length = "0x46A")]
  public void Set(Enemy enemy)
  {
  }

  [Token(Token = "0x600033B")]
  [Address(RVA = "0x45D310", Offset = "0x45BF10", Length = "0x29")]
  private void Update()
  {
  }

  [Token(Token = "0x600033C")]
  [Address(RVA = "0x45BEB0", Offset = "0x45AAB0", Length = "0x30C")]
  private void DrawLaser()
  {
  }

  [Token(Token = "0x600033D")]
  [Address(RVA = "0x45D190", Offset = "0x45BD90", Length = "0x179")]
  private void Surface()
  {
  }

  [Token(Token = "0x600033E")]
  [Address(RVA = "0x45B8C0", Offset = "0x45A4C0", Length = "0xFB")]
  private void Bury()
  {
  }

  [Token(Token = "0x600033F")]
  [Address(RVA = "0x45C320", Offset = "0x45AF20", Length = "0x1FD")]
  private void MoveUpdate()
  {
  }

  [Token(Token = "0x6000340")]
  [Address(RVA = "0x45BE60", Offset = "0x45AA60", Length = "0x42")]
  public void Despawn()
  {
  }

  [Token(Token = "0x6000341")]
  [Address(RVA = "0x45B770", Offset = "0x45A370", Length = "0x140")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000342")]
  [Address(RVA = "0x45C520", Offset = "0x45B120", Length = "0x140")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000343")]
  [Address(RVA = "0x45CFE0", Offset = "0x45BBE0", Length = "0x1A2")]
  private void Start()
  {
  }

  [Token(Token = "0x6000344")]
  [Address(RVA = "0x45C970", Offset = "0x45B570", Length = "0x145")]
  private void Reset()
  {
  }

  [Token(Token = "0x6000345")]
  [Address(RVA = "0x45C1C0", Offset = "0x45ADC0", Length = "0x155")]
  private void FindChargeTime()
  {
  }

  [Token(Token = "0x6000346")]
  [Address(RVA = "0x45B9C0", Offset = "0x45A5C0", Length = "0x23C")]
  private void ChargeUpdate()
  {
  }

  [Token(Token = "0x6000347")]
  [Address(RVA = "0x45C670", Offset = "0x45B270", Length = "0x69")]
  private void OnPause(bool paused)
  {
  }

  [Token(Token = "0x6000348")]
  [Address(RVA = "0x45BC00", Offset = "0x45A800", Length = "0x258")]
  private void Complete()
  {
  }

  [Token(Token = "0x6000349")]
  [Address(RVA = "0x45CAC0", Offset = "0x45B6C0", Length = "0xAB")]
  private void ScorePopup()
  {
  }

  [Token(Token = "0x600034A")]
  [Address(RVA = "0x45C6E0", Offset = "0x45B2E0", Length = "0x218")]
  private void OnTriggerEnter()
  {
  }

  [Token(Token = "0x600034B")]
  [Address(RVA = "0x45C900", Offset = "0x45B500", Length = "0x63")]
  private void OnTriggerExit()
  {
  }

  [Token(Token = "0x600034C")]
  [Address(RVA = "0x45D340", Offset = "0x45BF40", Length = "0x4A")]
  public BossPylon()
  {
  }
}
