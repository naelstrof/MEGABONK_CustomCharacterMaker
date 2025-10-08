// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Spawning.New.Summoners.BossSummoner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Spawning.New.Summoners
{
  [Token(Token = "0x2000419")]
  public class BossSummoner : BaseSummoner
  {
    [Token(Token = "0x6001D7B")]
    [Address(RVA = "0x41DC10", Offset = "0x41C810", Length = "0x8")]
    public BossSummoner(int id, List<EEnemy> defaultEnemies)
      : base(0, (List<EEnemy>) null)
    {
    }

    [Token(Token = "0x6001D7C")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void Init()
    {
    }

    [Token(Token = "0x6001D7D")]
    [Address(RVA = "0x395320", Offset = "0x393F20", Length = "0x3")]
    protected override List<EEnemy> GetEnemies() => (List<EEnemy>) null;

    [Token(Token = "0x6001D7E")]
    [Address(RVA = "0x3573F0", Offset = "0x355FF0", Length = "0x4")]
    public override float GetSummonInterval() => 0.0f;

    [Token(Token = "0x6001D7F")]
    [Address(RVA = "0x3573F0", Offset = "0x355FF0", Length = "0x4")]
    public override float GetBaseCreditsPerSecond() => 0.0f;

    [Token(Token = "0x6001D80")]
    [Address(RVA = "0x3573F0", Offset = "0x355FF0", Length = "0x4")]
    public override float GetInitialCredits() => 0.0f;

    [Token(Token = "0x6001D81")]
    [Address(RVA = "0x395320", Offset = "0x393F20", Length = "0x3")]
    public override int GetNumTargetEnemies() => 0;

    [Token(Token = "0x6001D82")]
    [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
    protected override bool UseDirectionBias() => false;

    [Token(Token = "0x6001D83")]
    [Address(RVA = "0x375D80", Offset = "0x374980", Length = "0x3")]
    protected override bool ForceSpawn() => false;
  }
}
