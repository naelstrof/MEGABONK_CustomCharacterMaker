// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemAttackModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Items
{
  [Token(Token = "0x2000390")]
  public class ItemAttackModifier
  {
    [Token(Token = "0x4001845")]
    [FieldOffset(Offset = "0x10")]
    public float flatValues;
    [Token(Token = "0x4001846")]
    [FieldOffset(Offset = "0x14")]
    public float additiveValues;
    [Token(Token = "0x4001847")]
    [FieldOffset(Offset = "0x18")]
    public float multiplicativeValues;

    [Token(Token = "0x6001948")]
    [Address(RVA = "0x400AD0", Offset = "0x3FF6D0", Length = "0xE")]
    public void Recycle()
    {
    }

    [field: Token(Token = "0x4001848")]
    [field: FieldOffset(Offset = "0x1C")]
    [Token(Token = "0x1700038A")]
    public float damageMultiplier { [Token(Token = "0x6001949"), Address(RVA = "0x393330", Offset = "0x391F30", Length = "0x6")] get; [Token(Token = "0x600194A"), Address(RVA = "0x3933B0", Offset = "0x391FB0", Length = "0x6")] private set; }

    [Token(Token = "0x600194B")]
    [Address(RVA = "0x400AA0", Offset = "0x3FF6A0", Length = "0x22")]
    public void Apply(DamageContainer dc)
    {
    }

    [Token(Token = "0x600194C")]
    [Address(RVA = "0x400A90", Offset = "0x3FF690", Length = "0xB")]
    public void AddMultiplier(float multiplier)
    {
    }

    [Token(Token = "0x600194D")]
    [Address(RVA = "0x400AE0", Offset = "0x3FF6E0", Length = "0x15")]
    public ItemAttackModifier()
    {
    }
  }
}
