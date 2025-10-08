// Decompiled with JetBrains decompiler
// Type: Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeModifiers.ChallengeModifierBlind
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeModifiers
{
  [CreateAssetMenu(menuName = "Me/Progression/Challenge/ChallengeModifiers/Blind", order = 1)]
  [Token(Token = "0x20002D6")]
  public class ChallengeModifierBlind : ChallengeModifier
  {
    [Token(Token = "0x60014FD")]
    [Address(RVA = "0x3876B0", Offset = "0x3862B0", Length = "0x119")]
    public override void Init()
    {
    }

    [Token(Token = "0x60014FE")]
    [Address(RVA = "0x387590", Offset = "0x386190", Length = "0x119")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x60014FF")]
    [Address(RVA = "0x3877D0", Offset = "0x3863D0", Length = "0x21B")]
    private void OnGenerationComplete()
    {
    }

    [Token(Token = "0x6001500")]
    [Address(RVA = "0x3879F0", Offset = "0x3865F0", Length = "0x7")]
    public ChallengeModifierBlind()
    {
    }
  }
}
