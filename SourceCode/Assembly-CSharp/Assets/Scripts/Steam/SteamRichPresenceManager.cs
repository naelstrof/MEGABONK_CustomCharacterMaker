// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Steam.SteamRichPresenceManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Steam
{
  [Token(Token = "0x200030F")]
  public static class SteamRichPresenceManager
  {
    [Token(Token = "0x40014CA")]
    public const string LEVEL_KEY = "lvl";
    [Token(Token = "0x40014CB")]
    public const string CHARACTER_KEY = "character";
    [Token(Token = "0x40014CC")]
    public const string MAP_KEY = "map";
    [Token(Token = "0x40014CD")]
    public const string TIME_KEY = "time";
    [Token(Token = "0x40014CE")]
    public const string MENU_STATUS_KEY = "menu_string";
    [Token(Token = "0x40014CF")]
    public const string DISPLAY_KEY = "steam_display";
    [Token(Token = "0x40014D0")]
    public const string TOKEN_MENU = "#Status_AtMainMenu";
    [Token(Token = "0x40014D1")]
    public const string TOKEN_INGAME = "#Status_InGame";
    [Token(Token = "0x40014D2")]
    private static float previousSecond;

    [Token(Token = "0x60015FA")]
    [Address(RVA = "0x3BBC70", Offset = "0x3BA870", Length = "0x304")]
    public static void Init()
    {
    }

    [Token(Token = "0x60015FB")]
    [Address(RVA = "0x3BBF80", Offset = "0x3BAB80", Length = "0x6B")]
    private static void MainMenuOpened()
    {
    }

    [Token(Token = "0x60015FC")]
    [Address(RVA = "0x3BC4B0", Offset = "0x3BB0B0", Length = "0x3AA")]
    public static void UpdateDisplayInGame()
    {
    }

    [Token(Token = "0x60015FD")]
    [Address(RVA = "0x3BB750", Offset = "0x3BA350", Length = "0xC0")]
    public static string GetPlayerLevel() => (string) null;

    [Token(Token = "0x60015FE")]
    [Address(RVA = "0x3BC900", Offset = "0x3BB500", Length = "0xF2")]
    private static void Update()
    {
    }

    [Token(Token = "0x60015FF")]
    [Address(RVA = "0x3BC860", Offset = "0x3BB460", Length = "0x95")]
    private static void UpdateTimer()
    {
    }

    [Token(Token = "0x6001600")]
    [Address(RVA = "0x3BC430", Offset = "0x3BB030", Length = "0x77")]
    private static void SetKeyValue(string key, string value)
    {
    }

    [Token(Token = "0x6001601")]
    [Address(RVA = "0x3BB460", Offset = "0x3BA060", Length = "0x10A")]
    public static string GetCharacter() => (string) null;

    [Token(Token = "0x6001602")]
    [Address(RVA = "0x3BB570", Offset = "0x3BA170", Length = "0xC1")]
    public static ECharacter GetEnumCharacter() => new ECharacter();

    [Token(Token = "0x6001603")]
    [Address(RVA = "0x3BB640", Offset = "0x3BA240", Length = "0x105")]
    public static string GetMapString() => (string) null;

    [Token(Token = "0x6001604")]
    [Address(RVA = "0x3BBB10", Offset = "0x3BA710", Length = "0x15F")]
    private static string GetTime() => (string) null;

    [Token(Token = "0x6001605")]
    [Address(RVA = "0x3BB820", Offset = "0x3BA420", Length = "0x2E9")]
    public static string GetRandomMenuStatus() => (string) null;

    [Token(Token = "0x6001606")]
    [Address(RVA = "0x3BC350", Offset = "0x3BAF50", Length = "0xD8")]
    private static void Refresh()
    {
    }

    [Token(Token = "0x6001607")]
    [Address(RVA = "0x3BBFF0", Offset = "0x3BABF0", Length = "0x35B")]
    public static void OnDestroy()
    {
    }
  }
}
