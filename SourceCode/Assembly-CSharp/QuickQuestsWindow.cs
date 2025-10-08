// Decompiled with JetBrains decompiler
// Type: QuickQuestsWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20001C0")]
public class QuickQuestsWindow : MonoBehaviour
{
  [Token(Token = "0x4000CBB")]
  [FieldOffset(Offset = "0x20")]
  public GameObject prefab;
  [Token(Token = "0x4000CBC")]
  [FieldOffset(Offset = "0x28")]
  public GameObject allQuestsCompletedText;
  [Token(Token = "0x4000CBD")]
  [FieldOffset(Offset = "0x30")]
  private int numMaxQuests;
  [Token(Token = "0x4000CBE")]
  [FieldOffset(Offset = "0x38")]
  private List<QuickQuestContainer> containers;
  [Token(Token = "0x4000CBF")]
  [FieldOffset(Offset = "0x40")]
  private List<MyAchievement> quests;

  [Token(Token = "0x6000B53")]
  [Address(RVA = "0x510770", Offset = "0x50F370", Length = "0x168")]
  private void Start()
  {
  }

  [Token(Token = "0x6000B54")]
  [Address(RVA = "0x50FF40", Offset = "0x50EB40", Length = "0x138")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000B55")]
  [Address(RVA = "0x510080", Offset = "0x50EC80", Length = "0x7")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000B56")]
  [Address(RVA = "0x510090", Offset = "0x50EC90", Length = "0x6D2")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000B57")]
  [Address(RVA = "0x50FD70", Offset = "0x50E970", Length = "0x1C4")]
  private List<MyAchievement> GetAllAchievements() => (List<MyAchievement>) null;

  [Token(Token = "0x6000B58")]
  [Address(RVA = "0x5108E0", Offset = "0x50F4E0", Length = "0x331")]
  private void TryInit()
  {
  }

  [Token(Token = "0x6000B59")]
  [Address(RVA = "0x510CE0", Offset = "0x50F8E0", Length = "0xE")]
  public QuickQuestsWindow()
  {
  }
}
