// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Progression.UnlockUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Inventory__Items__Pickups.Progression
{
  [Token(Token = "0x200038A")]
  public class UnlockUtility
  {
    [Token(Token = "0x40017DC")]
    public const float UNLOCKABLE_PRICE_MULTIPLIER = 1.75f;

    [Token(Token = "0x6001934")]
    [Address(RVA = "0x41A990", Offset = "0x419590", Length = "0x539")]
    public static HashSet<TomeData> GetAvailableTomes() => (HashSet<TomeData>) null;

    [Token(Token = "0x6001935")]
    [Address(RVA = "0x41AED0", Offset = "0x419AD0", Length = "0x5B8")]
    public static List<WeaponData> GetAvailableWeapons() => (List<WeaponData>) null;

    [Token(Token = "0x6001936")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public UnlockUtility()
    {
    }
  }
}
