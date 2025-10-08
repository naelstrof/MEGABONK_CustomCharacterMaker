// Decompiled with JetBrains decompiler
// Type: SelectionGroupToggleSingleButtonTier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Other;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001C7")]
public class SelectionGroupToggleSingleButtonTier : SelectionGroupToggleSingleButton
{
  [Token(Token = "0x4000CE2")]
  [FieldOffset(Offset = "0x70")]
  public GameObject completedIcon;
  [Token(Token = "0x4000CE3")]
  [FieldOffset(Offset = "0x78")]
  public GameObject alert;
  [Token(Token = "0x4000CE4")]
  [FieldOffset(Offset = "0x80")]
  private RunConfig runConfig;

  [Token(Token = "0x6000B90")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void Start()
  {
  }

  [Token(Token = "0x6000B91")]
  [Address(RVA = "0x5131A0", Offset = "0x511DA0", Length = "0x24F")]
  public void SetCompleted(bool completed, RunConfig runConfig)
  {
  }

  [Token(Token = "0x6000B92")]
  [Address(RVA = "0x513030", Offset = "0x511C30", Length = "0x161")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x6000B93")]
  [Address(RVA = "0x512FD0", Offset = "0x511BD0", Length = "0xD")]
  public SelectionGroupToggleSingleButtonTier()
  {
  }
}
