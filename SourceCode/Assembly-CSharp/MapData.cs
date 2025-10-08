// Decompiled with JetBrains decompiler
// Type: MapData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.MapsAndStages;
using Assets.Scripts.Audio.Music;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "Me/Mapping/MapData", order = 1)]
[Token(Token = "0x200021A")]
public class MapData : UnlockableBase
{
  [Token(Token = "0x4000EBD")]
  [FieldOffset(Offset = "0x50")]
  public StageData[] stages;
  [Header("Meta")]
  [Token(Token = "0x4000EBE")]
  [FieldOffset(Offset = "0x58")]
  public EMap eMap;
  [SerializeField]
  [Token(Token = "0x4000EBF")]
  [FieldOffset(Offset = "0x60")]
  private string mapName;
  [SerializeField]
  [Token(Token = "0x4000EC0")]
  [FieldOffset(Offset = "0x68")]
  private string description;
  [Token(Token = "0x4000EC1")]
  [FieldOffset(Offset = "0x70")]
  public Texture icon;
  [Token(Token = "0x4000EC2")]
  [FieldOffset(Offset = "0x78")]
  public Texture mapIconBig;
  [Token(Token = "0x4000EC3")]
  [FieldOffset(Offset = "0x80")]
  public EMapType mapType;
  [Header("Unlocks")]
  [Token(Token = "0x4000EC4")]
  [FieldOffset(Offset = "0x88")]
  public MyAchievement achievementRequirement;
  [Token(Token = "0x4000EC5")]
  [FieldOffset(Offset = "0x90")]
  public int unlockOrder;
  [Header("Map Generation")]
  [Token(Token = "0x4000EC6")]
  [FieldOffset(Offset = "0x98")]
  public GameObject[] shrines;
  [Header("Enemy spawning")]
  [Token(Token = "0x4000EC7")]
  [FieldOffset(Offset = "0xA0")]
  public float stageDuration;
  [Header("Audio")]
  [Token(Token = "0x4000EC8")]
  [FieldOffset(Offset = "0xA8")]
  public AudioClip ambience;
  [Token(Token = "0x4000EC9")]
  [FieldOffset(Offset = "0xB0")]
  public MusicTrack[] musicTracks;
  [Token(Token = "0x4000ECA")]
  [FieldOffset(Offset = "0xB8")]
  public MusicTrack bossTrack;
  [Header("Other")]
  [Token(Token = "0x4000ECB")]
  [FieldOffset(Offset = "0xC0")]
  public bool isWaterDamaging;
  [Token(Token = "0x4000ECC")]
  [FieldOffset(Offset = "0xC8")]
  public Material finalStageMaterial;

  [Token(Token = "0x6000DA6")]
  [Address(RVA = "0x529580", Offset = "0x528180", Length = "0x5")]
  public override Texture GetIcon() => (Texture) null;

  [Token(Token = "0x6000DA7")]
  [Address(RVA = "0x5295F0", Offset = "0x5281F0", Length = "0x8")]
  public override MyAchievement GetUnlockRequirement() => (MyAchievement) null;

  [Token(Token = "0x6000DA8")]
  [Address(RVA = "0x395320", Offset = "0x393F20", Length = "0x3")]
  public override UnlockableBase GetUnlockableRequirement() => (UnlockableBase) null;

  [Token(Token = "0x6000DA9")]
  [Address(RVA = "0x529600", Offset = "0x528200", Length = "0x63")]
  public override string GetUnlockableTypeDisplayString() => (string) null;

  [Token(Token = "0x6000DAA")]
  [Address(RVA = "0x529590", Offset = "0x528190", Length = "0x53")]
  public override string GetInternalName() => (string) null;

  [Token(Token = "0x6000DAB")]
  [Address(RVA = "0x529670", Offset = "0x528270", Length = "0x11")]
  public MapData()
  {
  }
}
