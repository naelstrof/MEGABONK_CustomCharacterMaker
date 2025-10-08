// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Stats.PlayerStatusEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Pickups;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Stats
{
  [Token(Token = "0x2000380")]
  public class PlayerStatusEffects
  {
    [Token(Token = "0x40017BC")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<EStatusEffect, StatusEffect> statusEffects;
    [Token(Token = "0x40017BD")]
    public static Action<EStat> A_StatusModifiedStat;
    [Token(Token = "0x40017BE")]
    public static Action<EStatusEffect, bool> A_StatusEffectAdded;
    [Token(Token = "0x40017BF")]
    public static Action<EStatusEffect> A_StatusEffectRemoved;
    [Token(Token = "0x40017C0")]
    public const string poisonEffectName = "Poison";
    [Token(Token = "0x40017C1")]
    public const string bleedEffectName = "Poison";
    [Token(Token = "0x40017C2")]
    [FieldOffset(Offset = "0x18")]
    private float nextBleedTime;
    [Token(Token = "0x40017C3")]
    [FieldOffset(Offset = "0x1C")]
    private float bleedInterval;
    [Token(Token = "0x40017C4")]
    [FieldOffset(Offset = "0x20")]
    private float nextPoisonTime;
    [Token(Token = "0x40017C5")]
    [FieldOffset(Offset = "0x24")]
    private float poisonInterval;

    [Token(Token = "0x60018F9")]
    [Address(RVA = "0x3F0D30", Offset = "0x3EF930", Length = "0x281")]
    public PlayerStatusEffects()
    {
    }

    [Token(Token = "0x60018FA")]
    [Address(RVA = "0x3EF430", Offset = "0x3EE030", Length = "0x223")]
    public void OnDestroy()
    {
    }

    [Token(Token = "0x60018FB")]
    [Address(RVA = "0x3F0A00", Offset = "0x3EF600", Length = "0x329")]
    public void Tick()
    {
    }

    [Token(Token = "0x60018FC")]
    [Address(RVA = "0x3EEEB0", Offset = "0x3EDAB0", Length = "0x1B1")]
    public void AddNewEffect(StatusEffect statusEffect, float statusLengthTime)
    {
    }

    [Token(Token = "0x60018FD")]
    [Address(RVA = "0x3F0150", Offset = "0x3EED50", Length = "0x156")]
    private void RemoveStatusEffect(EStatusEffect eStatusEffect)
    {
    }

    [Token(Token = "0x60018FE")]
    [Address(RVA = "0x3F0010", Offset = "0x3EEC10", Length = "0x13B")]
    public void RemoveAllStatusEffects()
    {
    }

    [Token(Token = "0x60018FF")]
    [Address(RVA = "0x3EF3D0", Offset = "0x3EDFD0", Length = "0x51")]
    public bool HasStatusEffect(EStatusEffect effect) => false;

    [Token(Token = "0x6001900")]
    [Address(RVA = "0x3F0430", Offset = "0x3EF030", Length = "0x8")]
    public void TestPickup(EPickup ePickup)
    {
    }

    [Token(Token = "0x6001901")]
    [Address(RVA = "0x3EF7E0", Offset = "0x3EE3E0", Length = "0x1D")]
    private void OnPickupTriggered(Pickup pickup)
    {
    }

    [Token(Token = "0x6001902")]
    [Address(RVA = "0x3F02B0", Offset = "0x3EEEB0", Length = "0x17C")]
    public void SlowPlayer(float time)
    {
    }

    [Token(Token = "0x6001903")]
    [Address(RVA = "0x3EF250", Offset = "0x3EDE50", Length = "0x17C")]
    public void FreezePlayer(float time)
    {
    }

    [Token(Token = "0x6001904")]
    [Address(RVA = "0x3EF070", Offset = "0x3EDC70", Length = "0xE8")]
    public void BleedPlayer(float duration)
    {
    }

    [Token(Token = "0x6001905")]
    [Address(RVA = "0x3EFD60", Offset = "0x3EE960", Length = "0x2AC")]
    public void PoisonPlayer(float duration)
    {
    }

    [Token(Token = "0x6001906")]
    [Address(RVA = "0x3EF160", Offset = "0x3EDD60", Length = "0xE8")]
    public void BossPoisonPlayer(float duration)
    {
    }

    [Token(Token = "0x6001907")]
    [Address(RVA = "0x3EF800", Offset = "0x3EE400", Length = "0x55D")]
    private void OnPickupTriggered(EPickup ePickup)
    {
    }

    [Token(Token = "0x6001908")]
    [Address(RVA = "0x3EF660", Offset = "0x3EE260", Length = "0x17C")]
    private void OnLevelupScreenDone()
    {
    }

    [Token(Token = "0x6001909")]
    [Address(RVA = "0x3F0440", Offset = "0x3EF040", Length = "0x5BC")]
    private void TickEffects()
    {
    }
  }
}
