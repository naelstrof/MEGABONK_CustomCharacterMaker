// Decompiled with JetBrains decompiler
// Type: DeathScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000148")]
public class DeathScreen : MonoBehaviour
{
  [Token(Token = "0x4000999")]
  [FieldOffset(Offset = "0x20")]
  public DeathScreenBlocksUI blocksUi;
  [Token(Token = "0x400099A")]
  [FieldOffset(Offset = "0x28")]
  public GameObject deadUiWindow;
  [Token(Token = "0x400099B")]
  [FieldOffset(Offset = "0x30")]
  public GameObject statsWindow;
  [Token(Token = "0x400099C")]
  [FieldOffset(Offset = "0x38")]
  public GameObject background;
  [Token(Token = "0x400099D")]
  [FieldOffset(Offset = "0x40")]
  public GameObject leaderboardsWindow;
  [Token(Token = "0x400099E")]
  [FieldOffset(Offset = "0x48")]
  public GameObject victoryScreen;
  [Token(Token = "0x400099F")]
  [FieldOffset(Offset = "0x50")]
  public UiAnimation t_dead;
  [Token(Token = "0x40009A0")]
  [FieldOffset(Offset = "0x58")]
  public UiAnimation b_continue;
  [Token(Token = "0x40009A1")]
  [FieldOffset(Offset = "0x60")]
  public AudioSource audio;
  [Token(Token = "0x40009A2")]
  [FieldOffset(Offset = "0x68")]
  public RawImage playerOnlyRender;
  [Token(Token = "0x40009A3")]
  [FieldOffset(Offset = "0x70")]
  public CanvasGroup canvasGroup;
  [Token(Token = "0x40009A4")]
  [FieldOffset(Offset = "0x78")]
  private float fadeInTime;
  [Token(Token = "0x40009A5")]
  [FieldOffset(Offset = "0x7C")]
  private float fadeTimer;
  [Token(Token = "0x40009A6")]
  [FieldOffset(Offset = "0x80")]
  private bool hasNewRecord;
  [Token(Token = "0x40009A7")]
  [FieldOffset(Offset = "0x81")]
  private bool tierVictory;
  [Token(Token = "0x40009A8")]
  [FieldOffset(Offset = "0x88")]
  public GameObject restartBtn;

  [Token(Token = "0x6000845")]
  [Address(RVA = "0x4D0EA0", Offset = "0x4CFAA0", Length = "0x24D")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000846")]
  [Address(RVA = "0x4D1370", Offset = "0x4CFF70", Length = "0x24D")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000847")]
  [Address(RVA = "0x4D15C0", Offset = "0x4D01C0", Length = "0x77")]
  private void OnLeaderboardScoreUploaded(string lbName)
  {
  }

  [Token(Token = "0x6000848")]
  [Address(RVA = "0x4D1340", Offset = "0x4CFF40", Length = "0x21")]
  private void OnBossDefeated(bool canSpawnPortal)
  {
  }

  [Token(Token = "0x6000849")]
  [Address(RVA = "0x4D1640", Offset = "0x4D0240", Length = "0x1D")]
  public void PlayAudio()
  {
  }

  [Token(Token = "0x600084A")]
  [Address(RVA = "0x4D1820", Offset = "0x4D0420", Length = "0x71")]
  public void StartDeathScreen()
  {
  }

  [Token(Token = "0x600084B")]
  [Address(RVA = "0x4D10F0", Offset = "0x4CFCF0", Length = "0x67")]
  private IEnumerator DoTransition() => (IEnumerator) null;

  [Token(Token = "0x600084C")]
  [Address(RVA = "0x4D18A0", Offset = "0x4D04A0", Length = "0x202")]
  private void Update()
  {
  }

  [Token(Token = "0x600084D")]
  [Address(RVA = "0x4D1670", Offset = "0x4D0270", Length = "0x20")]
  public void ShowLeaderboard()
  {
  }

  [Token(Token = "0x600084E")]
  [Address(RVA = "0x4D11B0", Offset = "0x4CFDB0", Length = "0x187")]
  public void HideVictoryScreen()
  {
  }

  [Token(Token = "0x600084F")]
  [Address(RVA = "0x4D16A0", Offset = "0x4D02A0", Length = "0x170")]
  public void ShowStats()
  {
  }

  [Token(Token = "0x6000850")]
  [Address(RVA = "0x4D1160", Offset = "0x4CFD60", Length = "0x46")]
  public void GoToMenu()
  {
  }

  [Token(Token = "0x6000851")]
  [Address(RVA = "0x4D1660", Offset = "0x4D0260", Length = "0x7")]
  public void Restart()
  {
  }

  [Token(Token = "0x6000852")]
  [Address(RVA = "0x4D1AB0", Offset = "0x4D06B0", Length = "0x15")]
  public DeathScreen()
  {
  }
}
