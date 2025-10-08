// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemElectricPlug
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003B4")]
  public class ItemElectricPlug : ItemBase
  {
    [Token(Token = "0x40018D8")]
    [FieldOffset(Offset = "0x30")]
    private string damageSource;
    [Token(Token = "0x40018D9")]
    [FieldOffset(Offset = "0x38")]
    private DamageContainer reuseDc;
    [Token(Token = "0x40018DA")]
    [FieldOffset(Offset = "0x40")]
    private float radius;
    [Token(Token = "0x40018DB")]
    [FieldOffset(Offset = "0x44")]
    private float radiusPerAmount;
    [Token(Token = "0x40018DC")]
    [FieldOffset(Offset = "0x48")]
    private int targets;
    [Token(Token = "0x40018DD")]
    [FieldOffset(Offset = "0x4C")]
    private int targetsPerAmount;

    [Token(Token = "0x6001A6B")]
    [Address(RVA = "0x409EC0", Offset = "0x408AC0", Length = "0x42")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001A6C")]
    [Address(RVA = "0x409D10", Offset = "0x408910", Length = "0x69")]
    private float GetDamage() => 0.0f;

    [Token(Token = "0x6001A6D")]
    [Address(RVA = "0x409D80", Offset = "0x408980", Length = "0x138")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001A6E")]
    [Address(RVA = "0x409BD0", Offset = "0x4087D0", Length = "0x138")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001A6F")]
    [Address(RVA = "0x409F10", Offset = "0x408B10", Length = "0x4DC")]
    private void OnPlayerHit()
    {
    }

    [Token(Token = "0x6001A70")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001A71")]
    [Address(RVA = "0x40A3F0", Offset = "0x408FF0", Length = "0x11B")]
    public ItemElectricPlug(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x6001A72")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001A73")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }
  }
}
