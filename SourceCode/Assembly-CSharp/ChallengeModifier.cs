// Decompiled with JetBrains decompiler
// Type: ChallengeModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "Me/Progression/Challenge/", order = 1)]
[Token(Token = "0x200021E")]
public abstract class ChallengeModifier : ScriptableObject
{
  [Token(Token = "0x4000EFB")]
  [FieldOffset(Offset = "0x18")]
  public string internalName;
  [Token(Token = "0x4000EFC")]
  [FieldOffset(Offset = "0x20")]
  public StatModifier[] statModifiers;

  [Token(Token = "0x6000DBD")]
  public abstract void Init();

  [Token(Token = "0x6000DBE")]
  public abstract void Cleanup();

  [Token(Token = "0x6000DBF")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public virtual void Tick()
  {
  }

  [Token(Token = "0x6000DC0")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public virtual void OnStatsApplied()
  {
  }

  [Token(Token = "0x6000DC1")]
  [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
  protected ChallengeModifier()
  {
  }
}
