// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.PassiveAbility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Items;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine.Localization;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive
{
  [Token(Token = "0x20003F1")]
  public abstract class PassiveAbility
  {
    [Token(Token = "0x4001A3A")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<EStat, StatModifiersContainer> statModifiers;
    [Token(Token = "0x4001A3B")]
    public static Action<EStat> A_StatModified;

    [Token(Token = "0x6001C6D")]
    [Address(RVA = "0x434750", Offset = "0x433350", Length = "0x13D")]
    protected void SetStat(StatModifier statModifier)
    {
    }

    [Token(Token = "0x6001C6E")]
    public abstract void Init();

    [Token(Token = "0x6001C6F")]
    public abstract void Cleanup();

    [Token(Token = "0x6001C70")]
    public abstract void Tick();

    [Token(Token = "0x6001C71")]
    public abstract EPassive GetPassiveType();

    [Token(Token = "0x6001C72")]
    [Address(RVA = "0x42E9F0", Offset = "0x42D5F0", Length = "0x1F")]
    public virtual string GetDescription(LocalizedString localizedString) => (string) null;

    [Token(Token = "0x6001C73")]
    [Address(RVA = "0x434890", Offset = "0x433490", Length = "0x77")]
    protected PassiveAbility()
    {
    }
  }
}
