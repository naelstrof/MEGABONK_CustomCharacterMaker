// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.Achievements.MyAchievement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.Progression;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

namespace Assets.Scripts.Saves___Serialization.Progression.Achievements
{
  [CreateAssetMenu(menuName = "Me/Progression/Unlock", order = 1)]
  [Token(Token = "0x2000337")]
  public class MyAchievement : ScriptableObject, IComparable<MyAchievement>
  {
    [Token(Token = "0x40015DF")]
    [FieldOffset(Offset = "0x18")]
    public LocalizedString localizedName;
    [Token(Token = "0x40015E0")]
    [FieldOffset(Offset = "0x20")]
    public LocalizedString localizedDescription;
    [Token(Token = "0x40015E1")]
    [FieldOffset(Offset = "0x28")]
    public bool isEnabled;
    [Token(Token = "0x40015E2")]
    [FieldOffset(Offset = "0x29")]
    public bool isHidden;
    [HideInInspector]
    [Token(Token = "0x40015E3")]
    [FieldOffset(Offset = "0x30")]
    public string internalName;
    [Token(Token = "0x40015E4")]
    [FieldOffset(Offset = "0x38")]
    public string statName;
    [Token(Token = "0x40015E5")]
    [FieldOffset(Offset = "0x40")]
    public int targetValue;
    [Token(Token = "0x40015E6")]
    [FieldOffset(Offset = "0x44")]
    public float targetValueFloat;
    [Token(Token = "0x40015E7")]
    [FieldOffset(Offset = "0x48")]
    public string targetValueString;
    [Token(Token = "0x40015E8")]
    [FieldOffset(Offset = "0x50")]
    public Texture icon;
    [Token(Token = "0x40015E9")]
    [FieldOffset(Offset = "0x58")]
    public int sortingOrder;
    [Token(Token = "0x40015EA")]
    [FieldOffset(Offset = "0x5C")]
    public EAchievementDifficulty difficulty;
    [Token(Token = "0x40015EB")]
    [FieldOffset(Offset = "0x60")]
    public EAchievementType achievementType;
    [Token(Token = "0x40015EC")]
    [FieldOffset(Offset = "0x68")]
    public List<LocalizationKey> serializedLocalizationKeys;
    [Token(Token = "0x40015ED")]
    [FieldOffset(Offset = "0x70")]
    public int achIteration;
    [Token(Token = "0x40015EE")]
    [FieldOffset(Offset = "0x74")]
    public bool useIterations;

    [field: Token(Token = "0x40015EF")]
    [field: FieldOffset(Offset = "0x78")]
    [Token(Token = "0x1700037D")]
    public UnlockableBase unlockable { [Token(Token = "0x6001709"), Address(RVA = "0x3D1A90", Offset = "0x3D0690", Length = "0x5")] get; [Token(Token = "0x600170A"), Address(RVA = "0x3D1A80", Offset = "0x3D0680", Length = "0xD")] private set; }

    [Token(Token = "0x600170B")]
    [Address(RVA = "0x3D1350", Offset = "0x3CFF50", Length = "0x159")]
    public string GetUnlockDescription() => (string) null;

    [Token(Token = "0x600170C")]
    [Address(RVA = "0x3D0D90", Offset = "0x3CF990", Length = "0xE3")]
    public virtual string GetDisplayName() => (string) null;

    [Token(Token = "0x600170D")]
    [Address(RVA = "0x3D0F10", Offset = "0x3CFB10", Length = "0x24D")]
    private Dictionary<string, string> GetKeys() => (Dictionary<string, string>) null;

    [Token(Token = "0x600170E")]
    [Address(RVA = "0x3D0E80", Offset = "0x3CFA80", Length = "0x8E")]
    public Texture GetIcon() => (Texture) null;

    [Token(Token = "0x600170F")]
    [Address(RVA = "0x3D1790", Offset = "0x3D0390", Length = "0x35")]
    public bool IsUsingTargetValue() => false;

    [Token(Token = "0x6001710")]
    [Address(RVA = "0x3D1720", Offset = "0x3D0320", Length = "0x19")]
    public bool IsTrackingStat() => false;

    [Token(Token = "0x6001711")]
    [Address(RVA = "0x3D1350", Offset = "0x3CFF50", Length = "0x159")]
    public virtual string GetUnlockRequirement() => (string) null;

    [Token(Token = "0x6001712")]
    [Address(RVA = "0x3D14B0", Offset = "0x3D00B0", Length = "0xF7")]
    public string GetUnlockedString() => (string) null;

    [Token(Token = "0x6001713")]
    [Address(RVA = "0x3D1250", Offset = "0x3CFE50", Length = "0xC8")]
    public string GetRewardString() => (string) null;

    [Token(Token = "0x6001714")]
    [Address(RVA = "0x3D1A80", Offset = "0x3D0680", Length = "0xD")]
    public void SetUnlockable(UnlockableBase unlockable)
    {
    }

    [Token(Token = "0x6001715")]
    [Address(RVA = "0x3D1670", Offset = "0x3D0270", Length = "0x49")]
    public bool IsCompleted() => false;

    [Token(Token = "0x6001716")]
    [Address(RVA = "0x3D15B0", Offset = "0x3D01B0", Length = "0xBA")]
    public bool IsClaimed() => false;

    [Token(Token = "0x6001717")]
    [Address(RVA = "0x3D1160", Offset = "0x3CFD60", Length = "0xF0")]
    public float GetProgress() => 0.0f;

    [Token(Token = "0x6001718")]
    [Address(RVA = "0x3D0CE0", Offset = "0x3CF8E0", Length = "0xAD")]
    public int GetCurrentValue() => 0;

    [Token(Token = "0x6001719")]
    [Address(RVA = "0x3D16C0", Offset = "0x3D02C0", Length = "0x5D")]
    public bool IsHiddenInMenus() => false;

    [Token(Token = "0x600171A")]
    [Address(RVA = "0x3D1A50", Offset = "0x3D0650", Length = "0x25")]
    private void OnValidate()
    {
    }

    [Token(Token = "0x600171B")]
    [Address(RVA = "0x3D17D0", Offset = "0x3D03D0", Length = "0x27C")]
    public bool IsVisible() => false;

    [Token(Token = "0x600171C")]
    [Address(RVA = "0x3D1740", Offset = "0x3D0340", Length = "0x49")]
    public bool IsUnlocked() => false;

    [Token(Token = "0x600171D")]
    [Address(RVA = "0x3D1320", Offset = "0x3CFF20", Length = "0x2C")]
    public int GetSilverReward() => 0;

    [Token(Token = "0x600171E")]
    [Address(RVA = "0x3D0B30", Offset = "0x3CF730", Length = "0x1A8")]
    public virtual int CompareTo(MyAchievement other) => 0;

    [Token(Token = "0x600171F")]
    [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
    public MyAchievement()
    {
    }
  }
}
