// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Other.RunConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Other
{
  [Token(Token = "0x200041E")]
  public class RunConfig
  {
    [Token(Token = "0x4001AE7")]
    [FieldOffset(Offset = "0x10")]
    public MapData mapData;
    [Token(Token = "0x4001AE8")]
    [FieldOffset(Offset = "0x18")]
    public StageData stageData;
    [Token(Token = "0x4001AE9")]
    [FieldOffset(Offset = "0x20")]
    public int mapTierIndex;
    [Token(Token = "0x4001AEA")]
    [FieldOffset(Offset = "0x28")]
    public ChallengeData challenge;
    [Token(Token = "0x4001AEB")]
    [FieldOffset(Offset = "0x30")]
    public int musicTrackIndex;
    [Token(Token = "0x4001AEC")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<int, float> tierSilverMultipliers;

    [Token(Token = "0x6001DB1")]
    [Address(RVA = "0x452580", Offset = "0x451180", Length = "0x35")]
    public float GetEnemyHp(float hp) => 0.0f;

    [Token(Token = "0x6001DB2")]
    [Address(RVA = "0x4525C0", Offset = "0x4511C0", Length = "0x35")]
    public float GetEnemySpeed(float speed) => 0.0f;

    [Token(Token = "0x6001DB3")]
    [Address(RVA = "0x452540", Offset = "0x451140", Length = "0x35")]
    public float GetEnemyDamage(float value) => 0.0f;

    [Token(Token = "0x6001DB4")]
    [Address(RVA = "0x452780", Offset = "0x451380", Length = "0x29")]
    private float MapTierMultiplier(float value) => 0.0f;

    [Token(Token = "0x6001DB5")]
    [Address(RVA = "0x4526C0", Offset = "0x4512C0", Length = "0xB5")]
    public float GetSilverMultiplier() => 0.0f;

    [Token(Token = "0x6001DB6")]
    [Address(RVA = "0x452600", Offset = "0x451200", Length = "0xBB")]
    public string GetFormattedSilverMultiplier() => (string) null;

    [Token(Token = "0x6001DB7")]
    [Address(RVA = "0x4527B0", Offset = "0x4513B0", Length = "0xE5")]
    public RunConfig()
    {
    }
  }
}
