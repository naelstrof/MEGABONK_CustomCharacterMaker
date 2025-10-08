// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.TomeUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups
{
  [Token(Token = "0x2000362")]
  public class TomeUtility
  {
    [Token(Token = "0x4001722")]
    private static float balanceTomeValue;

    [Token(Token = "0x6001830")]
    [Address(RVA = "0x3F7EA0", Offset = "0x3F6AA0", Length = "0x6BA")]
    public static void CheckSpecialTomes(TomeData tomeData, ERarity rarity)
    {
    }

    [Token(Token = "0x6001831")]
    [Address(RVA = "0x3F8560", Offset = "0x3F7160", Length = "0x1BC")]
    public static string GetUpgradeDescription(TomeData tomeData, ERarity rarity) => (string) null;

    [Token(Token = "0x6001832")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public TomeUtility()
    {
    }

    [Token(Token = "0x6001833")]
    [Address(RVA = "0x3F8720", Offset = "0x3F7320", Length = "0x39")]
    static TomeUtility()
    {
    }
  }
}
