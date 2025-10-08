// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.Achievements.UnlockableBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

namespace Assets.Scripts.Saves___Serialization.Progression.Achievements
{
  [Token(Token = "0x2000338")]
  public abstract class UnlockableBase : ScriptableObject, IComparable<UnlockableBase>
  {
    [Token(Token = "0x40015F0")]
    [FieldOffset(Offset = "0x18")]
    public bool isEnabled;
    [Token(Token = "0x40015F1")]
    [FieldOffset(Offset = "0x19")]
    public bool showInUnlocks;
    [Token(Token = "0x40015F2")]
    [FieldOffset(Offset = "0x20")]
    public string author;
    [Token(Token = "0x40015F3")]
    [FieldOffset(Offset = "0x28")]
    public int price;
    [Token(Token = "0x40015F4")]
    [FieldOffset(Offset = "0x30")]
    public LocalizedString localizedName;
    [Token(Token = "0x40015F5")]
    [FieldOffset(Offset = "0x38")]
    public LocalizedString localizedDescription;
    [Token(Token = "0x40015F6")]
    [FieldOffset(Offset = "0x40")]
    public List<LocalizationKey> serializedLocalizationKeys;
    [Token(Token = "0x40015F7")]
    [FieldOffset(Offset = "0x48")]
    public List<LocalizationKey> serializedLocalizationKeysName;

    [Token(Token = "0x6001720")]
    [Address(RVA = "0x3E1B70", Offset = "0x3E0770", Length = "0x159")]
    public virtual string GetName() => (string) null;

    [Token(Token = "0x6001721")]
    [Address(RVA = "0x3E16D0", Offset = "0x3E02D0", Length = "0x159")]
    public virtual string GetDescription() => (string) null;

    [Token(Token = "0x6001722")]
    [Address(RVA = "0x3E1830", Offset = "0x3E0430", Length = "0x196")]
    private Dictionary<string, string> GetKeysDesc() => (Dictionary<string, string>) null;

    [Token(Token = "0x6001723")]
    [Address(RVA = "0x3E19D0", Offset = "0x3E05D0", Length = "0x196")]
    private Dictionary<string, string> GetKeysName() => (Dictionary<string, string>) null;

    [Token(Token = "0x6001724")]
    [Address(RVA = "0x3E1CD0", Offset = "0x3E08D0", Length = "0x17")]
    public virtual int GetPrice() => 0;

    [Token(Token = "0x6001725")]
    public abstract Texture GetIcon();

    [Token(Token = "0x6001726")]
    public abstract MyAchievement GetUnlockRequirement();

    [Token(Token = "0x6001727")]
    public abstract UnlockableBase GetUnlockableRequirement();

    [Token(Token = "0x6001728")]
    public abstract string GetUnlockableTypeDisplayString();

    [Token(Token = "0x6001729")]
    public abstract string GetInternalName();

    [Token(Token = "0x600172A")]
    [Address(RVA = "0x3E15B0", Offset = "0x3E01B0", Length = "0xBE")]
    public bool CanBuy() => false;

    [Token(Token = "0x600172B")]
    [Address(RVA = "0x3E1670", Offset = "0x3E0270", Length = "0x55")]
    public virtual int CompareTo(UnlockableBase other) => 0;

    [Token(Token = "0x600172C")]
    [Address(RVA = "0x3E1CF0", Offset = "0x3E08F0", Length = "0x6B")]
    protected UnlockableBase()
    {
    }
  }
}
