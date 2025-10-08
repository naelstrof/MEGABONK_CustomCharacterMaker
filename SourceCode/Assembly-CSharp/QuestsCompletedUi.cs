// Decompiled with JetBrains decompiler
// Type: QuestsCompletedUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000151")]
public class QuestsCompletedUi : MonoBehaviour
{
  [Token(Token = "0x40009DA")]
  [FieldOffset(Offset = "0x20")]
  public GameObject prefab;
  [Token(Token = "0x40009DB")]
  [FieldOffset(Offset = "0x28")]
  public Transform contentParent;
  [Token(Token = "0x40009DC")]
  [FieldOffset(Offset = "0x30")]
  public ScrollRect scrollRect;
  [Token(Token = "0x40009DD")]
  [FieldOffset(Offset = "0x38")]
  public AudioSource source;
  [Token(Token = "0x40009DE")]
  [FieldOffset(Offset = "0x40")]
  private float delay;

  [Token(Token = "0x6000872")]
  [Address(RVA = "0x4DC710", Offset = "0x4DB310", Length = "0xD1")]
  private void Start()
  {
  }

  [Token(Token = "0x6000873")]
  [Address(RVA = "0x4DC680", Offset = "0x4DB280", Length = "0x84")]
  private IEnumerator AnimateQuests(List<MyAchievement> achievements) => (IEnumerator) null;

  [Token(Token = "0x6000874")]
  [Address(RVA = "0x4DC7F0", Offset = "0x4DB3F0", Length = "0xFE")]
  private void TestAddItem(MyAchievement ach)
  {
  }

  [Token(Token = "0x6000875")]
  [Address(RVA = "0x4DC8F0", Offset = "0x4DB4F0", Length = "0xE")]
  public QuestsCompletedUi()
  {
  }
}
