// Decompiled with JetBrains decompiler
// Type: Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeWinConditions.ChallengeWinConditionKillTierBoss
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeWinConditions
{
  [CreateAssetMenu(menuName = "Me/Progression/Challenge/Win Conditions/Kill Tier Boss", order = 1)]
  [Token(Token = "0x20002D4")]
  public class ChallengeWinConditionKillTierBoss : ChallengeWinCondition
  {
    [Token(Token = "0x60014F6")]
    [Address(RVA = "0x388A70", Offset = "0x387670", Length = "0x216")]
    public override void Init()
    {
    }

    [Token(Token = "0x60014F7")]
    [Address(RVA = "0x388850", Offset = "0x387450", Length = "0x216")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x60014F8")]
    [Address(RVA = "0x388C90", Offset = "0x387890", Length = "0x29")]
    private void OnStageBossDied(bool didPortalOpen)
    {
    }

    [Token(Token = "0x60014F9")]
    [Address(RVA = "0x3879F0", Offset = "0x3865F0", Length = "0x7")]
    public ChallengeWinConditionKillTierBoss()
    {
    }
  }
}
