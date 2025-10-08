// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Stats___Achievements.Discord.DiscordRichPresence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Discord;

namespace Assets.Scripts.Stats___Achievements.Discord
{
  [Token(Token = "0x200044B")]
  public static class DiscordRichPresence
  {
    [Token(Token = "0x4001BC5")]
    private static Activity activity;
    [Token(Token = "0x4001BC6")]
    private static long startTime;

    [Token(Token = "0x6001EA6")]
    [Address(RVA = "0x43EC80", Offset = "0x43D880", Length = "0x3F8")]
    public static void Init()
    {
    }

    [Token(Token = "0x6001EA7")]
    [Address(RVA = "0x43F080", Offset = "0x43DC80", Length = "0x3F8")]
    public static void OnDestroy()
    {
    }

    [Token(Token = "0x6001EA8")]
    [Address(RVA = "0x43F4C0", Offset = "0x43E0C0", Length = "0xDA")]
    private static void RunStarted()
    {
    }

    [Token(Token = "0x6001EA9")]
    [Address(RVA = "0x43F480", Offset = "0x43E080", Length = "0x40")]
    private static void OnLevelUp(int level)
    {
    }

    [Token(Token = "0x6001EAA")]
    [Address(RVA = "0x43F7A0", Offset = "0x43E3A0", Length = "0x4EA")]
    public static void UpdateInGame()
    {
    }

    [Token(Token = "0x6001EAB")]
    [Address(RVA = "0x43F5A0", Offset = "0x43E1A0", Length = "0x1FE")]
    private static void TryUpdateCharacter(ECharacter character)
    {
    }

    [Token(Token = "0x6001EAC")]
    [Address(RVA = "0x43FC90", Offset = "0x43E890", Length = "0x1E1")]
    public static void UpdateMainMenu()
    {
    }

    [Token(Token = "0x6001EAD")]
    [Address(RVA = "0x43FE80", Offset = "0x43EA80", Length = "0x150")]
    static DiscordRichPresence()
    {
    }
  }
}
