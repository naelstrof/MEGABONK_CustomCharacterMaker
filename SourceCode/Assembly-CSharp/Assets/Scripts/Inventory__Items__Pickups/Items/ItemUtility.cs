// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Interactables;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Items
{
  [Token(Token = "0x2000396")]
  public static class ItemUtility
  {
    [Token(Token = "0x600196E")]
    [Address(RVA = "0x418710", Offset = "0x417310", Length = "0x31C")]
    public static ItemData GetRandomChestItem(EChest chestType, float luck) => (ItemData) null;

    [Token(Token = "0x600196F")]
    [Address(RVA = "0x418C50", Offset = "0x417850", Length = "0x18")]
    public static ItemData GetRandomItem(float luck) => (ItemData) null;

    [Token(Token = "0x6001970")]
    [Address(RVA = "0x418A30", Offset = "0x417630", Length = "0x219")]
    public static ItemData GetRandomItemFromRarity(EItemRarity rarity) => (ItemData) null;

    [Token(Token = "0x6001971")]
    [Address(RVA = "0x418C70", Offset = "0x417870", Length = "0x97")]
    public static bool TryProc(float procCoefficient, float baseProcChance) => false;
  }
}
