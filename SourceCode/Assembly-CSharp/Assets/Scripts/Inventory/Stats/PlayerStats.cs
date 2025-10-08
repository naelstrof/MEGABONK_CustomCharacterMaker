// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory.Stats.PlayerStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory.Stats
{
  [Token(Token = "0x200035B")]
  public static class PlayerStats
  {
    [Token(Token = "0x60017E1")]
    [Address(RVA = "0x3EECD0", Offset = "0x3ED8D0", Length = "0x13E")]
    public static float GetStat(EStat stat) => 0.0f;

    [Token(Token = "0x60017E2")]
    [Address(RVA = "0x3EEB60", Offset = "0x3ED760", Length = "0x16F")]
    public static float GetStatRaw(EStat stat) => 0.0f;

    [Token(Token = "0x60017E3")]
    [Address(RVA = "0x3EEA00", Offset = "0x3ED600", Length = "0x157")]
    public static StatComponents GetStatComponents(EStat stat) => (StatComponents) null;

    [Token(Token = "0x60017E4")]
    [Address(RVA = "0x3EEE10", Offset = "0x3EDA10", Length = "0x99")]
    public static bool HasStats() => false;
  }
}
