// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.InventoryUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data;
using Assets.Scripts.Inventory__Items__Pickups.Items;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups
{
  [Token(Token = "0x200035C")]
  public class InventoryUtility
  {
    [Token(Token = "0x60017E5")]
    [Address(RVA = "0x3E7FE0", Offset = "0x3E6BE0", Length = "0x585")]
    public static List<IUpgradable> GetRandomUpgrades() => (List<IUpgradable>) null;

    [Token(Token = "0x60017E6")]
    [Address(RVA = "0x3E74C0", Offset = "0x3E60C0", Length = "0x5A8")]
    public static List<ItemData> GetRandomItemsMoai(int moaiLuckMode) => (List<ItemData>) null;

    [Token(Token = "0x60017E7")]
    [Address(RVA = "0x3E7A70", Offset = "0x3E6670", Length = "0x560")]
    public static List<ItemData> GetRandomItemsShadyGuy(EItemRarity itemRarity) => (List<ItemData>) null;

    [Token(Token = "0x60017E8")]
    [Address(RVA = "0x3E74B0", Offset = "0x3E60B0", Length = "0x6")]
    private static int GetNumUpgrades() => 0;

    [Token(Token = "0x60017E9")]
    [Address(RVA = "0x3E6EF0", Offset = "0x3E5AF0", Length = "0x2CB")]
    private static bool CanUnlockItem(IUpgradable upgradable) => false;

    [Token(Token = "0x60017EA")]
    [Address(RVA = "0x3E72D0", Offset = "0x3E5ED0", Length = "0x10D")]
    private static bool CanUnlockWeapons() => false;

    [Token(Token = "0x60017EB")]
    [Address(RVA = "0x3E71C0", Offset = "0x3E5DC0", Length = "0x10D")]
    private static bool CanUnlockTomes() => false;

    [Token(Token = "0x60017EC")]
    [Address(RVA = "0x3E7440", Offset = "0x3E6040", Length = "0x5F")]
    public static int GetNumAvailableWeaponSlots() => 0;

    [Token(Token = "0x60017ED")]
    [Address(RVA = "0x3E73E0", Offset = "0x3E5FE0", Length = "0x5F")]
    public static int GetNumAvailableTomeSlots() => 0;

    [Token(Token = "0x60017EE")]
    [Address(RVA = "0x3E74A0", Offset = "0x3E60A0", Length = "0x6")]
    public static int GetNumMaxWeaponSlots() => 0;

    [Token(Token = "0x60017EF")]
    [Address(RVA = "0x3E74A0", Offset = "0x3E60A0", Length = "0x6")]
    public static int GetNumMaxTomeSlots() => 0;

    [Token(Token = "0x60017F0")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public InventoryUtility()
    {
    }
  }
}
