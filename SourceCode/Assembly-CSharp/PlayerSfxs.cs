// Decompiled with JetBrains decompiler
// Type: PlayerSfxs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000DC")]
public class PlayerSfxs : MonoBehaviour
{
  [Token(Token = "0x4000749")]
  public static PlayerSfxs Instance;
  [Token(Token = "0x400074A")]
  [FieldOffset(Offset = "0x20")]
  public RandomSfx sourceEvade;
  [Token(Token = "0x400074B")]
  [FieldOffset(Offset = "0x28")]
  public RandomSfx sourceFlex;
  [Token(Token = "0x400074C")]
  [FieldOffset(Offset = "0x30")]
  public RandomSfx slideStart;
  [Token(Token = "0x400074D")]
  [FieldOffset(Offset = "0x38")]
  public AudioSource slideLoop;
  [Token(Token = "0x400074E")]
  [FieldOffset(Offset = "0x40")]
  public AudioClip evade;
  [Token(Token = "0x400074F")]
  [FieldOffset(Offset = "0x48")]
  public AudioClip evadePhantom;
  [Token(Token = "0x4000750")]
  [FieldOffset(Offset = "0x50")]
  public AudioSource windAudio;
  [Token(Token = "0x4000751")]
  [FieldOffset(Offset = "0x58")]
  private float maxVolume;
  [Token(Token = "0x4000752")]
  [FieldOffset(Offset = "0x5C")]
  private float maxPitch;
  [Token(Token = "0x4000753")]
  [FieldOffset(Offset = "0x60")]
  private float minSpeed;
  [Token(Token = "0x4000754")]
  [FieldOffset(Offset = "0x64")]
  private float maxSpeed;
  [Token(Token = "0x4000755")]
  [FieldOffset(Offset = "0x68")]
  public GameObject grindFx;
  [Token(Token = "0x4000756")]
  [FieldOffset(Offset = "0x70")]
  public RandomSfx sourceGrindAction;
  [Token(Token = "0x4000757")]
  [FieldOffset(Offset = "0x78")]
  public RandomSfx sourceGrindLoop;
  [Token(Token = "0x4000758")]
  [FieldOffset(Offset = "0x80")]
  public AudioClip grindStart;
  [Token(Token = "0x4000759")]
  [FieldOffset(Offset = "0x88")]
  public AudioClip grindStop;
  [Token(Token = "0x400075A")]
  [FieldOffset(Offset = "0x90")]
  private float avgSpeed;
  [Token(Token = "0x400075B")]
  [FieldOffset(Offset = "0x94")]
  private bool wasPlayingGrind;

  [Token(Token = "0x600062B")]
  [Address(RVA = "0x4A0F30", Offset = "0x49FB30", Length = "0x140")]
  private void Start()
  {
  }

  [Token(Token = "0x600062C")]
  [Address(RVA = "0x4A0C80", Offset = "0x49F880", Length = "0x140")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600062D")]
  [Address(RVA = "0x4A1610", Offset = "0x4A0210", Length = "0xFB")]
  private void Update()
  {
  }

  [Token(Token = "0x600062E")]
  [Address(RVA = "0x4A0B60", Offset = "0x49F760", Length = "0xEF")]
  public void Evade(bool phantom)
  {
  }

  [Token(Token = "0x600062F")]
  [Address(RVA = "0x4A0C50", Offset = "0x49F850", Length = "0x29")]
  public void Flex()
  {
  }

  [Token(Token = "0x6000630")]
  [Address(RVA = "0x4A0E40", Offset = "0x49FA40", Length = "0xE7")]
  public void StartGrind()
  {
  }

  [Token(Token = "0x6000631")]
  [Address(RVA = "0x4A1080", Offset = "0x49FC80", Length = "0xD3")]
  public void StopGrind()
  {
  }

  [Token(Token = "0x6000632")]
  [Address(RVA = "0x4A1160", Offset = "0x49FD60", Length = "0x2C5")]
  private void UpdateSliding()
  {
  }

  [Token(Token = "0x6000633")]
  [Address(RVA = "0x4A1430", Offset = "0x4A0030", Length = "0x1D9")]
  private void UpdateWind()
  {
  }

  [Token(Token = "0x6000634")]
  [Address(RVA = "0x4A0DD0", Offset = "0x49F9D0", Length = "0x6A")]
  private void OnPause(bool pause)
  {
  }

  [Token(Token = "0x6000635")]
  [Address(RVA = "0x4A1710", Offset = "0x4A0310", Length = "0x23")]
  public PlayerSfxs()
  {
  }
}
