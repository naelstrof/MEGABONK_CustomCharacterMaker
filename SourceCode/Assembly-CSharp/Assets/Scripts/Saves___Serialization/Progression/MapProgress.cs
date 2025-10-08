// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.MapProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Saves___Serialization.Progression
{
  [Token(Token = "0x2000328")]
  [Serializable]
  public class MapProgress
  {
    [Token(Token = "0x400155F")]
    [FieldOffset(Offset = "0x10")]
    public HashSet<int> tierNotifications;
    [Token(Token = "0x4001560")]
    [FieldOffset(Offset = "0x18")]
    public HashSet<int> tierChallengeNotifications;
    [Token(Token = "0x4001561")]
    [FieldOffset(Offset = "0x20")]
    public bool newMapNotification;
    [Token(Token = "0x4001562")]
    [FieldOffset(Offset = "0x24")]
    public int lastSelectTier;
    [Token(Token = "0x4001563")]
    [FieldOffset(Offset = "0x28")]
    public List<int> completedTiers;
    [Token(Token = "0x4001564")]
    [FieldOffset(Offset = "0x30")]
    public Dictionary<int, HashSet<ECharacter>> tierCompletionsWithCharacters;
    [Token(Token = "0x4001565")]
    [FieldOffset(Offset = "0x38")]
    public Dictionary<int, int> numRunsByTier;
    [Token(Token = "0x4001566")]
    [FieldOffset(Offset = "0x40")]
    public Dictionary<int, float> tierHighscores;
    [Token(Token = "0x4001567")]
    [FieldOffset(Offset = "0x48")]
    public Dictionary<int, float> tierFastestTimes;

    [Token(Token = "0x6001666")]
    [Address(RVA = "0x3AEE90", Offset = "0x3ADA90", Length = "0x1D1")]
    public void OnRunFinished(ECharacter character, bool victory, int tier)
    {
    }

    [Token(Token = "0x6001667")]
    [Address(RVA = "0x3AE980", Offset = "0x3AD580", Length = "0x9E")]
    public int GetNumTierRuns(int tier) => 0;

    [Token(Token = "0x6001668")]
    [Address(RVA = "0x3AEA20", Offset = "0x3AD620", Length = "0x10A")]
    public List<ECharacter> GetTierCompletionCharacters(int tier) => (List<ECharacter>) null;

    [Token(Token = "0x6001669")]
    [Address(RVA = "0x3AE880", Offset = "0x3AD480", Length = "0xFE")]
    public void CompleteTier(int tier)
    {
    }

    [Token(Token = "0x600166A")]
    [Address(RVA = "0x3AEE30", Offset = "0x3ADA30", Length = "0x51")]
    public bool IsTierCompleted(int tier) => false;

    [Token(Token = "0x600166B")]
    [Address(RVA = "0x3AF070", Offset = "0x3ADC70", Length = "0xA9")]
    public void SetCompletedTime(float time)
    {
    }

    [Token(Token = "0x600166C")]
    [Address(RVA = "0x3AF120", Offset = "0x3ADD20", Length = "0xBC")]
    public void SetKills(int kills)
    {
    }

    [Token(Token = "0x600166D")]
    [Address(RVA = "0x3AED30", Offset = "0x3AD930", Length = "0xF0")]
    public string GetTierHighscoreString(int tier) => (string) null;

    [Token(Token = "0x600166E")]
    [Address(RVA = "0x3AEB30", Offset = "0x3AD730", Length = "0x1FE")]
    public string GetTierFastestTimeString(int tier) => (string) null;

    [Token(Token = "0x600166F")]
    [Address(RVA = "0x3AF1E0", Offset = "0x3ADDE0", Length = "0x1EB")]
    public MapProgress()
    {
    }
  }
}
