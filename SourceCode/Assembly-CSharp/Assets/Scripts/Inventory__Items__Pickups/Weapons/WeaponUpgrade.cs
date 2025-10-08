// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Weapons.WeaponUpgrade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Weapons
{
  [Token(Token = "0x200036A")]
  [Serializable]
  public class WeaponUpgrade
  {
    [Token(Token = "0x400174E")]
    [FieldOffset(Offset = "0x10")]
    public List<StatModifier> statModifiers;

    [Token(Token = "0x600186C")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public WeaponUpgrade()
    {
    }
  }
}
