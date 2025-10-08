// Decompiled with JetBrains decompiler
// Type: RequirementsContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001E6")]
public class RequirementsContainer : MonoBehaviour
{
  [Token(Token = "0x4000D9A")]
  [FieldOffset(Offset = "0x20")]
  public RequirementPrefab[] reqContainers;

  [Token(Token = "0x6000C9A")]
  [Address(RVA = "0x511380", Offset = "0x50FF80", Length = "0x20D")]
  public void Set(UnlockableBase unlockable)
  {
  }

  [Token(Token = "0x6000C9B")]
  [Address(RVA = "0x5112D0", Offset = "0x50FED0", Length = "0xA7")]
  public void HideBar()
  {
  }

  [Token(Token = "0x6000C9C")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public RequirementsContainer()
  {
  }
}
