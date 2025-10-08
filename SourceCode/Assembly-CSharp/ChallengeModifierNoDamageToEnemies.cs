// Decompiled with JetBrains decompiler
// Type: ChallengeModifierNoDamageToEnemies
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "Me/Progression/Challenge/ChallengeModifiers/No damage to enemies", order = 1)]
[Token(Token = "0x200021F")]
public class ChallengeModifierNoDamageToEnemies : ChallengeModifier
{
  [Token(Token = "0x6000DC2")]
  [Address(RVA = "0x51DC50", Offset = "0x51C850", Length = "0x140")]
  public override void Init()
  {
  }

  [Token(Token = "0x6000DC3")]
  [Address(RVA = "0x51DB00", Offset = "0x51C700", Length = "0x140")]
  public override void Cleanup()
  {
  }

  [Token(Token = "0x6000DC4")]
  [Address(RVA = "0x51DDA0", Offset = "0x51C9A0", Length = "0x74")]
  private void OnDamageEnemy(Enemy arg1, DamageContainer arg2)
  {
  }

  [Token(Token = "0x6000DC5")]
  [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
  public ChallengeModifierNoDamageToEnemies()
  {
  }
}
