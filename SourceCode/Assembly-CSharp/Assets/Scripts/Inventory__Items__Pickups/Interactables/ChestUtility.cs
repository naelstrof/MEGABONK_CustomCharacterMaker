// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Interactables.ChestUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.UI.InGame.Rewards;
using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Interactables
{
  [Token(Token = "0x20003EB")]
  public class ChestUtility
  {
    [Token(Token = "0x6001C57")]
    [Address(RVA = "0x41EFA0", Offset = "0x41DBA0", Length = "0xCC")]
    public static EEncounter ChestTypeToEncounter(EChest chestType) => new EEncounter();

    [Token(Token = "0x6001C58")]
    [Address(RVA = "0x41F070", Offset = "0x41DC70", Length = "0xC9")]
    public static EChest EncounterToChestType(EEncounter encounter) => new EChest();

    [Token(Token = "0x6001C59")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public ChestUtility()
    {
    }
  }
}
