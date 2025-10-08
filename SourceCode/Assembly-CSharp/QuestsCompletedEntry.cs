// Decompiled with JetBrains decompiler
// Type: QuestsCompletedEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000150")]
public class QuestsCompletedEntry : MonoBehaviour
{
  [Token(Token = "0x40009D4")]
  [FieldOffset(Offset = "0x20")]
  public RawImage icon;
  [Token(Token = "0x40009D5")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_name;
  [Token(Token = "0x40009D6")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_description;
  [Token(Token = "0x40009D7")]
  [FieldOffset(Offset = "0x38")]
  public TextMeshProUGUI t_unlock;
  [Token(Token = "0x40009D8")]
  [FieldOffset(Offset = "0x40")]
  public UiAnimation uiAnimation;
  [Token(Token = "0x40009D9")]
  [FieldOffset(Offset = "0x48")]
  public MyButton myButton;

  [Token(Token = "0x6000870")]
  [Address(RVA = "0x4DC4D0", Offset = "0x4DB0D0", Length = "0x1A5")]
  public void Set(MyAchievement achievement)
  {
  }

  [Token(Token = "0x6000871")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public QuestsCompletedEntry()
  {
  }
}
