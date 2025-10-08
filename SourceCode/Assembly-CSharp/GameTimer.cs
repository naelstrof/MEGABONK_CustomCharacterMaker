// Decompiled with JetBrains decompiler
// Type: GameTimer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x200012C")]
public class GameTimer : MonoBehaviour
{
  [Token(Token = "0x40008DD")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_timerRun;
  [Token(Token = "0x40008DE")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_timerStage;
  [Token(Token = "0x40008DF")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_timerSpeedrun;
  [Token(Token = "0x40008E0")]
  [FieldOffset(Offset = "0x38")]
  private bool isRed;
  [Token(Token = "0x40008E1")]
  [FieldOffset(Offset = "0x40")]
  private ChallengeModifierSpeedrun speedrunModifier;

  [Token(Token = "0x6000783")]
  [Address(RVA = "0x4B7E10", Offset = "0x4B6A10", Length = "0x7")]
  private void Start()
  {
  }

  [Token(Token = "0x6000784")]
  [Address(RVA = "0x4B8230", Offset = "0x4B6E30", Length = "0x5B")]
  private void Update()
  {
  }

  [Token(Token = "0x6000785")]
  [Address(RVA = "0x4B7FC0", Offset = "0x4B6BC0", Length = "0x266")]
  private void UpdateTimers()
  {
  }

  [Token(Token = "0x6000786")]
  [Address(RVA = "0x4B7E20", Offset = "0x4B6A20", Length = "0x193")]
  private void UpdateTimer(float time, TextMeshProUGUI textMesh, bool useClock = false)
  {
  }

  [Token(Token = "0x6000787")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public GameTimer()
  {
  }
}
