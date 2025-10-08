// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.StatModifiersContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items
{
  [Token(Token = "0x2000397")]
  public class StatModifiersContainer
  {
    [Token(Token = "0x4001857")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<EStatModifyType, StatModifier> statContainers;

    [Token(Token = "0x6001972")]
    [Address(RVA = "0x4194D0", Offset = "0x4180D0", Length = "0x5B")]
    public void SetModifier(StatModifier statModifier)
    {
    }

    [Token(Token = "0x6001973")]
    [Address(RVA = "0x419480", Offset = "0x418080", Length = "0x44")]
    public IEnumerable<StatModifier> GetModifiers() => (IEnumerable<StatModifier>) null;

    [Token(Token = "0x6001974")]
    [Address(RVA = "0x419530", Offset = "0x418130", Length = "0x77")]
    public StatModifiersContainer()
    {
    }
  }
}
