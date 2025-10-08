// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Stats.StatCategoryRatio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Assets.Scripts.Inventory__Items__Pickups.Stats
{
  [Token(Token = "0x2000381")]
  [Serializable]
  public class StatCategoryRatio
  {
    [Token(Token = "0x40017C6")]
    [FieldOffset(Offset = "0x10")]
    public EStatCategory category;
    [Token(Token = "0x40017C7")]
    [FieldOffset(Offset = "0x14")]
    public float value;

    [Token(Token = "0x600190A")]
    [Address(RVA = "0x3F6500", Offset = "0x3F5100", Length = "0x36")]
    public StatCategoryRatio(EStatCategory category, float value)
    {
    }
  }
}
