// Decompiled with JetBrains decompiler
// Type: CreditsWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000192")]
public class CreditsWindow : MonoBehaviour
{
  [Token(Token = "0x4000B75")]
  [FieldOffset(Offset = "0x20")]
  private float nextUpdateTime;
  [Token(Token = "0x4000B76")]
  [FieldOffset(Offset = "0x24")]
  private int holdingDir;
  [Token(Token = "0x4000B77")]
  [FieldOffset(Offset = "0x28")]
  private float cooldownTimer;
  [Token(Token = "0x4000B78")]
  [FieldOffset(Offset = "0x30")]
  public ScrollRect scrollRect;
  [Token(Token = "0x4000B79")]
  [FieldOffset(Offset = "0x38")]
  private float multiplier;

  [Token(Token = "0x6000A2B")]
  [Address(RVA = "0x4EC280", Offset = "0x4EAE80", Length = "0x194")]
  private void Update()
  {
  }

  [Token(Token = "0x6000A2C")]
  [Address(RVA = "0x4EC250", Offset = "0x4EAE50", Length = "0x29")]
  private void ResetCooldown()
  {
  }

  [Token(Token = "0x6000A2D")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public CreditsWindow()
  {
  }
}
