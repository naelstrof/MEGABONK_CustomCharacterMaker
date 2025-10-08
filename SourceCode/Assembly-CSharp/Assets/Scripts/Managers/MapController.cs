// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Managers.MapController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Other;
using Cpp2ILInjected;
using System;

namespace Assets.Scripts.Managers
{
  [Token(Token = "0x2000358")]
  public class MapController
  {
    [Token(Token = "0x40016DB")]
    private static PlayerInventory inventory;
    [Token(Token = "0x40016DC")]
    public static int index;
    [Token(Token = "0x40016DF")]
    private static bool isFinalBossStage;
    [Token(Token = "0x40016E0")]
    private static bool reseting;
    [Token(Token = "0x40016E1")]
    public static Action A_NewRunStarted;
    [Token(Token = "0x40016E2")]
    public static RunConfig runConfig;

    [field: Token(Token = "0x40016DD")]
    [Token(Token = "0x17000382")]
    public static MapData currentMap { [Token(Token = "0x60017C5"), Address(RVA = "0x3CDBB0", Offset = "0x3CC7B0", Length = "0x37")] get; [Token(Token = "0x60017C6"), Address(RVA = "0x3CDC30", Offset = "0x3CC830", Length = "0x56")] private set; }

    [field: Token(Token = "0x40016DE")]
    [Token(Token = "0x17000383")]
    public static StageData currentStage { [Token(Token = "0x60017C7"), Address(RVA = "0x3CDBF0", Offset = "0x3CC7F0", Length = "0x37")] get; [Token(Token = "0x60017C8"), Address(RVA = "0x3CDC90", Offset = "0x3CC890", Length = "0x56")] private set; }

    [Token(Token = "0x60017C9")]
    [Address(RVA = "0x3CD3B0", Offset = "0x3CBFB0", Length = "0x1C1")]
    public static void RestartRun()
    {
    }

    [Token(Token = "0x60017CA")]
    [Address(RVA = "0x3CD580", Offset = "0x3CC180", Length = "0x17D")]
    public static void StartNewMap(RunConfig newRunConfig)
    {
    }

    [Token(Token = "0x60017CB")]
    [Address(RVA = "0x3CDB60", Offset = "0x3CC760", Length = "0x47")]
    private static void TryCleanupInventory()
    {
    }

    [Token(Token = "0x60017CC")]
    [Address(RVA = "0x3CD150", Offset = "0x3CBD50", Length = "0x252")]
    public static void LoadNextStage()
    {
    }

    [Token(Token = "0x60017CD")]
    [Address(RVA = "0x3CCFA0", Offset = "0x3CBBA0", Length = "0x1A5")]
    public static void LoadFinalStage()
    {
    }

    [Token(Token = "0x60017CE")]
    [Address(RVA = "0x3CCE60", Offset = "0x3CBA60", Length = "0x3A")]
    public static bool IsFirstStage() => false;

    [Token(Token = "0x60017CF")]
    [Address(RVA = "0x3CCDA0", Offset = "0x3CB9A0", Length = "0x36")]
    public static int GetStageIndex() => 0;

    [Token(Token = "0x60017D0")]
    [Address(RVA = "0x3CCEA0", Offset = "0x3CBAA0", Length = "0x84")]
    public static bool IsLastStage() => false;

    [Token(Token = "0x60017D1")]
    [Address(RVA = "0x3CCE20", Offset = "0x3CBA20", Length = "0x37")]
    public static bool IsFinalBossStage() => false;

    [Token(Token = "0x60017D2")]
    [Address(RVA = "0x3CD700", Offset = "0x3CC300", Length = "0x4C")]
    public static void TestFinalBoss()
    {
    }

    [Token(Token = "0x60017D3")]
    [Address(RVA = "0x3CCF30", Offset = "0x3CBB30", Length = "0x69")]
    public static bool IsTierFinalStage() => false;

    [Token(Token = "0x60017D4")]
    [Address(RVA = "0x3CCCF0", Offset = "0x3CB8F0", Length = "0xAD")]
    public static PlayerInventory GetPlayerInventory(CharacterData data) => (PlayerInventory) null;

    [Token(Token = "0x60017D5")]
    [Address(RVA = "0x3CCDE0", Offset = "0x3CB9E0", Length = "0x3A")]
    public static bool HasPlayerInventory() => false;

    [Token(Token = "0x60017D6")]
    [Address(RVA = "0x3CD750", Offset = "0x3CC350", Length = "0x1E4")]
    public static void TestMap(MapData mapData, StageData stageData)
    {
    }

    [Token(Token = "0x60017D7")]
    [Address(RVA = "0x3CD940", Offset = "0x3CC540", Length = "0x21B")]
    public static void TestMap(RunConfig testConfig)
    {
    }

    [Token(Token = "0x60017D8")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public MapController()
    {
    }
  }
}
