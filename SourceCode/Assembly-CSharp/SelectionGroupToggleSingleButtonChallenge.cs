// Decompiled with JetBrains decompiler
// Type: SelectionGroupToggleSingleButtonChallenge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001C6")]
public class SelectionGroupToggleSingleButtonChallenge : SelectionGroupToggleSingleButton
{
  [Token(Token = "0x4000CDB")]
  public static Action<SelectionGroupToggleSingleButtonChallenge> A_ChallengeHovered;
  [Token(Token = "0x4000CDC")]
  [FieldOffset(Offset = "0x70")]
  public TextMeshProUGUI t_name;
  [Token(Token = "0x4000CDD")]
  [FieldOffset(Offset = "0x78")]
  public TextMeshProUGUI t_silver;
  [Token(Token = "0x4000CDE")]
  [FieldOffset(Offset = "0x80")]
  public GameObject completedIcon;
  [Token(Token = "0x4000CDF")]
  [FieldOffset(Offset = "0x88")]
  public GameObject completedOverlay;

  [field: Token(Token = "0x4000CE0")]
  [field: FieldOffset(Offset = "0x90")]
  [Token(Token = "0x1700006C")]
  public bool isShowing { [Token(Token = "0x6000B86"), Address(RVA = "0x512FF0", Offset = "0x511BF0", Length = "0x8")] get; [Token(Token = "0x6000B87"), Address(RVA = "0x513020", Offset = "0x511C20", Length = "0x7")] private set; }

  [field: Token(Token = "0x4000CE1")]
  [field: FieldOffset(Offset = "0x98")]
  [Token(Token = "0x1700006D")]
  public ChallengeData challengeData { [Token(Token = "0x6000B88"), Address(RVA = "0x512FE0", Offset = "0x511BE0", Length = "0x8")] get; [Token(Token = "0x6000B89"), Address(RVA = "0x513000", Offset = "0x511C00", Length = "0x13")] private set; }

  [Token(Token = "0x6000B8A")]
  [Address(RVA = "0x512CB0", Offset = "0x5118B0", Length = "0x2BD")]
  public void Set(ChallengeData challengeData)
  {
  }

  [Token(Token = "0x6000B8B")]
  [Address(RVA = "0x512B30", Offset = "0x511730", Length = "0x175")]
  private void SetVisible()
  {
  }

  [Token(Token = "0x6000B8C")]
  [Address(RVA = "0x512A00", Offset = "0x511600", Length = "0x123")]
  private void SetHidden()
  {
  }

  [Token(Token = "0x6000B8D")]
  [Address(RVA = "0x512F70", Offset = "0x511B70", Length = "0x59")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x6000B8E")]
  [Address(RVA = "0x4D7080", Offset = "0x4D5C80", Length = "0x5")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x6000B8F")]
  [Address(RVA = "0x512FD0", Offset = "0x511BD0", Length = "0xD")]
  public SelectionGroupToggleSingleButtonChallenge()
  {
  }
}
