// Decompiled with JetBrains decompiler
// Type: AlertUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Spawning;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x200012A")]
public class AlertUi : MonoBehaviour
{
  [Token(Token = "0x40008C4")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_alert;
  [Token(Token = "0x40008C5")]
  [FieldOffset(Offset = "0x28")]
  public AudioSource audio;
  [Token(Token = "0x40008C6")]
  [FieldOffset(Offset = "0x30")]
  public AudioClip c_swarm;
  [Token(Token = "0x40008C7")]
  [FieldOffset(Offset = "0x38")]
  public AudioClip c_finalSwarm;
  [Token(Token = "0x40008C8")]
  [FieldOffset(Offset = "0x40")]
  public AudioClip c_boss;
  [Token(Token = "0x40008C9")]
  [FieldOffset(Offset = "0x48")]
  public Color swarmColor;
  [Token(Token = "0x40008CA")]
  [FieldOffset(Offset = "0x58")]
  public Color swarmFinalColor;
  [Token(Token = "0x40008CB")]
  [FieldOffset(Offset = "0x68")]
  public Color bossColor;
  [Token(Token = "0x40008CC")]
  [FieldOffset(Offset = "0x78")]
  private float timer;
  [Token(Token = "0x40008CD")]
  [FieldOffset(Offset = "0x7C")]
  private bool startedFade;

  [Token(Token = "0x600076B")]
  [Address(RVA = "0x4B1F40", Offset = "0x4B0B40", Length = "0x2E9")]
  private void Awake()
  {
  }

  [Token(Token = "0x600076C")]
  [Address(RVA = "0x4B2260", Offset = "0x4B0E60", Length = "0x2E9")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600076D")]
  [Address(RVA = "0x4B2580", Offset = "0x4B1180", Length = "0xC")]
  private void OnSwarmStarted()
  {
  }

  [Token(Token = "0x600076E")]
  [Address(RVA = "0x4B2550", Offset = "0x4B1150", Length = "0xC")]
  private void OnFinalSwarmStarted()
  {
  }

  [Token(Token = "0x600076F")]
  [Address(RVA = "0x4B2560", Offset = "0x4B1160", Length = "0x13")]
  private void OnNewWave(EWaveType waveType)
  {
  }

  [Token(Token = "0x6000770")]
  [Address(RVA = "0x4B2590", Offset = "0x4B1190", Length = "0xDE")]
  public void SetAlertBoss()
  {
  }

  [Token(Token = "0x6000771")]
  [Address(RVA = "0x4B2670", Offset = "0x4B1270", Length = "0x163")]
  public void SetAlert(EWaveType waveType)
  {
  }

  [Token(Token = "0x6000772")]
  [Address(RVA = "0x4B1E20", Offset = "0x4B0A20", Length = "0x110")]
  private void AnimateAlert()
  {
  }

  [Token(Token = "0x6000773")]
  [Address(RVA = "0x4B2860", Offset = "0x4B1460", Length = "0x324")]
  private void Update()
  {
  }

  [Token(Token = "0x6000774")]
  [Address(RVA = "0x4B27E0", Offset = "0x4B13E0", Length = "0x79")]
  private void StartFade()
  {
  }

  [Token(Token = "0x6000775")]
  [Address(RVA = "0x4B2230", Offset = "0x4B0E30", Length = "0x2F")]
  private void Disable()
  {
  }

  [Token(Token = "0x6000776")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public AlertUi()
  {
  }
}
