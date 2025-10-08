// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemSuckyHoof
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Items
{
  [Token(Token = "0x2000394")]
  public class ItemSuckyHoof : ItemBase
  {
    [Token(Token = "0x4001850")]
    [FieldOffset(Offset = "0x30")]
    private float range;
    [Token(Token = "0x4001851")]
    [FieldOffset(Offset = "0x34")]
    private float interval;
    [Token(Token = "0x4001852")]
    [FieldOffset(Offset = "0x38")]
    private float nextSuckTime;

    [Token(Token = "0x600195B")]
    [Address(RVA = "0x4183C0", Offset = "0x416FC0", Length = "0x37")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x600195C")]
    [Address(RVA = "0x418400", Offset = "0x417000", Length = "0x2F9")]
    public override void Tick()
    {
    }

    [Token(Token = "0x600195D")]
    [Address(RVA = "0x418700", Offset = "0x417300", Length = "0xF")]
    public ItemSuckyHoof(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }

    [Token(Token = "0x600195E")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Init()
    {
    }

    [Token(Token = "0x600195F")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001960")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001961")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }
  }
}
