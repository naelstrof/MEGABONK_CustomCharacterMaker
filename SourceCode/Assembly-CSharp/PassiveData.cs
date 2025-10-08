// Decompiled with JetBrains decompiler
// Type: PassiveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(menuName = "Me/Passive", order = 1)]
[Token(Token = "0x200021C")]
public class PassiveData : ScriptableObject
{
  [Token(Token = "0x4000EEE")]
  [FieldOffset(Offset = "0x18")]
  public LocalizedString localizedName;
  [Token(Token = "0x4000EEF")]
  [FieldOffset(Offset = "0x20")]
  public LocalizedString localizedDescription;
  [Token(Token = "0x4000EF0")]
  [FieldOffset(Offset = "0x28")]
  public EPassive ePassive;
  [SerializeField]
  [Token(Token = "0x4000EF1")]
  [FieldOffset(Offset = "0x30")]
  private string name;
  [Token(Token = "0x4000EF2")]
  [FieldOffset(Offset = "0x38")]
  public Texture icon;
  [Token(Token = "0x4000EF3")]
  [FieldOffset(Offset = "0x40")]
  private PassiveAbility dummyPassive;

  [Token(Token = "0x6000DB3")]
  [Address(RVA = "0x51EBA0", Offset = "0x51D7A0", Length = "0x1D")]
  public string GetName() => (string) null;

  [Token(Token = "0x6000DB4")]
  [Address(RVA = "0x52B1C0", Offset = "0x529DC0", Length = "0x31")]
  public string GetDescription() => (string) null;

  [Token(Token = "0x6000DB5")]
  [Address(RVA = "0x52B200", Offset = "0x529E00", Length = "0x32")]
  public void Init()
  {
  }

  [Token(Token = "0x6000DB6")]
  [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
  public PassiveData()
  {
  }
}
