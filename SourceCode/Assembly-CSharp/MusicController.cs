// Decompiled with JetBrains decompiler
// Type: MusicController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Audio.Music;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x2000029")]
public class MusicController : MonoBehaviour
{
  [Token(Token = "0x4000165")]
  public static MusicController Instance;
  [Token(Token = "0x4000166")]
  [FieldOffset(Offset = "0x20")]
  public AudioSource musicSource;
  [Token(Token = "0x4000167")]
  [FieldOffset(Offset = "0x28")]
  public AudioLowPassFilter lowpassFilter;
  [Token(Token = "0x4000168")]
  [FieldOffset(Offset = "0x30")]
  private float volumeMultiplier;
  [Token(Token = "0x4000169")]
  [FieldOffset(Offset = "0x34")]
  private float desiredVolumeMultiplier;
  [Token(Token = "0x400016A")]
  [FieldOffset(Offset = "0x38")]
  private float desiredVolume;
  [Token(Token = "0x400016B")]
  [FieldOffset(Offset = "0x3C")]
  private float desiredLowpass;
  [Token(Token = "0x400016C")]
  [FieldOffset(Offset = "0x40")]
  public MusicTrack menuMusicTrack;
  [Token(Token = "0x400016D")]
  [FieldOffset(Offset = "0x48")]
  private MusicTrack currentTrack;
  [Token(Token = "0x400016E")]
  [FieldOffset(Offset = "0x50")]
  private bool isPlayingIntro;
  [Token(Token = "0x400016F")]
  [FieldOffset(Offset = "0x54")]
  private float introLength;
  [Token(Token = "0x4000170")]
  [FieldOffset(Offset = "0x58")]
  private float defaultPitch;
  [Token(Token = "0x4000171")]
  [FieldOffset(Offset = "0x5C")]
  private float nextCheckTime;
  [Token(Token = "0x4000172")]
  [FieldOffset(Offset = "0x60")]
  private float checkCooldown;
  [Token(Token = "0x4000173")]
  [FieldOffset(Offset = "0x68")]
  private FinalFightController finalFightController;
  [Token(Token = "0x4000174")]
  [FieldOffset(Offset = "0x70")]
  private int lowpassLow;
  [Token(Token = "0x4000175")]
  [FieldOffset(Offset = "0x74")]
  private float currentDangerPitch;
  [Token(Token = "0x4000176")]
  [FieldOffset(Offset = "0x78")]
  private Dictionary<MusicPauseZone, float> zoneInfluences;
  [Token(Token = "0x4000177")]
  [FieldOffset(Offset = "0x80")]
  private float zoneMultiplier;

  [Token(Token = "0x600013E")]
  [Address(RVA = "0x35F390", Offset = "0x35DF90", Length = "0x8B5")]
  private void Awake()
  {
  }

  [Token(Token = "0x600013F")]
  [Address(RVA = "0x35FC70", Offset = "0x35E870", Length = "0x856")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000140")]
  [Address(RVA = "0x360790", Offset = "0x35F390", Length = "0x11D")]
  private void OnStageStarted()
  {
  }

  [Token(Token = "0x6000141")]
  [Address(RVA = "0x360730", Offset = "0x35F330", Length = "0x56")]
  private void OnSceneTransitionStart()
  {
  }

  [Token(Token = "0x6000142")]
  [Address(RVA = "0x360B00", Offset = "0x35F700", Length = "0xA3")]
  public void PlayStageMusic()
  {
  }

  [Token(Token = "0x6000143")]
  [Address(RVA = "0x3608B0", Offset = "0x35F4B0", Length = "0x7D")]
  public void PlayMenuTrack()
  {
  }

  [Token(Token = "0x6000144")]
  [Address(RVA = "0x360930", Offset = "0x35F530", Length = "0x1C4")]
  public void PlayMusicTrack(MusicTrack musicTrack)
  {
  }

  [Token(Token = "0x6000145")]
  [Address(RVA = "0x3604D0", Offset = "0x35F0D0", Length = "0x1FC")]
  private void OnMainMenu()
  {
  }

  [Token(Token = "0x6000146")]
  [Address(RVA = "0x361270", Offset = "0x35FE70", Length = "0x1B2")]
  private void Update()
  {
  }

  [Token(Token = "0x6000147")]
  [Address(RVA = "0x360DF0", Offset = "0x35F9F0", Length = "0x271")]
  private void UpdatePitch()
  {
  }

  [Token(Token = "0x6000148")]
  [Address(RVA = "0x360C50", Offset = "0x35F850", Length = "0x19F")]
  private void UpdateDesiredLowpass()
  {
  }

  [Token(Token = "0x6000149")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void OnSettingUpdated(string name, object oldValue, object newValue)
  {
  }

  [Token(Token = "0x600014A")]
  [Address(RVA = "0x360C20", Offset = "0x35F820", Length = "0x23")]
  public void SetMusicVolume(float volume)
  {
  }

  [Token(Token = "0x600014B")]
  [Address(RVA = "0x360BB0", Offset = "0x35F7B0", Length = "0x63")]
  public void RegisterZoneInfluence(MusicPauseZone zone, float influence)
  {
  }

  [Token(Token = "0x600014C")]
  [Address(RVA = "0x361070", Offset = "0x35FC70", Length = "0x1F5")]
  private void UpdateZoneInfluences()
  {
  }

  [Token(Token = "0x600014D")]
  [Address(RVA = "0x3606E0", Offset = "0x35F2E0", Length = "0x4D")]
  private void OnPlayerDied()
  {
  }

  [Token(Token = "0x600014E")]
  [Address(RVA = "0x35FC60", Offset = "0x35E860", Length = "0x8")]
  private void OnChestOpening()
  {
  }

  [Token(Token = "0x600014F")]
  [Address(RVA = "0x35FC50", Offset = "0x35E850", Length = "0x8")]
  private void OnChestClosed()
  {
  }

  [Token(Token = "0x6000150")]
  [Address(RVA = "0x3606D0", Offset = "0x35F2D0", Length = "0x7")]
  private void OnPause(bool p)
  {
  }

  [Token(Token = "0x6000151")]
  [Address(RVA = "0x3606D0", Offset = "0x35F2D0", Length = "0x7")]
  public void RefreshFilter()
  {
  }

  [Token(Token = "0x6000152")]
  [Address(RVA = "0x361430", Offset = "0x360030", Length = "0xB9")]
  public MusicController()
  {
  }
}
