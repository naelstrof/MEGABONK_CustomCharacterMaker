// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.InGame.Rewards.EncounterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Localization;

namespace Assets.Scripts.UI.InGame.Rewards
{
  [CreateAssetMenu(menuName = "Me/EncounterData")]
  [Token(Token = "0x20002FA")]
  public class EncounterData : ScriptableObject
  {
    [Token(Token = "0x400144E")]
    [FieldOffset(Offset = "0x18")]
    public EEncounter encounterType;
    [Token(Token = "0x400144F")]
    [FieldOffset(Offset = "0x20")]
    public EncounterOffer[] offers;
    [Token(Token = "0x4001450")]
    [FieldOffset(Offset = "0x28")]
    public LocalizedString localizedName;
    [Token(Token = "0x4001451")]
    [FieldOffset(Offset = "0x30")]
    public LocalizedString localizedDescription;

    [Token(Token = "0x6001595")]
    [Address(RVA = "0x3A9080", Offset = "0x3A7C80", Length = "0x1D")]
    public string GetName() => (string) null;

    [Token(Token = "0x6001596")]
    [Address(RVA = "0x3A9060", Offset = "0x3A7C60", Length = "0x1D")]
    public string GetDescription() => (string) null;

    [Token(Token = "0x6001597")]
    [Address(RVA = "0x3A90A0", Offset = "0x3A7CA0", Length = "0x291")]
    public EncounterOffer[] GetOffers() => (EncounterOffer[]) null;

    [Token(Token = "0x6001598")]
    [Address(RVA = "0x3A9340", Offset = "0x3A7F40", Length = "0x8")]
    public bool HasRarity() => false;

    [Token(Token = "0x6001599")]
    [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
    public EncounterData()
    {
    }
  }
}
