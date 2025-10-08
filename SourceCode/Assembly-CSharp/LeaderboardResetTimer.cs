// Decompiled with JetBrains decompiler
// Type: LeaderboardResetTimer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001A5")]
public class LeaderboardResetTimer : MonoBehaviour
{
  [Token(Token = "0x4000BEE")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI countdownText;

  [Token(Token = "0x6000AA4")]
  [Address(RVA = "0x4F0C10", Offset = "0x4EF810", Length = "0x270")]
  private void Update()
  {
  }

  [Token(Token = "0x6000AA5")]
  [Address(RVA = "0x4F0AF0", Offset = "0x4EF6F0", Length = "0x113")]
  private DateTime GetNextMondayUtc(DateTime currentUtc) => new DateTime();

  [Token(Token = "0x6000AA6")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public LeaderboardResetTimer()
  {
  }
}
