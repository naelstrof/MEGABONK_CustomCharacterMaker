// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Spawning.New.EnemyCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Game.Spawning.New
{
  [Token(Token = "0x2000411")]
  public class EnemyCard
  {
    [Token(Token = "0x4001A9F")]
    [FieldOffset(Offset = "0x10")]
    private float costInfluenceOnWeight;
    [Token(Token = "0x4001AA0")]
    [FieldOffset(Offset = "0x18")]
    public EnemyData enemy;
    [Token(Token = "0x4001AA1")]
    [FieldOffset(Offset = "0x20")]
    public bool isElite;
    [Token(Token = "0x4001AA2")]
    [FieldOffset(Offset = "0x24")]
    public float cost;
    [Token(Token = "0x4001AA3")]
    [FieldOffset(Offset = "0x28")]
    public float weight;

    [Token(Token = "0x6001D3D")]
    [Address(RVA = "0x420110", Offset = "0x41ED10", Length = "0x61")]
    public EnemyCard(EnemyData enemy, bool isElite)
    {
    }

    [Token(Token = "0x6001D3E")]
    [Address(RVA = "0x41FF80", Offset = "0x41EB80", Length = "0x84")]
    public void RefreshWeightAndCost()
    {
    }

    [Token(Token = "0x6001D3F")]
    [Address(RVA = "0x420010", Offset = "0x41EC10", Length = "0xF1")]
    public new string ToString() => (string) null;
  }
}
