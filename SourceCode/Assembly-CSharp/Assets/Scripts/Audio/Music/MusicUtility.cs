// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Audio.Music.MusicUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.MapsAndStages;
using Assets.Scripts.Game.Other;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Audio.Music
{
  [Token(Token = "0x200044A")]
  public class MusicUtility
  {
    [Token(Token = "0x4001BC1")]
    private static List<MusicTrack> tracks;
    [Token(Token = "0x4001BC2")]
    private static List<MusicTrack> tracksOther;
    [Token(Token = "0x4001BC3")]
    private static Dictionary<EMap, int> mapTrackRotation;
    [Token(Token = "0x4001BC4")]
    private static MusicTrack themeTrackPlayedLastRound;

    [Token(Token = "0x6001EA1")]
    [Address(RVA = "0x44BD50", Offset = "0x44A950", Length = "0x66E")]
    public static MusicTrack GetMusicTrackToPlay(RunConfig runConfig) => (MusicTrack) null;

    [Token(Token = "0x6001EA2")]
    [Address(RVA = "0x44C690", Offset = "0x44B290", Length = "0x2B9")]
    public static List<MusicTrack> GetTracks() => (List<MusicTrack>) null;

    [Token(Token = "0x6001EA3")]
    [Address(RVA = "0x44C3C0", Offset = "0x44AFC0", Length = "0x2CA")]
    public static List<MusicTrack> GetTracksOther() => (List<MusicTrack>) null;

    [Token(Token = "0x6001EA4")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public MusicUtility()
    {
    }

    [Token(Token = "0x6001EA5")]
    [Address(RVA = "0x44C950", Offset = "0x44B550", Length = "0xB8")]
    static MusicUtility()
    {
    }
  }
}
