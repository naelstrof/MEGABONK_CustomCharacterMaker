// Decompiled with JetBrains decompiler
// Type: TargetOfInterestPrefab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000154")]
public class TargetOfInterestPrefab : MonoBehaviour
{
  [Token(Token = "0x40009EB")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_name;
  [Token(Token = "0x40009EC")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_hp;
  [Token(Token = "0x40009ED")]
  [FieldOffset(Offset = "0x30")]
  public RawImage hpBar;
  [Token(Token = "0x40009EE")]
  [FieldOffset(Offset = "0x38")]
  public RawImage bloodmark;
  [Token(Token = "0x40009EF")]
  [FieldOffset(Offset = "0x40")]
  public RawImage poison;
  [Token(Token = "0x40009F0")]
  [FieldOffset(Offset = "0x48")]
  public CanvasGroup canvasGroup;
  [Token(Token = "0x40009F1")]
  [FieldOffset(Offset = "0x50")]
  public Color defaultColor;
  [Token(Token = "0x40009F2")]
  [FieldOffset(Offset = "0x60")]
  public Color invulnerableColor;
  [Token(Token = "0x40009F3")]
  [FieldOffset(Offset = "0x70")]
  private Enemy enemy;
  [Token(Token = "0x40009F4")]
  [FieldOffset(Offset = "0x78")]
  private float fadeTimer;
  [Token(Token = "0x40009F5")]
  [FieldOffset(Offset = "0x7C")]
  private float fadeTime;
  [Token(Token = "0x40009F6")]
  [FieldOffset(Offset = "0x80")]
  private float debuffLerpSpeed;
  [Token(Token = "0x40009F7")]
  [FieldOffset(Offset = "0x84")]
  private float bloodmarkRatio;
  [Token(Token = "0x40009F8")]
  [FieldOffset(Offset = "0x88")]
  private float poisonRatio;
  [Token(Token = "0x40009F9")]
  [FieldOffset(Offset = "0x8C")]
  private float poisonTargetRatio;
  [Token(Token = "0x40009FA")]
  [FieldOffset(Offset = "0x90")]
  private float bloodmarkTargetRatio;

  [Token(Token = "0x600087F")]
  [Address(RVA = "0x4DFF50", Offset = "0x4DEB50", Length = "0x336")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000880")]
  [Address(RVA = "0x4E0310", Offset = "0x4DEF10", Length = "0x336")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000881")]
  [Address(RVA = "0x4E0790", Offset = "0x4DF390", Length = "0x24F")]
  public void SetEnemy(Enemy enemy)
  {
  }

  [Token(Token = "0x6000882")]
  [Address(RVA = "0x4E10B0", Offset = "0x4DFCB0", Length = "0xC2")]
  private void Update()
  {
  }

  [Token(Token = "0x6000883")]
  [Address(RVA = "0x4E0ED0", Offset = "0x4DFAD0", Length = "0x1D5")]
  private void UpdateHp()
  {
  }

  [Token(Token = "0x6000884")]
  [Address(RVA = "0x4E09E0", Offset = "0x4DF5E0", Length = "0x4EB")]
  private void UpdateDebuffs()
  {
  }

  [Token(Token = "0x6000885")]
  [Address(RVA = "0x4E0290", Offset = "0x4DEE90", Length = "0x76")]
  private void OnDamage(Enemy enemy, DamageContainer dc)
  {
  }

  [Token(Token = "0x6000886")]
  [Address(RVA = "0x4E06D0", Offset = "0x4DF2D0", Length = "0xB2")]
  private void OnInvulnerableChanged(Enemy enemy, bool invulnerable)
  {
  }

  [Token(Token = "0x6000887")]
  [Address(RVA = "0x4E0650", Offset = "0x4DF250", Length = "0x76")]
  private void OnHealthChange(Enemy enemy)
  {
  }

  [Token(Token = "0x6000888")]
  [Address(RVA = "0x4E1180", Offset = "0x4DFD80", Length = "0x18")]
  public TargetOfInterestPrefab()
  {
  }
}
