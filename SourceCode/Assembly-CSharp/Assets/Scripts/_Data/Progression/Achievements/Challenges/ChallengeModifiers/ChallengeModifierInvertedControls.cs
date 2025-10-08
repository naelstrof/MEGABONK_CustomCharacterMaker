// Decompiled with JetBrains decompiler
// Type: Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeModifiers.ChallengeModifierInvertedControls
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeModifiers
{
  [CreateAssetMenu(menuName = "Me/Progression/Challenge/ChallengeModifiers/InvertedControls", order = 1)]
  [Token(Token = "0x20002D7")]
  public class ChallengeModifierInvertedControls : ChallengeModifier
  {
    [Token(Token = "0x4001378")]
    public static bool disableInvertedControlsOptions;

    [Token(Token = "0x6001501")]
    [Address(RVA = "0x387A00", Offset = "0x386600", Length = "0x36")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001502")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001503")]
    [Address(RVA = "0x3879F0", Offset = "0x3865F0", Length = "0x7")]
    public ChallengeModifierInvertedControls()
    {
    }
  }
}
