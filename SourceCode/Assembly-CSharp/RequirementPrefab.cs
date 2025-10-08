// Decompiled with JetBrains decompiler
// Type: RequirementPrefab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001E5")]
public class RequirementPrefab : MonoBehaviour
{
  [Token(Token = "0x4000D95")]
  [FieldOffset(Offset = "0x20")]
  public GameObject checkMark;
  [Token(Token = "0x4000D96")]
  [FieldOffset(Offset = "0x28")]
  public GameObject progress;
  [Token(Token = "0x4000D97")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_requirement;
  [Token(Token = "0x4000D98")]
  [FieldOffset(Offset = "0x38")]
  public RawImage progressBar;
  [Token(Token = "0x4000D99")]
  [FieldOffset(Offset = "0x40")]
  public TextMeshProUGUI t_progress;

  [Token(Token = "0x6000C96")]
  [Address(RVA = "0x510F60", Offset = "0x50FB60", Length = "0x360")]
  public void Set(MyAchievement ach)
  {
  }

  [Token(Token = "0x6000C97")]
  [Address(RVA = "0x510D60", Offset = "0x50F960", Length = "0x1F3")]
  public void Set(UnlockableBase unlockable)
  {
  }

  [Token(Token = "0x6000C98")]
  [Address(RVA = "0x510CF0", Offset = "0x50F8F0", Length = "0x63")]
  public void HideBar()
  {
  }

  [Token(Token = "0x6000C99")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public RequirementPrefab()
  {
  }
}
