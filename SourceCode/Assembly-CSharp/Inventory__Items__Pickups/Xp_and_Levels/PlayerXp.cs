// Decompiled with JetBrains decompiler
// Type: Inventory__Items__Pickups.Xp_and_Levels.PlayerXp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Inventory__Items__Pickups.Xp_and_Levels
{
  [Token(Token = "0x20002C6")]
  public class PlayerXp
  {
    [Token(Token = "0x40012D0")]
    [FieldOffset(Offset = "0x10")]
    public int xp;
    [Token(Token = "0x40012D1")]
    [FieldOffset(Offset = "0x14")]
    public int level;
    [Token(Token = "0x40012D2")]
    public static float maxXpMultiplier;
    [Token(Token = "0x40012D3")]
    public static Action<int> A_LevelUp;
    [Token(Token = "0x40012D4")]
    public static Action<PlayerXp, int> A_XpAdded;
    [Token(Token = "0x40012D5")]
    [FieldOffset(Offset = "0x18")]
    private float leftOverXp;

    [Token(Token = "0x60014C0")]
    [Address(RVA = "0x3910E0", Offset = "0x38FCE0", Length = "0x202")]
    public void AddXp(int amount)
    {
    }

    [Token(Token = "0x60014C1")]
    [Address(RVA = "0x3912F0", Offset = "0x38FEF0", Length = "0x5D")]
    public int GetXpInt() => 0;

    [Token(Token = "0x60014C2")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public PlayerXp()
    {
    }

    [Token(Token = "0x60014C3")]
    [Address(RVA = "0x391350", Offset = "0x38FF50", Length = "0x39")]
    static PlayerXp()
    {
    }
  }
}
