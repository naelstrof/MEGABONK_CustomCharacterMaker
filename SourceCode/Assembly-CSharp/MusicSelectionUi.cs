// Decompiled with JetBrains decompiler
// Type: MusicSelectionUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Audio.Music;
using Cpp2ILInjected;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001B4")]
public class MusicSelectionUi : MonoBehaviour
{
  [Token(Token = "0x4000C75")]
  private static int index;
  [Token(Token = "0x4000C76")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_trackName;
  [Token(Token = "0x4000C77")]
  [FieldOffset(Offset = "0x28")]
  private List<MusicTrack> tracks;
  [Token(Token = "0x4000C78")]
  [FieldOffset(Offset = "0x30")]
  public MapSelectionUi mapSelection;

  [Token(Token = "0x6000B09")]
  [Address(RVA = "0x4F9700", Offset = "0x4F8300", Length = "0x128")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000B0A")]
  [Address(RVA = "0x4F99B0", Offset = "0x4F85B0", Length = "0x128")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000B0B")]
  [Address(RVA = "0x4F9AE0", Offset = "0x4F86E0", Length = "0xA")]
  private void Start()
  {
  }

  [Token(Token = "0x6000B0C")]
  [Address(RVA = "0x4F9830", Offset = "0x4F8430", Length = "0x11E")]
  public void Flip(int dir)
  {
  }

  [Token(Token = "0x6000B0D")]
  [Address(RVA = "0x4F9AF0", Offset = "0x4F86F0", Length = "0x27E")]
  private void UpdateTrack(bool playTrack)
  {
  }

  [Token(Token = "0x6000B0E")]
  [Address(RVA = "0x4F9AE0", Offset = "0x4F86E0", Length = "0xA")]
  private void OnMapSelected(SelectionGroupToggleSingleButton btn, MapData mapData)
  {
  }

  [Token(Token = "0x6000B0F")]
  [Address(RVA = "0x4F9950", Offset = "0x4F8550", Length = "0x5A")]
  private int NumSongs() => 0;

  [Token(Token = "0x6000B10")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MusicSelectionUi()
  {
  }

  [Token(Token = "0x6000B11")]
  [Address(RVA = "0x4F9D70", Offset = "0x4F8970", Length = "0x39")]
  static MusicSelectionUi()
  {
  }
}
