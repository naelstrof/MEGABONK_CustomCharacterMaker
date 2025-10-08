// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Utility.FxUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Utility
{
  [Token(Token = "0x20002E0")]
  public static class FxUtility
  {
    [Token(Token = "0x400138D")]
    public static Dictionary<EWeapon, float> weaponCooldowns;
    [Token(Token = "0x400138E")]
    public static Dictionary<EWeapon, float> muzzleCooldowns;

    [Token(Token = "0x6001519")]
    [Address(RVA = "0x38DF50", Offset = "0x38CB50", Length = "0x112")]
    public static void Init()
    {
    }

    [Token(Token = "0x600151A")]
    [Address(RVA = "0x38DE30", Offset = "0x38CA30", Length = "0x112")]
    public static void Cleanup()
    {
    }

    [Token(Token = "0x600151B")]
    [Address(RVA = "0x38E070", Offset = "0x38CC70", Length = "0xE3")]
    private static void OnRunStarted()
    {
    }

    [Token(Token = "0x600151C")]
    [Address(RVA = "0x38E160", Offset = "0x38CD60", Length = "0xCE")]
    static FxUtility()
    {
    }
  }
}
