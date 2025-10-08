// Decompiled with JetBrains decompiler
// Type: MyButtonTabsQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.Progression;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000183")]
public class MyButtonTabsQuest : MyButtonTabs
{
  [Token(Token = "0x4000B20")]
  [FieldOffset(Offset = "0x98")]
  public TextMeshProUGUI t_progress;
  [Token(Token = "0x4000B21")]
  [FieldOffset(Offset = "0xA0")]
  public TextMeshProUGUI t_unlcaimed;
  [Token(Token = "0x4000B22")]
  [FieldOffset(Offset = "0xA8")]
  public RawImage i_progressBar;
  [Token(Token = "0x4000B23")]
  [FieldOffset(Offset = "0xB0")]
  public GameObject unclaimedUi;
  [Token(Token = "0x4000B24")]
  [FieldOffset(Offset = "0xB8")]
  private EAchievementType achievementType;
  [Token(Token = "0x4000B25")]
  [FieldOffset(Offset = "0xBC")]
  private int unclaimed;

  [Token(Token = "0x60009C0")]
  [Address(RVA = "0x4DA570", Offset = "0x4D9170", Length = "0x132")]
  private new void Awake()
  {
  }

  [Token(Token = "0x60009C1")]
  [Address(RVA = "0x4DA7F0", Offset = "0x4D93F0", Length = "0x128")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60009C2")]
  [Address(RVA = "0x4DA920", Offset = "0x4D9520", Length = "0x233")]
  public void Set(EAchievementType achievementType)
  {
  }

  [Token(Token = "0x60009C3")]
  [Address(RVA = "0x4DA6B0", Offset = "0x4D92B0", Length = "0x134")]
  private void OnClaimed(MyAchievement achievement)
  {
  }

  [Token(Token = "0x60009C4")]
  [Address(RVA = "0x4D7090", Offset = "0x4D5C90", Length = "0xE")]
  public MyButtonTabsQuest()
  {
  }
}
