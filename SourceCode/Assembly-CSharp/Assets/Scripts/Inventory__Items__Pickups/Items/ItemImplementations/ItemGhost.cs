// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations.ItemGhost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
{
  [Token(Token = "0x20003BA")]
  public class ItemGhost : ItemBase
  {
    [Token(Token = "0x40018F9")]
    public const int maxGhosts = 100;
    [Token(Token = "0x40018FA")]
    [FieldOffset(Offset = "0x30")]
    private int numGhosts;
    [Token(Token = "0x40018FB")]
    [FieldOffset(Offset = "0x34")]
    private int numGhostsPerAmount;
    [Token(Token = "0x40018FC")]
    [FieldOffset(Offset = "0x38")]
    private string damageSource;

    [Token(Token = "0x6001AA0")]
    [Address(RVA = "0x40DAA0", Offset = "0x40C6A0", Length = "0xB")]
    protected override void OnInitOrAmountChanged()
    {
    }

    [Token(Token = "0x6001AA1")]
    [Address(RVA = "0x40DAB0", Offset = "0x40C6B0", Length = "0x133")]
    private void OnInteracted(BaseInteractable interactable, bool success)
    {
    }

    [Token(Token = "0x6001AA2")]
    [Address(RVA = "0x40DBF0", Offset = "0x40C7F0", Length = "0xF5")]
    private void SpawnGhost()
    {
    }

    [Token(Token = "0x6001AA3")]
    [Address(RVA = "0x40D950", Offset = "0x40C550", Length = "0x1B")]
    private float GetDuration() => 0.0f;

    [Token(Token = "0x6001AA4")]
    [Address(RVA = "0x40D8E0", Offset = "0x40C4E0", Length = "0x65")]
    private float GetDamage() => 0.0f;

    [Token(Token = "0x6001AA5")]
    [Address(RVA = "0x40D970", Offset = "0x40C570", Length = "0x121")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001AA6")]
    [Address(RVA = "0x40D7B0", Offset = "0x40C3B0", Length = "0x121")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001AA7")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001AA8")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier)
    {
    }

    [Token(Token = "0x6001AA9")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public override void ProcOnHitEffects(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001AAA")]
    [Address(RVA = "0x40DCF0", Offset = "0x40C8F0", Length = "0x85")]
    public ItemGhost(ItemInventory itemInventoryRef)
      : base((ItemInventory) null)
    {
    }
  }
}
