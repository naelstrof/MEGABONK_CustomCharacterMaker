// Decompiled with JetBrains decompiler
// Type: ChallengeModifierSpeedrun
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "Me/Progression/Challenge/ChallengeModifiers/Speedrun", order = 1)]
[Token(Token = "0x2000222")]
public class ChallengeModifierSpeedrun : ChallengeModifier
{
  [Token(Token = "0x4000EFD")]
  [FieldOffset(Offset = "0x28")]
  public float timeLimitMinutes;
  [Token(Token = "0x4000EFE")]
  [FieldOffset(Offset = "0x2C")]
  private bool isFinalBossKilled;

  [Token(Token = "0x6000DCD")]
  [Address(RVA = "0x51E4B0", Offset = "0x51D0B0", Length = "0x31B")]
  public override void Init()
  {
  }

  [Token(Token = "0x6000DCE")]
  [Address(RVA = "0x51E190", Offset = "0x51CD90", Length = "0x31B")]
  public override void Cleanup()
  {
  }

  [Token(Token = "0x6000DCF")]
  [Address(RVA = "0x51E7D0", Offset = "0x51D3D0", Length = "0x5")]
  private void OnFinalBossDefeated(bool obj)
  {
  }

  [Token(Token = "0x6000DD0")]
  [Address(RVA = "0x51E7E0", Offset = "0x51D3E0", Length = "0x1E")]
  private void OnStageBossDied(bool obj)
  {
  }

  [Token(Token = "0x6000DD1")]
  [Address(RVA = "0x51E800", Offset = "0x51D400", Length = "0xFA")]
  private void OnStageStarted()
  {
  }

  [Token(Token = "0x6000DD2")]
  [Address(RVA = "0x51E900", Offset = "0x51D500", Length = "0x235")]
  public override void Tick()
  {
  }

  [Token(Token = "0x6000DD3")]
  [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
  public ChallengeModifierSpeedrun()
  {
  }
}
