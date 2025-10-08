// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.SaveFiles.ProgressionSaveFile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.ShopItems;
using Assets.Scripts.Saves___Serialization.Progression;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Saves___Serialization.SaveFiles
{
  [Token(Token = "0x200031F")]
  [Serializable]
  public class ProgressionSaveFile
  {
    [Token(Token = "0x4001538")]
    [FieldOffset(Offset = "0x10")]
    public int gold;
    [Token(Token = "0x4001539")]
    [FieldOffset(Offset = "0x14")]
    public int silver;
    [Token(Token = "0x400153A")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<EShopItem, int> shopItems;
    [Token(Token = "0x400153B")]
    [FieldOffset(Offset = "0x20")]
    public Dictionary<ECharacter, CharacterProgression> characterProgression;
    [Token(Token = "0x400153C")]
    [FieldOffset(Offset = "0x28")]
    public HashSet<string> achievements;
    [Token(Token = "0x400153D")]
    [FieldOffset(Offset = "0x30")]
    public HashSet<string> claimedAchievements;
    [Token(Token = "0x400153E")]
    [FieldOffset(Offset = "0x38")]
    public HashSet<string> purchases;
    [Token(Token = "0x400153F")]
    [FieldOffset(Offset = "0x40")]
    public HashSet<string> inactivated;
    [Token(Token = "0x4001540")]
    [FieldOffset(Offset = "0x48")]
    public bool hasNewQuestDone;
    [Token(Token = "0x4001541")]
    [FieldOffset(Offset = "0x50")]
    public MenuMeta menuMeta;
    [Token(Token = "0x4001542")]
    [FieldOffset(Offset = "0x58")]
    public HashSet<string> newUnlockables;
    [Token(Token = "0x4001543")]
    [FieldOffset(Offset = "0x60")]
    public HashSet<string> newShopItems;
    [Token(Token = "0x4001544")]
    [FieldOffset(Offset = "0x68")]
    public HashSet<string> newMaps;
    [Token(Token = "0x4001545")]
    public static Action<int> A_SilverChanged;
    [Token(Token = "0x4001546")]
    public static Action<MyAchievement> A_AchievementClaimed;
    [Token(Token = "0x4001547")]
    public static Action<UnlockableBase> A_UnlockablePurchased;

    [Token(Token = "0x6001640")]
    [Address(RVA = "0x3B67C0", Offset = "0x3B53C0", Length = "0x53D")]
    public void Init()
    {
    }

    [Token(Token = "0x6001641")]
    [Address(RVA = "0x3B6D00", Offset = "0x3B5900", Length = "0x120")]
    public void OnDestroy()
    {
    }

    [Token(Token = "0x6001642")]
    [Address(RVA = "0x3B6390", Offset = "0x3B4F90", Length = "0x22D")]
    public void CompleteAchievement(MyAchievement achievement)
    {
    }

    [Token(Token = "0x6001643")]
    [Address(RVA = "0x3B7160", Offset = "0x3B5D60", Length = "0x143")]
    public bool PurchaseUnlockable(UnlockableBase unlockable) => false;

    [Token(Token = "0x6001644")]
    [Address(RVA = "0x3B6770", Offset = "0x3B5370", Length = "0x4B")]
    public bool HasUnclaimedQuests() => false;

    [Token(Token = "0x6001645")]
    [Address(RVA = "0x3B7040", Offset = "0x3B5C40", Length = "0x110")]
    public bool PurchaseShopItem(ShopItemData shopItemData) => false;

    [Token(Token = "0x6001646")]
    [Address(RVA = "0x3B72B0", Offset = "0x3B5EB0", Length = "0xB3")]
    public bool RefundShopItem(ShopItemData shopItemData) => false;

    [Token(Token = "0x6001647")]
    [Address(RVA = "0x3B6260", Offset = "0x3B4E60", Length = "0x71")]
    public void AddSilver(int change)
    {
    }

    [Token(Token = "0x6001648")]
    [Address(RVA = "0x3B7370", Offset = "0x3B5F70", Length = "0x5E")]
    public void RemoveSilver(int change)
    {
    }

    [Token(Token = "0x6001649")]
    [Address(RVA = "0x3B62E0", Offset = "0x3B4EE0", Length = "0xA2")]
    public void ClaimAchievement(MyAchievement achievement)
    {
    }

    [Token(Token = "0x600164A")]
    [Address(RVA = "0x3B6710", Offset = "0x3B5310", Length = "0x57")]
    public bool HasShopItem(EShopItem eShopItem) => false;

    [Token(Token = "0x600164B")]
    [Address(RVA = "0x3B66B0", Offset = "0x3B52B0", Length = "0x51")]
    public int GetShopItemLevel(EShopItem eShopItem) => 0;

    [Token(Token = "0x600164C")]
    [Address(RVA = "0x3B6E30", Offset = "0x3B5A30", Length = "0x208")]
    private void OnGameOver()
    {
    }

    [Token(Token = "0x600164D")]
    [Address(RVA = "0x3B65C0", Offset = "0x3B51C0", Length = "0xE1")]
    public CharacterProgression GetCharacterProgression(ECharacter character) => (CharacterProgression) null;

    [Token(Token = "0x600164E")]
    [Address(RVA = "0x3B73D0", Offset = "0x3B5FD0", Length = "0x2D6")]
    public ProgressionSaveFile()
    {
    }
  }
}
