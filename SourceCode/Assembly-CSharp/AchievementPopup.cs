// Decompiled with JetBrains decompiler
// Type: AchievementPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200011B")]
public class AchievementPopup : MonoBehaviour
{
  [Token(Token = "0x400086F")]
  [FieldOffset(Offset = "0x20")]
  public RectTransform content;
  [Token(Token = "0x4000870")]
  [FieldOffset(Offset = "0x28")]
  public RawImage icon;
  [Token(Token = "0x4000871")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_title;
  [Token(Token = "0x4000872")]
  [FieldOffset(Offset = "0x38")]
  public TextMeshProUGUI t_description;
  [Token(Token = "0x4000873")]
  [FieldOffset(Offset = "0x40")]
  public RandomSfx sfx;
  [Token(Token = "0x4000874")]
  [FieldOffset(Offset = "0x48")]
  private Queue<MyAchievement> queue;
  [Token(Token = "0x4000875")]
  [FieldOffset(Offset = "0x50")]
  private bool isAnimating;
  [Token(Token = "0x4000876")]
  [FieldOffset(Offset = "0x54")]
  private float contentHeight;
  [Token(Token = "0x4000877")]
  [FieldOffset(Offset = "0x58")]
  private float moveTime;
  [Token(Token = "0x4000878")]
  [FieldOffset(Offset = "0x5C")]
  private float stayTime;

  [Token(Token = "0x6000712")]
  [Address(RVA = "0x4B1780", Offset = "0x4B0380", Length = "0x140")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000713")]
  [Address(RVA = "0x4B1990", Offset = "0x4B0590", Length = "0x140")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000714")]
  [Address(RVA = "0x4B1B50", Offset = "0x4B0750", Length = "0x34")]
  private void Start()
  {
  }

  [Token(Token = "0x6000715")]
  [Address(RVA = "0x4B18D0", Offset = "0x4B04D0", Length = "0xB4")]
  private void OnAchievementUnlocked(MyAchievement achievement)
  {
  }

  [Token(Token = "0x6000716")]
  [Address(RVA = "0x4B1AE0", Offset = "0x4B06E0", Length = "0x67")]
  private IEnumerator ShowAchievements() => (IEnumerator) null;

  [Token(Token = "0x6000717")]
  [Address(RVA = "0x4B1B90", Offset = "0x4B0790", Length = "0x85")]
  public AchievementPopup()
  {
  }
}
