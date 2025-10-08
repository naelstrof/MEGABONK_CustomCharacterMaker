// Decompiled with JetBrains decompiler
// Type: ItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Items;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "Me/Item", order = 1)]
[Token(Token = "0x2000219")]
public class ItemData : UnlockableBase
{
  [Token(Token = "0x4000EB4")]
  [FieldOffset(Offset = "0x50")]
  public bool inItemPool;
  [Token(Token = "0x4000EB5")]
  [FieldOffset(Offset = "0x54")]
  public EItem eItem;
  [TextArea]
  [Token(Token = "0x4000EB6")]
  [FieldOffset(Offset = "0x58")]
  public string description;
  [TextArea]
  [Token(Token = "0x4000EB7")]
  [FieldOffset(Offset = "0x60")]
  public string shortDescription;
  [Token(Token = "0x4000EB8")]
  [FieldOffset(Offset = "0x68")]
  public Texture icon;
  [Token(Token = "0x4000EB9")]
  [FieldOffset(Offset = "0x70")]
  public EItemRarity rarity;
  [Token(Token = "0x4000EBA")]
  [FieldOffset(Offset = "0x78")]
  public MyAchievement unlockRequirement;
  [Token(Token = "0x4000EBB")]
  [FieldOffset(Offset = "0x80")]
  public int maxAmount;
  [Token(Token = "0x4000EBC")]
  [FieldOffset(Offset = "0x88")]
  private ItemBase dummyItem;

  [Token(Token = "0x6000D9A")]
  [Address(RVA = "0x3A9060", Offset = "0x3A7C60", Length = "0x1D")]
  public override string GetName() => (string) null;

  [Token(Token = "0x6000D9B")]
  [Address(RVA = "0x5278C0", Offset = "0x5264C0", Length = "0x34")]
  public override string GetDescription() => (string) null;

  [Token(Token = "0x6000D9C")]
  [Address(RVA = "0x5279B0", Offset = "0x5265B0", Length = "0x14")]
  public string GetShortDescription() => (string) null;

  [Token(Token = "0x6000D9D")]
  [Address(RVA = "0x527900", Offset = "0x526500", Length = "0x50")]
  public ItemBase GetDummyItem() => (ItemBase) null;

  [Token(Token = "0x6000D9E")]
  [Address(RVA = "0x41E7E0", Offset = "0x41D3E0", Length = "0x5")]
  public override Texture GetIcon() => (Texture) null;

  [Token(Token = "0x6000D9F")]
  [Address(RVA = "0x3D1A90", Offset = "0x3D0690", Length = "0x5")]
  public override MyAchievement GetUnlockRequirement() => (MyAchievement) null;

  [Token(Token = "0x6000DA0")]
  [Address(RVA = "0x395320", Offset = "0x393F20", Length = "0x3")]
  public override UnlockableBase GetUnlockableRequirement() => (UnlockableBase) null;

  [Token(Token = "0x6000DA1")]
  [Address(RVA = "0x5279D0", Offset = "0x5265D0", Length = "0x63")]
  public override string GetUnlockableTypeDisplayString() => (string) null;

  [Token(Token = "0x6000DA2")]
  [Address(RVA = "0x527950", Offset = "0x526550", Length = "0x53")]
  public override string GetInternalName() => (string) null;

  [Token(Token = "0x6000DA3")]
  [Address(RVA = "0x527850", Offset = "0x526450", Length = "0x67")]
  public Color GetColor() => new Color();

  [Token(Token = "0x6000DA4")]
  [Address(RVA = "0x527720", Offset = "0x526320", Length = "0x122")]
  public override int CompareTo(UnlockableBase other) => 0;

  [Token(Token = "0x6000DA5")]
  [Address(RVA = "0x527A40", Offset = "0x526640", Length = "0xB")]
  public ItemData()
  {
  }
}
