// Decompiled with JetBrains decompiler
// Type: ChallengeModifierNoWeapons
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "Me/Progression/Challenge/ChallengeModifiers/No weapons", order = 1)]
[Token(Token = "0x2000220")]
public class ChallengeModifierNoWeapons : ChallengeModifier
{
  [Token(Token = "0x6000DC6")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public override void Init()
  {
  }

  [Token(Token = "0x6000DC7")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public override void Cleanup()
  {
  }

  [Token(Token = "0x6000DC8")]
  [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
  public ChallengeModifierNoWeapons()
  {
  }
}
