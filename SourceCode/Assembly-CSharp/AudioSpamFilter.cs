// Decompiled with JetBrains decompiler
// Type: AudioSpamFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x2000026")]
public class AudioSpamFilter : MonoBehaviour
{
  [Token(Token = "0x4000153")]
  [FieldOffset(Offset = "0x20")]
  public AudioSource audioSource;
  [Token(Token = "0x4000154")]
  [FieldOffset(Offset = "0x28")]
  public RandomSfx randomSfx;
  [Token(Token = "0x4000155")]
  private static Dictionary<string, AudioSpamFilter.SpamFilterContainer> spamFilter;
  [Token(Token = "0x4000156")]
  [FieldOffset(Offset = "0x30")]
  public float spamDelay;
  [Token(Token = "0x4000157")]
  [FieldOffset(Offset = "0x34")]
  public float minVolumeMultiplier;
  [Token(Token = "0x4000158")]
  [FieldOffset(Offset = "0x38")]
  public float maxInterval;
  [Token(Token = "0x4000159")]
  [FieldOffset(Offset = "0x3C")]
  public float overrideMinInterval;

  [Token(Token = "0x600012E")]
  [Address(RVA = "0x33A6C0", Offset = "0x3392C0", Length = "0x3DB")]
  public void OnEnable()
  {
  }

  [Token(Token = "0x600012F")]
  [Address(RVA = "0x33A440", Offset = "0x339040", Length = "0x275")]
  public static float FindVolumeMultiplier(
    float minInterval,
    float maxInterval,
    float interval,
    float minVolumeMultiplierValue,
    bool log = false)
  {
    return 0.0f;
  }

  [Token(Token = "0x6000130")]
  [Address(RVA = "0x33AAA0", Offset = "0x3396A0", Length = "0x74")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x6000131")]
  [Address(RVA = "0x33ABB0", Offset = "0x3397B0", Length = "0x1C")]
  public AudioSpamFilter()
  {
  }

  [Token(Token = "0x6000132")]
  [Address(RVA = "0x33AB20", Offset = "0x339720", Length = "0x84")]
  static AudioSpamFilter()
  {
  }

  [Token(Token = "0x2000027")]
  private class SpamFilterContainer
  {
    [Token(Token = "0x400015A")]
    [FieldOffset(Offset = "0x10")]
    public bool isMuted;
    [Token(Token = "0x400015B")]
    [FieldOffset(Offset = "0x14")]
    public float unmuteTime;
    [Token(Token = "0x400015C")]
    [FieldOffset(Offset = "0x18")]
    public float lastPlayedTime;

    [Token(Token = "0x6000133")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public SpamFilterContainer()
    {
    }
  }
}
