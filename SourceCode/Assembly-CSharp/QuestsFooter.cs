// Decompiled with JetBrains decompiler
// Type: QuestsFooter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001BC")]
public class QuestsFooter : MonoBehaviour
{
  [Token(Token = "0x4000C9B")]
  [FieldOffset(Offset = "0x20")]
  public UnlockContainer achievementContainer;
  [Token(Token = "0x4000C9C")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_description;
  [Token(Token = "0x4000C9D")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_unlock;
  [Token(Token = "0x4000C9E")]
  [FieldOffset(Offset = "0x38")]
  public TextMeshProUGUI t_reward;
  [Token(Token = "0x4000C9F")]
  [FieldOffset(Offset = "0x40")]
  public GameObject checkMark;
  [Token(Token = "0x4000CA0")]
  [FieldOffset(Offset = "0x48")]
  public RawImage i_progressBar;
  [Token(Token = "0x4000CA1")]
  [FieldOffset(Offset = "0x50")]
  public TextMeshProUGUI t_progress;

  [Token(Token = "0x6000B38")]
  [Address(RVA = "0x50D380", Offset = "0x50BF80", Length = "0x1F6")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000B39")]
  [Address(RVA = "0x50DC20", Offset = "0x50C820", Length = "0x128")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000B3A")]
  [Address(RVA = "0x50DD50", Offset = "0x50C950", Length = "0xDC")]
  private void SetEmpty()
  {
  }

  [Token(Token = "0x6000B3B")]
  [Address(RVA = "0x50D580", Offset = "0x50C180", Length = "0x69D")]
  private void OnAchievementHover(MyButtonQuest questButton)
  {
  }

  [Token(Token = "0x6000B3C")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public QuestsFooter()
  {
  }
}
