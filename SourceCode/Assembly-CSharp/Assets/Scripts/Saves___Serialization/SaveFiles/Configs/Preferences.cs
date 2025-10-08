// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.SaveFiles.Configs.Preferences
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Saves___Serialization.SaveFiles.Configs
{
  [Token(Token = "0x2000322")]
  public class Preferences
  {
    [Token(Token = "0x400154D")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<ECharacter, int> characterSkins;
    [Token(Token = "0x400154E")]
    [FieldOffset(Offset = "0x18")]
    public ECharacter selectedCharacter;
    [Token(Token = "0x400154F")]
    [FieldOffset(Offset = "0x1C")]
    public bool hasShownUnlocks;
    [Token(Token = "0x4001550")]
    [FieldOffset(Offset = "0x1D")]
    public bool hasShownQuests;
    [Token(Token = "0x4001551")]
    [FieldOffset(Offset = "0x1E")]
    public bool hasShownShop;
    [Token(Token = "0x4001552")]
    [FieldOffset(Offset = "0x1F")]
    public bool hasShownLeaderboards;
    [Token(Token = "0x4001553")]
    [FieldOffset(Offset = "0x20")]
    public bool hasShownQuickQuests;

    [Token(Token = "0x6001652")]
    [Address(RVA = "0x3B5F10", Offset = "0x3B4B10", Length = "0x2C3")]
    public void Init()
    {
    }

    [Token(Token = "0x6001653")]
    [Address(RVA = "0x3B61E0", Offset = "0x3B4DE0", Length = "0x77")]
    public Preferences()
    {
    }
  }
}
