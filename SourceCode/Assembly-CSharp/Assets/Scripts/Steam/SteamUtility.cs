// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Steam.SteamUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Steam
{
  [Token(Token = "0x2000312")]
  public class SteamUtility
  {
    [Token(Token = "0x600161B")]
    [Address(RVA = "0x3BF330", Offset = "0x3BDF30", Length = "0x2CE")]
    public static Texture2D LoadAvatar(ulong steamId, int quality = 0) => (Texture2D) null;

    [Token(Token = "0x600161C")]
    [Address(RVA = "0x3BF190", Offset = "0x3BDD90", Length = "0x196")]
    public static Texture2D FlipTexture(Texture2D original) => (Texture2D) null;

    [Token(Token = "0x600161D")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public SteamUtility()
    {
    }
  }
}
