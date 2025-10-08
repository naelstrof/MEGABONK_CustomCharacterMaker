// Decompiled with JetBrains decompiler
// Type: SkinData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Me/Skin", order = 1)]
[Token(Token = "0x2000226")]
public class SkinData : UnlockableBase, IComparable<SkinData>
{
  [Token(Token = "0x4000F0A")]
  [FieldOffset(Offset = "0x50")]
  public Texture icon;
  [Token(Token = "0x4000F0B")]
  [FieldOffset(Offset = "0x58")]
  public Material[] materials;
  [Token(Token = "0x4000F0C")]
  [FieldOffset(Offset = "0x60")]
  public ECharacter character;
  [Token(Token = "0x4000F0D")]
  [FieldOffset(Offset = "0x68")]
  public MyAchievement unlockRequirement;
  [Token(Token = "0x4000F0E")]
  [FieldOffset(Offset = "0x70")]
  public ESkinType skinType;

  [Token(Token = "0x6000DED")]
  [Address(RVA = "0x52EBD0", Offset = "0x52D7D0", Length = "0x98")]
  public override string GetName() => (string) null;

  [Token(Token = "0x6000DEE")]
  [Address(RVA = "0x52EB30", Offset = "0x52D730", Length = "0x14")]
  public override string GetDescription() => (string) null;

  [Token(Token = "0x6000DEF")]
  [Address(RVA = "0x52EC70", Offset = "0x52D870", Length = "0x6A")]
  public override int GetPrice() => 0;

  [Token(Token = "0x6000DF0")]
  [Address(RVA = "0x36CC90", Offset = "0x36B890", Length = "0x5")]
  public override Texture GetIcon() => (Texture) null;

  [Token(Token = "0x6000DF1")]
  [Address(RVA = "0x41E7E0", Offset = "0x41D3E0", Length = "0x5")]
  public override MyAchievement GetUnlockRequirement() => (MyAchievement) null;

  [Token(Token = "0x6000DF2")]
  [Address(RVA = "0x395320", Offset = "0x393F20", Length = "0x3")]
  public override UnlockableBase GetUnlockableRequirement() => (UnlockableBase) null;

  [Token(Token = "0x6000DF3")]
  [Address(RVA = "0x52ECE0", Offset = "0x52D8E0", Length = "0x63")]
  public override string GetUnlockableTypeDisplayString() => (string) null;

  [Token(Token = "0x6000DF4")]
  [Address(RVA = "0x52EB50", Offset = "0x52D750", Length = "0x7A")]
  public override string GetInternalName() => (string) null;

  [Token(Token = "0x6000DF5")]
  [Address(RVA = "0x52EA50", Offset = "0x52D650", Length = "0xDB")]
  public int CompareTo(SkinData other) => 0;

  [Token(Token = "0x6000DF6")]
  [Address(RVA = "0x52ED50", Offset = "0x52D950", Length = "0x7")]
  public SkinData()
  {
  }
}
