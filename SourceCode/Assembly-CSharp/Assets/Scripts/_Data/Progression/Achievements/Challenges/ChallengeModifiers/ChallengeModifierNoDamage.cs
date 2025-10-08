// Decompiled with JetBrains decompiler
// Type: Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeModifiers.ChallengeModifierNoDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeModifiers
{
  [CreateAssetMenu(menuName = "Me/Progression/Challenge/ChallengeModifiers/1 HP", order = 1)]
  [Token(Token = "0x20002D9")]
  public class ChallengeModifierNoDamage : ChallengeModifier
  {
    [Token(Token = "0x4001383")]
    [FieldOffset(Offset = "0x28")]
    private bool hasBeenCalled;
    [Token(Token = "0x4001384")]
    [FieldOffset(Offset = "0x29")]
    private bool hasBeenKilled;

    [Token(Token = "0x6001509")]
    [Address(RVA = "0x388530", Offset = "0x387130", Length = "0x138")]
    public override void Init()
    {
    }

    [Token(Token = "0x600150A")]
    [Address(RVA = "0x3883F0", Offset = "0x386FF0", Length = "0x138")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x600150B")]
    [Address(RVA = "0x388670", Offset = "0x387270", Length = "0x14E")]
    private void OnDamagePlayer()
    {
    }

    [Token(Token = "0x600150C")]
    [Address(RVA = "0x3887C0", Offset = "0x3873C0", Length = "0x8C")]
    public override void Tick()
    {
    }

    [Token(Token = "0x600150D")]
    [Address(RVA = "0x3879F0", Offset = "0x3865F0", Length = "0x7")]
    public ChallengeModifierNoDamage()
    {
    }
  }
}
