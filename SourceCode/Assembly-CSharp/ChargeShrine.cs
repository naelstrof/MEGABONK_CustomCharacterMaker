// Decompiled with JetBrains decompiler
// Type: ChargeShrine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000085")]
public class ChargeShrine : MonoBehaviour
{
  [Token(Token = "0x400043F")]
  [FieldOffset(Offset = "0x20")]
  private float chargeTime;
  [Token(Token = "0x4000440")]
  [FieldOffset(Offset = "0x24")]
  private float currentChargeTime;
  [Token(Token = "0x4000441")]
  [FieldOffset(Offset = "0x28")]
  private float chargeProgress;
  [Token(Token = "0x4000442")]
  [FieldOffset(Offset = "0x30")]
  public Renderer zoneRenderer;
  [Token(Token = "0x4000443")]
  [FieldOffset(Offset = "0x38")]
  public Renderer meshRenderer;
  [Token(Token = "0x4000444")]
  [FieldOffset(Offset = "0x40")]
  public Transform runeStone;
  [Token(Token = "0x4000445")]
  [FieldOffset(Offset = "0x48")]
  private MaterialPropertyBlock zonePropertyBlock;
  [Token(Token = "0x4000446")]
  [FieldOffset(Offset = "0x50")]
  private MaterialPropertyBlock rendererPropertyBlock;
  [Token(Token = "0x4000447")]
  [FieldOffset(Offset = "0x58")]
  private Color zoneColor;
  [Token(Token = "0x4000448")]
  [FieldOffset(Offset = "0x68")]
  private Color startColor;
  [Token(Token = "0x4000449")]
  [FieldOffset(Offset = "0x78")]
  public GameObject minimapIcon;
  [Token(Token = "0x400044A")]
  [FieldOffset(Offset = "0x80")]
  public Image circleProgress;
  [Token(Token = "0x400044B")]
  [FieldOffset(Offset = "0x88")]
  public CanvasGroup circleParent;
  [Token(Token = "0x400044C")]
  [FieldOffset(Offset = "0x90")]
  public AudioSource audioStart;
  [Token(Token = "0x400044D")]
  [FieldOffset(Offset = "0x98")]
  public AudioSource audioLoop;
  [Token(Token = "0x400044E")]
  [FieldOffset(Offset = "0xA0")]
  public AudioSource audioComplete;
  [Token(Token = "0x400044F")]
  [FieldOffset(Offset = "0xA8")]
  public AudioSource audioAbort;
  [Token(Token = "0x4000450")]
  [FieldOffset(Offset = "0xB0")]
  public GameObject finishParticles;
  [Token(Token = "0x4000451")]
  [FieldOffset(Offset = "0xB8")]
  public GameObject altarIcon;
  [Token(Token = "0x4000452")]
  [FieldOffset(Offset = "0xC0")]
  public GameObject healingZone;
  [Token(Token = "0x4000453")]
  [FieldOffset(Offset = "0xC8")]
  private bool notInterrupted;
  [Token(Token = "0x4000454")]
  public static Action A_ChargeShrineSpawned;
  [Token(Token = "0x4000455")]
  public static Action<bool> A_Charged;
  [Token(Token = "0x4000456")]
  [FieldOffset(Offset = "0xCC")]
  private float goldChance;
  [Token(Token = "0x4000458")]
  [FieldOffset(Offset = "0xD8")]
  public Material goldMaterial;
  [Token(Token = "0x4000459")]
  [FieldOffset(Offset = "0xE0")]
  private bool wasLoopAudioPlayingWhenPaused;
  [Token(Token = "0x400045A")]
  [FieldOffset(Offset = "0xE4")]
  private float pitchStart;
  [Token(Token = "0x400045B")]
  [FieldOffset(Offset = "0xE8")]
  private float pitchEnd;
  [Token(Token = "0x400045C")]
  [FieldOffset(Offset = "0xEC")]
  private bool completed;
  [Token(Token = "0x400045D")]
  [FieldOffset(Offset = "0xF0")]
  private float rewardTime;
  [Token(Token = "0x400045E")]
  [FieldOffset(Offset = "0xF4")]
  private bool rewardGiven;
  [Token(Token = "0x400045F")]
  public static ChargeShrine lastRewardShrine;
  [Token(Token = "0x4000460")]
  [FieldOffset(Offset = "0xF5")]
  private bool charging;
  [Token(Token = "0x4000461")]
  [FieldOffset(Offset = "0xF8")]
  private float volumeWhenExit;

  [field: Token(Token = "0x4000457")]
  [field: FieldOffset(Offset = "0xD0")]
  [Token(Token = "0x1700001B")]
  public bool isGolden { [Token(Token = "0x600034D"), Address(RVA = "0x45EE00", Offset = "0x45DA00", Length = "0x8")] get; [Token(Token = "0x600034E"), Address(RVA = "0x45EE10", Offset = "0x45DA10", Length = "0x7")] private set; }

  [Token(Token = "0x600034F")]
  [Address(RVA = "0x45D8F0", Offset = "0x45C4F0", Length = "0x193")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000350")]
  [Address(RVA = "0x45DF50", Offset = "0x45CB50", Length = "0x140")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000351")]
  [Address(RVA = "0x45E500", Offset = "0x45D100", Length = "0x388")]
  private void Start()
  {
  }

  [Token(Token = "0x6000352")]
  [Address(RVA = "0x45DE10", Offset = "0x45CA10", Length = "0x138")]
  private void FindChargeTime()
  {
  }

  [Token(Token = "0x6000353")]
  [Address(RVA = "0x45E890", Offset = "0x45D490", Length = "0x529")]
  private void Update()
  {
  }

  [Token(Token = "0x6000354")]
  [Address(RVA = "0x45E0A0", Offset = "0x45CCA0", Length = "0x69")]
  private void OnPause(bool paused)
  {
  }

  [Token(Token = "0x6000355")]
  [Address(RVA = "0x45DA90", Offset = "0x45C690", Length = "0x377")]
  private void Complete()
  {
  }

  [Token(Token = "0x6000356")]
  [Address(RVA = "0x45E450", Offset = "0x45D050", Length = "0xAB")]
  private void ScorePopup()
  {
  }

  [Token(Token = "0x6000357")]
  [Address(RVA = "0x45E3A0", Offset = "0x45CFA0", Length = "0xA8")]
  private void Reward()
  {
  }

  [Token(Token = "0x6000358")]
  [Address(RVA = "0x45E110", Offset = "0x45CD10", Length = "0x214")]
  private void OnTriggerEnter()
  {
  }

  [Token(Token = "0x6000359")]
  [Address(RVA = "0x45E330", Offset = "0x45CF30", Length = "0x68")]
  private void OnTriggerExit()
  {
  }

  [Token(Token = "0x600035A")]
  [Address(RVA = "0x45EDC0", Offset = "0x45D9C0", Length = "0x3A")]
  public ChargeShrine()
  {
  }
}
