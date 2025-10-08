// Decompiled with JetBrains decompiler
// Type: ShopItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.ShopItems;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "Me/Shop Item", order = 1)]
[Token(Token = "0x2000225")]
public class ShopItemData : UnlockableBase
{
  [Token(Token = "0x4000F01")]
  [FieldOffset(Offset = "0x50")]
  public EShopItem eShopItem;
  [Token(Token = "0x4000F02")]
  [FieldOffset(Offset = "0x58")]
  public Texture icon;
  [Token(Token = "0x4000F03")]
  [FieldOffset(Offset = "0x60")]
  public int maxLevel;
  [Token(Token = "0x4000F04")]
  [FieldOffset(Offset = "0x68")]
  public MyAchievement unlockRequirement;
  [Token(Token = "0x4000F05")]
  [FieldOffset(Offset = "0x70")]
  public bool canRefund;
  [Token(Token = "0x4000F06")]
  [FieldOffset(Offset = "0x74")]
  public float value;
  [Token(Token = "0x4000F07")]
  [FieldOffset(Offset = "0x78")]
  public int sortingOrder;
  [Header("Price Settings")]
  [Token(Token = "0x4000F08")]
  [FieldOffset(Offset = "0x7C")]
  public int linearIncrease;
  [Token(Token = "0x4000F09")]
  [FieldOffset(Offset = "0x80")]
  public float exponentialMultiplier;

  [Token(Token = "0x6000DDE")]
  [Address(RVA = "0x3992E0", Offset = "0x397EE0", Length = "0x5")]
  public override Texture GetIcon() => (Texture) null;

  [Token(Token = "0x6000DDF")]
  [Address(RVA = "0x41E7E0", Offset = "0x41D3E0", Length = "0x5")]
  public override MyAchievement GetUnlockRequirement() => (MyAchievement) null;

  [Token(Token = "0x6000DE0")]
  [Address(RVA = "0x395320", Offset = "0x393F20", Length = "0x3")]
  public override UnlockableBase GetUnlockableRequirement() => (UnlockableBase) null;

  [Token(Token = "0x6000DE1")]
  [Address(RVA = "0x52D2B0", Offset = "0x52BEB0", Length = "0x46")]
  public override string GetUnlockableTypeDisplayString() => (string) null;

  [Token(Token = "0x6000DE2")]
  [Address(RVA = "0x52CF50", Offset = "0x52BB50", Length = "0x53")]
  public override string GetInternalName() => (string) null;

  [Token(Token = "0x6000DE3")]
  [Address(RVA = "0x52CFB0", Offset = "0x52BBB0", Length = "0xBA")]
  private int GetLevelPrice(int level) => 0;

  [Token(Token = "0x6000DE4")]
  [Address(RVA = "0x52D250", Offset = "0x52BE50", Length = "0x22")]
  public override int GetPrice() => 0;

  [Token(Token = "0x6000DE5")]
  [Address(RVA = "0x52D280", Offset = "0x52BE80", Length = "0x23")]
  public int GetRefundPrice() => 0;

  [Token(Token = "0x6000DE6")]
  [Address(RVA = "0x52D070", Offset = "0x52BC70", Length = "0xB9")]
  public int GetLevel() => 0;

  [Token(Token = "0x6000DE7")]
  [Address(RVA = "0x52D300", Offset = "0x52BF00", Length = "0x1E5")]
  public bool IsMaxLevel() => false;

  [Token(Token = "0x6000DE8")]
  [Address(RVA = "0x52CCE0", Offset = "0x52B8E0", Length = "0xD8")]
  public new bool CanBuy() => false;

  [Token(Token = "0x6000DE9")]
  [Address(RVA = "0x52CDC0", Offset = "0x52B9C0", Length = "0x22")]
  public bool CanRefund() => false;

  [Token(Token = "0x6000DEA")]
  [Address(RVA = "0x52D130", Offset = "0x52BD30", Length = "0x115")]
  public int GetMaxLevel() => 0;

  [Token(Token = "0x6000DEB")]
  [Address(RVA = "0x52CDF0", Offset = "0x52B9F0", Length = "0x154")]
  public override int CompareTo(UnlockableBase other) => 0;

  [Token(Token = "0x6000DEC")]
  [Address(RVA = "0x52D4F0", Offset = "0x52C0F0", Length = "0x1C")]
  public ShopItemData()
  {
  }
}
