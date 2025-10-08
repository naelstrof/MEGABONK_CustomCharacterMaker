// Decompiled with JetBrains decompiler
// Type: QuickQuestContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

[Token(Token = "0x20001BF")]
public class QuickQuestContainer : MonoBehaviour
{
  [Token(Token = "0x4000CB5")]
  [FieldOffset(Offset = "0x20")]
  public RawImage icon;
  [Token(Token = "0x4000CB6")]
  [FieldOffset(Offset = "0x28")]
  public RawImage progress;
  [Token(Token = "0x4000CB7")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_name;
  [Token(Token = "0x4000CB8")]
  [FieldOffset(Offset = "0x38")]
  public TextMeshProUGUI t_desc;
  [Token(Token = "0x4000CB9")]
  [FieldOffset(Offset = "0x40")]
  public TextMeshProUGUI t_progress;
  [Token(Token = "0x4000CBA")]
  [FieldOffset(Offset = "0x48")]
  private MyAchievement currentAchievement;

  [Token(Token = "0x6000B4E")]
  [Address(RVA = "0x50F950", Offset = "0x50E550", Length = "0x6D")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000B4F")]
  [Address(RVA = "0x50F9C0", Offset = "0x50E5C0", Length = "0x6D")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000B50")]
  [Address(RVA = "0x50FA30", Offset = "0x50E630", Length = "0xC")]
  private void OnLocaleChanged(Locale obj)
  {
  }

  [Token(Token = "0x6000B51")]
  [Address(RVA = "0x50FA40", Offset = "0x50E640", Length = "0x327")]
  public void SetQuest(MyAchievement ach)
  {
  }

  [Token(Token = "0x6000B52")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public QuickQuestContainer()
  {
  }
}
