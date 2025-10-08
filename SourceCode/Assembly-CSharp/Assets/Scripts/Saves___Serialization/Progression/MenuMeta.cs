// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.MenuMeta
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.MapsAndStages;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Saves___Serialization.Progression
{
  [Token(Token = "0x2000329")]
  [Serializable]
  public class MenuMeta
  {
    [Token(Token = "0x4001568")]
    [FieldOffset(Offset = "0x10")]
    public EMap lastSelectedMap;
    [Token(Token = "0x4001569")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<EMap, MapProgress> mapsProgress;
    [Token(Token = "0x400156A")]
    [FieldOffset(Offset = "0x20")]
    private int numRunsForUnlocks;
    [Token(Token = "0x400156B")]
    [FieldOffset(Offset = "0x24")]
    private int numRunsForLeaderboards;
    [Token(Token = "0x400156C")]
    [FieldOffset(Offset = "0x28")]
    private int numRunsForQuests;
    [Token(Token = "0x400156D")]
    [FieldOffset(Offset = "0x2C")]
    private int numRunsForQuickQuests;
    [Token(Token = "0x400156E")]
    [FieldOffset(Offset = "0x30")]
    private int numRunsForShop;
    [Token(Token = "0x400156F")]
    [FieldOffset(Offset = "0x34")]
    public bool hasVisitedUnlocks;
    [Token(Token = "0x4001570")]
    [FieldOffset(Offset = "0x35")]
    public bool hasVisitedQuests;
    [Token(Token = "0x4001571")]
    [FieldOffset(Offset = "0x36")]
    public bool hasVisitedShop;

    [Token(Token = "0x6001670")]
    [Address(RVA = "0x3AF8D0", Offset = "0x3AE4D0", Length = "0x99")]
    public bool HasMenuUnlocks() => false;

    [Token(Token = "0x6001671")]
    [Address(RVA = "0x3AF790", Offset = "0x3AE390", Length = "0x99")]
    public bool HasMenuQuests() => false;

    [Token(Token = "0x6001672")]
    [Address(RVA = "0x3AF830", Offset = "0x3AE430", Length = "0x99")]
    public bool HasMenuShop() => false;

    [Token(Token = "0x6001673")]
    [Address(RVA = "0x3AF970", Offset = "0x3AE570", Length = "0x99")]
    public bool HasQuickQuests() => false;

    [Token(Token = "0x6001674")]
    [Address(RVA = "0x3AF650", Offset = "0x3AE250", Length = "0x130")]
    public bool HasLeaderboards() => false;

    [Token(Token = "0x6001675")]
    [Address(RVA = "0x3AF5F0", Offset = "0x3AE1F0", Length = "0x5E")]
    public MapProgress GetMapProgress(EMap map) => (MapProgress) null;

    [Token(Token = "0x6001676")]
    [Address(RVA = "0x3AFC40", Offset = "0x3AE840", Length = "0xAE")]
    private void VerifyMap(EMap map)
    {
    }

    [Token(Token = "0x6001677")]
    [Address(RVA = "0x3AFBC0", Offset = "0x3AE7C0", Length = "0x74")]
    public void SetTier(EMap map, int tier)
    {
    }

    [Token(Token = "0x6001678")]
    [Address(RVA = "0x3AFAF0", Offset = "0x3AE6F0", Length = "0xC1")]
    public void SetTierCompletion(EMap map, int tier)
    {
    }

    [Token(Token = "0x6001679")]
    [Address(RVA = "0x3AF580", Offset = "0x3AE180", Length = "0x67")]
    public int GetLastSelectedTier(EMap map) => 0;

    [Token(Token = "0x600167A")]
    [Address(RVA = "0x3AFA10", Offset = "0x3AE610", Length = "0xD1")]
    public bool IsTierCompleted(EMap map, int tier) => false;

    [Token(Token = "0x600167B")]
    [Address(RVA = "0x3AF3D0", Offset = "0x3ADFD0", Length = "0x1A1")]
    public int GetHighestCompletedTier(EMap map) => 0;

    [Token(Token = "0x600167C")]
    [Address(RVA = "0x3AFCF0", Offset = "0x3AE8F0", Length = "0xA1")]
    public MenuMeta()
    {
    }
  }
}
