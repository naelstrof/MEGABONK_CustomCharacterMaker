// Decompiled with JetBrains decompiler
// Type: UiManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.UI.HUD;
using Assets.Scripts.UI.InGame.Levelup;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000172")]
public class UiManager : MonoBehaviour
{
  [Token(Token = "0x4000AAA")]
  [FieldOffset(Offset = "0x20")]
  public DeathScreen deathScreen;
  [Token(Token = "0x4000AAB")]
  [FieldOffset(Offset = "0x28")]
  public ScoreUi scoreUi;
  [Token(Token = "0x4000AAC")]
  [FieldOffset(Offset = "0x30")]
  public EncounterWindows encounterWindows;
  [Token(Token = "0x4000AAD")]
  [FieldOffset(Offset = "0x38")]
  public MapTitle mapTile;
  [Token(Token = "0x4000AAE")]
  [FieldOffset(Offset = "0x40")]
  public TargetOfInterestUi targetOfInterestUi;
  [Token(Token = "0x4000AAF")]
  [FieldOffset(Offset = "0x48")]
  public PauseUi pause;
  [Token(Token = "0x4000AB0")]
  [FieldOffset(Offset = "0x50")]
  public PortalDemoUi portalDemoUi;
  [Token(Token = "0x4000AB1")]
  [FieldOffset(Offset = "0x58")]
  public ShrineLogs shrineLogs;
  [Token(Token = "0x4000AB2")]
  [FieldOffset(Offset = "0x60")]
  public ObjectiveArrow objectiveArrow;
  [Token(Token = "0x4000AB3")]
  [FieldOffset(Offset = "0x68")]
  public GameObject hud;
  [Token(Token = "0x4000AB4")]
  [FieldOffset(Offset = "0x70")]
  public CinematicBars cinematicBars;
  [Token(Token = "0x4000AB5")]
  [FieldOffset(Offset = "0x78")]
  private bool inited;
  [Token(Token = "0x4000AB6")]
  public static UiManager Instance;

  [Token(Token = "0x6000952")]
  [Address(RVA = "0x4E3D10", Offset = "0x4E2910", Length = "0x7")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000953")]
  [Address(RVA = "0x4E3F60", Offset = "0x4E2B60", Length = "0x3EC")]
  public void TryInit()
  {
  }

  [Token(Token = "0x6000954")]
  [Address(RVA = "0x4E4350", Offset = "0x4E2F50", Length = "0xF7")]
  private void Update()
  {
  }

  [Token(Token = "0x6000955")]
  [Address(RVA = "0x4E3D20", Offset = "0x4E2920", Length = "0x203")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000956")]
  [Address(RVA = "0x4772E0", Offset = "0x475EE0", Length = "0x20")]
  private void OnPortalOpen()
  {
  }

  [Token(Token = "0x6000957")]
  [Address(RVA = "0x4E3F30", Offset = "0x4E2B30", Length = "0x20")]
  private void OnPortalClose()
  {
  }

  [Token(Token = "0x6000958")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public UiManager()
  {
  }
}
