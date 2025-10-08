// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Audio.Music.MusicTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

namespace Assets.Scripts.Audio.Music
{
  [CreateAssetMenu(menuName = "Me/MusicTrack", order = 1)]
  [Token(Token = "0x2000449")]
  public class MusicTrack : ScriptableObject, IComparable<MusicTrack>
  {
    [Token(Token = "0x4001BB9")]
    [FieldOffset(Offset = "0x18")]
    public bool isEnabled;
    [Token(Token = "0x4001BBA")]
    [FieldOffset(Offset = "0x19")]
    public bool isInJukebox;
    [Token(Token = "0x4001BBB")]
    [FieldOffset(Offset = "0x1A")]
    public bool isInRandomPool;
    [Token(Token = "0x4001BBC")]
    [FieldOffset(Offset = "0x1C")]
    public int maxStageCompatibility;
    [Token(Token = "0x4001BBD")]
    [FieldOffset(Offset = "0x20")]
    public MusicCategory category;
    [Token(Token = "0x4001BBE")]
    [FieldOffset(Offset = "0x28")]
    public string trackName;
    [Token(Token = "0x4001BBF")]
    [FieldOffset(Offset = "0x30")]
    public AudioClip intro;
    [Token(Token = "0x4001BC0")]
    [FieldOffset(Offset = "0x38")]
    public AudioClip loop;

    [Token(Token = "0x6001E9C")]
    [Address(RVA = "0x44BBD0", Offset = "0x44A7D0", Length = "0xAD")]
    public void LoadToMemory()
    {
    }

    [Token(Token = "0x6001E9D")]
    [Address(RVA = "0x44BC80", Offset = "0x44A880", Length = "0xAD")]
    public void UnloadFromMemory()
    {
    }

    [Token(Token = "0x6001E9E")]
    [Address(RVA = "0x44BAF0", Offset = "0x44A6F0", Length = "0xDD")]
    public bool IsLoadedInMemory() => false;

    [Token(Token = "0x6001E9F")]
    [Address(RVA = "0x44BA20", Offset = "0x44A620", Length = "0xC7")]
    public int CompareTo(MusicTrack other) => 0;

    [Token(Token = "0x6001EA0")]
    [Address(RVA = "0x44BD30", Offset = "0x44A930", Length = "0x18")]
    public MusicTrack()
    {
    }
  }
}
