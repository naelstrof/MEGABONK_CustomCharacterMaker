// Decompiled with JetBrains decompiler
// Type: Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeModifiers.ChallengeModifierLava
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeModifiers
{
  [CreateAssetMenu(menuName = "Me/Progression/Challenge/ChallengeModifiers/Lava", order = 1)]
  [Token(Token = "0x20002D8")]
  public class ChallengeModifierLava : ChallengeModifier
  {
    [Token(Token = "0x4001379")]
    [FieldOffset(Offset = "0x28")]
    private GameObject lavaObject;
    [Token(Token = "0x400137A")]
    [FieldOffset(Offset = "0x30")]
    private Vector3 topPosition;
    [Token(Token = "0x400137B")]
    [FieldOffset(Offset = "0x3C")]
    private Vector3 lowPosition;
    [Token(Token = "0x400137C")]
    [FieldOffset(Offset = "0x48")]
    private float riseTime;
    [Token(Token = "0x400137D")]
    [FieldOffset(Offset = "0x4C")]
    private float stayTop;
    [Token(Token = "0x400137E")]
    [FieldOffset(Offset = "0x50")]
    private float lowerTime;
    [Token(Token = "0x400137F")]
    [FieldOffset(Offset = "0x54")]
    private float stayBottom;
    [Token(Token = "0x4001380")]
    [FieldOffset(Offset = "0x58")]
    private float cycleDuration;
    [Token(Token = "0x4001381")]
    [FieldOffset(Offset = "0x5C")]
    private float startDelay;
    [Token(Token = "0x4001382")]
    [FieldOffset(Offset = "0x60")]
    private float startTime;

    [Token(Token = "0x6001504")]
    [Address(RVA = "0x387B60", Offset = "0x386760", Length = "0x119")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001505")]
    [Address(RVA = "0x387A40", Offset = "0x386640", Length = "0x119")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001506")]
    [Address(RVA = "0x387C80", Offset = "0x386880", Length = "0x44B")]
    private void OnGenerationComplete()
    {
    }

    [Token(Token = "0x6001507")]
    [Address(RVA = "0x3880D0", Offset = "0x386CD0", Length = "0x2EA")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001508")]
    [Address(RVA = "0x3883C0", Offset = "0x386FC0", Length = "0x2A")]
    public ChallengeModifierLava()
    {
    }
  }
}
