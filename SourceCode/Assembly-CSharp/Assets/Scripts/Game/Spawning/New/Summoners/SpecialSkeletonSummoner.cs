// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Spawning.New.Summoners.SpecialSkeletonSummoner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Spawning.New.Summoners
{
  [Token(Token = "0x200041B")]
  public class SpecialSkeletonSummoner : BaseSummoner
  {
    [Token(Token = "0x6001D8F")]
    [Address(RVA = "0x41DC10", Offset = "0x41C810", Length = "0x8")]
    public SpecialSkeletonSummoner(int id, List<EEnemy> defaultEnemies)
      : base(0, (List<EEnemy>) null)
    {
    }

    [Token(Token = "0x6001D90")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void Init()
    {
    }

    [Token(Token = "0x6001D91")]
    [Address(RVA = "0x4371C0", Offset = "0x435DC0", Length = "0x11A")]
    protected override List<EEnemy> GetEnemies() => (List<EEnemy>) null;

    [Token(Token = "0x6001D92")]
    [Address(RVA = "0x437300", Offset = "0x435F00", Length = "0xC8")]
    public override List<Enemy> SpendCredits(bool useWeights = true) => (List<Enemy>) null;

    [Token(Token = "0x6001D93")]
    [Address(RVA = "0x4372F0", Offset = "0x435EF0", Length = "0x9")]
    public override float GetSummonInterval() => 0.0f;

    [Token(Token = "0x6001D94")]
    [Address(RVA = "0x3573F0", Offset = "0x355FF0", Length = "0x4")]
    public override float GetBaseCreditsPerSecond() => 0.0f;

    [Token(Token = "0x6001D95")]
    [Address(RVA = "0x4372E0", Offset = "0x435EE0", Length = "0x9")]
    public override float GetInitialCredits() => 0.0f;

    [Token(Token = "0x6001D96")]
    [Address(RVA = "0x430D40", Offset = "0x42F940", Length = "0x6")]
    public override int GetNumTargetEnemies() => 0;

    [Token(Token = "0x6001D97")]
    [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
    protected override bool UseDirectionBias() => false;

    [Token(Token = "0x6001D98")]
    [Address(RVA = "0x375D80", Offset = "0x374980", Length = "0x3")]
    protected override bool ForceSpawn() => false;

    [Token(Token = "0x6001D99")]
    [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
    protected override bool UseMultiplier() => false;
  }
}
