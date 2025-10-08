// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemGasmask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003B9")]
  public class ItemGasmask : ItemBase
  {
    [Token(Token = "0x40018F0")]
    [FieldOffset(Offset = "0x30")]
    private float armorPerStack;
    [Token(Token = "0x40018F1")]
    [FieldOffset(Offset = "0x34")]
    private float overhealPerStack;
    [Token(Token = "0x40018F2")]
    [FieldOffset(Offset = "0x38")]
    private float maxArmorPerAmount;
    [Token(Token = "0x40018F3")]
    [FieldOffset(Offset = "0x3C")]
    private float maxOverhealPerAmount;
    [Token(Token = "0x40018F4")]
    [FieldOffset(Offset = "0x40")]
    private float maxArmor;
    [Token(Token = "0x40018F5")]
    [FieldOffset(Offset = "0x44")]
    private float maxOverheal;
    [Token(Token = "0x40018F6")]
    [FieldOffset(Offset = "0x48")]
    private int lastStoredStacks;
    [Token(Token = "0x40018F7")]
    [FieldOffset(Offset = "0x4C")]
    private float updateInverval;
    [Token(Token = "0x40018F8")]
    [FieldOffset(Offset = "0x50")]
    private float nextUpdateTime;

    [Token(Token = "0x6001A95")]
    [Address(RVA = "0x40D390", Offset = "0x40BF90", Length = "0x84")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001A96")]
    [Address(RVA = "0x40D640", Offset = "0x40C240", Length = "0x137")]
    private void UpdateRetaliation()
    {
    }

    [Token(Token = "0x6001A97")]
    [Address(RVA = "0x40D210", Offset = "0x40BE10", Length = "0x4D")]
    private int GetNumPoisonedEnemies() => 0;

    [Token(Token = "0x6001A98")]
    [Address(RVA = "0x40D420", Offset = "0x40C020", Length = "0x51")]
    private void OnStageStarted()
    {
    }

    [Token(Token = "0x6001A99")]
    [Address(RVA = "0x40D480", Offset = "0x40C080", Length = "0x1B1")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001A9A")]
    [Address(RVA = "0x40D780", Offset = "0x40C380", Length = "0x2B")]
    public ItemGasmask(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001A9B")]
    [Address(RVA = "0x40D260", Offset = "0x40BE60", Length = "0x120")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001A9C")]
    [Address(RVA = "0x40CFF0", Offset = "0x40BBF0", Length = "0x120")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001A9D")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001A9E")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001A9F")]
    [Address(RVA = "0x40D120", Offset = "0x40BD20", Length = "0xED")]
    protected override Dictionary<string, object> GetLocalizationKeys() => (Dictionary<string, object>) null;
  }
}
