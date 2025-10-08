// Decompiled with JetBrains decompiler
// Type: Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeModifiers.ChallengeModifierNoItems
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeModifiers
{
  [CreateAssetMenu(menuName = "Me/Progression/Challenge/ChallengeModifiers/No items", order = 1)]
  [Token(Token = "0x20002DA")]
  public class ChallengeModifierNoItems : ChallengeModifier
  {
    [Token(Token = "0x600150E")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x600150F")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001510")]
    [Address(RVA = "0x3879F0", Offset = "0x3865F0", Length = "0x7")]
    public ChallengeModifierNoItems()
    {
    }
  }
}
